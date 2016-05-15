using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUL;
using QuanLiBanVang.ExtendClass;
using QuanLiBanVang.Model;
using DTO;

namespace QuanLiBanVang.Form
{
    public partial class PhieuNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public static readonly int LIMIT_NUMBER_OF_IMPORT_PROFUCTS = 500;


        BindingList<ImportItemGridViewDataSource> bindingListDataSource = new BindingList<ImportItemGridViewDataSource>(); // bindlist for gridview
        List<CTPNH> savingList = new List<CTPNH>(); // list to be saved into database
        private decimal total = decimal.Zero;
        BUL_PhieuNhapHang bulImportDetail = new BUL_PhieuNhapHang();
        public PhieuNhapHang()
        {
            InitializeComponent();
            this.gridControl1.DataSource = this.bindingListDataSource;
        }

        /// <summary>
        /// member constructor
        /// </summary>
        /// <param name="type"> identify user's intention : view or create new one </param>
        /// <param name="data"> null if the Action Type is null. Otherwise , data will be not null to show to user</param>
        public PhieuNhapHang(ActionType type, PHIEUNHAPHANG data)
        {
            this.InitializeComponent();
            switch (type)
            {
                // see detail from existed PHIEUNHAPHANG
                case ActionType.ACTION_VIEW:
                    this.showExistingImportDetail(data);
                    break;
                // create new PHIEUNHAPHANG
                case ActionType.ACTION_CREATE_NEW:
                    // load database to fill in content for view component
                    int numberOfReceipt = this.bulImportDetail.lastNumberOfReceipt();
                    if (numberOfReceipt != -1)
                    {
                        numberOfReceipt++;
                        this.textEditSoPhieuNhap.Text = numberOfReceipt.ToString();
                    }
                    ContainerItem item; // temporary value holder
                    /* [START- set up content for combobox] */
                    foreach (NHACUNGCAP provider in new BUL_NhaCungCap().getAll())
                    {
                        item = new ContainerItem
                        {
                            Text = provider.TenNCC,
                            Value = provider

                        };
                        this.comboBoxEditNhaCungCap.Properties.Items.Add(item);
                    }
                    foreach (LOAISANPHAM productType in new BUL_LoaiSanPham().getAllProductType())
                    {
                        item = new ContainerItem
                        {
                            Text = productType.TenLoaiSP,
                            Value = productType

                        };
                        this.comboBoxEditLoaiSp.Properties.Items.Add(item);
                    }
                    /* [END- set up content for combobox] */
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 
        /// do things when load the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhieuNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEditLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // first , clear the items in comboboxSanPham
            this.comboBoxEditSP.Properties.Items.Clear();
            // load all product coresponding to the selected product type
            ContainerItem selectedItem = (ContainerItem)this.comboBoxEditLoaiSp.SelectedItem;
            LOAISANPHAM selectedProductType = (LOAISANPHAM)selectedItem.Value; // hold value of the selected item
            foreach (SANPHAM item in (new BUL_LoaiSanPham()).getProductsByTypeId(selectedProductType.MaLoaiSP))
            {
                this.comboBoxEditSP.Properties.Items.Add(new ContainerItem
                {
                    Text = item.TenSP,
                    Value = item
                });
            }
        }

        /// <summary>
        /// save this import receit into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // make sure everthing is ready to be saved
            if (this.isValidGeneralInformation())
            {
                ContainerItem selectedItem = (ContainerItem)this.comboBoxEditNhaCungCap.SelectedItem;
                NHACUNGCAP provider = (NHACUNGCAP)selectedItem.Value;
                // start to save
                PHIEUNHAPHANG newImportReceipt = new PHIEUNHAPHANG
                {
                    MaNCC = provider.MaNCC,
                    NgayNhap = this.dateTimePicker1.Value,
                   // MaNV = UserAccess.Instance.GetUserId, // test
                    TongTien = this.total,
                    NHACUNGCAP = provider,
                    // ignore some fields


                };
                this.bulImportDetail.add(newImportReceipt);
                int numberOfReceipt = -1; // compute SoPhieuNhap
                if (string.IsNullOrEmpty(this.textEditSoPhieuNhap.Text))
                {
                    numberOfReceipt = this.bulImportDetail.lastNumberOfReceipt();
                }
                else
                {
                    numberOfReceipt = int.Parse(this.textEditSoPhieuNhap.Text);
                }
                foreach (ImportItemGridViewDataSource item in this.bindingListDataSource)
                {
                    this.savingList.Add(new CTPNH
                    {
                        SoPhieuNhap = numberOfReceipt,
                        MaSP = item.MaSp,
                        SoLuong = item.SoLuong,
                        ThanhTien = item.ThanhTien,
                        GiaMua = item.GiaMua
                    });
                }
                new BUL_CTPNH().addRange(this.savingList); // save the list of detail
                // notify user that the work is done
                DialogResult dialogResult = MessageBox.Show(NotificationMessage.MESSAGE_SAVING_JOB_DONE, NotificationMessage.MESSAGE_SAVING_JOB_DONE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
        }


        /// <summary>
        /// add new record into gridview, as well as add new item of the list to be saved into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // at first , check content of View (ComboxboxEdit and TextEdit)
            if (!this.isValidImportViewData())
            {
                return; // exit method
            }
            ContainerItem selectedItem = (ContainerItem)this.comboBoxEditSP.SelectedItem;
            SANPHAM selectedProduct = (SANPHAM)selectedItem.Value;
            // make sure that we have no duplicated elements
            if (this.bindingListDataSource.Any(x => x.MaSp == selectedProduct.MaSP))
            {
                MessageBox.Show(ErrorMessage.EXISTED_PRODUCT_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // exit method
            }
            else
            {
                // otherwise, instace new element
                ImportItemGridViewDataSource newElement = new ImportItemGridViewDataSource
                {
                    STT = this.bindingListDataSource.Count,
                    LoaiSanPham = this.comboBoxEditLoaiSp.Text,
                    MaSp = selectedProduct.MaSP,
                    TenSp = selectedProduct.TenSP,
                    SoLuong = Int32.Parse(this.textEditSoLuong.Text.Trim()),
                    GiaMua = decimal.Parse(this.textEditGiaMua.Text.Trim())
                };
                // update cost
                newElement.ThanhTien = newElement.SoLuong * newElement.GiaMua;
                this.bindingListDataSource.Add(newElement); //add into list
                // update total
                this.updateTotal();
            }

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.bindingListDataSource.Count == 0) { return; }// exit method if the binding datasource list is empty
            // delete the focused row of gridview
            this.bindingListDataSource.RemoveAt(this.gridView1.FocusedRowHandle);
            // update stt
            for (int i = 0; i < this.bindingListDataSource.Count; ++i)
            {
                this.bindingListDataSource[i].STT = i;
            }
            this.gridView1.RefreshData();
            // update total
            this.updateTotal();
        }

        #region ------------------------- PRIVATE METHOD ---------------------------------------
        /// <summary>
        /// check wheather content of view components is valid or not 
        /// </summary>
        /// <returns>
        /// true if all content is valid. Otherwise , return false
        /// </returns>
        private bool isValidImportViewData()
        {
            if (string.IsNullOrEmpty(this.comboBoxEditLoaiSp.Text)
                || string.IsNullOrEmpty(this.comboBoxEditSP.Text)
            || string.IsNullOrEmpty(this.textEditSoLuong.Text)
            || string.IsNullOrEmpty(this.textEditGiaMua.Text))
            {
                MessageBox.Show(ErrorMessage.CLIENT_INVALID_INPUT_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (!string.IsNullOrEmpty(this.textEditSoLuong.Text) && int.Parse(this.textEditSoLuong.Text) > LIMIT_NUMBER_OF_IMPORT_PROFUCTS)
            {
                MessageBox.Show(ErrorMessage.OVER_LIMITATION_FOR_IMPORTING, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // exit method
            }
            return true;
        }

        /// <summary>
        /// check whether general information of this receipt is valid
        /// </summary>
        /// <returns>
        /// true if information is valid, otherwise , return false;
        /// </returns>
        private bool isValidGeneralInformation()
        {
            if (this.bindingListDataSource.Count == 0)
            {
                MessageBox.Show(ErrorMessage.NO_DETALI_FOR_RECEIPT, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(this.comboBoxEditNhaCungCap.Text))
            {
                MessageBox.Show(ErrorMessage.CLIENT_INVALID_INPUT_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void updateTotal()
        {

            this.total = decimal.Zero;
            foreach (ImportItemGridViewDataSource element in this.bindingListDataSource)
            {
                this.total = decimal.Add(this.total, element.ThanhTien);
            }
            // update textedit
            this.textEditTongTien.Text = this.total.ToString();
        }


        private void updateItemFromDelegate(ImportItemGridViewDataSource item)
        {
            this.bindingListDataSource[item.STT] = item;
            this.updateTotal();
        }
        /// <summary>
        /// show detail of an existed PHIEUNHAPHANG
        /// </summary>
        /// <param name="data"> desired PHIEUBANHANG to be shown detal</param>
        private void showExistingImportDetail(PHIEUNHAPHANG data)
        {
            // general information
            this.textEditSoPhieuNhap.Text = data.SoPhieuNhap.ToString();
            this.textEditSoPhieuNhap.Enabled = false;
            this.textEditMaNhanVien.Text = data.MaNV.ToString();
            this.textEditMaNhanVien.Enabled = false;
            this.textEditTongTien.Text = data.TongTien.ToString();
            this.textEditMaNhanVien.Enabled = false;
            // date time
            this.dateTimePicker1.Value = data.NgayNhap;
            this.dateTimePicker1.Enabled = false;
            // provider
            this.comboBoxEditNhaCungCap.Text = data.NHACUNGCAP.TenNCC;
            this.comboBoxEditNhaCungCap.Enabled = false;

            // disable conext strip menu to prevent user from modifying data
            this.gridViewContextMenuStrip.Enabled = false;
            // binding data 
            this.gridControl1.DataSource = new BUL_CTPNH().get(data);

            // disable save button
            this.simpleButtonSave.Enabled = false;
            this.simpleButtonSave.Visible = false;

        }
        #endregion

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.bindingListDataSource.Count == 0) { return; }// exit if the binding datasource list is empty
            ImportItemGridViewDataSource focusedItem = (ImportItemGridViewDataSource)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);

            UpdateImportDetailltem updateImportDetailItemForm = new UpdateImportDetailltem(focusedItem, this.gridView1.FocusedRowHandle);
            updateImportDetailItemForm.sendBack = new UpdateImportDetailltem.SendBackDataDelegate(this.updateItemFromDelegate);
            updateImportDetailItemForm.ShowDialog();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
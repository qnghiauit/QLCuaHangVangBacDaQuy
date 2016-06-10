﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUL;
using System.Collections.ObjectModel;
using QuanLiBanVang.ExtendClass;
using System.Collections;
using QuanLiBanVang.Form;
using QuanLiBanVang.Model;
using QuanLiBanVang.model;
using System.Data.Entity;


namespace QuanLiBanVang
{
    public partial class PhieuBanHang : DevExpress.XtraEditors.XtraForm
    {

        private List<CTPBH> receiptDetail = new List<CTPBH>(); // to save all products that client choose to save to database
        decimal tongTien = Decimal.Zero;

        private ObservableCollection<DetailGridViewDataSource> gridViewDataSource = new ObservableCollection<DetailGridViewDataSource>(); // bind data to data gridview
        ActionType actionType; // identify what is form's action
        private KHACHHANG frequenter;

        public PhieuBanHang()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionType"> identify user's intention</param>
        /// <param name="receipt"> should be null if actionType is  ACTION_VIEW</param>
        public PhieuBanHang(ActionType actionType, PHIEUBANHANG data)
        {
            InitializeComponent();
            this.actionType = actionType;
            if (this.actionType == ActionType.ACTION_CREATE_NEW) // incase user want to create new receipt 
            {
                this.checkEditKhachQuen.Checked = false;
                //   this.simpleButtonUpdate.Enabled = false;
                //  this.simpleButtonUpdate.Visible = false;
                this.textEditMaKhachHang.Visible = false;
                this.textEditSoPhieuBH.Visible = false;
                this.simpleButtonTimKhachQuen.Visible = false;
                this.comboBoxEditMaLoaiSp.Properties.Items.Clear();
                this.comboBoxEditMaSp.Properties.Items.Clear();
                // load all product types and product into combobox
                BUL_LoaiSanPham bulProduct = new BUL_LoaiSanPham();
                foreach (LOAISANPHAM item in bulProduct.getAllProductType())
                {
                    this.comboBoxEditMaLoaiSp.Properties.Items.Add(new ContainerItem
                    {
                        Text = item.TenLoaiSP.ToString(),
                        Value = item
                    });
                }
                //this.soPhieu = new BUL_PhieuBanHang().numberOfLastRecept() + 1;
                // auto index SoPhieuBanHang
                //this.textEditSoPhieuBH.Text = this.soPhieu.ToString();
                // datasource will reference to ObservableCollection : gridViewDataSource
                this.gridControlDanhSachSanPham.DataSource = this.gridViewDataSource;
            }
            else if (this.actionType == ActionType.ACTION_VIEW) // incase user only want to show existed receipt from database
            {
                // start to load data
                this.viewExistedDetail(data);
            }
            //else if (this.actionType == ActionType.ACTION_UPDATE) // incase user only want to show existed receipt from database
            //{
            //    // start to load data
            //    this.viewAndUpdateExistedDetail(data);
            //}


        }
        private void PhieuBanHang_Load(object sender, EventArgs e)
        {

        }


        private void onReceiveFrequenter(KHACHHANG frequenter)
        {
            this.frequenter = frequenter;
            // set value for view
            this.textEditMaKhachHang.Text = this.frequenter.MaKH.ToString();
            this.textEditTenKhachHang.Text = this.frequenter.TenKH;
            this.textEditDiaChiKhachHang.Text = this.frequenter.DiaChi;
        }

        /*
         * before adding new record into grid control , data must be check to be valid
         * 
         * */
        private bool checkValidItem()
        {
            try
            {
                // make sure the all component is not empty
                if (string.IsNullOrEmpty(this.comboBoxEditMaLoaiSp.Text)
                    || string.IsNullOrEmpty(this.comboBoxEditMaSp.Text)
                    || string.IsNullOrEmpty(this.textEditSoLuong.Text))
                {
                    MessageBox.Show(ErrorMessage.CLIENT_INVALID_INPUT_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (ArgumentException exception)
            {
                // show message box to client
                Console.Error.WriteLine("Argument Exception : " + exception.Message);
                MessageBox.Show(ErrorMessage.CLIENT_INVALID_INPUT_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }


        private bool checkGerneralInformation()
        {
            // no empty field
            if (//!string.IsNullOrEmpty(this.textEditMaKhachHang.Text)&&
                 !string.IsNullOrEmpty(this.textEditDiaChiKhachHang.Text)
            && !string.IsNullOrEmpty(this.textEditTenKhachHang.Text))
            {
                // check valid date
                DateTime receiptDate = this.dateTimePickerNgayBan.DateTime;
                DateTime paymentDate = this.dateTimePickerNgayBan.DateTime;

                if (paymentDate.CompareTo(receiptDate) < 0)
                {
                    // show message box
                    MessageBox.Show(ErrorMessage.INVALID_INPUT_RECEIPT_DATE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            // everything is valid to be saved
            return false;
        }


        /// <summary>
        /// Update value of DonGia texfield corresponding to product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxEditMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContainerItem selectedItem = (ContainerItem)this.comboBoxEditMaSp.SelectedItem;
            SANPHAM sanPham = (SANPHAM)selectedItem.Value;
            ContainerItem productTypeItem = (ContainerItem)this.comboBoxEditMaLoaiSp.SelectedItem;
            LOAISANPHAM prodcuctType = (LOAISANPHAM)productTypeItem.Value;
            this.textEditDonGia.Text = Math.Round(Decimal.Multiply(Convert.ToDecimal(sanPham.GiaMua), Convert.ToDecimal(1 + prodcuctType.PhanTramLoiNhuan))).ToString();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        private void gridControl1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        ///<summary>
        ///save all data into database
        ///</summary>
        ///<notice>
        /// Have to check all data before invoking this method
        ///</notice>
        private void saveReceiptIntoDatabase()
        {
            PHIEUBANHANG newReceipt = new PHIEUBANHANG()
            {
                NgayBan = this.dateTimePickerNgayBan.DateTime.Date,
                NgayTra = this.dateTimePickerNgayThanhToan.DateTime.Date,
                MaNV = UserAccess.Instance.GetUserId, // to be update code
                // MaKH = 1, // to be update code
                TongTien = this.tongTien
            };
            // if the buyer is frequenter
            if (this.frequenter != null)
            {
                newReceipt.MaKH = this.frequenter.MaKH;
                // newReceipt.KHACHHANG = this.frequenter;
            }
            // save general information of receipt first
            BUL_PhieuBanHang bulPhieuBanHang = new BUL_PhieuBanHang();
            newReceipt = bulPhieuBanHang.add(newReceipt);
            // add elements into list
            foreach (DetailGridViewDataSource item in this.gridViewDataSource)
            {
                this.receiptDetail.Add(new CTPBH
                {
                    SoPhieuBH = newReceipt.SoPhieuBH,
                    MaSP = item.MaSP,
                    SoLuong = item.SoLuong,
                    ThanhTien = item.ThanhTien,
                    GiaBan = item.GiaBan
                    // ignore some fields
                });
            }
            // start to save detail of the Recepit
            BUL_CTPBH bulDetail = new BUL_CTPBH();
            bulDetail.insertRange(receiptDetail);
        }

        /// <summary>
        /// udpate value of receipt total
        /// </summary>
        private void updateTotal()
        {
            this.tongTien = this.gridViewDataSource.Sum(x => x.ThanhTien);
            // update text
            this.textEditTongTien.Text = Math.Round(tongTien).ToString();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get focus rown data of gridview
            // make sure that focus rows greater than 0
            if (this.gridView1.GetSelectedRows().Count() == 0)
            {
                return;
            }

            for (int i = 0; i < this.gridView1.GetSelectedRows().Count(); ++i)
            {
                // cast to GridViewDataSource at row[i]
                DetailGridViewDataSource item = (DetailGridViewDataSource)this.gridView1.GetRow(i);
                // start to delete this row
                this.gridViewDataSource.RemoveAt(item.Stt); // Stt corresponds to index of element to be deleted
            }
            for (int i = 0; i < this.gridViewDataSource.Count; ++i)
            {
                // cast to GridViewDataSource at row[i]
                // start to delete this row
                this.gridViewDataSource[i].Stt = i; // Stt corresponds to index of element to be deleted
            }

            // update total
            this.updateTotal();
        }


        //
        // reset all text in box
        //
        private void resetEditText()
        {
            this.comboBoxEditMaLoaiSp.Text = string.Empty;
            this.comboBoxEditMaLoaiSp.Text = string.Empty;
            this.textEditSoLuong.Text = string.Empty;
            this.textEditDonGia.Text = string.Empty;
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get value from selected row
            DetailGridViewDataSource item = (DetailGridViewDataSource)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);

            // start to show the update form
            UpdateDetaiItem updateDetailItemForm = new UpdateDetaiItem(item);
            updateDetailItemForm.sendBackDelegate = new UpdateDetaiItem.onDataSendBack(this.updateDetailItemDelegate); // instance a delegate for form
            updateDetailItemForm.ShowDialog();
        }

        // delegate function
        private void updateDetailItemDelegate(DetailGridViewDataSource arg)
        {
            // make sure that no duplicate product
            if (this.gridViewDataSource.Any(x => x.Stt != arg.Stt && x.MaSP == arg.MaSP))
            {
                MessageBox.Show(ErrorMessage.EXISTED_PRODUCT_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // start update if everything is valid
            this.gridViewDataSource[arg.Stt] = arg;
            this.updateTotal();
        }

        // <summary>
        // background work saving data into database
        //</summary>
        private void databaseSavingBackgrounWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.saveReceiptIntoDatabase();
        }

        private void databaseSavingBackgrounWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // notify user when the job was done
            MessageBox.Show(NotificationMessage.MESSAGE_SAVING_JOB_DONE, NotificationMessage.MESSAGE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            // close the form
            this.Close();
        }

        /// <summary>
        /// incase user want to see the details of existed receipt
        /// Disable all views that should not be modified
        /// </summary>
        /// <param name="data">PHIEUBANHANG from database</param>
        private void viewExistedDetail(PHIEUBANHANG data)
        {

            // general information
            this.textEditSoPhieuBH.Text = data.SoPhieuBH.ToString();
            this.textEditSoPhieuBH.Enabled = true;

            // this.textEditNhanVien.Text = data.NHANVIEN.HoTen;
            // this.textEditNhanVien.Enabled = false;
            this.dateTimePickerNgayBan.DateTime = data.NgayBan;
            this.dateTimePickerNgayBan.Enabled = true;
            this.dateTimePickerNgayBan.ReadOnly = true;

            this.dateTimePickerNgayThanhToan.DateTime = data.NgayTra;
            this.dateTimePickerNgayThanhToan.Enabled = true;
            this.dateTimePickerNgayThanhToan.ReadOnly = true;

            this.textEditMaKhachHang.Visible = true;
            this.textEditMaKhachHang.Enabled = true;
            this.textEditMaKhachHang.ReadOnly = true;

            this.textEditMaKhachHang.Text = data.MaKH.ToString();
            this.textEditTenKhachHang.Enabled = true;
            this.textEditTenKhachHang.ReadOnly = true;

            this.textEditDiaChiKhachHang.Enabled = true;
            this.textEditDiaChiKhachHang.ReadOnly = true;


            this.textEditTongTien.Text = Math.Round(data.TongTien).ToString();
            this.simpleButtonTimKhachQuen.Enabled = false;

            this.checkEditKhachQuen.Enabled = false; // disable checkbox

            // show customer's information if the customer is frequent
            if (data.MaKH != null)
            {

                this.textEditTenKhachHang.Text = data.KHACHHANG.TenKH;
                this.textEditDiaChiKhachHang.Text = data.KHACHHANG.DiaChi;
            }
            //
            // disable and visiable some view components
            this.simpleButtonThem.Enabled = false;
            this.simpleButtonThem.Visible = false;

            this.simpleButton_Luu.Enabled = false;

            //  this.simpleButtonUpdate.Enabled = false;
            // this.simpleButtonUpdate.Visible = false;

            this.simpleButton_Luu.Visible = false;
            this.comboBoxEditMaLoaiSp.Visible = false;
            this.comboBoxEditMaSp.Visible = false;
            this.textEditSoLuong.Visible = false;
            this.textEditDonGia.Visible = false;
            // disable context menustrip
            this.contextMenuStripUpdateGridData.Enabled = false;
            // get bindinglist

            BindingList<CTPBH> listOfDetails = new BUL_CTPBH().toBindingList(data);
            this.gridControlDanhSachSanPham.DataSource = listOfDetails;


            // hide some columns
            this.gridView1.Columns[5].Visible = false;
            this.gridView1.Columns[6].Visible = false;
        }



        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkEditKhachQuen.Checked)
            {
                this.simpleButtonTimKhachQuen.Visible = true;
                this.simpleButtonTimKhachQuen.Enabled = true;
            }
            else
            {
                this.simpleButtonTimKhachQuen.Enabled = false;
                this.simpleButtonTimKhachQuen.Visible = false;
                this.frequenter = null;
            }
        }

        /// <summary>
        /// Show form containing list of frequenters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonTimKhachQuen_Click(object sender, EventArgs e)
        {
            DanhSachKhachQuen frequenterListForm = new DanhSachKhachQuen();
            frequenterListForm.frequenterSender = new DanhSachKhachQuen.FrequenterInformationSendBack(this.onReceiveFrequenter);
            frequenterListForm.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButtonLapPhieuNo_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_Huy_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton_Luu_Click(object sender, EventArgs e)
        {
            // check information
            if (this.checkGerneralInformation())
            {
                // make sure that the detail is not null
                if (this.gridViewDataSource.Count > 0)
                {
                    this.databaseSavingBackgrounWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show(ErrorMessage.EMPTY_DETAILS_ERR_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(ErrorMessage.CLIENT_INVALID_INPUT_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkEditKhachQuen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkEditKhachQuen.Checked)
            {
                this.simpleButtonTimKhachQuen.Visible = true;
                this.simpleButtonTimKhachQuen.Enabled = true;
            }
            else
            {
                this.simpleButtonTimKhachQuen.Enabled = false;
                this.simpleButtonTimKhachQuen.Visible = false;
                this.frequenter = null;
            }
        }

        // show form containing list of frequenters for staff to choose 
        private void simpleButtonTimKhachQuen_Click_1(object sender, EventArgs e)
        {
            DanhSachKhachQuen frequenterListForm = new DanhSachKhachQuen();
            frequenterListForm.frequenterSender = new DanhSachKhachQuen.FrequenterInformationSendBack(this.onReceiveFrequenter);
            frequenterListForm.ShowDialog();
        }

        // insert new item into user's cart
        private void simpleButtonThem_Click_1(object sender, EventArgs e)
        {
            if (this.checkValidItem())
            {
                // first , add this item into list first
                ContainerItem productTypeItem = (ContainerItem)this.comboBoxEditMaLoaiSp.SelectedItem;
                LOAISANPHAM selectedProdcuctType = (LOAISANPHAM)productTypeItem.Value;
                ContainerItem productItem = (ContainerItem)this.comboBoxEditMaSp.SelectedItem;
                SANPHAM selectedProduct = (SANPHAM)productItem.Value;
                // check number of products in stock
                int numberOfProducts = Int32.Parse(this.textEditSoLuong.Text);
                if (numberOfProducts > selectedProduct.SoLuongTon)
                {
                    MessageBox.Show(ErrorMessage.OVER_IN_STOCK_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // make sure san pham did not exist before in list
                if (!this.gridViewDataSource.Any(x => x.MaSP == selectedProduct.MaSP))
                {

                    // new record data for gridview
                    DetailGridViewDataSource newRow = new DetailGridViewDataSource
                    {
                        MaLoaiSp = selectedProdcuctType.MaLoaiSP,
                        Stt = this.gridViewDataSource.Count,
                        LoaiSP = selectedProdcuctType.TenLoaiSP,
                        MaSP = selectedProduct.MaSP,
                        SoLuong = int.Parse(this.textEditSoLuong.Text),
                        TenSp = selectedProduct.TenSP,
                        GiaBan = decimal.Multiply(Convert.ToDecimal(selectedProduct.GiaMua),
                                                    Convert.ToDecimal(selectedProdcuctType.PhanTramLoiNhuan + 1)),
                    };
                    newRow.ThanhTien = Math.Round(decimal.Multiply(newRow.GiaBan, newRow.SoLuong));
                    // add valid element to two lists
                    this.gridViewDataSource.Add(newRow);
                    this.updateTotal(); // update the total
                }
                else
                {
                    MessageBox.Show(ErrorMessage.EXISTED_PRODUCT_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /// <summary>
        /// load all products corresponding to product type that user selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxEditMaLoaiSp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // first , clear the items in comboboxSanPham
            this.comboBoxEditMaSp.Properties.Items.Clear();
            // load all product coresponding to the selected product type
            ContainerItem selectedItem = (ContainerItem)this.comboBoxEditMaLoaiSp.SelectedItem;
            LOAISANPHAM selectedProductType = (LOAISANPHAM)selectedItem.Value; // hold value of the selected item
            foreach (SANPHAM item in (new BUL_LoaiSanPham()).getProductsByTypeId(selectedProductType.MaLoaiSP))
            {
                // make sure that product is available to be sold
                if (item.TinhTrang == true)
                {
                    this.comboBoxEditMaSp.Properties.Items.Add(new ContainerItem
                    {
                        Text = item.TenSP,
                        Value = item
                    });
                }
            }
        }

        private void comboBoxEditMaSp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ContainerItem selectedItem = (ContainerItem)this.comboBoxEditMaSp.SelectedItem;
            SANPHAM sanPham = (SANPHAM)selectedItem.Value;
            ContainerItem productTypeItem = (ContainerItem)this.comboBoxEditMaLoaiSp.SelectedItem;
            LOAISANPHAM prodcuctType = (LOAISANPHAM)productTypeItem.Value;
            this.textEditDonGia.Text = Math.Round(Decimal.Multiply(Convert.ToDecimal(sanPham.GiaMua), Convert.ToDecimal(1 + prodcuctType.PhanTramLoiNhuan))).ToString();
        }

        /// <summary>
        /// Make sure that the selling date has to be today
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerNgayBan_EditValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(this.dateTimePickerNgayBan.DateTime.Date, DateTime.Now.Date) != 0)
            {
                MessageBox.Show(ErrorMessage.TODAY_ONLY_FOR_SELLING_DATE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateTimePickerNgayBan.DateTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Make sure that the payment date has to be greater than the selling date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerNgayThanhToan_EditValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(this.dateTimePickerNgayThanhToan.DateTime.Date, this.dateTimePickerNgayBan.DateTime.Date) < 0)
            {
                MessageBox.Show(ErrorMessage.INVALID_PAYMENT_DATE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.dateTimePickerNgayBan.DateTime = DateTime.Now;
            }
        }

    }

}
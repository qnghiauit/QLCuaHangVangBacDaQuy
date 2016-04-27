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
using QuanLiBanVang.Model;
using DTO;
using QuanLiBanVang.ExtendClass;
using BUL;

namespace QuanLiBanVang.Form
{
    public partial class UpdateImportDetailltem : DevExpress.XtraEditors.XtraForm
    {
      // updated
        public delegate void SendBackDataDelegate(ImportItemGridViewDataSource data); // delegate to transfer data back to parent form
        public SendBackDataDelegate sendBack;
        private int Stt;
        public UpdateImportDetailltem()
        {
            InitializeComponent();
        }

        public UpdateImportDetailltem(ImportItemGridViewDataSource argument , int indexOfRow)
        {
            this.InitializeComponent();
            this.Stt = indexOfRow;
            /**
            * start to load list product types and coresponding prodcuts from database into view component(ComboBox Edit)
            * 
            */
            // load product types from database
            BUL_LoaiSanPham bulProductTypes = new BUL_LoaiSanPham();
            ContainerItem temporaryItem; // temporary saver
            foreach (LOAISANPHAM item in bulProductTypes.getListProductType())
            {
                temporaryItem = new ContainerItem
                {
                    Text = item.TenLoaiSP,
                    Value = item,
                };
                this.comboBoxEditLoaiSP.Properties.Items.Add(temporaryItem);
                // choose item to show
                if (item.TenLoaiSP == argument.LoaiSanPham)
                {
                    this.comboBoxEditLoaiSP.SelectedItem = temporaryItem;
                }
            }
            temporaryItem = (ContainerItem)this.comboBoxEditLoaiSP.SelectedItem;
            LOAISANPHAM type = (LOAISANPHAM)temporaryItem.Value;
            // set value for view components
            // BUL_SanPham bulProducts = new BUL_SanPham();
            foreach (SANPHAM product in bulProductTypes.getAllProductsByProductTypeId(type.MaLoaiSP))
            {
                temporaryItem = new ContainerItem
                {
                    Text = product.TenSP,
                    Value = product
                };
                this.comboBoxEditSP.Properties.Items.Add(temporaryItem);
                if (product.MaSP == argument.MaSp)
                {
                    this.comboBoxEditSP.SelectedItem = temporaryItem;
                }
            }


        }

        /// <summary>
        ///  called when loading the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateImportDetailltem_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxEditLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // first , clear the items in comboboxSanPham
            this.comboBoxEditSP.Properties.Items.Clear();
            // load all product coresponding to the selected product type
            ContainerItem selectedItem = (ContainerItem)this.comboBoxEditLoaiSP.SelectedItem;
            LOAISANPHAM selectedProductType = (LOAISANPHAM)selectedItem.Value; // hold value of the selected item
            foreach (SANPHAM item in (new BUL_LoaiSanPham()).getAllProductsByProductTypeId(selectedProductType.MaLoaiSP))
            {
                this.comboBoxEditSP.Properties.Items.Add(new ContainerItem
                {
                    Text = item.TenSP,
                    Value = item
                });
            }
        }

        /// <summary>
        /// check wheather content of view components is valid or not 
        /// </summary>
        /// <returns>
        /// true if all content is valid. Otherwise , return false
        /// </returns>
        private bool isValidImportViewData()
        {
            if (string.IsNullOrEmpty(this.comboBoxEditLoaiSP.Text)
                || string.IsNullOrEmpty(this.comboBoxEditSP.Text)
            || string.IsNullOrEmpty(this.textEditSoLuong.Text)
            || string.IsNullOrEmpty(this.textEditGiaMua.Text))
            {
                MessageBox.Show(ErrorMessage.CLIENT_INVALID_INPUT_MESSAGE, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (!string.IsNullOrEmpty(this.textEditSoLuong.Text) && int.Parse(this.textEditSoLuong.Text) > PhieuNhapHang.LIMIT_NUMBER_OF_IMPORT_PROFUCTS)
            {
                MessageBox.Show(ErrorMessage.OVER_LIMITATION_FOR_IMPORTING, ErrorMessage.ERROR_MESSARE_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // exit method
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if content is not valid, exit method
            if (!this.isValidImportViewData())
            {
                return;
            }
            ContainerItem selectedItem = (ContainerItem)this.comboBoxEditSP.SelectedItem;
             SANPHAM sanPham = (SANPHAM)selectedItem.Value;
            // otherwise, send back data
            ImportItemGridViewDataSource data = new ImportItemGridViewDataSource
            {
                STT = this.Stt,
                LoaiSanPham = this.comboBoxEditLoaiSP.Text,
                MaSp = sanPham.MaSP,
                TenSp = sanPham.TenSP,
                SoLuong = int.Parse(this.textEditSoLuong.Text.Trim()),
                GiaMua = decimal.Parse(this.textEditGiaMua.Text.Trim())
            };
            data.ThanhTien = decimal.Multiply(data.SoLuong , data.GiaMua);
            // send back data to main form
           this.sendBack(data);
            this.Close();// close the form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
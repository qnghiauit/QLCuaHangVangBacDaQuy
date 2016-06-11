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
using BUL;
using DTO;
using System.Data.Entity;

namespace QuanLiBanVang.Form
{
    public partial class DanhSachKhachQuen : DevExpress.XtraEditors.XtraForm
    {
        private BUL_KhachHang bulKhachHang;
        public delegate void FrequenterInformationSendBack(KHACHHANG customer);
        public FrequenterInformationSendBack frequenterSender;
        public DanhSachKhachQuen()
        {
            InitializeComponent();
            this.bulKhachHang = new BUL_KhachHang();
            // binding data
            this.gridControl1.DataSource = this.bulKhachHang.getAllBindingListOfKhachHang();

            this.gridView1.Columns[5].Visible = gridView1.Columns[6].Visible = gridView1.Columns[7].Visible = false;
        }

        private void DanhSachKhachQuen_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// get the current selected row of the grid control and close the form. 
        /// Note : including send back data(KHACHANG ) back to the parent form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gridView1.SelectedRowsCount == 0 || this.gridView1.SelectedRowsCount > 1) return;
            // get data in focused row
            KHACHHANG selectedFrequenter = (KHACHHANG)this.gridView1.GetRow(this.gridView1.FocusedRowHandle);
            this.frequenterSender(selectedFrequenter);
            // close the form
            this.Close();
        }

        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
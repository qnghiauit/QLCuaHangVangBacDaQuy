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
using DevExpress.XtraEditors.Controls;

namespace QuanLiBanVang
{
    public partial class PhieuDichVu : DevExpress.XtraEditors.XtraForm
    {
        public PhieuDichVu()
        {
            InitializeComponent();
        }
        public class PersonInfo
        {
            private string _firstName;
            private string _lastName;
            private int manv;

            public PersonInfo(string firstName, string lastName)
            {
                _firstName = firstName;
                _lastName = lastName;
                manv = 1;
            }

            public override string ToString()
            {
                return _firstName + " " + _lastName;
            }

            public int getMaNV()
            {
                return manv;
            }
        }

        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            ComboBoxItemCollection coll = this.comboBoxEditNhanVien.Properties.Items;
            coll.BeginUpdate();
            try
            {
                coll.Add(new PersonInfo("quang", "nghia"));
                coll.Add(new PersonInfo("hello", "co ba"));
            }
            finally 
            {
                coll.EndUpdate();
            }
            comboBoxEditNhanVien.SelectedIndex = 0;
        }

        private void checkEditKhachQuen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkEditKhachQuen.Checked)
                this.comboBoxEditTenKhach.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            else
                this.comboBoxEditTenKhach.Properties.TextEditStyle = TextEditStyles.Standard;
        }
        
    }
}
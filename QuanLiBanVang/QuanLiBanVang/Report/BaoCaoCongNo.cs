using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLiBanVang.Report
{
    public partial class BaoCaoCongNo : DevExpress.XtraReports.UI.XtraReport
    {
        int _selection;
        public BaoCaoCongNo()
        {
            InitializeComponent();
            _selection = 0;
        }
        public BaoCaoCongNo(int selection)
        {
            InitializeComponent();
            _selection = selection;
            if(_selection == 1)
            {
                this.Detail.SortFields.Add(new GroupField("SoTienNo",XRColumnSortOrder.Descending));
            }
            else if (selection == 2)
            {
                this.Detail.SortFields.Add(new GroupField("SoTienNo",XRColumnSortOrder.Ascending));
            }
        }
    }
}

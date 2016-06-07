using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
namespace QuanLiBanVang
{static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]static void Main()
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "DevExpress Style";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // purpose to change language DateTimePicker to Vietnamese
            // Application.CurrentCulture = new System.Globalization.CultureInfo("zh-Hans");
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new MainForm());}
    }
}

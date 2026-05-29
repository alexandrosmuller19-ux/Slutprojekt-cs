using System;
using System;
using System.Windows.Forms;

namespace drinks_info
{
    class Program
    {
        //initierar WinForms-applikationen och startar huvudformuläret (Form1)
        [STAThread]
        static void Main(string[] args)
        {
            //initiera WinForms och kör huvudformuläret
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetDefaultFont(new System.Drawing.Font("Segoe UI", 9F));
            Application.Run(new Form1());
        }
    }
}

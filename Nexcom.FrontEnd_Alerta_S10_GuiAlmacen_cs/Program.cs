﻿using System;
using System.Windows.Forms;

namespace Nexcom.FrontEnd_Alerta_S10_GuiAlmacen_cs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAlert());
        }
    }
}

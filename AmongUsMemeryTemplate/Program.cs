using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsMemeryTemplate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Globals.running = true;
            Thread HandlerThread = new Thread(Handler.Init);
            HandlerThread.Start();


            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 appForm = new Form1();
            Application.Run(appForm);
        }
    }
}

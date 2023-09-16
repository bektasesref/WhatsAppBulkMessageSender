using System;
using System.Threading;
using System.Windows.Forms;

namespace WhatsAppMaster
{
    internal static class Program
    {
        private static Mutex mutex = null;

        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "WhatsappMaster";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("Program already working!");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
    }
}

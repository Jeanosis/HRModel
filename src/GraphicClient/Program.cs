using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicClient
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

            var model = new ModelRepository();
            var mainForm = new ClientForm();
            var presenter = new Presenter(mainForm, model);

            Application.Run(new ApplicationContext(mainForm));
        }
    }
}

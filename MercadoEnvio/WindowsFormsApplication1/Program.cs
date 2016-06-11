using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

 /*           // Open App.Config of executable
        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        // Add an Application Setting.
        config.AppSettings.Settings.Add("FechaActualSistema", DateTime.Now.ToString("dd/MM/yyyy"));

        // Save the changes in App.config file.
        config.Save(ConfigurationSaveMode.Modified);

        // Force a reload of a changed section.
        ConfigurationManager.RefreshSection("appSettings");
*/
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioLogin());
        }

    }
}

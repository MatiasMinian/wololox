using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Listado_Estadistico;
using WindowsFormsApplication1.ABM_Usuario;
using WindowsFormsApplication1.ABM_Rol;
using System.Data.SqlClient;
using System.Data;

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

           GD1C2016DataSetTableAdapters.publicacionesTableAdapter publiAdapter = new GD1C2016DataSetTableAdapters.publicacionesTableAdapter();

           var value = System.Configuration.ConfigurationManager.AppSettings["DateKey"];

           String appDate = value;

           MessageBox.Show("Se van a actualizar publicaciones vencidas..");

           String conexion = Convert.ToString(System.Configuration.ConfigurationManager.ConnectionStrings[1]);

           SqlConnection cnn = new SqlConnection(conexion);
           
           cnn.Open();

           SqlCommand cmd = new SqlCommand("WOLOLOX.ActualizarPublicacionesVencidas", cnn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@fechaDeHoy", SqlDbType.NVarChar);
            cmd.Parameters["@fechaDeHoy"].Value = appDate;
           cmd.CommandTimeout = 1800;


           try
           {
               SqlDataReader reader = cmd.ExecuteReader();
               reader.Read();
           }
           catch (Exception)
           {

               MessageBox.Show("Fallo la ejecucion del procedimiento");
               throw;

           }

          MessageBox.Show("Publicaciones vencidas actualizadas.Presione aceptar para continuar");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularioLogin());

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos.Accesos
{
    public class DBConexion
    {
        public static bool InitialLoad()
        {
            using (var context = new EurekaBD())
            {
                try
                {
                    bool success = context.docentes.Where(x => x.email.Equals("david.alonso@uabc.edu.mx")).FirstOrDefault() != null;
                    return success;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión. " + ex.Message);
                    return false;
                }
            }
        }
    }
}

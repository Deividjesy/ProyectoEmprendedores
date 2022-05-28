using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class Class1
    {
        public void Nada()
        {
            try
            {
                using (var context = new EurekaBD())
                {
                    var query = context.docentes.Where(x => x.email.Equals("david.alonso@uabc.edu.mx")).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}

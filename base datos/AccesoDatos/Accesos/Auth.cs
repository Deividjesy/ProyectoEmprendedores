using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Accesos
{
    public static class Auth
    {
        public static bool Autenticacion(string email, string pass, out docente usuario)
        {
            try
            {
                using (EurekaBD context = new EurekaBD())
                {
                    var query = from entidad in context.docentes
                                where entidad.email.Equals(email) && entidad.password.Equals(pass)
                                select entidad;
                    usuario = query.FirstOrDefault();
                    return usuario != null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

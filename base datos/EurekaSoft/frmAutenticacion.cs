using AccesoDatos;
using AccesoDatos.Accesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EurekaSoft
{
    public partial class frmAutenticacion : Form
    {
        public frmAutenticacion(string usuario, string password)
        {
            InitializeComponent();
            Usuario = usuario;
            Password = password;
        }

        public string Usuario { get => txtUsuario.Text; set => txtUsuario.Text = value; }
        public string Password { get => txtPass.Text; set => txtPass.Text = value; }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Enabled = false;
            bool success = false;
            if (success = Auth.Autenticacion(Usuario, Password, out docente usuario))
            {
                if (success)
                {
                    Visible = false;
                    frmMenuPrincipal main = new frmMenuPrincipal(usuario.id, usuario.nombre);
                    main.ShowDialog();
                    Close();
                }
            }
            else
                MessageBox.Show("Usuario o contraseña incorrecta", "Acceso denegado", MessageBoxButtons.OK);
            if (!success)
            {
                txtPass.Select();
                txtPass.SelectAll();
                txtPass.Focus();
            }
            Enabled = true;
            Cursor = Cursors.Default;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmAutenticacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmAutenticacion_Load(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Password))
            //    btn_Aceptar_Click(null, null);
        }
    }
}

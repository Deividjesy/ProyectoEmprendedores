using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EurekaSoft
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal(int usuario_id, string usuario_nombre)
        {
            InitializeComponent();
        }

        private void HideSubMenu()
        {
            if (pnlOpcionesCursos.Visible)
                pnlOpcionesCursos.Visible = false;
            if (pnlOpcionesImportacion.Visible)
                pnlOpcionesImportacion.Visible = false;
            if (pnlOpcionesReportes.Visible)
                pnlOpcionesReportes.Visible = false;
        }
        private void ShowSubMenu(Panel submenu, string titulo)
        {
            if (!submenu.Visible)
            {
                HideSubMenu();
                submenu.Visible = true;
                lblTitulo.Text = titulo;
            }
            else
                submenu.Visible = false;
        }

        #region Eventos

        #endregion
        private void btnReportes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlOpcionesReportes,"Reportes");
            lblHojaActual.Text = "Reportes";
            lblVentana.Text = "Reportes";
        }

        private void OcultarReportesSubMenu_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            HideSubMenu();
            lblHojaActual.Text = "Reportes";
            lblVentana.Text = button.Text;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlOpcionesImportacion, "Importación");
            lblHojaActual.Text = "Importación";
            lblVentana.Text = "Importación";
        }
    }
}

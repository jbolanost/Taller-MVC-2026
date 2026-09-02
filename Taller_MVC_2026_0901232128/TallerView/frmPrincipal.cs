using TallerController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerView
{
    public partial class frmPrincipal : Form
    {
        string nombreTabla = "tipo_sancion";
        Controlador controlador = new Controlador();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void actualizarDgv()
        {
            DataTable dtVista = controlador.llenarDgv(nombreTabla);
            DgvConsultaTabla.DataSource = dtVista;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDgv();
        }
    }
}

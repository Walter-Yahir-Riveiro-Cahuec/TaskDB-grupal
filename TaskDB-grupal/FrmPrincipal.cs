using System;
using System.Windows.Forms;

namespace TaskDB_grupal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuListado_Click(object sender, EventArgs e)
        {
            var abierto = MdiChildren.OfType<FrmListadoTareas>().FirstOrDefault();
            if (abierto != null) { abierto.Activate(); return; }

            new FrmListadoTareas
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

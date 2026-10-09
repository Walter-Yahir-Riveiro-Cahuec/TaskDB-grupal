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
            // Evita abrir dos listados
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

    }
}

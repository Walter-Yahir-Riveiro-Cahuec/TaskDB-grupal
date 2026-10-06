namespace TaskDB_grupal
{
    partial class FrmListadoTareas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvTareas = new DataGridView();
            cmbFiltro = new ComboBox();
            btnFiltrar = new Button();
            btnNuevaTarea = new Button();
            btnCompletar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            SuspendLayout();
            // 
            // dgvTareas
            // 
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(34, 107);
            dgvTareas.Margin = new Padding(3, 4, 3, 4);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.RowHeadersWidth = 51;
            dgvTareas.Size = new Size(457, 267);
            dgvTareas.TabIndex = 0;
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(34, 40);
            cmbFiltro.Margin = new Padding(3, 4, 3, 4);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(138, 28);
            cmbFiltro.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(194, 40);
            btnFiltrar.Margin = new Padding(3, 4, 3, 4);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(86, 31);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevaTarea
            // 
            btnNuevaTarea.Location = new Point(34, 400);
            btnNuevaTarea.Margin = new Padding(3, 4, 3, 4);
            btnNuevaTarea.Name = "btnNuevaTarea";
            btnNuevaTarea.Size = new Size(114, 31);
            btnNuevaTarea.TabIndex = 3;
            btnNuevaTarea.Text = "Nueva Tarea";
            btnNuevaTarea.UseVisualStyleBackColor = true;
            // 
            // btnCompletar
            // 
            btnCompletar.Location = new Point(171, 400);
            btnCompletar.Margin = new Padding(3, 4, 3, 4);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(114, 31);
            btnCompletar.TabIndex = 4;
            btnCompletar.Text = "Completar";
            btnCompletar.UseVisualStyleBackColor = true;
            // 
            // FrmListadoTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 455);
            Controls.Add(btnCompletar);
            Controls.Add(btnNuevaTarea);
            Controls.Add(btnFiltrar);
            Controls.Add(cmbFiltro);
            Controls.Add(dgvTareas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmListadoTareas";
            Text = "Listado de Tareas";
            Load += FrmListadoTareas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ResumeLayout(false);
        }

        public System.Windows.Forms.DataGridView dgvTareas;
        public System.Windows.Forms.ComboBox cmbFiltro;
        public System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.Button btnNuevaTarea;
        public System.Windows.Forms.Button btnCompletar;
    }
}

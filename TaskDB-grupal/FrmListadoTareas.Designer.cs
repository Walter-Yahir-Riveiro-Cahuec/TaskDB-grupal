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
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnNuevaTarea = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(30, 80);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.Size = new System.Drawing.Size(400, 200);
            this.dgvTareas.TabIndex = 0;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(30, 30);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 23);
            this.cmbFiltro.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(170, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevaTarea
            // 
            this.btnNuevaTarea.Location = new System.Drawing.Point(30, 300);
            this.btnNuevaTarea.Name = "btnNuevaTarea";
            this.btnNuevaTarea.Size = new System.Drawing.Size(100, 23);
            this.btnNuevaTarea.TabIndex = 3;
            this.btnNuevaTarea.Text = "Nueva Tarea";
            this.btnNuevaTarea.UseVisualStyleBackColor = true;
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(150, 300);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(100, 23);
            this.btnCompletar.TabIndex = 4;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.UseVisualStyleBackColor = true;
            // 
            // FrmListadoTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 341);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnNuevaTarea);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.dgvTareas);
            this.Name = "FrmListadoTareas";
            this.Text = "Listado de Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.DataGridView dgvTareas;
        public System.Windows.Forms.ComboBox cmbFiltro;
        public System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.Button btnNuevaTarea;
        public System.Windows.Forms.Button btnCompletar;
    }
}

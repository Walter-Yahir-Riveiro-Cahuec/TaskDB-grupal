using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using TaskDB;

namespace TaskDB_grupal
{
    public partial class FrmListadoTareas : Form
    {
        public FrmListadoTareas()
        {
            InitializeComponent();
            ConfigurarGrilla();
        }

        private void FrmListadoTareas_Load(object sender, EventArgs e)
        {
            CargarTareas();
        }
        private void ConfigurarGrilla()
        {
            // RNF3.1
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.ReadOnly = true;
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.MultiSelect = false;
            dgvTareas.RowHeadersVisible = false;
        }

        /// <summary>
        /// Carga tareas desde la BD. Contrato para Persona 4.
        /// </summary>
        /// <param name="estado">"Todos", "Pendiente" o "Completada"</param>
        public void CargarTareas(string estado = "Todos")
        {
            const string sql = @"SELECT Id, Titulo, Estado, FechaCreacion
                                 FROM Tareas
                                 WHERE (@Estado = 'Todos' OR Estado = @Estado)
                                 ORDER BY Id";

            try // RNF3.2
            {
                DataTable tabla = new DataTable();

                using (SqlConnection cn = DatabaseConnection.GetConnection())
                using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Estado", estado);
                    da.Fill(tabla);
                }

                dgvTareas.DataSource = tabla;

                // Encabezados limpios (RNF3.1)
                dgvTareas.Columns["Id"]!.HeaderText = "ID";
                dgvTareas.Columns["Titulo"]!.HeaderText = "Titulo";
                dgvTareas.Columns["Estado"]!.HeaderText = "Estado";
                dgvTareas.Columns["FechaCreacion"]!.HeaderText = "Fecha Creacion";
                dgvTareas.Columns["FechaCreacion"]!.DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al leer las tareas: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

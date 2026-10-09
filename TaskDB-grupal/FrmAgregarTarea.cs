using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TaskDB_grupal
{
    public partial class FrmAgregarTarea : Form
    {
        public FrmAgregarTarea()
        {
            InitializeComponent();

            // Configurar ComboBox Estado
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.AddRange(new object[]
            {
                "Pendiente",
                "Completada"
            });

            cmbEstado.SelectedIndex = 0;

            // Botones predeterminados
            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el título no esté vacío
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show(
                    "El título es obligatorio.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTitulo.Focus();
                return;
            }

            const string sql =
                @"INSERT INTO Tareas (Titulo, Descripcion, Estado)
                  VALUES (@Titulo, @Descripcion, @Estado)";

            try
            {
                using (SqlConnection cn = DatabaseConnection.GetConnection())
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    // Parámetros para evitar SQL Injection
                    cmd.Parameters.AddWithValue(
                        "@Titulo",
                        txtTitulo.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Descripcion",
                        string.IsNullOrWhiteSpace(txtDescripcion.Text)
                            ? (object)DBNull.Value
                            : txtDescripcion.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Estado",
                        cmbEstado.SelectedItem?.ToString() ?? "Pendiente");

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Tarea guardada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error al guardar: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using TaskDB;

namespace TaskDB_grupal
{
    public partial class FrmAgregarTarea : Form
    {
        public FrmAgregarTarea()
        {
            InitializeComponent();

            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cmbEstado.Items.Count == 0)
            {
                cmbEstado.Items.AddRange(new object[]
                {
                    "Pendiente",
                    "Completada"
                });
            }

            cmbEstado.SelectedIndex = 0;

            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
                Close();
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
            Close();
        }
    }
}
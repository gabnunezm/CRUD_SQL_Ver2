using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        private string idUsuario = null;
        private bool Editar = false;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        // Método para cargar los usuarios en un DataGridView
        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dgvUsuarios.DataSource = objeto.MostrarUsuarios();
        }

        // Botón Guardar (Insertar o Editar)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtUsuario.Text == "" || txtContrasena.Text == "" || txtTipo.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Editar == false) // INSERTAR
            {
                try
                {
                    objetoCN.InsertarUsuario(txtNombre.Text, txtUsuario.Text, txtContrasena.Text, txtTipo.Text);
                    MessageBox.Show("Usuario registrado correctamente");
                    MostrarUsuarios();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar el usuario: " + ex.Message);
                }
            }
            else // EDITAR
            {
                try
                {
                    objetoCN.EditarUsuario(idUsuario, txtNombre.Text, txtUsuario.Text, txtContrasena.Text, txtTipo.Text);
                    MessageBox.Show("Usuario actualizado correctamente");
                    MostrarUsuarios();
                    LimpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el usuario: " + ex.Message);
                }
            }
        }

        // Botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                Editar = true;
                idUsuario = dgvUsuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString();
                txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContrasena.Text = dgvUsuarios.CurrentRow.Cells["Password"].Value.ToString();
                txtTipo.Text = dgvUsuarios.CurrentRow.Cells["Tipo_usuario"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                idUsuario = dgvUsuarios.CurrentRow.Cells["Id_Usuario"].Value.ToString();
                try
                {
                    objetoCN.EliminarUsuario(idUsuario);
                    MessageBox.Show("Usuario eliminado correctamente");
                    MostrarUsuarios();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar el usuario: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para limpiar los campos
        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtTipo.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Hide();
        }
    }
}

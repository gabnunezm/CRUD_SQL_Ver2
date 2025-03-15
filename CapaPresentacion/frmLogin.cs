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
using Microsoft.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        private string Conexion = "Server=DESKTOP-QQ4E961;Database=Practica;Integrated Security=True;TrustServerCertificate=True";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtContrasena.Text.Trim();

            if (ValidarUsuario(usuario, password))
            {
                MessageBox.Show("¡Bienvenido!", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmHome home = new frmHome();
            home.Show();
            this.Hide();
        }

        private bool ValidarUsuario(string usuario, string password)
        {
            using (SqlConnection conn = new SqlConnection(Conexion))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}

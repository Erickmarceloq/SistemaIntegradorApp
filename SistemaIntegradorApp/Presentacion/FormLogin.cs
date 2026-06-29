using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaIntegradorApp.Datos;
using SistemaIntegradorApp.Negocio;

namespace SistemaIntegradorApp.Presentacion
{
    public partial class FormLogin : Form
    {
        private ConexionBD conexionBD = new ConexionBD();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Debe completar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consulta SQL con INNER JOIN para traer el nombre del Rol de forma directa
            string query = @"SELECT u.Username, r.NombreRol 
                             FROM Usuarios u 
                             INNER JOIN Roles r ON u.IdRol = r.IdRol 
                             WHERE u.Username = @usuario AND u.Password = @password";

            try
            {
                using (SqlConnection con = conexionBD.ObtenerConexion())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Evita la inyección SQL usando parámetros
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Guardar los datos del usuario en memoria global (UserSession)
                                UserSession.Username = reader["Username"].ToString();
                                UserSession.Rol = reader["NombreRol"].ToString();

                                MessageBox.Show($"¡Acceso autorizado!\nBienvenido: {UserSession.Username}\nRol: {UserSession.Rol}",
                                                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Abrir el menú principal y ocultar el login
                                FormMenuPrincipal menu = new FormMenuPrincipal();
                                menu.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using System;
using System.Windows.Forms;
using SistemaIntegradorApp.Negocio;

namespace SistemaIntegradorApp.Presentacion
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        // Cambiamos el nombre aquí poniéndole el _1 para que Visual Studio lo reconozca oficialmente
        private void FormMenuPrincipal_Load_1(object sender, EventArgs e)
        {
            // Cambia el título de la ventana para mostrar el usuario y el rol que entró
            this.Text = $"Menú Principal - {UserSession.Username} ({UserSession.Rol})";

            // Ejecutamos el filtro dinámico exigido por la tarea
            AplicarRestriccionesPorRol();
        }

        private void AplicarRestriccionesPorRol()
        {
            string rolUsuario = UserSession.Rol; // Obtenemos el rol desde la memoria global

            // Recorremos de forma dinámica todos los controles que pusiste en el formulario
            foreach (Control control in this.Controls)
            {
                // Si el control es un Botón y le configuraste la propiedad Tag...
                if (control is Button && control.Tag != null)
                {
                    string rolesPermitidos = control.Tag.ToString();

                    // Si el rol del usuario actual NO está incluido en los roles permitidos del Tag
                    if (!rolesPermitidos.Contains(rolUsuario))
                    {
                        // Le damos retroalimentación visual desactivándolo (Enabled = false) como pide la tarea
                        control.Enabled = false;
                    }
                }
            }
        }

        // Si cierran el menú, cerramos toda la aplicación por completo
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }


        private void btnConfigurarZonas_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del formulario
            FormZonas frm = new FormZonas();

            // Lo mostramos como un diálogo (esto bloquea el menú hasta cerrar la ventana)
            frm.ShowDialog();
        }

        private void btnControlarSimulacion_Click(object sender, EventArgs e)
        {
            FormSimulacion frm = new FormSimulacion();
            frm.ShowDialog();
        }

       
            private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes frm = new FormReportes(); // Asegúrate de crear este Form en el explorador
            frm.ShowDialog();
        }
    }
    }


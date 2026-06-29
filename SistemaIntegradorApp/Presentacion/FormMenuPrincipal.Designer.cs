namespace SistemaIntegradorApp.Presentacion
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfigurarZonas = new Button();
            btnControlarSimulacion = new Button();
            btnVerReportes = new Button();
            SuspendLayout();
            // 
            // btnConfigurarZonas
            // 
            btnConfigurarZonas.Location = new Point(12, 26);
            btnConfigurarZonas.Name = "btnConfigurarZonas";
            btnConfigurarZonas.Size = new Size(137, 43);
            btnConfigurarZonas.TabIndex = 0;
            btnConfigurarZonas.Tag = "Admin";
            btnConfigurarZonas.Text = "Configurar Zonas";
            btnConfigurarZonas.UseVisualStyleBackColor = true;
            btnConfigurarZonas.Click += btnConfigurarZonas_Click;
            // 
            // btnControlarSimulacion
            // 
            btnControlarSimulacion.Location = new Point(12, 104);
            btnControlarSimulacion.Name = "btnControlarSimulacion";
            btnControlarSimulacion.Size = new Size(137, 47);
            btnControlarSimulacion.TabIndex = 1;
            btnControlarSimulacion.Tag = "Admin,Operador";
            btnControlarSimulacion.Text = "Controlar Simulación";
            btnControlarSimulacion.UseVisualStyleBackColor = true;
            btnControlarSimulacion.Click += btnControlarSimulacion_Click;
            // 
            // btnVerReportes
            // 
            btnVerReportes.Location = new Point(12, 180);
            btnVerReportes.Name = "btnVerReportes";
            btnVerReportes.Size = new Size(137, 49);
            btnVerReportes.TabIndex = 2;
            btnVerReportes.Tag = "Admin,Operador,Consulta";
            btnVerReportes.Text = "Ver Reportes y Alertas";
            btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerReportes);
            Controls.Add(btnControlarSimulacion);
            Controls.Add(btnConfigurarZonas);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            Load += FormMenuPrincipal_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfigurarZonas;
        private Button btnControlarSimulacion;
        private Button btnVerReportes;
    }
}
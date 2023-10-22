namespace ProyectoLaFarmaciaFinal
{
    partial class formularioLogin
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
            txtLoginContraseña = new TextBox();
            txtLoginNombreDeUsuario = new TextBox();
            btnLoginIniciarSesion = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtLoginContraseña
            // 
            txtLoginContraseña.Location = new Point(73, 214);
            txtLoginContraseña.Name = "txtLoginContraseña";
            txtLoginContraseña.PlaceholderText = "Contraseña";
            txtLoginContraseña.Size = new Size(226, 23);
            txtLoginContraseña.TabIndex = 58;
            // 
            // txtLoginNombreDeUsuario
            // 
            txtLoginNombreDeUsuario.Location = new Point(73, 175);
            txtLoginNombreDeUsuario.Name = "txtLoginNombreDeUsuario";
            txtLoginNombreDeUsuario.PlaceholderText = "Nombre de usuario";
            txtLoginNombreDeUsuario.Size = new Size(226, 23);
            txtLoginNombreDeUsuario.TabIndex = 57;
            // 
            // btnLoginIniciarSesion
            // 
            btnLoginIniciarSesion.BackColor = Color.Salmon;
            btnLoginIniciarSesion.ForeColor = SystemColors.ControlText;
            btnLoginIniciarSesion.Location = new Point(73, 256);
            btnLoginIniciarSesion.Name = "btnLoginIniciarSesion";
            btnLoginIniciarSesion.Size = new Size(226, 33);
            btnLoginIniciarSesion.TabIndex = 52;
            btnLoginIniciarSesion.Text = "Iniciar sesión";
            btnLoginIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(73, 67);
            label2.Name = "label2";
            label2.Size = new Size(226, 33);
            label2.TabIndex = 51;
            label2.Text = "Farmacia La Buena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(73, 109);
            label4.Name = "label4";
            label4.Size = new Size(252, 15);
            label4.TabIndex = 59;
            label4.Text = "Al acceder aceptas los términos y condiciones.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(73, 124);
            label5.Name = "label5";
            label5.Size = new Size(140, 15);
            label5.TabIndex = 60;
            label5.Text = "Solo para uso autorizado.";
            // 
            // formularioLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLoginContraseña);
            Controls.Add(txtLoginNombreDeUsuario);
            Controls.Add(btnLoginIniciarSesion);
            Controls.Add(label2);
            Name = "formularioLogin";
            Text = "formularioLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoginContraseña;
        private TextBox txtLoginNombreDeUsuario;
        private Button btnLoginIniciarSesion;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}
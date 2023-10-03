namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioCliente1
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
            btnRegresarMenu = new Button();
            btnClienteEliminarCliente = new Button();
            btnClienteAgregarCliente = new Button();
            btnClienteRealizarTransaccion = new Button();
            label2 = new Label();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(443, 37);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(75, 27);
            btnRegresarMenu.TabIndex = 36;
            btnRegresarMenu.Text = "Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            btnRegresarMenu.Click += button5_Click;
            // 
            // btnClienteEliminarCliente
            // 
            btnClienteEliminarCliente.Location = new Point(198, 237);
            btnClienteEliminarCliente.Name = "btnClienteEliminarCliente";
            btnClienteEliminarCliente.Size = new Size(156, 32);
            btnClienteEliminarCliente.TabIndex = 35;
            btnClienteEliminarCliente.Text = "Eliminar Cliente";
            btnClienteEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnClienteAgregarCliente
            // 
            btnClienteAgregarCliente.Location = new Point(198, 187);
            btnClienteAgregarCliente.Name = "btnClienteAgregarCliente";
            btnClienteAgregarCliente.Size = new Size(156, 32);
            btnClienteAgregarCliente.TabIndex = 34;
            btnClienteAgregarCliente.Text = "Agregar Cliente";
            btnClienteAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // btnClienteRealizarTransaccion
            // 
            btnClienteRealizarTransaccion.Location = new Point(198, 138);
            btnClienteRealizarTransaccion.Name = "btnClienteRealizarTransaccion";
            btnClienteRealizarTransaccion.Size = new Size(156, 32);
            btnClienteRealizarTransaccion.TabIndex = 33;
            btnClienteRealizarTransaccion.Text = "Realizar Transacción";
            btnClienteRealizarTransaccion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(225, 55);
            label2.Name = "label2";
            label2.Size = new Size(92, 33);
            label2.TabIndex = 32;
            label2.Text = "Cliente";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(33, 37);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(96, 27);
            btnCerrarSesion.TabIndex = 43;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // FormularioCliente1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnRegresarMenu);
            Controls.Add(btnClienteEliminarCliente);
            Controls.Add(btnClienteAgregarCliente);
            Controls.Add(btnClienteRealizarTransaccion);
            Controls.Add(label2);
            Name = "FormularioCliente1";
            Text = "FormularioCliente1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresarMenu;
        private Button btnClienteEliminarCliente;
        private Button btnClienteAgregarCliente;
        private Button btnClienteRealizarTransaccion;
        private Label label2;
        private Button btnCerrarSesion;
    }
}
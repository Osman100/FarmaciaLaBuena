namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioTarjetaCredito1
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
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(456, 40);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(75, 27);
            btnRegresarMenu.TabIndex = 48;
            btnRegresarMenu.Text = "Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            // 
            // btnClienteEliminarCliente
            // 
            btnClienteEliminarCliente.Location = new Point(210, 235);
            btnClienteEliminarCliente.Name = "btnClienteEliminarCliente";
            btnClienteEliminarCliente.Size = new Size(156, 32);
            btnClienteEliminarCliente.TabIndex = 47;
            btnClienteEliminarCliente.Text = "Eliminar Tarjeta";
            btnClienteEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // btnClienteAgregarCliente
            // 
            btnClienteAgregarCliente.Location = new Point(210, 185);
            btnClienteAgregarCliente.Name = "btnClienteAgregarCliente";
            btnClienteAgregarCliente.Size = new Size(156, 32);
            btnClienteAgregarCliente.TabIndex = 46;
            btnClienteAgregarCliente.Text = "Modificar Tarjeta";
            btnClienteAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // btnClienteRealizarTransaccion
            // 
            btnClienteRealizarTransaccion.Location = new Point(210, 136);
            btnClienteRealizarTransaccion.Name = "btnClienteRealizarTransaccion";
            btnClienteRealizarTransaccion.Size = new Size(156, 32);
            btnClienteRealizarTransaccion.TabIndex = 45;
            btnClienteRealizarTransaccion.Text = "Agregar Tarjeta";
            btnClienteRealizarTransaccion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(186, 75);
            label2.Name = "label2";
            label2.Size = new Size(213, 33);
            label2.TabIndex = 44;
            label2.Text = "Tarjeta de Credito";
            // 
            // button1
            // 
            button1.Location = new Point(210, 286);
            button1.Name = "button1";
            button1.Size = new Size(156, 32);
            button1.TabIndex = 50;
            button1.Text = "Buscar Tarjeta";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormularioTarjetaCredito1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(button1);
            Controls.Add(btnRegresarMenu);
            Controls.Add(btnClienteEliminarCliente);
            Controls.Add(btnClienteAgregarCliente);
            Controls.Add(btnClienteRealizarTransaccion);
            Controls.Add(label2);
            Name = "FormularioTarjetaCredito1";
            Text = "FormularioTarjetaCredito1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegresarMenu;
        private Button btnClienteEliminarCliente;
        private Button btnClienteAgregarCliente;
        private Button btnClienteRealizarTransaccion;
        private Label label2;
        private Button button1;
    }
}
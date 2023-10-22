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
            btnModificarCliente = new Button();
            btnAgregarCliente = new Button();
            label2 = new Label();
            btnBuscarCliente = new Button();
            btnEliminarCliente = new Button();
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
            // btnModificarCliente
            // 
            btnModificarCliente.Location = new Point(197, 159);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(156, 32);
            btnModificarCliente.TabIndex = 35;
            btnModificarCliente.Text = "Modificar Cliente";
            btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(197, 109);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(156, 32);
            btnAgregarCliente.TabIndex = 34;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
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
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(197, 261);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(156, 32);
            btnBuscarCliente.TabIndex = 38;
            btnBuscarCliente.Text = "Buscar Cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(197, 211);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(156, 32);
            btnEliminarCliente.TabIndex = 37;
            btnEliminarCliente.Text = "Eliminar Cliente";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // FormularioCliente1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnBuscarCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnRegresarMenu);
            Controls.Add(btnModificarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(label2);
            Name = "FormularioCliente1";
            Text = "FormularioCliente1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresarMenu;
        private Button btnModificarCliente;
        private Button btnAgregarCliente;
        private Label label2;
        private Button btnBuscarCliente;
        private Button btnEliminarCliente;
    }
}
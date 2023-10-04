namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioVenta1
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
            btnBuscarVenta = new Button();
            btnEliminarVenta = new Button();
            btnRegresarMenu = new Button();
            btnModificarVenta = new Button();
            btnAgregarVenta = new Button();
            label2 = new Label();
            btnCalcularTotalVenta = new Button();
            SuspendLayout();
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.Location = new Point(200, 247);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(156, 32);
            btnBuscarVenta.TabIndex = 44;
            btnBuscarVenta.Text = "Buscar Venta";
            btnBuscarVenta.UseVisualStyleBackColor = true;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(200, 197);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(156, 32);
            btnEliminarVenta.TabIndex = 43;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(442, 48);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(75, 27);
            btnRegresarMenu.TabIndex = 42;
            btnRegresarMenu.Text = "Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            // 
            // btnModificarVenta
            // 
            btnModificarVenta.Location = new Point(200, 145);
            btnModificarVenta.Name = "btnModificarVenta";
            btnModificarVenta.Size = new Size(156, 32);
            btnModificarVenta.TabIndex = 41;
            btnModificarVenta.Text = "Modificar Venta";
            btnModificarVenta.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(200, 95);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(156, 32);
            btnAgregarVenta.TabIndex = 40;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(228, 41);
            label2.Name = "label2";
            label2.Size = new Size(80, 33);
            label2.TabIndex = 39;
            label2.Text = "Venta";
            // 
            // btnCalcularTotalVenta
            // 
            btnCalcularTotalVenta.Location = new Point(200, 302);
            btnCalcularTotalVenta.Name = "btnCalcularTotalVenta";
            btnCalcularTotalVenta.Size = new Size(156, 32);
            btnCalcularTotalVenta.TabIndex = 45;
            btnCalcularTotalVenta.Text = "Calcular Total";
            btnCalcularTotalVenta.UseVisualStyleBackColor = true;
            // 
            // FormularioVenta1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnCalcularTotalVenta);
            Controls.Add(btnBuscarVenta);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnRegresarMenu);
            Controls.Add(btnModificarVenta);
            Controls.Add(btnAgregarVenta);
            Controls.Add(label2);
            Name = "FormularioVenta1";
            Text = "FormularioVenta1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarVenta;
        private Button btnEliminarVenta;
        private Button btnRegresarMenu;
        private Button btnModificarVenta;
        private Button btnAgregarVenta;
        private Label label2;
        private Button btnCalcularTotalVenta;
    }
}
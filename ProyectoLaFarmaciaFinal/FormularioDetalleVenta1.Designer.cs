namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioDetalleVenta1
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
            btnBuscarDetalleVenta = new Button();
            btnEliminarDetalleVenta = new Button();
            btnModificarDetalleVenta = new Button();
            btnRegresarMenu = new Button();
            btnAgregarDetalleVenta = new Button();
            btnCalcularSubtotal = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBuscarDetalleVenta
            // 
            btnBuscarDetalleVenta.Location = new Point(197, 291);
            btnBuscarDetalleVenta.Name = "btnBuscarDetalleVenta";
            btnBuscarDetalleVenta.Size = new Size(156, 32);
            btnBuscarDetalleVenta.TabIndex = 52;
            btnBuscarDetalleVenta.Text = "Buscar detalle de venta";
            btnBuscarDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDetalleVenta
            // 
            btnEliminarDetalleVenta.Location = new Point(197, 236);
            btnEliminarDetalleVenta.Name = "btnEliminarDetalleVenta";
            btnEliminarDetalleVenta.Size = new Size(156, 32);
            btnEliminarDetalleVenta.TabIndex = 51;
            btnEliminarDetalleVenta.Text = "Eliminar detalle de venta";
            btnEliminarDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // btnModificarDetalleVenta
            // 
            btnModificarDetalleVenta.Location = new Point(197, 186);
            btnModificarDetalleVenta.Name = "btnModificarDetalleVenta";
            btnModificarDetalleVenta.Size = new Size(156, 32);
            btnModificarDetalleVenta.TabIndex = 50;
            btnModificarDetalleVenta.Text = "Modificar detalle de venta";
            btnModificarDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(439, 37);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(75, 27);
            btnRegresarMenu.TabIndex = 49;
            btnRegresarMenu.Text = "Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDetalleVenta
            // 
            btnAgregarDetalleVenta.Location = new Point(197, 134);
            btnAgregarDetalleVenta.Name = "btnAgregarDetalleVenta";
            btnAgregarDetalleVenta.Size = new Size(156, 32);
            btnAgregarDetalleVenta.TabIndex = 48;
            btnAgregarDetalleVenta.Text = "Agregar detalle de venta";
            btnAgregarDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // btnCalcularSubtotal
            // 
            btnCalcularSubtotal.Location = new Point(197, 84);
            btnCalcularSubtotal.Name = "btnCalcularSubtotal";
            btnCalcularSubtotal.Size = new Size(156, 32);
            btnCalcularSubtotal.TabIndex = 47;
            btnCalcularSubtotal.Text = "Calcular Subtotal";
            btnCalcularSubtotal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(172, 29);
            label2.Name = "label2";
            label2.Size = new Size(199, 33);
            label2.TabIndex = 46;
            label2.Text = "Detalle de Venta";
            // 
            // FormularioDetalleVenta1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnBuscarDetalleVenta);
            Controls.Add(btnEliminarDetalleVenta);
            Controls.Add(btnModificarDetalleVenta);
            Controls.Add(btnRegresarMenu);
            Controls.Add(btnAgregarDetalleVenta);
            Controls.Add(btnCalcularSubtotal);
            Controls.Add(label2);
            Name = "FormularioDetalleVenta1";
            Text = "FormularioDetalleVenta1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarDetalleVenta;
        private Button btnEliminarDetalleVenta;
        private Button btnModificarDetalleVenta;
        private Button btnRegresarMenu;
        private Button btnAgregarDetalleVenta;
        private Button btnCalcularSubtotal;
        private Label label2;
    }
}
namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioMenu
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
            btnCompra1 = new Button();
            btnVenta1 = new Button();
            btnCliente1 = new Button();
            label2 = new Label();
            btnCerrarSesion = new Button();
            btnProducto1 = new Button();
            SuspendLayout();
            // 
            // btnCompra1
            // 
            btnCompra1.Location = new Point(195, 212);
            btnCompra1.Name = "btnCompra1";
            btnCompra1.Size = new Size(156, 32);
            btnCompra1.TabIndex = 40;
            btnCompra1.Text = "Compra";
            btnCompra1.UseVisualStyleBackColor = true;
            // 
            // btnVenta1
            // 
            btnVenta1.Location = new Point(195, 162);
            btnVenta1.Name = "btnVenta1";
            btnVenta1.Size = new Size(156, 32);
            btnVenta1.TabIndex = 39;
            btnVenta1.Text = "Venta";
            btnVenta1.UseVisualStyleBackColor = true;
            // 
            // btnCliente1
            // 
            btnCliente1.Location = new Point(195, 113);
            btnCliente1.Name = "btnCliente1";
            btnCliente1.Size = new Size(156, 32);
            btnCliente1.TabIndex = 38;
            btnCliente1.Text = "Cliente";
            btnCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(222, 62);
            label2.Name = "label2";
            label2.Size = new Size(80, 33);
            label2.TabIndex = 37;
            label2.Text = "Menu";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(21, 44);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(96, 27);
            btnCerrarSesion.TabIndex = 42;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnProducto1
            // 
            btnProducto1.Location = new Point(195, 262);
            btnProducto1.Name = "btnProducto1";
            btnProducto1.Size = new Size(156, 32);
            btnProducto1.TabIndex = 43;
            btnProducto1.Text = "Producto";
            btnProducto1.UseVisualStyleBackColor = true;
            // 
            // FormularioMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnProducto1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnCompra1);
            Controls.Add(btnVenta1);
            Controls.Add(btnCliente1);
            Controls.Add(label2);
            Name = "FormularioMenu";
            Text = "FormularioMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCompra1;
        private Button btnVenta1;
        private Button btnCliente1;
        private Label label2;
        private Button btnCerrarSesion;
        private Button btnProducto1;
    }
}
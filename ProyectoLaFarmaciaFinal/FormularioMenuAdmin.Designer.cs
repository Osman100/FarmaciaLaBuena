namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioMenuAdmin
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
            btnProducto1 = new Button();
            btnCerrarSesion = new Button();
            btnCompra1 = new Button();
            btnVenta1 = new Button();
            btnCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnProducto1
            // 
            btnProducto1.Location = new Point(187, 260);
            btnProducto1.Name = "btnProducto1";
            btnProducto1.Size = new Size(156, 32);
            btnProducto1.TabIndex = 49;
            btnProducto1.Text = "Buscar Empleado";
            btnProducto1.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(13, 42);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(96, 27);
            btnCerrarSesion.TabIndex = 48;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnCompra1
            // 
            btnCompra1.Location = new Point(187, 210);
            btnCompra1.Name = "btnCompra1";
            btnCompra1.Size = new Size(156, 32);
            btnCompra1.TabIndex = 47;
            btnCompra1.Text = "Eliminar Empleado";
            btnCompra1.UseVisualStyleBackColor = true;
            // 
            // btnVenta1
            // 
            btnVenta1.Location = new Point(187, 160);
            btnVenta1.Name = "btnVenta1";
            btnVenta1.Size = new Size(156, 32);
            btnVenta1.TabIndex = 46;
            btnVenta1.Text = "Modificar Empleado";
            btnVenta1.UseVisualStyleBackColor = true;
            // 
            // btnCliente1
            // 
            btnCliente1.Location = new Point(187, 111);
            btnCliente1.Name = "btnCliente1";
            btnCliente1.Size = new Size(156, 32);
            btnCliente1.TabIndex = 45;
            btnCliente1.Text = "Agregar Empleado";
            btnCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(154, 58);
            label2.Name = "label2";
            label2.Size = new Size(248, 33);
            label2.TabIndex = 44;
            label2.Text = "Menu Administrador";
            // 
            // FormularioMenuAdmin
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
            Name = "FormularioMenuAdmin";
            Text = "FormularioMenuAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProducto1;
        private Button btnCerrarSesion;
        private Button btnCompra1;
        private Button btnVenta1;
        private Button btnCliente1;
        private Label label2;
    }
}
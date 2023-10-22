namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioProducto3
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
            txtIdPedidoMostrar = new TextBox();
            label1 = new Label();
            btnMostrarProducto = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtIdPedidoMostrar
            // 
            txtIdPedidoMostrar.Location = new Point(229, 86);
            txtIdPedidoMostrar.Name = "txtIdPedidoMostrar";
            txtIdPedidoMostrar.Size = new Size(125, 23);
            txtIdPedidoMostrar.TabIndex = 102;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(165, 94);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 98;
            label1.Text = "ID Pedido";
            // 
            // btnMostrarProducto
            // 
            btnMostrarProducto.Location = new Point(406, 317);
            btnMostrarProducto.Name = "btnMostrarProducto";
            btnMostrarProducto.Size = new Size(100, 27);
            btnMostrarProducto.TabIndex = 97;
            btnMostrarProducto.Text = "Mostrar";
            btnMostrarProducto.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(431, 28);
            btnRegresarCliente1.Name = "btnRegresarCliente1";
            btnRegresarCliente1.Size = new Size(75, 27);
            btnRegresarCliente1.TabIndex = 96;
            btnRegresarCliente1.Text = "Regresar";
            btnRegresarCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(165, 34);
            label2.Name = "label2";
            label2.Size = new Size(213, 33);
            label2.TabIndex = 95;
            label2.Text = "Mostrar Producto";
            // 
            // FormularioProducto3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtIdPedidoMostrar);
            Controls.Add(label1);
            Controls.Add(btnMostrarProducto);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioProducto3";
            Text = "FormularioProducto3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExistenciaProductoAgregar;
        private Label label7;
        private TextBox txtPrecioProductoAgregar;
        private Label label6;
        private TextBox txtIdCategoriaAgregar;
        private TextBox txtCantidadStockMostrar;
        private TextBox txtNombreProductoMostrar;
        private TextBox txtIdPedidoMostrar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnMostrarProducto;
        private Button btnRegresarCliente1;
        private Label label2;
    }
}
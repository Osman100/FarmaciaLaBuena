namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioProducto4
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
            txtIdPedidoEliminar = new TextBox();
            label1 = new Label();
            btnEliminarProducto = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtIdPedidoEliminar
            // 
            txtIdPedidoEliminar.Location = new Point(216, 92);
            txtIdPedidoEliminar.Name = "txtIdPedidoEliminar";
            txtIdPedidoEliminar.Size = new Size(125, 23);
            txtIdPedidoEliminar.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(152, 100);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 106;
            label1.Text = "ID Pedido";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(393, 323);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(100, 27);
            btnEliminarProducto.TabIndex = 105;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(418, 34);
            btnRegresarCliente1.Name = "btnRegresarCliente1";
            btnRegresarCliente1.Size = new Size(75, 27);
            btnRegresarCliente1.TabIndex = 104;
            btnRegresarCliente1.Text = "Regresar";
            btnRegresarCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(152, 40);
            label2.Name = "label2";
            label2.Size = new Size(215, 33);
            label2.TabIndex = 103;
            label2.Text = "Eliminar Producto";
            // 
            // FormularioProducto4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtIdPedidoEliminar);
            Controls.Add(label1);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioProducto4";
            Text = "FormularioProducto4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdPedidoEliminar;
        private Label label1;
        private Button btnEliminarProducto;
        private Button btnRegresarCliente1;
        private Label label2;
    }
}
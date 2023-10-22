namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioDetalleVenta5
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
            this.txtIdDetalleVentaEliminar = new TextBox();
            label1 = new Label();
            btnEliminarDetalleVenta = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtIdDetalleVentaEliminar
            // 
            this.txtIdDetalleVentaEliminar.Location = new Point(226, 108);
            this.txtIdDetalleVentaEliminar.Name = "txtIdDetalleVentaEliminar";
            this.txtIdDetalleVentaEliminar.Size = new Size(125, 23);
            this.txtIdDetalleVentaEliminar.TabIndex = 113;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(162, 116);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 109;
            label1.Text = "ID Detalle";
            // 
            // btnEliminarDetalleVenta
            // 
            btnEliminarDetalleVenta.Location = new Point(393, 317);
            btnEliminarDetalleVenta.Name = "btnEliminarDetalleVenta";
            btnEliminarDetalleVenta.Size = new Size(92, 27);
            btnEliminarDetalleVenta.TabIndex = 108;
            btnEliminarDetalleVenta.Text = "Eliminar";
            btnEliminarDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(428, 34);
            btnRegresarCliente1.Name = "btnRegresarCliente1";
            btnRegresarCliente1.Size = new Size(75, 27);
            btnRegresarCliente1.TabIndex = 107;
            btnRegresarCliente1.Text = "Regresar";
            btnRegresarCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(142, 53);
            label2.Name = "label2";
            label2.Size = new Size(299, 33);
            label2.TabIndex = 106;
            label2.Text = "Eliminar Detalle de Venta";
            // 
            // FormularioDetalleVenta5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(this.txtIdDetalleVentaEliminar);
            Controls.Add(label1);
            Controls.Add(btnEliminarDetalleVenta);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioDetalleVenta5";
            Text = "FormularioDetalleVenta5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubtotalDetalleVentaModificar;
        private Label label6;
        private TextBox txtCantidadProductoDetalleVentaModificar;
        private TextBox txtIdProductoDetalleVentaModificar;
        private TextBox txtIdVentaDetalleVentaModificar;
        private TextBox txtIdDetalleVentaModificar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnEliminarDetalleVenta;
        private Button btnRegresarCliente1;
        private Label label2;
    }
}
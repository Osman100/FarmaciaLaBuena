namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioDetalleVenta6
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
            this.txtIdVentaDetalleVentaBuscar = new TextBox();
            txtIdDetalleVentaBuscar = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnBuscarDetalleVenta = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtIdVentaDetalleVentaBuscar
            // 
            this.txtIdVentaDetalleVentaBuscar.Location = new Point(226, 150);
            this.txtIdVentaDetalleVentaBuscar.Name = "txtIdVentaDetalleVentaBuscar";
            this.txtIdVentaDetalleVentaBuscar.Size = new Size(125, 23);
            this.txtIdVentaDetalleVentaBuscar.TabIndex = 114;
            // 
            // txtIdDetalleVentaBuscar
            // 
            txtIdDetalleVentaBuscar.Location = new Point(226, 103);
            txtIdDetalleVentaBuscar.Name = "txtIdDetalleVentaBuscar";
            txtIdDetalleVentaBuscar.Size = new Size(125, 23);
            txtIdDetalleVentaBuscar.TabIndex = 113;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(162, 158);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 110;
            label3.Text = "ID Venta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(162, 111);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 109;
            label1.Text = "ID Detalle";
            // 
            // btnBuscarDetalleVenta
            // 
            btnBuscarDetalleVenta.Location = new Point(393, 312);
            btnBuscarDetalleVenta.Name = "btnBuscarDetalleVenta";
            btnBuscarDetalleVenta.Size = new Size(92, 27);
            btnBuscarDetalleVenta.TabIndex = 108;
            btnBuscarDetalleVenta.Text = "Buscar";
            btnBuscarDetalleVenta.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(428, 29);
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
            label2.Location = new Point(142, 48);
            label2.Name = "label2";
            label2.Size = new Size(280, 33);
            label2.TabIndex = 106;
            label2.Text = "Buscar Detalle de Venta";
            // 
            // FormularioDetalleVenta6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(this.txtIdVentaDetalleVentaBuscar);
            Controls.Add(txtIdDetalleVentaBuscar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnBuscarDetalleVenta);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioDetalleVenta6";
            Text = "FormularioDetalleVenta6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSubtotalDetalleVentaModificar;
        private Label label6;
        private TextBox txtCantidadProductoDetalleVentaModificar;
        private TextBox txtIdProductoDetalleVentaModificar;
        private TextBox txtIdVentaDetalleVentaModificar;
        private TextBox txtIdDetalleVentaBuscar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnBuscarDetalleVenta;
        private Button btnRegresarCliente1;
        private Label label2;
    }
}
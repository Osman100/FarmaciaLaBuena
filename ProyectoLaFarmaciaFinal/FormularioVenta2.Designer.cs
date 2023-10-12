namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioVenta2
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
            txtTipoVenta = new TextBox();
            txtIDEmpleadoVenta = new TextBox();
            txtIdClienteVenta = new TextBox();
            txtIdVenta = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnVentaAgregar = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            txtTotalVenta = new TextBox();
            txtFechaVenta = new TextBox();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtTipoVenta
            // 
            txtTipoVenta.Location = new Point(253, 239);
            txtTipoVenta.Name = "txtTipoVenta";
            txtTipoVenta.Size = new Size(122, 23);
            txtTipoVenta.TabIndex = 61;
            // 
            // txtIDEmpleadoVenta
            // 
            txtIDEmpleadoVenta.Location = new Point(250, 195);
            txtIDEmpleadoVenta.Name = "txtIDEmpleadoVenta";
            txtIDEmpleadoVenta.Size = new Size(125, 23);
            txtIDEmpleadoVenta.TabIndex = 60;
            // 
            // txtIdClienteVenta
            // 
            txtIdClienteVenta.Location = new Point(250, 150);
            txtIdClienteVenta.Name = "txtIdClienteVenta";
            txtIdClienteVenta.Size = new Size(125, 23);
            txtIdClienteVenta.TabIndex = 59;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(250, 103);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(125, 23);
            txtIdVenta.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(158, 247);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 57;
            label5.Text = "Tipo de Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(162, 203);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 56;
            label4.Text = "ID Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(178, 158);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 55;
            label3.Text = "ID Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(186, 111);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 54;
            label1.Text = "ID Venta";
            // 
            // btnVentaAgregar
            // 
            btnVentaAgregar.Location = new Point(464, 311);
            btnVentaAgregar.Name = "btnVentaAgregar";
            btnVentaAgregar.Size = new Size(75, 27);
            btnVentaAgregar.TabIndex = 53;
            btnVentaAgregar.Text = "Agregar";
            btnVentaAgregar.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(452, 29);
            btnRegresarCliente1.Name = "btnRegresarCliente1";
            btnRegresarCliente1.Size = new Size(75, 27);
            btnRegresarCliente1.TabIndex = 52;
            btnRegresarCliente1.Text = "Regresar";
            btnRegresarCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(186, 51);
            label2.Name = "label2";
            label2.Size = new Size(177, 33);
            label2.TabIndex = 51;
            label2.Text = "Agregar Venta";
            // 
            // txtTotalVenta
            // 
            txtTotalVenta.Location = new Point(256, 322);
            txtTotalVenta.Name = "txtTotalVenta";
            txtTotalVenta.Size = new Size(122, 23);
            txtTotalVenta.TabIndex = 65;
            // 
            // txtFechaVenta
            // 
            txtFechaVenta.Location = new Point(253, 278);
            txtFechaVenta.Name = "txtFechaVenta";
            txtFechaVenta.Size = new Size(125, 23);
            txtFechaVenta.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(204, 330);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 63;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.ForeColor = Color.Snow;
            label7.Location = new Point(150, 286);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 62;
            label7.Text = "Fecha de venta";
            // 
            // FormularioVenta2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtTotalVenta);
            Controls.Add(txtFechaVenta);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtTipoVenta);
            Controls.Add(txtIDEmpleadoVenta);
            Controls.Add(txtIdClienteVenta);
            Controls.Add(txtIdVenta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnVentaAgregar);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioVenta2";
            Text = "FormularioVenta2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTipoVenta;
        private TextBox txtIDEmpleadoVenta;
        private TextBox txtIdClienteVenta;
        private TextBox txtIdVenta;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnVentaAgregar;
        private Button btnRegresarCliente1;
        private Label label2;
        private TextBox txtTotalVenta;
        private TextBox txtFechaVenta;
        private Label label6;
        private Label label7;
    }
}
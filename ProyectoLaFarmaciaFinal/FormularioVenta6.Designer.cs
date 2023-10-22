namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioVenta6
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
            txtTotalCalcularTotal = new TextBox();
            label6 = new Label();
            txtIdVentaCalcularTotal = new TextBox();
            label1 = new Label();
            btnCalcularTotal = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtTotalCalcularTotal
            // 
            txtTotalCalcularTotal.Location = new Point(217, 135);
            txtTotalCalcularTotal.Name = "txtTotalCalcularTotal";
            txtTotalCalcularTotal.Size = new Size(125, 23);
            txtTotalCalcularTotal.TabIndex = 110;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(165, 143);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 108;
            label6.Text = "Total";
            // 
            // txtIdVentaCalcularTotal
            // 
            txtIdVentaCalcularTotal.Location = new Point(217, 90);
            txtIdVentaCalcularTotal.Name = "txtIdVentaCalcularTotal";
            txtIdVentaCalcularTotal.Size = new Size(125, 23);
            txtIdVentaCalcularTotal.TabIndex = 103;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(153, 98);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 99;
            label1.Text = "ID Venta";
            // 
            // btnCalcularTotal
            // 
            btnCalcularTotal.Location = new Point(431, 298);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(75, 27);
            btnCalcularTotal.TabIndex = 98;
            btnCalcularTotal.Text = "Calcular";
            btnCalcularTotal.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(419, 16);
            btnRegresarCliente1.Name = "btnRegresarCliente1";
            btnRegresarCliente1.Size = new Size(75, 27);
            btnRegresarCliente1.TabIndex = 97;
            btnRegresarCliente1.Text = "Regresar";
            btnRegresarCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(184, 32);
            label2.Name = "label2";
            label2.Size = new Size(167, 33);
            label2.TabIndex = 96;
            label2.Text = "Calcular Total";
            // 
            // FormularioVenta6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtTotalCalcularTotal);
            Controls.Add(label6);
            Controls.Add(txtIdVentaCalcularTotal);
            Controls.Add(label1);
            Controls.Add(btnCalcularTotal);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioVenta6";
            Text = "FormularioVenta6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotalCalcularTotal;
        private Label label6;
        private TextBox txtIdVentaCalcularTotal;
        private Label label1;
        private Button btnCalcularTotal;
        private Button btnRegresarCliente1;
        private Label label2;
    }
}
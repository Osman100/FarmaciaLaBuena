namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioVenta4
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
            txtIdVentaEliminar = new TextBox();
            label1 = new Label();
            btnVentaEliminar = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtIdVentaEliminar
            // 
            txtIdVentaEliminar.Location = new Point(225, 96);
            txtIdVentaEliminar.Name = "txtIdVentaEliminar";
            txtIdVentaEliminar.Size = new Size(125, 23);
            txtIdVentaEliminar.TabIndex = 88;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(161, 104);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 84;
            label1.Text = "ID Venta";
            // 
            // btnVentaEliminar
            // 
            btnVentaEliminar.Location = new Point(439, 304);
            btnVentaEliminar.Name = "btnVentaEliminar";
            btnVentaEliminar.Size = new Size(75, 27);
            btnVentaEliminar.TabIndex = 83;
            btnVentaEliminar.Text = "Eliminar";
            btnVentaEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(427, 22);
            btnRegresarCliente1.Name = "btnRegresarCliente1";
            btnRegresarCliente1.Size = new Size(75, 27);
            btnRegresarCliente1.TabIndex = 82;
            btnRegresarCliente1.Text = "Regresar";
            btnRegresarCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(161, 44);
            label2.Name = "label2";
            label2.Size = new Size(180, 33);
            label2.TabIndex = 81;
            label2.Text = "Eliminar Venta";
            // 
            // FormularioVenta4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtIdVentaEliminar);
            Controls.Add(label1);
            Controls.Add(btnVentaEliminar);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioVenta4";
            Text = "FormularioVenta4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdVentaEliminar;
        private Label label1;
        private Button btnVentaEliminar;
        private Button btnRegresarCliente1;
        private Label label2;
    }
}
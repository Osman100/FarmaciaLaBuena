namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioCliente3
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
            txtNumeroTelefonicoModificar = new TextBox();
            txtCorreoElectronicoModificar = new TextBox();
            txtNombreClienteModificar = new TextBox();
            txtIdClienteModificar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnClienteModificar = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNumeroTelefonicoModificar
            // 
            txtNumeroTelefonicoModificar.Location = new Point(245, 251);
            txtNumeroTelefonicoModificar.Name = "txtNumeroTelefonicoModificar";
            txtNumeroTelefonicoModificar.Size = new Size(122, 23);
            txtNumeroTelefonicoModificar.TabIndex = 61;
            // 
            // txtCorreoElectronicoModificar
            // 
            txtCorreoElectronicoModificar.Location = new Point(242, 207);
            txtCorreoElectronicoModificar.Name = "txtCorreoElectronicoModificar";
            txtCorreoElectronicoModificar.Size = new Size(125, 23);
            txtCorreoElectronicoModificar.TabIndex = 60;
            // 
            // txtNombreClienteModificar
            // 
            txtNombreClienteModificar.Location = new Point(242, 162);
            txtNombreClienteModificar.Name = "txtNombreClienteModificar";
            txtNombreClienteModificar.Size = new Size(125, 23);
            txtNombreClienteModificar.TabIndex = 59;
            // 
            // txtIdClienteModificar
            // 
            txtIdClienteModificar.Location = new Point(242, 115);
            txtIdClienteModificar.Name = "txtIdClienteModificar";
            txtIdClienteModificar.Size = new Size(125, 23);
            txtIdClienteModificar.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(131, 259);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 57;
            label5.Text = "Número Telefónico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(131, 215);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 56;
            label4.Text = "Correo Electrónico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(145, 170);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 55;
            label3.Text = "Nombre Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(178, 123);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 54;
            label1.Text = "ID Cliente";
            // 
            // btnClienteModificar
            // 
            btnClienteModificar.Location = new Point(245, 310);
            btnClienteModificar.Name = "btnClienteModificar";
            btnClienteModificar.Size = new Size(75, 27);
            btnClienteModificar.TabIndex = 53;
            btnClienteModificar.Text = "Modificar";
            btnClienteModificar.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(444, 41);
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
            label2.Location = new Point(178, 63);
            label2.Name = "label2";
            label2.Size = new Size(207, 33);
            label2.TabIndex = 51;
            label2.Text = "Modificar Cliente";
            // 
            // FormularioCliente3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtNumeroTelefonicoModificar);
            Controls.Add(txtCorreoElectronicoModificar);
            Controls.Add(txtNombreClienteModificar);
            Controls.Add(txtIdClienteModificar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnClienteModificar);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioCliente3";
            Text = "FormularioCliente3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroTelefonicoModificar;
        private TextBox txtCorreoElectronicoModificar;
        private TextBox txtNombreClienteModificar;
        private TextBox txtIdClienteModificar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnClienteModificar;
        private Button btnRegresarCliente1;
        private Label label2;
    }
}
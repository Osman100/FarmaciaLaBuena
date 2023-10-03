namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioCliente2
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
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            btnClienteAgregar = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIdCliente = new TextBox();
            txtNombreCliente = new TextBox();
            txtCorreoElectronico = new TextBox();
            txtNumeroTelefonico = new TextBox();
            SuspendLayout();
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(444, 40);
            btnRegresarCliente1.Name = "btnRegresarCliente1";
            btnRegresarCliente1.Size = new Size(75, 27);
            btnRegresarCliente1.TabIndex = 41;
            btnRegresarCliente1.Text = "Regresar";
            btnRegresarCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(178, 62);
            label2.Name = "label2";
            label2.Size = new Size(189, 33);
            label2.TabIndex = 37;
            label2.Text = "Agregar Cliente";
            // 
            // btnClienteAgregar
            // 
            btnClienteAgregar.Location = new Point(245, 309);
            btnClienteAgregar.Name = "btnClienteAgregar";
            btnClienteAgregar.Size = new Size(75, 27);
            btnClienteAgregar.TabIndex = 42;
            btnClienteAgregar.Text = "Agregar";
            btnClienteAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(178, 122);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 43;
            label1.Text = "ID Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(145, 169);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 44;
            label3.Text = "Nombre Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(131, 214);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 45;
            label4.Text = "Correo Electrónico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(131, 258);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 46;
            label5.Text = "Número Telefónico";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(242, 114);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(125, 23);
            txtIdCliente.TabIndex = 47;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(242, 161);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 23);
            txtNombreCliente.TabIndex = 48;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(242, 206);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(125, 23);
            txtCorreoElectronico.TabIndex = 49;
            // 
            // txtNumeroTelefonico
            // 
            txtNumeroTelefonico.Location = new Point(245, 250);
            txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            txtNumeroTelefonico.Size = new Size(122, 23);
            txtNumeroTelefonico.TabIndex = 50;
            // 
            // FormularioCliente2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtNumeroTelefonico);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtNombreCliente);
            Controls.Add(txtIdCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnClienteAgregar);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioCliente2";
            Text = "FormularioCliente2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresarCliente1;
        private Label label2;
        private Button btnClienteAgregar;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdCliente;
        private TextBox txtNombreCliente;
        private TextBox txtCorreoElectronico;
        private TextBox txtNumeroTelefonico;
    }
}
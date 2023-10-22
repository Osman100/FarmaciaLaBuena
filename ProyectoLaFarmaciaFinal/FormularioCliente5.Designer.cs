namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioCliente5
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
            txtNumeroTelefonicoBuscar = new TextBox();
            txtCorreoElectronicoBuscar = new TextBox();
            txtNombreClienteBuscar = new TextBox();
            txtIdClienteBuscar = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnClienteBuscar = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNumeroTelefonicoBuscar
            // 
            txtNumeroTelefonicoBuscar.Location = new Point(241, 248);
            txtNumeroTelefonicoBuscar.Name = "txtNumeroTelefonicoBuscar";
            txtNumeroTelefonicoBuscar.Size = new Size(122, 23);
            txtNumeroTelefonicoBuscar.TabIndex = 72;
            // 
            // txtCorreoElectronicoBuscar
            // 
            txtCorreoElectronicoBuscar.Location = new Point(238, 204);
            txtCorreoElectronicoBuscar.Name = "txtCorreoElectronicoBuscar";
            txtCorreoElectronicoBuscar.Size = new Size(125, 23);
            txtCorreoElectronicoBuscar.TabIndex = 71;
            // 
            // txtNombreClienteBuscar
            // 
            txtNombreClienteBuscar.Location = new Point(238, 159);
            txtNombreClienteBuscar.Name = "txtNombreClienteBuscar";
            txtNombreClienteBuscar.Size = new Size(125, 23);
            txtNombreClienteBuscar.TabIndex = 70;
            // 
            // txtIdClienteBuscar
            // 
            txtIdClienteBuscar.Location = new Point(238, 112);
            txtIdClienteBuscar.Name = "txtIdClienteBuscar";
            txtIdClienteBuscar.Size = new Size(125, 23);
            txtIdClienteBuscar.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(127, 256);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 68;
            label5.Text = "Número Telefónico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(127, 212);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 67;
            label4.Text = "Correo Electrónico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(141, 167);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 66;
            label3.Text = "Nombre Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(174, 120);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 65;
            label1.Text = "ID Cliente";
            // 
            // btnClienteBuscar
            // 
            btnClienteBuscar.Location = new Point(241, 307);
            btnClienteBuscar.Name = "btnClienteBuscar";
            btnClienteBuscar.Size = new Size(75, 27);
            btnClienteBuscar.TabIndex = 64;
            btnClienteBuscar.Text = "Buscar";
            btnClienteBuscar.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(440, 38);
            btnRegresarCliente1.Name = "btnRegresarCliente1";
            btnRegresarCliente1.Size = new Size(75, 27);
            btnRegresarCliente1.TabIndex = 63;
            btnRegresarCliente1.Text = "Regresar";
            btnRegresarCliente1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(190, 55);
            label2.Name = "label2";
            label2.Size = new Size(173, 33);
            label2.TabIndex = 62;
            label2.Text = "Buscar Cliente";
            // 
            // FormularioCliente5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtNumeroTelefonicoBuscar);
            Controls.Add(txtCorreoElectronicoBuscar);
            Controls.Add(txtNombreClienteBuscar);
            Controls.Add(txtIdClienteBuscar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnClienteBuscar);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioCliente5";
            Text = "FormularioCliente5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroTelefonicoBuscar;
        private TextBox txtCorreoElectronicoBuscar;
        private TextBox txtNombreClienteBuscar;
        private TextBox txtIdClienteBuscar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnClienteBuscar;
        private Button btnRegresarCliente1;
        private Label label2;
    }
}
namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioCliente4
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
            txtIdClienteEliminar = new TextBox();
            label1 = new Label();
            btnClienteEliminar = new Button();
            btnRegresarCliente1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtIdClienteEliminar
            // 
            txtIdClienteEliminar.Location = new Point(230, 109);
            txtIdClienteEliminar.Name = "txtIdClienteEliminar";
            txtIdClienteEliminar.Size = new Size(125, 23);
            txtIdClienteEliminar.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(166, 117);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 65;
            label1.Text = "ID Cliente";
            // 
            // btnClienteEliminar
            // 
            btnClienteEliminar.Location = new Point(280, 300);
            btnClienteEliminar.Name = "btnClienteEliminar";
            btnClienteEliminar.Size = new Size(75, 27);
            btnClienteEliminar.TabIndex = 64;
            btnClienteEliminar.Text = "Eliminar";
            btnClienteEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegresarCliente1
            // 
            btnRegresarCliente1.Location = new Point(432, 35);
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
            label2.Location = new Point(178, 55);
            label2.Name = "label2";
            label2.Size = new Size(192, 33);
            label2.TabIndex = 62;
            label2.Text = "Eliminar Cliente";
            // 
            // FormularioCliente4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtIdClienteEliminar);
            Controls.Add(label1);
            Controls.Add(btnClienteEliminar);
            Controls.Add(btnRegresarCliente1);
            Controls.Add(label2);
            Name = "FormularioCliente4";
            Text = "FormularioCliente4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIdClienteEliminar;
        private Label label1;
        private Button btnClienteEliminar;
        private Button btnRegresarCliente1;
        private Label label2;
    }
}
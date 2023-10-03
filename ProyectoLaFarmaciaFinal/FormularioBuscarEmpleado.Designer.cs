namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioBuscarEmpleado
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
            txtNombreEmpleado = new TextBox();
            txtIdEmpleado = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnEmpleadoBuscar = new Button();
            btnRegresarMenuAdministrador = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(253, 151);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(125, 23);
            txtNombreEmpleado.TabIndex = 79;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(253, 110);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(125, 23);
            txtIdEmpleado.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(140, 159);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 75;
            label4.Text = "Nombre Empleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(173, 118);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 73;
            label1.Text = "ID Empleado";
            // 
            // btnEmpleadoBuscar
            // 
            btnEmpleadoBuscar.Location = new Point(456, 303);
            btnEmpleadoBuscar.Name = "btnEmpleadoBuscar";
            btnEmpleadoBuscar.Size = new Size(75, 27);
            btnEmpleadoBuscar.TabIndex = 72;
            btnEmpleadoBuscar.Text = "Buscar";
            btnEmpleadoBuscar.UseVisualStyleBackColor = true;
            // 
            // btnRegresarMenuAdministrador
            // 
            btnRegresarMenuAdministrador.Location = new Point(456, 40);
            btnRegresarMenuAdministrador.Name = "btnRegresarMenuAdministrador";
            btnRegresarMenuAdministrador.Size = new Size(75, 27);
            btnRegresarMenuAdministrador.TabIndex = 71;
            btnRegresarMenuAdministrador.Text = "Regresar";
            btnRegresarMenuAdministrador.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(184, 56);
            label2.Name = "label2";
            label2.Size = new Size(207, 33);
            label2.TabIndex = 69;
            label2.Text = "Buscar Empleado";
            // 
            // FormularioBuscarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(txtIdEmpleado);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnEmpleadoBuscar);
            Controls.Add(btnRegresarMenuAdministrador);
            Controls.Add(label2);
            Name = "FormularioBuscarEmpleado";
            Text = "FormularioBuscarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreEmpleado;
        private TextBox txtIdEmpleado;
        private Label label4;
        private Label label1;
        private Button btnEmpleadoBuscar;
        private Button btnRegresarMenuAdministrador;
        private Label label2;
    }
}
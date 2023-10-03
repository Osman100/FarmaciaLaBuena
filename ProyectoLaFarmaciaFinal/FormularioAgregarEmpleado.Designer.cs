namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioAgregarEmpleado
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
            label2 = new Label();
            btnRegresarMenuAdministrador = new Button();
            txtEstadoLaboral = new TextBox();
            txtNombreEmpleado = new TextBox();
            txtIdRol = new TextBox();
            txtIdEmpleado = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnEmpleadoAgregar = new Button();
            txtSalarioEmpleado = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(182, 59);
            label2.Name = "label2";
            label2.Size = new Size(223, 33);
            label2.TabIndex = 50;
            label2.Text = "Agregar Empleado";
            // 
            // btnRegresarMenuAdministrador
            // 
            btnRegresarMenuAdministrador.Location = new Point(454, 43);
            btnRegresarMenuAdministrador.Name = "btnRegresarMenuAdministrador";
            btnRegresarMenuAdministrador.Size = new Size(75, 27);
            btnRegresarMenuAdministrador.TabIndex = 57;
            btnRegresarMenuAdministrador.Text = "Regresar";
            btnRegresarMenuAdministrador.UseVisualStyleBackColor = true;
            // 
            // txtEstadoLaboral
            // 
            txtEstadoLaboral.Location = new Point(254, 249);
            txtEstadoLaboral.Name = "txtEstadoLaboral";
            txtEstadoLaboral.Size = new Size(122, 23);
            txtEstadoLaboral.TabIndex = 66;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(251, 205);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(125, 23);
            txtNombreEmpleado.TabIndex = 65;
            // 
            // txtIdRol
            // 
            txtIdRol.Location = new Point(251, 160);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.Size = new Size(125, 23);
            txtIdRol.TabIndex = 64;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(251, 113);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(125, 23);
            txtIdEmpleado.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(161, 257);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 62;
            label5.Text = "Estado Laboral";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(138, 213);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 61;
            label4.Text = "Nombre Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(207, 168);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 60;
            label3.Text = "ID Rol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(171, 121);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 59;
            label1.Text = "ID Empleado";
            // 
            // btnEmpleadoAgregar
            // 
            btnEmpleadoAgregar.Location = new Point(454, 306);
            btnEmpleadoAgregar.Name = "btnEmpleadoAgregar";
            btnEmpleadoAgregar.Size = new Size(75, 27);
            btnEmpleadoAgregar.TabIndex = 58;
            btnEmpleadoAgregar.Text = "Agregar";
            btnEmpleadoAgregar.UseVisualStyleBackColor = true;
            // 
            // txtSalarioEmpleado
            // 
            txtSalarioEmpleado.Location = new Point(254, 289);
            txtSalarioEmpleado.Name = "txtSalarioEmpleado";
            txtSalarioEmpleado.Size = new Size(122, 23);
            txtSalarioEmpleado.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(203, 297);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 67;
            label6.Text = "Salario";
            // 
            // FormularioAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtSalarioEmpleado);
            Controls.Add(label6);
            Controls.Add(txtEstadoLaboral);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(txtIdRol);
            Controls.Add(txtIdEmpleado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnEmpleadoAgregar);
            Controls.Add(btnRegresarMenuAdministrador);
            Controls.Add(label2);
            Name = "FormularioAgregarEmpleado";
            Text = "FormularioAgregarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnRegresarMenuAdministrador;
        private TextBox txtEstadoLaboral;
        private TextBox txtNombreEmpleado;
        private TextBox txtIdRol;
        private TextBox txtIdEmpleado;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnEmpleadoAgregar;
        private TextBox txtSalarioEmpleado;
        private Label label6;
    }
}
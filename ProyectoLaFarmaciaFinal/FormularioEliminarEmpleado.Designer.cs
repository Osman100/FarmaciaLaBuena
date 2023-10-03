namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioEliminarEmpleado
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
            btnRegresarMenuAdministrador = new Button();
            label2 = new Label();
            txtIdEmpleadoEliminar = new TextBox();
            label1 = new Label();
            btnEmpleadoEliminar = new Button();
            SuspendLayout();
            // 
            // btnRegresarMenuAdministrador
            // 
            btnRegresarMenuAdministrador.Location = new Point(460, 37);
            btnRegresarMenuAdministrador.Name = "btnRegresarMenuAdministrador";
            btnRegresarMenuAdministrador.Size = new Size(75, 27);
            btnRegresarMenuAdministrador.TabIndex = 53;
            btnRegresarMenuAdministrador.Text = "Regresar";
            btnRegresarMenuAdministrador.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(194, 59);
            label2.Name = "label2";
            label2.Size = new Size(226, 33);
            label2.TabIndex = 52;
            label2.Text = "Eliminar Empleado";
            // 
            // txtIdEmpleadoEliminar
            // 
            txtIdEmpleadoEliminar.Location = new Point(231, 113);
            txtIdEmpleadoEliminar.Name = "txtIdEmpleadoEliminar";
            txtIdEmpleadoEliminar.Size = new Size(125, 23);
            txtIdEmpleadoEliminar.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(151, 121);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 70;
            label1.Text = "ID Empleado";
            // 
            // btnEmpleadoEliminar
            // 
            btnEmpleadoEliminar.Location = new Point(434, 306);
            btnEmpleadoEliminar.Name = "btnEmpleadoEliminar";
            btnEmpleadoEliminar.Size = new Size(75, 27);
            btnEmpleadoEliminar.TabIndex = 69;
            btnEmpleadoEliminar.Text = "Eliminar";
            btnEmpleadoEliminar.UseVisualStyleBackColor = true;
            // 
            // FormularioEliminarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(txtIdEmpleadoEliminar);
            Controls.Add(label1);
            Controls.Add(btnEmpleadoEliminar);
            Controls.Add(btnRegresarMenuAdministrador);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            Name = "FormularioEliminarEmpleado";
            Text = "FormularioEliminarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegresarMenuAdministrador;
        private Label label2;
        private TextBox txtIdEmpleadoEliminar;
        private Label label1;
        private Button btnEmpleadoEliminar;
    }
}
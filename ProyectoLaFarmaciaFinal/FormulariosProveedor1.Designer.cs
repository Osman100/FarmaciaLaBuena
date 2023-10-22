namespace ProyectoLaFarmaciaFinal
{
    partial class FormulariosProveedor1
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
            btnBuscarProveedor = new Button();
            btnEliminarProveedor = new Button();
            btnModificarProveedor = new Button();
            btnAgregarProveedor = new Button();
            btnRegresarMenu = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Location = new Point(195, 273);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(156, 32);
            btnBuscarProveedor.TabIndex = 69;
            btnBuscarProveedor.Text = "Buscar proveedor";
            btnBuscarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Location = new Point(195, 218);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(156, 32);
            btnEliminarProveedor.TabIndex = 68;
            btnEliminarProveedor.Text = "Eliminar proveedor";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.Location = new Point(195, 168);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(156, 32);
            btnModificarProveedor.TabIndex = 67;
            btnModificarProveedor.Text = "Modificar proveedor";
            btnModificarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(195, 116);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(156, 32);
            btnAgregarProveedor.TabIndex = 66;
            btnAgregarProveedor.Text = "Agregar proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(437, 54);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(75, 27);
            btnRegresarMenu.TabIndex = 65;
            btnRegresarMenu.Text = "Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(195, 46);
            label2.Name = "label2";
            label2.Size = new Size(130, 33);
            label2.TabIndex = 64;
            label2.Text = "Proveedor";
            // 
            // FormulariosProveedor1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnBuscarProveedor);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(btnModificarProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(btnRegresarMenu);
            Controls.Add(label2);
            Name = "FormulariosProveedor1";
            Text = "FormulariosProveedor1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarProveedor;
        private Button btnEliminarProveedor;
        private Button btnModificarProveedor;
        private Button btnAgregarProveedor;
        private Button btnRegresarMenu;
        private Label label2;
    }
}
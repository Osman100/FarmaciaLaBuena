namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioProducto1
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
            btnBuscarProducto = new Button();
            btnEliminarProducto = new Button();
            btnMostrarProducto = new Button();
            btnRegresarMenu = new Button();
            btnAgregarProducto = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(195, 262);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(156, 32);
            btnBuscarProducto.TabIndex = 59;
            btnBuscarProducto.Text = "Actualizar producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(195, 207);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(156, 32);
            btnEliminarProducto.TabIndex = 58;
            btnEliminarProducto.Text = "Eliminar producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProducto
            // 
            btnMostrarProducto.Location = new Point(195, 157);
            btnMostrarProducto.Name = "btnMostrarProducto";
            btnMostrarProducto.Size = new Size(156, 32);
            btnMostrarProducto.TabIndex = 57;
            btnMostrarProducto.Text = "Mostrar producto";
            btnMostrarProducto.UseVisualStyleBackColor = true;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(452, 34);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(75, 27);
            btnRegresarMenu.TabIndex = 56;
            btnRegresarMenu.Text = "Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(195, 105);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(156, 32);
            btnAgregarProducto.TabIndex = 55;
            btnAgregarProducto.Text = "Agregar producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(195, 34);
            label2.Name = "label2";
            label2.Size = new Size(115, 33);
            label2.TabIndex = 53;
            label2.Text = "Producto";
            // 
            // FormularioProducto1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnBuscarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnMostrarProducto);
            Controls.Add(btnRegresarMenu);
            Controls.Add(btnAgregarProducto);
            Controls.Add(label2);
            Name = "FormularioProducto1";
            Text = "FormularioProducto1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarProducto;
        private Button btnEliminarProducto;
        private Button btnMostrarProducto;
        private Button btnRegresarMenu;
        private Button btnAgregarProducto;
        private Label label2;
    }
}
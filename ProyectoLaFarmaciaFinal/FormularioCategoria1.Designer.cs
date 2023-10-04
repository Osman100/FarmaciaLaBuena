namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioCategoria1
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
            btnRegresarMenu = new Button();
            label2 = new Label();
            btnBuscarCategoria = new Button();
            btnEliminarCategoria = new Button();
            btnMostrarCategoria = new Button();
            btnAgregarCategoria = new Button();
            SuspendLayout();
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(434, 44);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(75, 27);
            btnRegresarMenu.TabIndex = 56;
            btnRegresarMenu.Text = "Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(192, 36);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 53;
            label2.Text = "Categoría";
            // 
            // btnBuscarCategoria
            // 
            btnBuscarCategoria.Location = new Point(192, 263);
            btnBuscarCategoria.Name = "btnBuscarCategoria";
            btnBuscarCategoria.Size = new Size(156, 32);
            btnBuscarCategoria.TabIndex = 63;
            btnBuscarCategoria.Text = "Buscar categoría";
            btnBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Location = new Point(192, 208);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(156, 32);
            btnEliminarCategoria.TabIndex = 62;
            btnEliminarCategoria.Text = "Eliminar categoría";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnMostrarCategoria
            // 
            btnMostrarCategoria.Location = new Point(192, 158);
            btnMostrarCategoria.Name = "btnMostrarCategoria";
            btnMostrarCategoria.Size = new Size(156, 32);
            btnMostrarCategoria.TabIndex = 61;
            btnMostrarCategoria.Text = "Mostrar categoría";
            btnMostrarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(192, 106);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(156, 32);
            btnAgregarCategoria.TabIndex = 60;
            btnAgregarCategoria.Text = "Agregar categoría";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // FormularioCategoria1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnBuscarCategoria);
            Controls.Add(btnEliminarCategoria);
            Controls.Add(btnMostrarCategoria);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(btnRegresarMenu);
            Controls.Add(label2);
            Name = "FormularioCategoria1";
            Text = "FormularioCategoria1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegresarMenu;
        private Label label2;
        private Button btnBuscarCategoria;
        private Button btnEliminarCategoria;
        private Button btnMostrarCategoria;
        private Button btnAgregarCategoria;
    }
}
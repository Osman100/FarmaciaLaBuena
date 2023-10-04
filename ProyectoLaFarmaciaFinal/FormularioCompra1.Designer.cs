namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioCompra1
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
            btnBuscarCompra = new Button();
            btnEliminarCompra = new Button();
            btnModificarCompra = new Button();
            btnAgregarCompra = new Button();
            btnRegresarMenu = new Button();
            label2 = new Label();
            btnCalcularTotalCompra = new Button();
            SuspendLayout();
            // 
            // btnBuscarCompra
            // 
            btnBuscarCompra.Location = new Point(203, 250);
            btnBuscarCompra.Name = "btnBuscarCompra";
            btnBuscarCompra.Size = new Size(156, 32);
            btnBuscarCompra.TabIndex = 75;
            btnBuscarCompra.Text = "Buscar compra";
            btnBuscarCompra.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCompra
            // 
            btnEliminarCompra.Location = new Point(203, 195);
            btnEliminarCompra.Name = "btnEliminarCompra";
            btnEliminarCompra.Size = new Size(156, 32);
            btnEliminarCompra.TabIndex = 74;
            btnEliminarCompra.Text = "Eliminar compra";
            btnEliminarCompra.UseVisualStyleBackColor = true;
            // 
            // btnModificarCompra
            // 
            btnModificarCompra.Location = new Point(203, 145);
            btnModificarCompra.Name = "btnModificarCompra";
            btnModificarCompra.Size = new Size(156, 32);
            btnModificarCompra.TabIndex = 73;
            btnModificarCompra.Text = "Modificar compra";
            btnModificarCompra.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.Location = new Point(203, 93);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(156, 32);
            btnAgregarCompra.TabIndex = 72;
            btnAgregarCompra.Text = "Agregar compra";
            btnAgregarCompra.UseVisualStyleBackColor = true;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(445, 55);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(75, 27);
            btnRegresarMenu.TabIndex = 71;
            btnRegresarMenu.Text = "Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(203, 47);
            label2.Name = "label2";
            label2.Size = new Size(103, 33);
            label2.TabIndex = 70;
            label2.Text = "Compra";
            // 
            // btnCalcularTotalCompra
            // 
            btnCalcularTotalCompra.Location = new Point(203, 303);
            btnCalcularTotalCompra.Name = "btnCalcularTotalCompra";
            btnCalcularTotalCompra.Size = new Size(156, 32);
            btnCalcularTotalCompra.TabIndex = 76;
            btnCalcularTotalCompra.Text = "Calcular Total";
            btnCalcularTotalCompra.UseVisualStyleBackColor = true;
            // 
            // FormularioCompra1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnCalcularTotalCompra);
            Controls.Add(btnBuscarCompra);
            Controls.Add(btnEliminarCompra);
            Controls.Add(btnModificarCompra);
            Controls.Add(btnAgregarCompra);
            Controls.Add(btnRegresarMenu);
            Controls.Add(label2);
            Name = "FormularioCompra1";
            Text = "FormularioCompra1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarCompra;
        private Button btnEliminarCompra;
        private Button btnModificarCompra;
        private Button btnAgregarCompra;
        private Button btnRegresarMenu;
        private Label label2;
        private Button btnCalcularTotalCompra;
    }
}
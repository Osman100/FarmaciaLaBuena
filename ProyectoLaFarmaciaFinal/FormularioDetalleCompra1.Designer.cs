namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioDetalleCompra1
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
            btnCalcularSubtotaDetalle = new Button();
            btnBuscarDetalle = new Button();
            btnEliminarDetalle = new Button();
            btnModificarDetalle = new Button();
            btnAgregarDetalle = new Button();
            btnRegresarMenu = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCalcularSubtotaDetalle
            // 
            btnCalcularSubtotaDetalle.Location = new Point(201, 296);
            btnCalcularSubtotaDetalle.Name = "btnCalcularSubtotaDetalle";
            btnCalcularSubtotaDetalle.Size = new Size(156, 32);
            btnCalcularSubtotaDetalle.TabIndex = 83;
            btnCalcularSubtotaDetalle.Text = "Calcular subtotal";
            btnCalcularSubtotaDetalle.UseVisualStyleBackColor = true;
            // 
            // btnBuscarDetalle
            // 
            btnBuscarDetalle.Location = new Point(201, 243);
            btnBuscarDetalle.Name = "btnBuscarDetalle";
            btnBuscarDetalle.Size = new Size(156, 32);
            btnBuscarDetalle.TabIndex = 82;
            btnBuscarDetalle.Text = "Buscar detalle";
            btnBuscarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDetalle
            // 
            btnEliminarDetalle.Location = new Point(201, 188);
            btnEliminarDetalle.Name = "btnEliminarDetalle";
            btnEliminarDetalle.Size = new Size(156, 32);
            btnEliminarDetalle.TabIndex = 81;
            btnEliminarDetalle.Text = "Eliminar detalle";
            btnEliminarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnModificarDetalle
            // 
            btnModificarDetalle.Location = new Point(201, 138);
            btnModificarDetalle.Name = "btnModificarDetalle";
            btnModificarDetalle.Size = new Size(156, 32);
            btnModificarDetalle.TabIndex = 80;
            btnModificarDetalle.Text = "Modificar detalle";
            btnModificarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDetalle
            // 
            btnAgregarDetalle.Location = new Point(201, 86);
            btnAgregarDetalle.Name = "btnAgregarDetalle";
            btnAgregarDetalle.Size = new Size(156, 32);
            btnAgregarDetalle.TabIndex = 79;
            btnAgregarDetalle.Text = "Agregar detalle";
            btnAgregarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnRegresarMenu
            // 
            btnRegresarMenu.Location = new Point(443, 48);
            btnRegresarMenu.Name = "btnRegresarMenu";
            btnRegresarMenu.Size = new Size(75, 27);
            btnRegresarMenu.TabIndex = 78;
            btnRegresarMenu.Text = "Regresar";
            btnRegresarMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(162, 40);
            label2.Name = "label2";
            label2.Size = new Size(219, 33);
            label2.TabIndex = 77;
            label2.Text = "Detalle de compra";
            // 
            // FormularioDetalleCompra1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(btnCalcularSubtotaDetalle);
            Controls.Add(btnBuscarDetalle);
            Controls.Add(btnEliminarDetalle);
            Controls.Add(btnModificarDetalle);
            Controls.Add(btnAgregarDetalle);
            Controls.Add(btnRegresarMenu);
            Controls.Add(label2);
            Name = "FormularioDetalleCompra1";
            Text = "FormularioDetalleCompra1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularSubtotaDetalle;
        private Button btnBuscarDetalle;
        private Button btnEliminarDetalle;
        private Button btnModificarDetalle;
        private Button btnAgregarDetalle;
        private Button btnRegresarMenu;
        private Label label2;
    }
}
namespace ProyectoLaFarmaciaFinal
{
    partial class FormularioCliente1
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(443, 37);
            button5.Name = "button5";
            button5.Size = new Size(75, 27);
            button5.TabIndex = 36;
            button5.Text = "Regresar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(198, 237);
            button4.Name = "button4";
            button4.Size = new Size(156, 32);
            button4.TabIndex = 35;
            button4.Text = "Eliminar Cliente";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(198, 187);
            button3.Name = "button3";
            button3.Size = new Size(156, 32);
            button3.TabIndex = 34;
            button3.Text = "Agregar Cliente";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(198, 138);
            button2.Name = "button2";
            button2.Size = new Size(156, 32);
            button2.TabIndex = 33;
            button2.Text = "Realizar Transacción";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(225, 55);
            label2.Name = "label2";
            label2.Size = new Size(92, 33);
            label2.TabIndex = 32;
            label2.Text = "Cliente";
            // 
            // FormularioCliente1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(574, 371);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Name = "FormularioCliente1";
            Text = "FormularioCliente1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
    }
}
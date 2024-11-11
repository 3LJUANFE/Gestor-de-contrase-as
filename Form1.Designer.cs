namespace Gestor_contraseñas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbx1 = new TextBox();
            btn1 = new Button();
            checkOcultar = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 111);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "CONTRASEÑA";
            // 
            // tbx1
            // 
            tbx1.Location = new Point(52, 185);
            tbx1.Name = "tbx1";
            tbx1.PasswordChar = '*';
            tbx1.Size = new Size(159, 27);
            tbx1.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(127, 271);
            btn1.Name = "btn1";
            btn1.Size = new Size(104, 35);
            btn1.TabIndex = 2;
            btn1.Text = "VERIFICAR";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // checkOcultar
            // 
            checkOcultar.AutoSize = true;
            checkOcultar.Location = new Point(238, 188);
            checkOcultar.Name = "checkOcultar";
            checkOcultar.Size = new Size(99, 24);
            checkOcultar.TabIndex = 4;
            checkOcultar.Text = "MOSTRAR";
            checkOcultar.UseVisualStyleBackColor = true;
            checkOcultar.CheckedChanged += checkOcultar_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(checkOcultar);
            Controls.Add(btn1);
            Controls.Add(tbx1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Inicia Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbx1;
        private Button btn1;
        private CheckBox checkOcultar;
    }
}

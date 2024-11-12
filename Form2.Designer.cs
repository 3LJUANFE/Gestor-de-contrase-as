namespace Gestor_contraseñas
{
    partial class Form2
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
            lbx1 = new ListBox();
            btn1 = new Button();
            btn2 = new Button();
            lb1 = new Label();
            tbx1 = new TextBox();
            tbx2 = new TextBox();
            SuspendLayout();
            // 
            // lbx1
            // 
            lbx1.FormattingEnabled = true;
            lbx1.Location = new Point(12, 47);
            lbx1.Name = "lbx1";
            lbx1.Size = new Size(398, 384);
            lbx1.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Chartreuse;
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(485, 268);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 1;
            btn1.Text = "Agregar";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Firebrick;
            btn2.Location = new Point(613, 268);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 2;
            btn2.Text = "Eliminar";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(148, 12);
            lb1.Name = "lb1";
            lb1.Size = new Size(89, 20);
            lb1.TabIndex = 4;
            lb1.Text = "Contraseñas";
            // 
            // tbx1
            // 
            tbx1.Location = new Point(449, 47);
            tbx1.Name = "tbx1";
            tbx1.Size = new Size(306, 27);
            tbx1.TabIndex = 5;
            tbx1.Text = "Contraseña";
            // 
            // tbx2
            // 
            tbx2.Location = new Point(449, 123);
            tbx2.Multiline = true;
            tbx2.Name = "tbx2";
            tbx2.Size = new Size(306, 124);
            tbx2.TabIndex = 6;
            tbx2.Text = "Añade una descripcion";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbx2);
            Controls.Add(tbx1);
            Controls.Add(lb1);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lbx1);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx1;
        private Button btn1;
        private Button btn2;
        private Label lb1;
        private TextBox tbx1;
        private TextBox tbx2;
    }
}
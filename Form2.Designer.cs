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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lbx1 = new ListBox();
            btn1 = new Button();
            btn2 = new Button();
            lb1 = new Label();
            tbx1 = new TextBox();
            menuStrip1 = new MenuStrip();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            gargarToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbx1
            // 
            lbx1.BorderStyle = BorderStyle.FixedSingle;
            lbx1.FormattingEnabled = true;
            lbx1.Location = new Point(38, 65);
            lbx1.Name = "lbx1";
            lbx1.Size = new Size(398, 382);
            lbx1.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Chartreuse;
            btn1.FlatStyle = FlatStyle.Popup;
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(511, 125);
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
            btn2.FlatStyle = FlatStyle.Popup;
            btn2.Location = new Point(639, 125);
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
            lb1.Font = new Font("Segoe UI", 14F);
            lb1.Location = new Point(161, 30);
            lb1.Name = "lb1";
            lb1.Size = new Size(144, 32);
            lb1.TabIndex = 4;
            lb1.Text = "Contraseñas";
            // 
            // tbx1
            // 
            tbx1.Location = new Point(475, 65);
            tbx1.Name = "tbx1";
            tbx1.PlaceholderText = "Contraseña";
            tbx1.Size = new Size(306, 27);
            tbx1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { guardarToolStripMenuItem, gargarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(839, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(76, 24);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // gargarToolStripMenuItem
            // 
            gargarToolStripMenuItem.Name = "gargarToolStripMenuItem";
            gargarToolStripMenuItem.Size = new Size(68, 24);
            gargarToolStripMenuItem.Text = "Gargar";
            gargarToolStripMenuItem.Click += gargarToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\felip\\Desktop\\Cosas\\Programacion\\C#\\Gestor contraseñas\\img\\hacker-icono.ico";
            pictureBox1.Location = new Point(475, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(839, 485);
            Controls.Add(pictureBox1);
            Controls.Add(tbx1);
            Controls.Add(lb1);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lbx1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonFace;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de contraseñas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbx1;
        private Button btn1;
        private Button btn2;
        private Label lb1;
        private TextBox tbx1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem gargarToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
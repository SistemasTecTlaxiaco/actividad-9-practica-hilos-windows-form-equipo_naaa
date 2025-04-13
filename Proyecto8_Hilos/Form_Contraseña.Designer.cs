namespace Proyecto8_Hilos
{
    partial class Form_Contraseña
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
            label1 = new Label();
            label2 = new Label();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            pictureBox1 = new PictureBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(635, 67);
            label1.Name = "label1";
            label1.Size = new Size(531, 60);
            label1.TabIndex = 0;
            label1.Text = "Cambiar Contraseña";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(684, 165);
            label2.Name = "label2";
            label2.Size = new Size(395, 36);
            label2.TabIndex = 1;
            label2.Text = "Escriba su nueva contraseña:";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.DimGray;
            rjTextBox1.Location = new Point(684, 223);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.Size = new Size(388, 35);
            rjTextBox1.TabIndex = 2;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(684, 304);
            label3.Name = "label3";
            label3.Size = new Size(319, 36);
            label3.TabIndex = 3;
            label3.Text = "Confirme su contraeña:";
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.MediumSlateBlue;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox2.ForeColor = Color.DimGray;
            rjTextBox2.Location = new Point(684, 359);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.Size = new Size(388, 35);
            rjTextBox2.TabIndex = 4;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Honeydew;
            pictureBox1.Image = Properties.Resources.seguridad_de_datos;
            pictureBox1.Location = new Point(1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 885);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.DarkSlateGray;
            rjButton1.BackgroundColor = Color.DarkSlateGray;
            rjButton1.BorderColor = Color.PaleGreen;
            rjButton1.BorderRadius = 50;
            rjButton1.BorderSize = 5;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(731, 505);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(228, 105);
            rjButton1.TabIndex = 6;
            rjButton1.Text = "Confirmar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.ojo;
            pictureBox2.Location = new Point(1079, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.ojo1;
            pictureBox3.Location = new Point(1079, 359);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Form_Contraseña
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1330, 877);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(rjButton1);
            Controls.Add(pictureBox1);
            Controls.Add(rjTextBox2);
            Controls.Add(label3);
            Controls.Add(rjTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Contraseña";
            Text = "Form1";
            Load += Form_Contraseña_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Label label3;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton rjButton1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
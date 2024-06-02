namespace gymManagement1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            loginB = new Button();
            label2 = new Label();
            label1 = new Label();
            passwrdB = new TextBox();
            userN = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(loginB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(passwrdB);
            panel1.Controls.Add(userN);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(117, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 505);
            panel1.TabIndex = 0;
            // 
            // loginB
            // 
            loginB.BackColor = SystemColors.ButtonFace;
            loginB.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            loginB.ForeColor = Color.FromArgb(255, 128, 0);
            loginB.Location = new Point(196, 388);
            loginB.Name = "loginB";
            loginB.Size = new Size(190, 45);
            loginB.TabIndex = 34;
            loginB.Text = "Login";
            loginB.UseVisualStyleBackColor = false;
            loginB.Click += loginB_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(111, 312);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 33;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(102, 225);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 32;
            label1.Text = "User Name";
            // 
            // passwrdB
            // 
            passwrdB.BackColor = Color.FromArgb(255, 192, 128);
            passwrdB.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwrdB.Location = new Point(196, 304);
            passwrdB.Name = "passwrdB";
            passwrdB.PasswordChar = '*';
            passwrdB.Size = new Size(191, 25);
            passwrdB.TabIndex = 31;
            // 
            // userN
            // 
            userN.BackColor = Color.FromArgb(255, 192, 128);
            userN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userN.Location = new Point(196, 217);
            userN.Name = "userN";
            userN.Size = new Size(191, 25);
            userN.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(196, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(785, 680);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox passwrdB;
        private TextBox userN;
        private Button loginB;
    }
}
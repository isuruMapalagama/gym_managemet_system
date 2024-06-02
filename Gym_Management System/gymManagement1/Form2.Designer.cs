namespace gymManagement1
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            fname = new TextBox();
            lname = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            DoB = new DateTimePicker();
            mobile = new TextBox();
            email = new TextBox();
            JoinD = new DateTimePicker();
            address = new TextBox();
            gymTime = new ComboBox();
            membershipT = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // fname
            // 
            fname.Location = new Point(142, 197);
            fname.Name = "fname";
            fname.Size = new Size(163, 23);
            fname.TabIndex = 0;
            // 
            // lname
            // 
            lname.Location = new Point(142, 252);
            lname.Name = "lname";
            lname.Size = new Size(163, 23);
            lname.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(220, 303);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(142, 303);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // DoB
            // 
            DoB.Format = DateTimePickerFormat.Short;
            DoB.Location = new Point(142, 363);
            DoB.Name = "DoB";
            DoB.Size = new Size(163, 23);
            DoB.TabIndex = 4;
            DoB.Value = new DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // mobile
            // 
            mobile.Location = new Point(142, 422);
            mobile.Name = "mobile";
            mobile.Size = new Size(163, 23);
            mobile.TabIndex = 5;
            // 
            // email
            // 
            email.Location = new Point(574, 202);
            email.Name = "email";
            email.Size = new Size(163, 23);
            email.TabIndex = 6;
            // 
            // JoinD
            // 
            JoinD.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JoinD.Format = DateTimePickerFormat.Short;
            JoinD.Location = new Point(574, 250);
            JoinD.Name = "JoinD";
            JoinD.Size = new Size(163, 23);
            JoinD.TabIndex = 7;
            JoinD.ValueChanged += JoinD_ValueChanged;
            // 
            // address
            // 
            address.Location = new Point(574, 359);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(163, 87);
            address.TabIndex = 9;
            // 
            // gymTime
            // 
            gymTime.FormattingEnabled = true;
            gymTime.Items.AddRange(new object[] { "06.00AM - 07.00AM", "07.00AM - 08.00AM", "08.00AM -09.00AM", "05.00PM - 06.00PM", "06.00PM - 07.PM" });
            gymTime.Location = new Point(574, 302);
            gymTime.Name = "gymTime";
            gymTime.Size = new Size(163, 23);
            gymTime.TabIndex = 10;
            // 
            // membershipT
            // 
            membershipT.FormattingEnabled = true;
            membershipT.Items.AddRange(new object[] { "1 Month", "2 Month", "3 Month", "6 Month", "12 Month" });
            membershipT.Location = new Point(395, 516);
            membershipT.Name = "membershipT";
            membershipT.Size = new Size(163, 23);
            membershipT.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(48, 197);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 12;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(48, 253);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 13;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(48, 367);
            label3.Name = "label3";
            label3.Size = new Size(88, 17);
            label3.TabIndex = 14;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(48, 422);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 15;
            label4.Text = "Mobile";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(475, 203);
            label5.Name = "label5";
            label5.Size = new Size(47, 17);
            label5.TabIndex = 16;
            label5.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(475, 256);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 17;
            label6.Text = "Join Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(475, 308);
            label7.Name = "label7";
            label7.Size = new Size(71, 17);
            label7.TabIndex = 18;
            label7.Text = "Gym Time";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(475, 364);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 19;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(272, 519);
            label9.Name = "label9";
            label9.Size = new Size(120, 17);
            label9.TabIndex = 20;
            label9.Text = "Membership Time";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSave.ForeColor = Color.FromArgb(255, 128, 0);
            btnSave.Location = new Point(224, 600);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 32);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(255, 128, 0);
            btnReset.Location = new Point(437, 600);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 32);
            btnReset.TabIndex = 22;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(255, 128, 0);
            label10.Location = new Point(48, 305);
            label10.Name = "label10";
            label10.Size = new Size(52, 17);
            label10.TabIndex = 23;
            label10.Text = "Gender";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(293, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // NewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(785, 680);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(membershipT);
            Controls.Add(gymTime);
            Controls.Add(address);
            Controls.Add(JoinD);
            Controls.Add(email);
            Controls.Add(mobile);
            Controls.Add(DoB);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lname);
            Controls.Add(fname);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Member";
            Load += NewMember_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fname;
        private TextBox lname;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker DoB;
        private TextBox mobile;
        private TextBox email;
        private DateTimePicker JoinD;
        private TextBox address;
        private ComboBox gymTime;
        private ComboBox membershipT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSave;
        private Button btnReset;
        private Label label10;
        private PictureBox pictureBox1;
    }
}
namespace gymManagement1
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            equipmentN = new TextBox();
            musclesU = new TextBox();
            cost = new TextBox();
            deliveryD = new DateTimePicker();
            save = new Button();
            reset = new Button();
            viewEquip = new Button();
            description = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(294, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(127, 176);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 27;
            label1.Text = "Equipment Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(127, 225);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 28;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(127, 437);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 29;
            label3.Text = "Muscles Used";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(127, 504);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 30;
            label4.Text = "Delivery Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(127, 565);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 31;
            label5.Text = "Cost";
            // 
            // equipmentN
            // 
            equipmentN.Location = new Point(280, 173);
            equipmentN.Name = "equipmentN";
            equipmentN.Size = new Size(238, 23);
            equipmentN.TabIndex = 32;
            // 
            // musclesU
            // 
            musclesU.Location = new Point(281, 434);
            musclesU.Name = "musclesU";
            musclesU.Size = new Size(238, 23);
            musclesU.TabIndex = 34;
            // 
            // cost
            // 
            cost.Location = new Point(281, 562);
            cost.Name = "cost";
            cost.Size = new Size(238, 23);
            cost.TabIndex = 36;
            // 
            // deliveryD
            // 
            deliveryD.Format = DateTimePickerFormat.Short;
            deliveryD.Location = new Point(280, 498);
            deliveryD.Name = "deliveryD";
            deliveryD.Size = new Size(238, 23);
            deliveryD.TabIndex = 37;
            // 
            // save
            // 
            save.BackColor = Color.Transparent;
            save.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            save.ForeColor = Color.FromArgb(255, 128, 0);
            save.Location = new Point(178, 624);
            save.Name = "save";
            save.Size = new Size(131, 32);
            save.TabIndex = 38;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // reset
            // 
            reset.BackColor = Color.Transparent;
            reset.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            reset.ForeColor = Color.FromArgb(255, 128, 0);
            reset.Location = new Point(335, 624);
            reset.Name = "reset";
            reset.Size = new Size(131, 32);
            reset.TabIndex = 39;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // viewEquip
            // 
            viewEquip.BackColor = Color.Transparent;
            viewEquip.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            viewEquip.ForeColor = Color.FromArgb(255, 128, 0);
            viewEquip.Location = new Point(488, 624);
            viewEquip.Name = "viewEquip";
            viewEquip.Size = new Size(131, 32);
            viewEquip.TabIndex = 40;
            viewEquip.Text = "View Equipment";
            viewEquip.UseVisualStyleBackColor = false;
            viewEquip.Click += viewEquip_Click;
            // 
            // description
            // 
            description.Location = new Point(280, 222);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(238, 176);
            description.TabIndex = 33;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(785, 680);
            Controls.Add(viewEquip);
            Controls.Add(reset);
            Controls.Add(save);
            Controls.Add(deliveryD);
            Controls.Add(cost);
            Controls.Add(musclesU);
            Controls.Add(description);
            Controls.Add(equipmentN);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "equipment";
            Load += equipment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox equipmentN;
        private TextBox musclesU;
        private TextBox cost;
        private DateTimePicker deliveryD;
        private Button save;
        private Button reset;
        private Button viewEquip;
        private TextBox description;
    }
}
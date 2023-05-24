namespace PasswordManager
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            menuButton = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            buttonCreate = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel9 = new Panel();
            button8 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel7 = new Panel();
            button6 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel8 = new Panel();
            button7 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ActiveCaption;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel8);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(240, 543);
            sidebar.MinimumSize = new Size(78, 543);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(240, 543);
            sidebar.TabIndex = 0;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 81);
            panel1.TabIndex = 1;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.icons8_menu_rounded_50;
            menuButton.Location = new Point(16, 17);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(44, 45);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 2;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 26);
            label1.Name = "label1";
            label1.Size = new Size(67, 30);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCreate);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(3, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 45);
            panel2.TabIndex = 8;
            // 
            // buttonCreate
            // 
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Image = Properties.Resources.pngwing_com;
            buttonCreate.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCreate.Location = new Point(-13, -10);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Padding = new Padding(30, 0, 0, 0);
            buttonCreate.Size = new Size(261, 64);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "             Create New";
            buttonCreate.TextAlign = ContentAlignment.MiddleLeft;
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(3, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 45);
            panel3.TabIndex = 9;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.pngwing_com__2_;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-13, -10);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(261, 64);
            button2.TabIndex = 1;
            button2.Text = "             My Vault";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(3, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 45);
            panel4.TabIndex = 10;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.icons8_file_settings_26;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-13, -10);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(261, 64);
            button3.TabIndex = 1;
            button3.Text = "             Custom Record Types";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(button8);
            panel9.Cursor = Cursors.Hand;
            panel9.Location = new Point(3, 243);
            panel9.Name = "panel9";
            panel9.Size = new Size(222, 45);
            panel9.TabIndex = 11;
            // 
            // button8
            // 
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Image = Properties.Resources.icons8_credit_card_26;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-13, -10);
            button8.Name = "button8";
            button8.Padding = new Padding(30, 0, 0, 0);
            button8.Size = new Size(261, 64);
            button8.TabIndex = 1;
            button8.Text = "             Identity and Payment";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(3, 294);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 45);
            panel5.TabIndex = 12;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.icons8_security_shield_green_26;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-13, -10);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(261, 64);
            button4.TabIndex = 1;
            button4.Text = "             Security Audit";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(button6);
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(3, 345);
            panel7.Name = "panel7";
            panel7.Size = new Size(222, 45);
            panel7.TabIndex = 14;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.icons8_angry_eye_26;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-13, -10);
            button6.Name = "button6";
            button6.Padding = new Padding(30, 0, 0, 0);
            button6.Size = new Size(261, 64);
            button6.TabIndex = 1;
            button6.Text = "             BreachWatch";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(3, 396);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 45);
            panel6.TabIndex = 13;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.icons8_delete_file_26;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-13, -10);
            button5.Name = "button5";
            button5.Padding = new Padding(30, 0, 0, 0);
            button5.Size = new Size(261, 64);
            button5.TabIndex = 1;
            button5.Text = "             Deleted Item";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(button7);
            panel8.Cursor = Cursors.Hand;
            panel8.Location = new Point(3, 447);
            panel8.Name = "panel8";
            panel8.Size = new Size(222, 45);
            panel8.TabIndex = 15;
            // 
            // button7
            // 
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Image = Properties.Resources.icons8_document_26;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-13, -10);
            button7.Name = "button7";
            button7.Padding = new Padding(30, 0, 0, 0);
            button7.Size = new Size(261, 64);
            button7.TabIndex = 1;
            button7.Text = "             Admin Console";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(sidebar);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private PictureBox menuButton;
        private Label label1;
        private Panel panel2;
        private Button buttonCreate;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel9;
        private Button button8;
        private Panel panel5;
        private Button button4;
        private Panel panel7;
        private Button button6;
        private Panel panel6;
        private Button button5;
        private Panel panel8;
        private Button button7;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}
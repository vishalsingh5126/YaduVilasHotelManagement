using System.Windows.Forms;
namespace YaduVilasHM
{
    partial class Form1
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.pnlSelectRoom = new System.Windows.Forms.Panel();
            this.radSuit = new System.Windows.Forms.RadioButton();
            this.radExecutive = new System.Windows.Forms.RadioButton();
            this.radDeluxe = new System.Windows.Forms.RadioButton();
            this.comboBoxSuit = new System.Windows.Forms.ComboBox();
            this.comboBoxExecutive = new System.Windows.Forms.ComboBox();
            this.ComboBoxDeluxe = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNationalIdNumber = new System.Windows.Forms.TextBox();
            this.txtNationalIdType = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCheckAvailableRoom = new System.Windows.Forms.Button();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errPannel = new System.Windows.Forms.Panel();
            this.errLblBooking = new System.Windows.Forms.Label();
            this.lblTotalDays = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.pnlSelectRoom.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.errPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTab.Controls.Add(this.tabLogin);
            this.MainTab.Controls.Add(this.tabBookings);
            this.MainTab.Location = new System.Drawing.Point(12, 12);
            this.MainTab.MinimumSize = new System.Drawing.Size(1000, 800);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1428, 1186);
            this.MainTab.TabIndex = 0;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            // 
            // tabLogin
            // 
            this.tabLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLogin.Controls.Add(this.panel3);
            this.tabLogin.Controls.Add(this.panel2);
            this.tabLogin.Controls.Add(this.panel1);
            this.tabLogin.Location = new System.Drawing.Point(4, 25);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1420, 1157);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Log in";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Location = new System.Drawing.Point(6, 660);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 45);
            this.panel3.TabIndex = 6;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(9, 7);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(79, 29);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Error:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(707, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 285);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(155, 198);
            this.btnLogin.MinimumSize = new System.Drawing.Size(100, 41);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 41);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(184, 47);
            this.txtUsername.MinimumSize = new System.Drawing.Size(126, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(185, 115);
            this.txtPassword.MinimumSize = new System.Drawing.Size(126, 22);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(194, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 73);
            this.panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(970, 42);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(83, 17);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Today Time";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(967, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Today Date";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(904, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(901, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Hotel Yadu Vilas Palace";
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.errPannel);
            this.tabBookings.Controls.Add(this.btnConfirmBooking);
            this.tabBookings.Controls.Add(this.pnlSelectRoom);
            this.tabBookings.Controls.Add(this.panel5);
            this.tabBookings.Controls.Add(this.panel4);
            this.tabBookings.Location = new System.Drawing.Point(4, 25);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookings.Size = new System.Drawing.Size(1420, 1157);
            this.tabBookings.TabIndex = 1;
            this.tabBookings.Text = "Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(416, 610);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(232, 39);
            this.btnConfirmBooking.TabIndex = 5;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // pnlSelectRoom
            // 
            this.pnlSelectRoom.Controls.Add(this.radSuit);
            this.pnlSelectRoom.Controls.Add(this.radExecutive);
            this.pnlSelectRoom.Controls.Add(this.radDeluxe);
            this.pnlSelectRoom.Controls.Add(this.comboBoxSuit);
            this.pnlSelectRoom.Controls.Add(this.comboBoxExecutive);
            this.pnlSelectRoom.Controls.Add(this.ComboBoxDeluxe);
            this.pnlSelectRoom.Controls.Add(this.label11);
            this.pnlSelectRoom.Location = new System.Drawing.Point(24, 375);
            this.pnlSelectRoom.Name = "pnlSelectRoom";
            this.pnlSelectRoom.Size = new System.Drawing.Size(1109, 150);
            this.pnlSelectRoom.TabIndex = 4;
            // 
            // radSuit
            // 
            this.radSuit.AutoSize = true;
            this.radSuit.Location = new System.Drawing.Point(774, 30);
            this.radSuit.Name = "radSuit";
            this.radSuit.Size = new System.Drawing.Size(53, 21);
            this.radSuit.TabIndex = 6;
            this.radSuit.TabStop = true;
            this.radSuit.Text = "Suit";
            this.radSuit.UseVisualStyleBackColor = true;
            // 
            // radExecutive
            // 
            this.radExecutive.AutoSize = true;
            this.radExecutive.Location = new System.Drawing.Point(486, 32);
            this.radExecutive.Name = "radExecutive";
            this.radExecutive.Size = new System.Drawing.Size(89, 21);
            this.radExecutive.TabIndex = 5;
            this.radExecutive.TabStop = true;
            this.radExecutive.Text = "Executive";
            this.radExecutive.UseVisualStyleBackColor = true;
            // 
            // radDeluxe
            // 
            this.radDeluxe.AutoSize = true;
            this.radDeluxe.Location = new System.Drawing.Point(268, 30);
            this.radDeluxe.Name = "radDeluxe";
            this.radDeluxe.Size = new System.Drawing.Size(72, 21);
            this.radDeluxe.TabIndex = 4;
            this.radDeluxe.TabStop = true;
            this.radDeluxe.Text = "Deluxe";
            this.radDeluxe.UseVisualStyleBackColor = true;
            // 
            // comboBoxSuit
            // 
            this.comboBoxSuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuit.FormattingEnabled = true;
            this.comboBoxSuit.Location = new System.Drawing.Point(723, 73);
            this.comboBoxSuit.Name = "comboBoxSuit";
            this.comboBoxSuit.Size = new System.Drawing.Size(165, 24);
            this.comboBoxSuit.TabIndex = 3;
            // 
            // comboBoxExecutive
            // 
            this.comboBoxExecutive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExecutive.FormattingEnabled = true;
            this.comboBoxExecutive.Location = new System.Drawing.Point(449, 73);
            this.comboBoxExecutive.Name = "comboBoxExecutive";
            this.comboBoxExecutive.Size = new System.Drawing.Size(165, 24);
            this.comboBoxExecutive.TabIndex = 2;
            // 
            // ComboBoxDeluxe
            // 
            this.ComboBoxDeluxe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDeluxe.FormattingEnabled = true;
            this.ComboBoxDeluxe.Location = new System.Drawing.Point(226, 73);
            this.ComboBoxDeluxe.Name = "ComboBoxDeluxe";
            this.ComboBoxDeluxe.Size = new System.Drawing.Size(165, 24);
            this.ComboBoxDeluxe.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Available Rooms:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtNationalIdNumber);
            this.panel5.Controls.Add(this.txtNationalIdType);
            this.panel5.Controls.Add(this.txtGuestName);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(24, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(501, 150);
            this.panel5.TabIndex = 3;
            // 
            // txtNationalIdNumber
            // 
            this.txtNationalIdNumber.Location = new System.Drawing.Point(204, 103);
            this.txtNationalIdNumber.Name = "txtNationalIdNumber";
            this.txtNationalIdNumber.Size = new System.Drawing.Size(237, 22);
            this.txtNationalIdNumber.TabIndex = 5;
            // 
            // txtNationalIdType
            // 
            this.txtNationalIdType.Location = new System.Drawing.Point(204, 64);
            this.txtNationalIdType.Name = "txtNationalIdType";
            this.txtNationalIdType.Size = new System.Drawing.Size(237, 22);
            this.txtNationalIdType.TabIndex = 4;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(204, 21);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(237, 22);
            this.txtGuestName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "National Id Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "National Id Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Guest Name:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTotalDays);
            this.panel4.Controls.Add(this.btnCheckAvailableRoom);
            this.panel4.Controls.Add(this.toDatePicker);
            this.panel4.Controls.Add(this.fromDatePicker);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(24, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(975, 123);
            this.panel4.TabIndex = 2;
            // 
            // btnCheckAvailableRoom
            // 
            this.btnCheckAvailableRoom.Location = new System.Drawing.Point(411, 40);
            this.btnCheckAvailableRoom.Name = "btnCheckAvailableRoom";
            this.btnCheckAvailableRoom.Size = new System.Drawing.Size(196, 39);
            this.btnCheckAvailableRoom.TabIndex = 4;
            this.btnCheckAvailableRoom.Text = "Check Available Rooms";
            this.btnCheckAvailableRoom.UseVisualStyleBackColor = true;
            this.btnCheckAvailableRoom.Click += new System.EventHandler(this.btnCheckAvailableRoom_Click);
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(159, 81);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(200, 22);
            this.toDatePicker.TabIndex = 3;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(159, 21);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 22);
            this.fromDatePicker.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "From Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "To Date:";
            // 
            // errPannel
            // 
            this.errPannel.AutoSize = true;
            this.errPannel.Controls.Add(this.errLblBooking);
            this.errPannel.Location = new System.Drawing.Point(24, 655);
            this.errPannel.Name = "errPannel";
            this.errPannel.Size = new System.Drawing.Size(618, 68);
            this.errPannel.TabIndex = 6;
            // 
            // errLblBooking
            // 
            this.errLblBooking.AutoSize = true;
            this.errLblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.errLblBooking.ForeColor = System.Drawing.Color.Red;
            this.errLblBooking.Location = new System.Drawing.Point(3, 13);
            this.errLblBooking.Name = "errLblBooking";
            this.errLblBooking.Size = new System.Drawing.Size(99, 36);
            this.errLblBooking.TabIndex = 0;
            this.errLblBooking.Text = "Error:";
            // 
            // lblTotalDays
            // 
            this.lblTotalDays.AutoSize = true;
            this.lblTotalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDays.Location = new System.Drawing.Point(703, 51);
            this.lblTotalDays.Name = "lblTotalDays";
            this.lblTotalDays.Size = new System.Drawing.Size(140, 25);
            this.lblTotalDays.TabIndex = 5;
            this.lblTotalDays.Text = "Total Days: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 749);
            this.Controls.Add(this.MainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Yadu Vilas Palace";
            this.MainTab.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabBookings.ResumeLayout(false);
            this.tabBookings.PerformLayout();
            this.pnlSelectRoom.ResumeLayout(false);
            this.pnlSelectRoom.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.errPannel.ResumeLayout(false);
            this.errPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTab;
        private TabPage tabLogin;
        private TabPage tabBookings;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblTime;
        private Label lblDate;
        private Label lblError;
        private Panel panel2;
        private Label label4;
        private Button btnLogin;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Panel panel4;
        private DateTimePicker fromDatePicker;
        private DateTimePicker toDatePicker;
        private Button btnCheckAvailableRoom;
        private Panel pnlSelectRoom;
        private ComboBox comboBoxSuit;
        private ComboBox comboBoxExecutive;
        private ComboBox ComboBoxDeluxe;
        private Label label11;
        private Panel panel5;
        private TextBox txtNationalIdNumber;
        private TextBox txtNationalIdType;
        private TextBox txtGuestName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnConfirmBooking;
        private RadioButton radSuit;
        private RadioButton radExecutive;
        private RadioButton radDeluxe;
        private Panel errPannel;
        private Label errLblBooking;
        private Label lblTotalDays;
    }
}


namespace school_managment_system.Forms
{
    partial class add_user
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_user));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.type_combobox = new MetroFramework.Controls.MetroComboBox();
            this.u_add_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.password_box = new MetroFramework.Controls.MetroTextBox();
            this.username_box = new MetroFramework.Controls.MetroTextBox();
            this.ulastname_box = new MetroFramework.Controls.MetroTextBox();
            this.ufirstname_box = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.user_id_box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // type_combobox
            // 
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.ItemHeight = 23;
            this.type_combobox.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Teacher"});
            this.type_combobox.Location = new System.Drawing.Point(193, 267);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(215, 29);
            this.type_combobox.TabIndex = 5;
            this.type_combobox.UseSelectable = true;
            // 
            // u_add_btn
            // 
            this.u_add_btn.Location = new System.Drawing.Point(333, 319);
            this.u_add_btn.Name = "u_add_btn";
            this.u_add_btn.Size = new System.Drawing.Size(75, 23);
            this.u_add_btn.TabIndex = 6;
            this.u_add_btn.Text = "&Add";
            this.u_add_btn.UseSelectable = true;
            this.u_add_btn.Click += new System.EventHandler(this.U_add_btn_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(40, 281);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(36, 15);
            this.metroLabel13.TabIndex = 79;
            this.metroLabel13.Text = "Type:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(40, 227);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(60, 15);
            this.metroLabel6.TabIndex = 80;
            this.metroLabel6.Text = "Password:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(40, 184);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 15);
            this.metroLabel5.TabIndex = 81;
            this.metroLabel5.Text = "Username:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(40, 144);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 15);
            this.metroLabel4.TabIndex = 82;
            this.metroLabel4.Text = "Lastname:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(40, 100);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 15);
            this.metroLabel3.TabIndex = 83;
            this.metroLabel3.Text = "Firstname:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(13, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 25);
            this.metroLabel2.TabIndex = 78;
            this.metroLabel2.Text = "Add User";
            // 
            // password_box
            // 
            this.password_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.password_box.Lines = new string[0];
            this.password_box.Location = new System.Drawing.Point(193, 219);
            this.password_box.MaxLength = 32767;
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '\0';
            this.password_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password_box.SelectedText = "";
            this.password_box.Size = new System.Drawing.Size(215, 23);
            this.password_box.TabIndex = 4;
            this.password_box.UseCustomBackColor = true;
            this.password_box.UseSelectable = true;
            this.password_box.TextChanged += new System.EventHandler(this.Password_box_TextChanged);
            // 
            // username_box
            // 
            this.username_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.username_box.Lines = new string[0];
            this.username_box.Location = new System.Drawing.Point(193, 176);
            this.username_box.MaxLength = 32767;
            this.username_box.Name = "username_box";
            this.username_box.PasswordChar = '\0';
            this.username_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username_box.SelectedText = "";
            this.username_box.Size = new System.Drawing.Size(215, 23);
            this.username_box.TabIndex = 3;
            this.username_box.UseCustomBackColor = true;
            this.username_box.UseSelectable = true;
            this.username_box.TextChanged += new System.EventHandler(this.Username_box_TextChanged);
            // 
            // ulastname_box
            // 
            this.ulastname_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ulastname_box.Lines = new string[0];
            this.ulastname_box.Location = new System.Drawing.Point(193, 136);
            this.ulastname_box.MaxLength = 32767;
            this.ulastname_box.Name = "ulastname_box";
            this.ulastname_box.PasswordChar = '\0';
            this.ulastname_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ulastname_box.SelectedText = "";
            this.ulastname_box.Size = new System.Drawing.Size(215, 23);
            this.ulastname_box.TabIndex = 2;
            this.ulastname_box.UseCustomBackColor = true;
            this.ulastname_box.UseSelectable = true;
            // 
            // ufirstname_box
            // 
            this.ufirstname_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ufirstname_box.Lines = new string[0];
            this.ufirstname_box.Location = new System.Drawing.Point(193, 92);
            this.ufirstname_box.MaxLength = 32767;
            this.ufirstname_box.Name = "ufirstname_box";
            this.ufirstname_box.PasswordChar = '\0';
            this.ufirstname_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ufirstname_box.SelectedText = "";
            this.ufirstname_box.Size = new System.Drawing.Size(215, 23);
            this.ufirstname_box.TabIndex = 1;
            this.ufirstname_box.UseCustomBackColor = true;
            this.ufirstname_box.UseSelectable = true;
            this.ufirstname_box.TextChanged += new System.EventHandler(this.Ufirstname_box_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Red;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(433, 5);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(30, 24);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "X";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // user_id_box
            // 
            this.user_id_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.user_id_box.Lines = new string[0];
            this.user_id_box.Location = new System.Drawing.Point(193, 52);
            this.user_id_box.MaxLength = 32767;
            this.user_id_box.Name = "user_id_box";
            this.user_id_box.PasswordChar = '\0';
            this.user_id_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_id_box.SelectedText = "";
            this.user_id_box.Size = new System.Drawing.Size(215, 23);
            this.user_id_box.TabIndex = 0;
            this.user_id_box.UseCustomBackColor = true;
            this.user_id_box.UseSelectable = true;
            this.user_id_box.TextChanged += new System.EventHandler(this.User_id_box_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(40, 60);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 15);
            this.metroLabel7.TabIndex = 96;
            this.metroLabel7.Text = "User Id:";
            // 
            // add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 356);
            this.ControlBox = false;
            this.Controls.Add(this.user_id_box);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.type_combobox);
            this.Controls.Add(this.u_add_btn);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.ulastname_box);
            this.Controls.Add(this.ufirstname_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_user";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Add_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox type_combobox;
        private MetroFramework.Controls.MetroButton u_add_btn;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox password_box;
        private MetroFramework.Controls.MetroTextBox username_box;
        private MetroFramework.Controls.MetroTextBox ulastname_box;
        private MetroFramework.Controls.MetroTextBox ufirstname_box;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox user_id_box;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}
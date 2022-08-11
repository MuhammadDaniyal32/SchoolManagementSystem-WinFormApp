namespace school_managment_system.Forms
{
    partial class add_teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_teacher));
            this.Classes_combobox = new MetroFramework.Controls.MetroComboBox();
            this.dob_combobox = new MetroFramework.Controls.MetroDateTime();
            this.add_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.phone_box = new MetroFramework.Controls.MetroTextBox();
            this.salary_box = new MetroFramework.Controls.MetroTextBox();
            this.sub_box = new MetroFramework.Controls.MetroTextBox();
            this.qualif_box = new MetroFramework.Controls.MetroTextBox();
            this.age_box = new MetroFramework.Controls.MetroTextBox();
            this.te_fathern_box = new MetroFramework.Controls.MetroTextBox();
            this.te_lastn_box = new MetroFramework.Controls.MetroTextBox();
            this.te_firstn_box = new MetroFramework.Controls.MetroTextBox();
            this.te_id_box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Classes_combobox
            // 
            this.Classes_combobox.FormattingEnabled = true;
            this.Classes_combobox.ItemHeight = 23;
            this.Classes_combobox.Items.AddRange(new object[] {
            "Playground classes",
            "Primary classes",
            "Secondary classes",
            "Matric classes",
            "Practical classes"});
            this.Classes_combobox.Location = new System.Drawing.Point(231, 433);
            this.Classes_combobox.Name = "Classes_combobox";
            this.Classes_combobox.Size = new System.Drawing.Size(215, 29);
            this.Classes_combobox.TabIndex = 10;
            this.Classes_combobox.UseSelectable = true;
            // 
            // dob_combobox
            // 
            this.dob_combobox.Location = new System.Drawing.Point(231, 197);
            this.dob_combobox.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dob_combobox.MinDate = new System.DateTime(1980, 12, 31, 0, 0, 0, 0);
            this.dob_combobox.MinimumSize = new System.Drawing.Size(0, 29);
            this.dob_combobox.Name = "dob_combobox";
            this.dob_combobox.Size = new System.Drawing.Size(215, 29);
            this.dob_combobox.TabIndex = 4;
            this.dob_combobox.Value = new System.DateTime(2019, 9, 7, 0, 0, 0, 0);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(371, 492);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "&Add";
            this.add_btn.UseSelectable = true;
            this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(53, 447);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(82, 15);
            this.metroLabel13.TabIndex = 92;
            this.metroLabel13.Text = "Classes under:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(53, 407);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(61, 15);
            this.metroLabel12.TabIndex = 91;
            this.metroLabel12.Text = "Phone no:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(56, 367);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(41, 15);
            this.metroLabel11.TabIndex = 90;
            this.metroLabel11.Text = "Salary:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(53, 327);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(54, 15);
            this.metroLabel10.TabIndex = 89;
            this.metroLabel10.Text = "Subjects:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(53, 288);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(78, 15);
            this.metroLabel9.TabIndex = 88;
            this.metroLabel9.Text = "Qualification:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(53, 248);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(31, 15);
            this.metroLabel8.TabIndex = 87;
            this.metroLabel8.Text = "Age:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(53, 211);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 15);
            this.metroLabel7.TabIndex = 86;
            this.metroLabel7.Text = "Date of birth:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(53, 171);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 15);
            this.metroLabel6.TabIndex = 93;
            this.metroLabel6.Text = "Father name:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(53, 136);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(106, 15);
            this.metroLabel5.TabIndex = 85;
            this.metroLabel5.Text = "Teacher Lastname:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(53, 106);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 15);
            this.metroLabel4.TabIndex = 84;
            this.metroLabel4.Text = "Teacher Firstname:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(53, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 15);
            this.metroLabel3.TabIndex = 83;
            this.metroLabel3.Text = "Teacher Id:";
            // 
            // phone_box
            // 
            this.phone_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phone_box.Lines = new string[0];
            this.phone_box.Location = new System.Drawing.Point(231, 399);
            this.phone_box.MaxLength = 32767;
            this.phone_box.Name = "phone_box";
            this.phone_box.PasswordChar = '\0';
            this.phone_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phone_box.SelectedText = "";
            this.phone_box.Size = new System.Drawing.Size(215, 23);
            this.phone_box.TabIndex = 9;
            this.phone_box.UseCustomBackColor = true;
            this.phone_box.UseSelectable = true;
            this.phone_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_box_KeyPress);
            // 
            // salary_box
            // 
            this.salary_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.salary_box.Lines = new string[0];
            this.salary_box.Location = new System.Drawing.Point(231, 359);
            this.salary_box.MaxLength = 32767;
            this.salary_box.Name = "salary_box";
            this.salary_box.PasswordChar = '\0';
            this.salary_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.salary_box.SelectedText = "";
            this.salary_box.Size = new System.Drawing.Size(215, 23);
            this.salary_box.TabIndex = 8;
            this.salary_box.UseCustomBackColor = true;
            this.salary_box.UseSelectable = true;
            // 
            // sub_box
            // 
            this.sub_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sub_box.Lines = new string[0];
            this.sub_box.Location = new System.Drawing.Point(231, 319);
            this.sub_box.MaxLength = 32767;
            this.sub_box.Name = "sub_box";
            this.sub_box.PasswordChar = '\0';
            this.sub_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sub_box.SelectedText = "";
            this.sub_box.Size = new System.Drawing.Size(215, 23);
            this.sub_box.TabIndex = 7;
            this.sub_box.UseCustomBackColor = true;
            this.sub_box.UseSelectable = true;
            // 
            // qualif_box
            // 
            this.qualif_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.qualif_box.Lines = new string[0];
            this.qualif_box.Location = new System.Drawing.Point(231, 280);
            this.qualif_box.MaxLength = 32767;
            this.qualif_box.Name = "qualif_box";
            this.qualif_box.PasswordChar = '\0';
            this.qualif_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qualif_box.SelectedText = "";
            this.qualif_box.Size = new System.Drawing.Size(215, 23);
            this.qualif_box.TabIndex = 6;
            this.qualif_box.UseCustomBackColor = true;
            this.qualif_box.UseSelectable = true;
            // 
            // age_box
            // 
            this.age_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.age_box.Lines = new string[0];
            this.age_box.Location = new System.Drawing.Point(231, 240);
            this.age_box.MaxLength = 32767;
            this.age_box.Name = "age_box";
            this.age_box.PasswordChar = '\0';
            this.age_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.age_box.SelectedText = "";
            this.age_box.Size = new System.Drawing.Size(215, 23);
            this.age_box.TabIndex = 5;
            this.age_box.UseCustomBackColor = true;
            this.age_box.UseSelectable = true;
            this.age_box.TextChanged += new System.EventHandler(this.Age_box_TextChanged);
            this.age_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Age_box_KeyPress);
            // 
            // te_fathern_box
            // 
            this.te_fathern_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.te_fathern_box.Lines = new string[0];
            this.te_fathern_box.Location = new System.Drawing.Point(231, 163);
            this.te_fathern_box.MaxLength = 32767;
            this.te_fathern_box.Name = "te_fathern_box";
            this.te_fathern_box.PasswordChar = '\0';
            this.te_fathern_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_fathern_box.SelectedText = "";
            this.te_fathern_box.Size = new System.Drawing.Size(215, 23);
            this.te_fathern_box.TabIndex = 3;
            this.te_fathern_box.UseCustomBackColor = true;
            this.te_fathern_box.UseSelectable = true;
            // 
            // te_lastn_box
            // 
            this.te_lastn_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.te_lastn_box.Lines = new string[0];
            this.te_lastn_box.Location = new System.Drawing.Point(231, 128);
            this.te_lastn_box.MaxLength = 32767;
            this.te_lastn_box.Name = "te_lastn_box";
            this.te_lastn_box.PasswordChar = '\0';
            this.te_lastn_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_lastn_box.SelectedText = "";
            this.te_lastn_box.Size = new System.Drawing.Size(215, 23);
            this.te_lastn_box.TabIndex = 2;
            this.te_lastn_box.UseCustomBackColor = true;
            this.te_lastn_box.UseSelectable = true;
            // 
            // te_firstn_box
            // 
            this.te_firstn_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.te_firstn_box.Lines = new string[0];
            this.te_firstn_box.Location = new System.Drawing.Point(231, 98);
            this.te_firstn_box.MaxLength = 32767;
            this.te_firstn_box.Name = "te_firstn_box";
            this.te_firstn_box.PasswordChar = '\0';
            this.te_firstn_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_firstn_box.SelectedText = "";
            this.te_firstn_box.Size = new System.Drawing.Size(215, 23);
            this.te_firstn_box.TabIndex = 1;
            this.te_firstn_box.UseCustomBackColor = true;
            this.te_firstn_box.UseSelectable = true;
            this.te_firstn_box.TextChanged += new System.EventHandler(this.Te_firstn_box_TextChanged);
            // 
            // te_id_box
            // 
            this.te_id_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.te_id_box.Lines = new string[0];
            this.te_id_box.Location = new System.Drawing.Point(231, 63);
            this.te_id_box.MaxLength = 32767;
            this.te_id_box.Name = "te_id_box";
            this.te_id_box.PasswordChar = '\0';
            this.te_id_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.te_id_box.SelectedText = "";
            this.te_id_box.Size = new System.Drawing.Size(215, 23);
            this.te_id_box.TabIndex = 0;
            this.te_id_box.UseCustomBackColor = true;
            this.te_id_box.UseSelectable = true;
            this.te_id_box.TextChanged += new System.EventHandler(this.Te_id_box_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(14, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 25);
            this.metroLabel1.TabIndex = 97;
            this.metroLabel1.Text = "Add Teacher";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Red;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(463, 5);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(30, 24);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "X";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // add_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 519);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Classes_combobox);
            this.Controls.Add(this.dob_combobox);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.salary_box);
            this.Controls.Add(this.sub_box);
            this.Controls.Add(this.qualif_box);
            this.Controls.Add(this.age_box);
            this.Controls.Add(this.te_fathern_box);
            this.Controls.Add(this.te_lastn_box);
            this.Controls.Add(this.te_firstn_box);
            this.Controls.Add(this.te_id_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_teacher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Add_teacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox Classes_combobox;
        private MetroFramework.Controls.MetroDateTime dob_combobox;
        private MetroFramework.Controls.MetroButton add_btn;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox phone_box;
        private MetroFramework.Controls.MetroTextBox salary_box;
        private MetroFramework.Controls.MetroTextBox sub_box;
        private MetroFramework.Controls.MetroTextBox qualif_box;
        private MetroFramework.Controls.MetroTextBox age_box;
        private MetroFramework.Controls.MetroTextBox te_fathern_box;
        private MetroFramework.Controls.MetroTextBox te_lastn_box;
        private MetroFramework.Controls.MetroTextBox te_firstn_box;
        private MetroFramework.Controls.MetroTextBox te_id_box;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
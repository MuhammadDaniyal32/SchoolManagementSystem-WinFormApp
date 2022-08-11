namespace school_managment_system.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.label1 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.settings_tile = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.exit_btn = new MetroFramework.Controls.MetroButton();
            this.logout_btn = new MetroFramework.Controls.MetroButton();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.teachers_tile = new MetroFramework.Controls.MetroTile();
            this.students_tile = new MetroFramework.Controls.MetroTile();
            this.billing_tile = new MetroFramework.Controls.MetroTile();
            this.manage_tile = new MetroFramework.Controls.MetroTile();
            this.attendence_tile = new MetroFramework.Controls.MetroTile();
            this.Enroll_tile = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLink2
            // 
            this.metroLink2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink2.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink2.Location = new System.Drawing.Point(726, 8);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(218, 28);
            this.metroLink2.TabIndex = 7;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.UseStyleColors = true;
            this.metroLink2.Click += new System.EventHandler(this.MetroLink2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(113, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "School Managment System";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile4.Location = new System.Drawing.Point(117, 89);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(722, 4);
            this.metroTile4.TabIndex = 7;
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile5.Location = new System.Drawing.Point(0, 504);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(950, 16);
            this.metroTile5.TabIndex = 7;
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseStyleColors = true;
            // 
            // settings_tile
            // 
            this.settings_tile.ActiveControl = null;
            this.settings_tile.Location = new System.Drawing.Point(548, 331);
            this.settings_tile.Name = "settings_tile";
            this.settings_tile.Size = new System.Drawing.Size(113, 92);
            this.settings_tile.TabIndex = 6;
            this.settings_tile.Text = "Settings";
            this.settings_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.settings_tile.TileImage = global::school_managment_system.Properties.Resources.settings;
            this.settings_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settings_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.settings_tile.UseSelectable = true;
            this.settings_tile.UseStyleColors = true;
            this.settings_tile.UseTileImage = true;
            this.settings_tile.Click += new System.EventHandler(this.Settings_tile_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.exit_btn);
            this.metroPanel1.Controls.Add(this.logout_btn);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(744, 42);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 102);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.exit_btn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.exit_btn.Location = new System.Drawing.Point(17, 66);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(165, 23);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseCustomBackColor = true;
            this.exit_btn.UseSelectable = true;
            this.exit_btn.UseStyleColors = true;
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout_btn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.logout_btn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.logout_btn.Location = new System.Drawing.Point(17, 26);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(165, 23);
            this.logout_btn.TabIndex = 2;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseCustomBackColor = true;
            this.logout_btn.UseSelectable = true;
            this.logout_btn.UseStyleColors = true;
            this.logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Location = new System.Drawing.Point(694, 8);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(33, 28);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink1.UseSelectable = true;
            // 
            // teachers_tile
            // 
            this.teachers_tile.ActiveControl = null;
            this.teachers_tile.Location = new System.Drawing.Point(548, 228);
            this.teachers_tile.Name = "teachers_tile";
            this.teachers_tile.Size = new System.Drawing.Size(113, 92);
            this.teachers_tile.TabIndex = 4;
            this.teachers_tile.Text = "Teachers";
            this.teachers_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.teachers_tile.TileImage = global::school_managment_system.Properties.Resources.teacher_icon;
            this.teachers_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.teachers_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.teachers_tile.UseSelectable = true;
            this.teachers_tile.UseStyleColors = true;
            this.teachers_tile.UseTileImage = true;
            this.teachers_tile.Click += new System.EventHandler(this.Teachers_tile_Click);
            // 
            // students_tile
            // 
            this.students_tile.ActiveControl = null;
            this.students_tile.Location = new System.Drawing.Point(430, 228);
            this.students_tile.Name = "students_tile";
            this.students_tile.Size = new System.Drawing.Size(113, 92);
            this.students_tile.TabIndex = 3;
            this.students_tile.Text = "Students";
            this.students_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.students_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("students_tile.TileImage")));
            this.students_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.students_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.students_tile.UseSelectable = true;
            this.students_tile.UseStyleColors = true;
            this.students_tile.UseTileImage = true;
            this.students_tile.Click += new System.EventHandler(this.Students_tile_Click);
            // 
            // billing_tile
            // 
            this.billing_tile.ActiveControl = null;
            this.billing_tile.Location = new System.Drawing.Point(197, 331);
            this.billing_tile.Name = "billing_tile";
            this.billing_tile.Size = new System.Drawing.Size(221, 92);
            this.billing_tile.TabIndex = 1;
            this.billing_tile.Text = "Billing";
            this.billing_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.billing_tile.TileImage = global::school_managment_system.Properties.Resources.billing;
            this.billing_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.billing_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.billing_tile.UseSelectable = true;
            this.billing_tile.UseStyleColors = true;
            this.billing_tile.UseTileImage = true;
            this.billing_tile.Click += new System.EventHandler(this.Billing_tile_Click);
            // 
            // manage_tile
            // 
            this.manage_tile.ActiveControl = null;
            this.manage_tile.Location = new System.Drawing.Point(430, 331);
            this.manage_tile.Name = "manage_tile";
            this.manage_tile.Size = new System.Drawing.Size(113, 92);
            this.manage_tile.TabIndex = 5;
            this.manage_tile.Text = "Manage Users";
            this.manage_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.manage_tile.TileImage = global::school_managment_system.Properties.Resources.manage_user;
            this.manage_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.manage_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.manage_tile.UseSelectable = true;
            this.manage_tile.UseStyleColors = true;
            this.manage_tile.UseTileImage = true;
            this.manage_tile.Click += new System.EventHandler(this.Manage_tile_Click);
            // 
            // attendence_tile
            // 
            this.attendence_tile.ActiveControl = null;
            this.attendence_tile.Location = new System.Drawing.Point(430, 128);
            this.attendence_tile.Name = "attendence_tile";
            this.attendence_tile.Size = new System.Drawing.Size(231, 90);
            this.attendence_tile.TabIndex = 2;
            this.attendence_tile.Text = "Attendence";
            this.attendence_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.attendence_tile.TileImage = global::school_managment_system.Properties.Resources.attendence;
            this.attendence_tile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.attendence_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.attendence_tile.UseSelectable = true;
            this.attendence_tile.UseStyleColors = true;
            this.attendence_tile.UseTileImage = true;
            this.attendence_tile.Click += new System.EventHandler(this.Attendence_tile_Click);
            // 
            // Enroll_tile
            // 
            this.Enroll_tile.ActiveControl = null;
            this.Enroll_tile.BackColor = System.Drawing.Color.Transparent;
            this.Enroll_tile.Location = new System.Drawing.Point(197, 128);
            this.Enroll_tile.Name = "Enroll_tile";
            this.Enroll_tile.Size = new System.Drawing.Size(221, 192);
            this.Enroll_tile.TabIndex = 0;
            this.Enroll_tile.Text = "Enrollment";
            this.Enroll_tile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Enroll_tile.TileImage = global::school_managment_system.Properties.Resources.enroll;
            this.Enroll_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enroll_tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.Enroll_tile.UseSelectable = true;
            this.Enroll_tile.UseStyleColors = true;
            this.Enroll_tile.UseTileImage = true;
            this.Enroll_tile.Click += new System.EventHandler(this.Enroll_tile_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 520);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teachers_tile);
            this.Controls.Add(this.students_tile);
            this.Controls.Add(this.billing_tile);
            this.Controls.Add(this.manage_tile);
            this.Controls.Add(this.attendence_tile);
            this.Controls.Add(this.settings_tile);
            this.Controls.Add(this.Enroll_tile);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Home_Load);
            this.Click += new System.EventHandler(this.Home_Click);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile Enroll_tile;
        private MetroFramework.Controls.MetroTile attendence_tile;
        private MetroFramework.Controls.MetroTile billing_tile;
        private MetroFramework.Controls.MetroLink metroLink1;
        public MetroFramework.Controls.MetroLink metroLink2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile teachers_tile;
        private MetroFramework.Controls.MetroTile students_tile;
        private MetroFramework.Controls.MetroTile manage_tile;
        private MetroFramework.Controls.MetroTile settings_tile;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton logout_btn;
        private MetroFramework.Controls.MetroButton exit_btn;
    }
}
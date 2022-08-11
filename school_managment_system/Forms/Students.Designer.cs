namespace school_managment_system.Forms
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.search_box = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.delete_student_lnk = new MetroFramework.Controls.MetroLink();
            this.add_student_lnk = new MetroFramework.Controls.MetroLink();
            this.refresh_lnk = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile5.Location = new System.Drawing.Point(0, 534);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(901, 16);
            this.metroTile5.TabIndex = 63;
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel1.Location = new System.Drawing.Point(57, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Students";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.BackgroundImage = global::school_managment_system.Properties.Resources.home_icon_grey;
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.DisplayFocus = true;
            this.metroLink1.ForeColor = System.Drawing.Color.Transparent;
            this.metroLink1.Location = new System.Drawing.Point(0, 8);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(51, 34);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.MetroLink1_Click);
            this.metroLink1.MouseLeave += new System.EventHandler(this.MetroLink1_MouseLeave_1);
            this.metroLink1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MetroLink1_MouseMove_1);
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_box.Icon = ((System.Drawing.Image)(resources.GetObject("search_box.Icon")));
            this.search_box.IconRight = true;
            this.search_box.Lines = new string[0];
            this.search_box.Location = new System.Drawing.Point(2, 88);
            this.search_box.MaxLength = 32767;
            this.search_box.Name = "search_box";
            this.search_box.PasswordChar = '\0';
            this.search_box.PromptText = "search by ID";
            this.search_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_box.SelectedText = "";
            this.search_box.Size = new System.Drawing.Size(219, 23);
            this.search_box.TabIndex = 0;
            this.search_box.UseCustomBackColor = true;
            this.search_box.UseSelectable = true;
            this.search_box.TextChanged += new System.EventHandler(this.Search_box_TextChanged_1);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(2, 112);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(897, 419);
            this.metroGrid1.TabIndex = 1;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MetroGrid1_CellClick);
            // 
            // delete_student_lnk
            // 
            this.delete_student_lnk.BackgroundImage = global::school_managment_system.Properties.Resources.delete_user_grey;
            this.delete_student_lnk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_student_lnk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_student_lnk.Location = new System.Drawing.Point(826, 74);
            this.delete_student_lnk.Name = "delete_student_lnk";
            this.delete_student_lnk.Size = new System.Drawing.Size(75, 37);
            this.delete_student_lnk.TabIndex = 4;
            this.delete_student_lnk.UseSelectable = true;
            this.delete_student_lnk.Click += new System.EventHandler(this.Delete_student_lnk_Click);
            this.delete_student_lnk.MouseLeave += new System.EventHandler(this.Delete_student_lnk_MouseLeave);
            this.delete_student_lnk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Delete_student_lnk_MouseMove);
            // 
            // add_student_lnk
            // 
            this.add_student_lnk.BackgroundImage = global::school_managment_system.Properties.Resources.add_user_grey;
            this.add_student_lnk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_student_lnk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_student_lnk.Location = new System.Drawing.Point(755, 72);
            this.add_student_lnk.Name = "add_student_lnk";
            this.add_student_lnk.Size = new System.Drawing.Size(75, 34);
            this.add_student_lnk.TabIndex = 3;
            this.add_student_lnk.UseSelectable = true;
            this.add_student_lnk.Click += new System.EventHandler(this.Add_student_lnk_Click);
            this.add_student_lnk.MouseLeave += new System.EventHandler(this.Add_student_lnk_MouseLeave);
            this.add_student_lnk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Add_student_lnk_MouseMove);
            // 
            // refresh_lnk
            // 
            this.refresh_lnk.BackgroundImage = global::school_managment_system.Properties.Resources.refresh_grey;
            this.refresh_lnk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh_lnk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_lnk.Location = new System.Drawing.Point(683, 72);
            this.refresh_lnk.Name = "refresh_lnk";
            this.refresh_lnk.Size = new System.Drawing.Size(75, 34);
            this.refresh_lnk.TabIndex = 2;
            this.refresh_lnk.UseSelectable = true;
            this.refresh_lnk.Click += new System.EventHandler(this.Refresh_lnk_Click_1);
            this.refresh_lnk.MouseLeave += new System.EventHandler(this.Refresh_lnk_MouseLeave_1);
            this.refresh_lnk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Refresh_lnk_MouseMove_1);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.ControlBox = false;
            this.Controls.Add(this.refresh_lnk);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.delete_student_lnk);
            this.Controls.Add(this.add_student_lnk);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroTile5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Students";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTextBox search_box;
        public MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLink delete_student_lnk;
        private MetroFramework.Controls.MetroLink add_student_lnk;
        private MetroFramework.Controls.MetroLink refresh_lnk;
    }
}
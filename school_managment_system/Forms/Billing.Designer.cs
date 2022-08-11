namespace school_managment_system.Forms
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.date_lbl = new System.Windows.Forms.Label();
            this.search_box = new MetroFramework.Controls.MetroTextBox();
            this.refresh_lnk = new MetroFramework.Controls.MetroLink();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.no_data_lbl = new MetroFramework.Controls.MetroLabel();
            this.nxt_btn = new MetroFramework.Controls.MetroButton();
            this.done_btn = new MetroFramework.Controls.MetroButton();
            this.prev_btn = new MetroFramework.Controls.MetroButton();
            this.latepaid_radio_btn = new MetroFramework.Controls.MetroRadioButton();
            this.unpaid_radio_btn = new MetroFramework.Controls.MetroRadioButton();
            this.paid_radio_btn = new MetroFramework.Controls.MetroRadioButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.std_class_lbl = new MetroFramework.Controls.MetroLabel();
            this.std_lastname_lbl = new MetroFramework.Controls.MetroLabel();
            this.std_firstname_lbl = new MetroFramework.Controls.MetroLabel();
            this.std_id_lbl = new MetroFramework.Controls.MetroLabel();
            this.month_year_box = new MetroFramework.Controls.MetroTextBox();
            this.tutionfees_lbl = new MetroFramework.Controls.MetroLabel();
            this.other_lbl = new MetroFramework.Controls.MetroLabel();
            this.total_lbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // date_lbl
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.date_lbl, true);
            this.date_lbl.AutoSize = true;
            this.date_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.date_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.date_lbl.Font = new System.Drawing.Font("Tahoma", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.date_lbl.Location = new System.Drawing.Point(75, 416);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(0, 113);
            this.date_lbl.TabIndex = 95;
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_box.Icon = ((System.Drawing.Image)(resources.GetObject("search_box.Icon")));
            this.search_box.IconRight = true;
            this.search_box.Lines = new string[0];
            this.search_box.Location = new System.Drawing.Point(617, 35);
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
            this.search_box.TextChanged += new System.EventHandler(this.Search_box_TextChanged);
            // 
            // refresh_lnk
            // 
            this.refresh_lnk.BackgroundImage = global::school_managment_system.Properties.Resources.refresh_grey;
            this.refresh_lnk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh_lnk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_lnk.Location = new System.Drawing.Point(830, 35);
            this.refresh_lnk.Name = "refresh_lnk";
            this.refresh_lnk.Size = new System.Drawing.Size(75, 23);
            this.refresh_lnk.TabIndex = 84;
            this.refresh_lnk.UseSelectable = true;
            this.refresh_lnk.Click += new System.EventHandler(this.Refresh_lnk_Click);
            this.refresh_lnk.MouseLeave += new System.EventHandler(this.Refresh_lnk_MouseLeave);
            this.refresh_lnk.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Refresh_lnk_MouseMove);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.metroGrid1.Location = new System.Drawing.Point(5, 64);
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
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(890, 289);
            this.metroGrid1.TabIndex = 1;
            this.metroGrid1.UseStyleColors = true;
            // 
            // no_data_lbl
            // 
            this.no_data_lbl.AutoSize = true;
            this.no_data_lbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.no_data_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.no_data_lbl.Location = new System.Drawing.Point(433, 385);
            this.no_data_lbl.Name = "no_data_lbl";
            this.no_data_lbl.Size = new System.Drawing.Size(177, 25);
            this.no_data_lbl.TabIndex = 94;
            this.no_data_lbl.Text = "No Student To Show";
            this.no_data_lbl.Visible = false;
            this.no_data_lbl.VisibleChanged += new System.EventHandler(this.No_data_lbl_VisibleChanged);
            // 
            // nxt_btn
            // 
            this.nxt_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nxt_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.nxt_btn.Location = new System.Drawing.Point(582, 501);
            this.nxt_btn.Name = "nxt_btn";
            this.nxt_btn.Size = new System.Drawing.Size(47, 31);
            this.nxt_btn.TabIndex = 7;
            this.nxt_btn.Text = ">>";
            this.nxt_btn.UseCustomBackColor = true;
            this.nxt_btn.UseSelectable = true;
            this.nxt_btn.UseStyleColors = true;
            this.nxt_btn.Click += new System.EventHandler(this.Nxt_btn_Click);
            // 
            // done_btn
            // 
            this.done_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.done_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.done_btn.Location = new System.Drawing.Point(461, 501);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(108, 31);
            this.done_btn.TabIndex = 6;
            this.done_btn.Text = "Done";
            this.done_btn.UseCustomBackColor = true;
            this.done_btn.UseSelectable = true;
            this.done_btn.UseStyleColors = true;
            this.done_btn.Click += new System.EventHandler(this.Done_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.prev_btn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.prev_btn.Location = new System.Drawing.Point(402, 501);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(47, 31);
            this.prev_btn.TabIndex = 5;
            this.prev_btn.Text = "<<";
            this.prev_btn.UseCustomBackColor = true;
            this.prev_btn.UseSelectable = true;
            this.prev_btn.UseStyleColors = true;
            this.prev_btn.Click += new System.EventHandler(this.Prev_btn_Click);
            // 
            // latepaid_radio_btn
            // 
            this.latepaid_radio_btn.AutoSize = true;
            this.latepaid_radio_btn.Location = new System.Drawing.Point(420, 468);
            this.latepaid_radio_btn.Name = "latepaid_radio_btn";
            this.latepaid_radio_btn.Size = new System.Drawing.Size(71, 15);
            this.latepaid_radio_btn.TabIndex = 3;
            this.latepaid_radio_btn.Text = "Late Paid";
            this.latepaid_radio_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.latepaid_radio_btn.UseSelectable = true;
            // 
            // unpaid_radio_btn
            // 
            this.unpaid_radio_btn.AutoSize = true;
            this.unpaid_radio_btn.Location = new System.Drawing.Point(565, 437);
            this.unpaid_radio_btn.Name = "unpaid_radio_btn";
            this.unpaid_radio_btn.Size = new System.Drawing.Size(61, 15);
            this.unpaid_radio_btn.TabIndex = 4;
            this.unpaid_radio_btn.Text = "UnPaid";
            this.unpaid_radio_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unpaid_radio_btn.UseSelectable = true;
            // 
            // paid_radio_btn
            // 
            this.paid_radio_btn.AutoSize = true;
            this.paid_radio_btn.Location = new System.Drawing.Point(420, 437);
            this.paid_radio_btn.Name = "paid_radio_btn";
            this.paid_radio_btn.Size = new System.Drawing.Size(46, 15);
            this.paid_radio_btn.TabIndex = 2;
            this.paid_radio_btn.Text = "Paid";
            this.paid_radio_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paid_radio_btn.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(0, 357);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(900, 4);
            this.metroTile1.TabIndex = 96;
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile5.Location = new System.Drawing.Point(0, 534);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(900, 16);
            this.metroTile5.TabIndex = 97;
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseStyleColors = true;
            // 
            // metroLink1
            // 
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.BackgroundImage = global::school_managment_system.Properties.Resources.home_icon_grey;
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.DisplayFocus = true;
            this.metroLink1.ForeColor = System.Drawing.Color.Transparent;
            this.metroLink1.Location = new System.Drawing.Point(1, 7);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(51, 34);
            this.metroLink1.TabIndex = 72;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.MetroLink1_Click);
            this.metroLink1.MouseLeave += new System.EventHandler(this.MetroLink1_MouseLeave);
            this.metroLink1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MetroLink1_MouseMove);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
            this.metroLabel1.Location = new System.Drawing.Point(57, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 25);
            this.metroLabel1.TabIndex = 73;
            this.metroLabel1.Text = "Billing";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // std_class_lbl
            // 
            this.std_class_lbl.AutoSize = true;
            this.std_class_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.std_class_lbl.Location = new System.Drawing.Point(426, 410);
            this.std_class_lbl.Name = "std_class_lbl";
            this.std_class_lbl.Size = new System.Drawing.Size(0, 0);
            this.std_class_lbl.TabIndex = 98;
            // 
            // std_lastname_lbl
            // 
            this.std_lastname_lbl.AutoSize = true;
            this.std_lastname_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.std_lastname_lbl.Location = new System.Drawing.Point(507, 385);
            this.std_lastname_lbl.Name = "std_lastname_lbl";
            this.std_lastname_lbl.Size = new System.Drawing.Size(0, 0);
            this.std_lastname_lbl.TabIndex = 99;
            // 
            // std_firstname_lbl
            // 
            this.std_firstname_lbl.AutoSize = true;
            this.std_firstname_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.std_firstname_lbl.Location = new System.Drawing.Point(426, 385);
            this.std_firstname_lbl.Name = "std_firstname_lbl";
            this.std_firstname_lbl.Size = new System.Drawing.Size(0, 0);
            this.std_firstname_lbl.TabIndex = 100;
            // 
            // std_id_lbl
            // 
            this.std_id_lbl.AutoSize = true;
            this.std_id_lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.std_id_lbl.Location = new System.Drawing.Point(418, 363);
            this.std_id_lbl.Name = "std_id_lbl";
            this.std_id_lbl.Size = new System.Drawing.Size(0, 0);
            this.std_id_lbl.TabIndex = 101;
            // 
            // month_year_box
            // 
            this.month_year_box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.month_year_box.Enabled = false;
            this.month_year_box.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.month_year_box.Lines = new string[0];
            this.month_year_box.Location = new System.Drawing.Point(57, 369);
            this.month_year_box.MaxLength = 32767;
            this.month_year_box.Multiline = true;
            this.month_year_box.Name = "month_year_box";
            this.month_year_box.PasswordChar = '\0';
            this.month_year_box.ReadOnly = true;
            this.month_year_box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.month_year_box.SelectedText = "";
            this.month_year_box.Size = new System.Drawing.Size(199, 39);
            this.month_year_box.TabIndex = 102;
            this.month_year_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_year_box.UseCustomBackColor = true;
            this.month_year_box.UseSelectable = true;
            this.month_year_box.UseStyleColors = true;
            // 
            // tutionfees_lbl
            // 
            this.tutionfees_lbl.AutoSize = true;
            this.tutionfees_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tutionfees_lbl.Location = new System.Drawing.Point(722, 385);
            this.tutionfees_lbl.Name = "tutionfees_lbl";
            this.tutionfees_lbl.Size = new System.Drawing.Size(0, 0);
            this.tutionfees_lbl.TabIndex = 103;
            // 
            // other_lbl
            // 
            this.other_lbl.AutoSize = true;
            this.other_lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.other_lbl.Location = new System.Drawing.Point(722, 416);
            this.other_lbl.Name = "other_lbl";
            this.other_lbl.Size = new System.Drawing.Size(0, 0);
            this.other_lbl.TabIndex = 103;
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.total_lbl.Location = new System.Drawing.Point(725, 464);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(0, 0);
            this.total_lbl.TabIndex = 103;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.ControlBox = false;
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.other_lbl);
            this.Controls.Add(this.tutionfees_lbl);
            this.Controls.Add(this.month_year_box);
            this.Controls.Add(this.std_class_lbl);
            this.Controls.Add(this.std_id_lbl);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.no_data_lbl);
            this.Controls.Add(this.nxt_btn);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.latepaid_radio_btn);
            this.Controls.Add(this.unpaid_radio_btn);
            this.Controls.Add(this.paid_radio_btn);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.refresh_lnk);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.std_lastname_lbl);
            this.Controls.Add(this.std_firstname_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Billing";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTextBox search_box;
        private MetroFramework.Controls.MetroLink refresh_lnk;
        public MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Label date_lbl;
        private MetroFramework.Controls.MetroLabel no_data_lbl;
        private MetroFramework.Controls.MetroButton nxt_btn;
        private MetroFramework.Controls.MetroButton done_btn;
        private MetroFramework.Controls.MetroButton prev_btn;
        private MetroFramework.Controls.MetroRadioButton latepaid_radio_btn;
        private MetroFramework.Controls.MetroRadioButton unpaid_radio_btn;
        private MetroFramework.Controls.MetroRadioButton paid_radio_btn;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel std_class_lbl;
        private MetroFramework.Controls.MetroLabel std_id_lbl;
        private MetroFramework.Controls.MetroLabel std_lastname_lbl;
        private MetroFramework.Controls.MetroLabel std_firstname_lbl;
        private MetroFramework.Controls.MetroTextBox month_year_box;
        private MetroFramework.Controls.MetroLabel total_lbl;
        private MetroFramework.Controls.MetroLabel other_lbl;
        private MetroFramework.Controls.MetroLabel tutionfees_lbl;
    }
}
namespace school_managment_system
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.loginbtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.user_emptylbl = new MetroFramework.Controls.MetroLabel();
            this.pass_emptylbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.passtxt = new MetroFramework.Controls.MetroTextBox();
            this.usertxt = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(262, 182);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Username:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(262, 277);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Password:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginbtn
            // 
            this.loginbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginbtn.Location = new System.Drawing.Point(362, 347);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(174, 23);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseSelectable = true;
            this.loginbtn.UseStyleColors = true;
            this.loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(286, 141);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(316, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Please Login To Enter In School Managment System ";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseStyleColors = true;
            // 
            // user_emptylbl
            // 
            this.user_emptylbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_emptylbl.AutoSize = true;
            this.user_emptylbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.user_emptylbl.ForeColor = System.Drawing.Color.Red;
            this.user_emptylbl.Location = new System.Drawing.Point(587, 160);
            this.user_emptylbl.Name = "user_emptylbl";
            this.user_emptylbl.Size = new System.Drawing.Size(15, 19);
            this.user_emptylbl.TabIndex = 4;
            this.user_emptylbl.Text = "*";
            this.user_emptylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_emptylbl.UseCustomForeColor = true;
            this.user_emptylbl.Visible = false;
            // 
            // pass_emptylbl
            // 
            this.pass_emptylbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_emptylbl.AutoSize = true;
            this.pass_emptylbl.BackColor = System.Drawing.Color.White;
            this.pass_emptylbl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.pass_emptylbl.ForeColor = System.Drawing.Color.Red;
            this.pass_emptylbl.Location = new System.Drawing.Point(587, 255);
            this.pass_emptylbl.Name = "pass_emptylbl";
            this.pass_emptylbl.Size = new System.Drawing.Size(15, 19);
            this.pass_emptylbl.TabIndex = 4;
            this.pass_emptylbl.Text = "*";
            this.pass_emptylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pass_emptylbl.UseCustomForeColor = true;
            this.pass_emptylbl.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(402, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "LOGIN";
            // 
            // metroLink2
            // 
            this.metroLink2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLink2.BackColor = System.Drawing.Color.Transparent;
            this.metroLink2.BackgroundImage = global::school_managment_system.Properties.Resources.exit_white;
            this.metroLink2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink2.Location = new System.Drawing.Point(859, 6);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(38, 31);
            this.metroLink2.TabIndex = 4;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.UseStyleColors = true;
            this.metroLink2.Click += new System.EventHandler(this.MetroLink2_Click);
            this.metroLink2.MouseLeave += new System.EventHandler(this.MetroLink2_MouseLeave);
            this.metroLink2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MetroLink2_MouseMove);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLink1.BackColor = System.Drawing.Color.Transparent;
            this.metroLink1.BackgroundImage = global::school_managment_system.Properties.Resources.cogwheel_outline;
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.Location = new System.Drawing.Point(813, 6);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(38, 31);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.MetroLink1_Click);
            this.metroLink1.MouseLeave += new System.EventHandler(this.MetroLink1_MouseLeave);
            this.metroLink1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MetroLink1_MouseMove);
            // 
            // passtxt
            // 
            this.passtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passtxt.Icon = ((System.Drawing.Image)(resources.GetObject("passtxt.Icon")));
            this.passtxt.Lines = new string[0];
            this.passtxt.Location = new System.Drawing.Point(362, 277);
            this.passtxt.MaxLength = 32767;
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '●';
            this.passtxt.PromptText = "password";
            this.passtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passtxt.SelectedText = "";
            this.passtxt.Size = new System.Drawing.Size(240, 23);
            this.passtxt.TabIndex = 1;
            this.passtxt.UseSelectable = true;
            this.passtxt.UseStyleColors = true;
            this.passtxt.UseSystemPasswordChar = true;
            this.passtxt.TextChanged += new System.EventHandler(this.Passtxt_TextChanged);
            // 
            // usertxt
            // 
            this.usertxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usertxt.Icon = ((System.Drawing.Image)(resources.GetObject("usertxt.Icon")));
            this.usertxt.Lines = new string[0];
            this.usertxt.Location = new System.Drawing.Point(362, 182);
            this.usertxt.MaxLength = 32767;
            this.usertxt.Name = "usertxt";
            this.usertxt.PasswordChar = '\0';
            this.usertxt.PromptText = "user name";
            this.usertxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usertxt.SelectedText = "";
            this.usertxt.Size = new System.Drawing.Size(240, 23);
            this.usertxt.TabIndex = 0;
            this.usertxt.UseSelectable = true;
            this.usertxt.UseStyleColors = true;
            this.usertxt.WordWrap = false;
            this.usertxt.TextChanged += new System.EventHandler(this.Usertxt_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 509);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pass_emptylbl);
            this.Controls.Add(this.user_emptylbl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton loginbtn;
        private MetroFramework.Controls.MetroTextBox passtxt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel pass_emptylbl;
        private MetroFramework.Controls.MetroLabel user_emptylbl;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox usertxt;
    }
}


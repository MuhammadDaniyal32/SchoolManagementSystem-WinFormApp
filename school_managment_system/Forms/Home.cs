using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using school_managment_system.Properties;
using school_managment_system.Slide_Panel;
using System.Data;
using school_managment_system.Functions;

namespace school_managment_system.Forms
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            metroTile5.Text= DateTime.Now.ToLongDateString();

            try
            {
                DataSet dd = SQLCMD.SQLDataset("select firstname,lastname from user_details where user_name='" + Settings.Default.displayname.ToString()+ "'");

                metroLink2.Text = dd.Tables[0].Rows[0]["firstname"].ToString().ToUpper() + " " + dd.Tables[0].Rows[0]["lastname"].ToString().ToUpper();
            }
            catch (Exception)
            {

            }
        }
        private void MetroLink2_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = true;
           
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Click += Home_Click1;
        }

        private void Home_Click1(object sender, EventArgs e)
        {
            metroPanel1.Visible=false;
        }

        private void Teachers_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Teachers obj1 = new Teachers();
            obj1.Show();
        }

        private void Enroll_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Enrollment obj1 = new Enrollment();
            obj1.Show();
        }

        private void Attendence_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Attendence obj1 = new Attendence();
            obj1.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        private void Billing_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Billing obj = new Billing();
            obj.Show();
        }

        private void Students_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Students obj = new Students();
            obj.Show();
        }

        private void Manage_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            this.Hide();
            Manage_users obj = new Manage_users();
            obj.Show();
        }

        private void Settings_tile_Click(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;

            panel _pnlone = new panel(this);
            _pnlone.Closed += _pnlone_Closed;
            _pnlone.Shown += _pnlone_Shown;
            _pnlone.swipe(true);
        }
        void _pnlone_Closed(object sender, EventArgs e)
        {
        }

        void _pnlone_Shown(object sender, EventArgs e)
        {
            metroTile4.SendToBack();
            metroPanel1.Visible = false;
        }
    }
}

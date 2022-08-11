using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using school_managment_system.Forms;
using school_managment_system.Functions;
using school_managment_system.Properties;
using school_managment_system.Slide_Panel;

namespace school_managment_system
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;        
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style; 
        }
        
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            DataSet da = SQLCMD.SQLDataset("select * from user_details where user_name='" + usertxt.Text.ToUpper().Trim() + "'and password='" + passtxt.Text.ToLower().Trim() + "';");
            int cont = da.Tables[0].Rows.Count;
            if (cont == 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You Are Succefully Logged In!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Settings.Default.displayname = usertxt.Text;
                this.Hide();
                Home obj1= new Home();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("PLease correct Username and Password");
            }
        }
        void _pnlone_Closed(object sender, EventArgs e)
        {
            metroLink1.Enabled = true;
            metroLink1.Visible = true;
            metroLink2.Visible = true;
            usertxt.Enabled = true;
            passtxt.Enabled = true;
            loginbtn.Enabled = true;
            usertxt.Focus();
        }
        void _pnlone_Shown(object sender, EventArgs e)
        {
            metroLink1.Visible = false;
            metroLink2.Visible = false;
        }

       

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {
            if(usertxt.Text==""||passtxt.Text == ""|| usertxt.Text=="")
            {
                loginbtn.Enabled = false;
            }
            else
            {
                loginbtn.Enabled = true;
            }

            if (usertxt.Text == "")
            {
                user_emptylbl.Visible = true;
            }
            else
            {
                user_emptylbl.Visible = false;
            }
        }

        private void Passtxt_TextChanged(object sender, EventArgs e)
        {
            if (passtxt.Text == ""||usertxt.Text == "")
            {
                loginbtn.Enabled = false;
            }
            else
            {
                loginbtn.Enabled = true;
            }
            if (passtxt.Text == "")
            {
                pass_emptylbl.Visible = true;
            }
            else
            {
                pass_emptylbl.Visible = false;
            }
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            panel _pnlone = new panel(this);
            _pnlone.Closed += _pnlone_Closed;
            _pnlone.Shown += _pnlone_Shown;
            _pnlone.swipe(true);
            usertxt.Enabled = false;
            passtxt.Enabled = false;
            loginbtn.Enabled = false;
            
        }

        private void MetroLink2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usertxt.Focus();

            loginbtn.Enabled = false;
        }

        private void MetroLink2_MouseLeave(object sender, EventArgs e)
        {
            this.metroLink2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit_white));
            this.metroLink2.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void MetroLink2_MouseMove(object sender, MouseEventArgs e)
        {
            this.metroLink2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exit_black));
            this.metroLink2.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void MetroLink1_MouseLeave(object sender, EventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cogwheel_outline));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;            
        }

        private void MetroLink1_MouseMove(object sender, MouseEventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.cogwheel_outline_black));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

    }
}

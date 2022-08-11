using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using school_managment_system.Functions;
using school_managment_system.Properties;
namespace school_managment_system.Forms
{
    public partial class add_user : MetroForm
    {
        public add_user()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void U_add_btn_Click(object sender, EventArgs e)
        {
            string id = user_id_box.Text.Trim();
            string fname = ufirstname_box.Text;
            string lname = ulastname_box.Text;
            string username = username_box.Text.Trim().ToUpper();
            string pass = password_box.Text.Trim().ToLower();
            string type = type_combobox.Text;
            string q = "insert into user_details(user_id,firstname,lastname,user_name,password,type)values ('" + id + "','" + fname + "','" + lname + "','" + username + "','" + pass + "','" + type + "')";

            if (SQLCMD.SQLExecute(q))
            {
                Manage_users obj = new Manage_users();
                MetroFramework.MetroMessageBox.Show(obj, "data saved!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Manage_users obj = new Manage_users();
                MetroFramework.MetroMessageBox.Show(obj, "data not saved!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Add_user_Load(object sender, EventArgs e)
        {
            user_id_box.Focus();
            u_add_btn.Enabled = false;
        }

        private void User_id_box_TextChanged(object sender, EventArgs e)
        {
            if (user_id_box.Text == "" || ufirstname_box.Text == "" || username_box.Text == "" || password_box.Text == "")
            {
                u_add_btn.Enabled = false;
            }
            else
            {
                u_add_btn.Enabled = true;
            }
        }

        private void Ufirstname_box_TextChanged(object sender, EventArgs e)
        {
            if (user_id_box.Text == "" || ufirstname_box.Text == "" || username_box.Text == "" || password_box.Text == "")
            {
                u_add_btn.Enabled = false;
            }
            else
            {
                u_add_btn.Enabled = true;
            }
        }

        private void Username_box_TextChanged(object sender, EventArgs e)
        {
            if (user_id_box.Text == "" || ufirstname_box.Text == ""||username_box.Text==""||password_box.Text=="")
            {
                u_add_btn.Enabled = false;
            }
            else
            {
                u_add_btn.Enabled = true;
            }
        }

        private void Password_box_TextChanged(object sender, EventArgs e)
        {
            if (user_id_box.Text == "" || ufirstname_box.Text == "" || username_box.Text == "" || password_box.Text == "")
            {
                u_add_btn.Enabled = false;
            }
            else
            {
                u_add_btn.Enabled = true;
            }
        }
    }
}

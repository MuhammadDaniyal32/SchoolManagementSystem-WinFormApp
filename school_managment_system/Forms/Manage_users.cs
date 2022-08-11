using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using school_managment_system.Functions;
using school_managment_system.Properties;
namespace school_managment_system.Forms
{
    public partial class Manage_users : MetroForm
    {
        public Manage_users()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }
        public string u_id;
        public string fname;
        public string lname;
        private void Manage_users_Load(object sender, EventArgs e)
        {
            try
            {
                metroGrid1.DataSource = SQLCMD.SQLtable("select * from  user_details");
            }
            catch (Exception ex)
            {
                MessageBox.Show("data not load" + ex);
            }
            metroTile5.Text = DateTime.Now.ToLongDateString();
        }

        private void MetroLink1_MouseLeave(object sender, EventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_grey));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void MetroLink1_MouseMove(object sender, MouseEventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_black));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Refresh_lnk_MouseLeave(object sender, EventArgs e)
        {
            this.refresh_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.refresh_grey));
            this.refresh_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Refresh_lnk_MouseMove(object sender, MouseEventArgs e)
        {
            this.refresh_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.refresh_black));
            this.refresh_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Add_tech_lnk_MouseLeave(object sender, EventArgs e)
        {
            this.add_tech_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add_user_grey));
            this.add_tech_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Add_tech_lnk_MouseMove(object sender, MouseEventArgs e)
        {
            this.add_tech_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add_user_black));
            this.add_tech_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Delete_tech_lnk_MouseLeave(object sender, EventArgs e)
        {
            this.delete_tech_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete_user_grey));
            this.delete_tech_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Delete_tech_lnk_MouseMove(object sender, MouseEventArgs e)
        {
            this.delete_tech_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete_user_black));
            this.delete_tech_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Search_box_TextChanged(object sender, EventArgs e)
        {
            (metroGrid1.DataSource as DataTable).DefaultView.RowFilter = string.Format("user_id LIKE '{0}%'", search_box.Text);
        }

        private void Te_update_btn_Click(object sender, EventArgs e)
        {
            string id = user_id_box.Text;
            string fname = ufirstname_box.Text;
            string lname = ulastname_box.Text;
            string username = username_box.Text.Trim().ToUpper();
            string pass = password_box.Text.Trim().ToLower();
            string type = type_combobox.Text;
            string q = "update user_details set firstname='" + fname + "',lastname='" + lname + "',user_name='" + username + "',password='" + pass + "',type='" + type + "' where user_id="+id+"";

            if (SQLCMD.SQLExecute(q))
            {
                MetroFramework.MetroMessageBox.Show(this, "data saved!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                update_panel.Visible = false;
                metroGrid1.DataSource = SQLCMD.SQLtable("select * from  user_details");
                metroGrid1.Refresh();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "data not saved!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void MetroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            update_panel.Visible = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                u_id = row.Cells[0].Value.ToString();
                fname = row.Cells[1].Value.ToString();
                lname = row.Cells[2].Value.ToString();

            }

        }

        private void MetroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            update_panel.Visible = true;
            user_id_box.Focus();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                user_id_box.Text = row.Cells[0].Value.ToString();
                ufirstname_box.Text = row.Cells[1].Value.ToString();
                ulastname_box.Text = row.Cells[2].Value.ToString();
                username_box.Text = row.Cells[3].Value.ToString();
                password_box.Text = row.Cells[4].Value.ToString();
                type_combobox.Text = row.Cells[5].Value.ToString();
                
            }
        }

        private void Delete_tech_lnk_Click(object sender, EventArgs e)
        {

            if (u_id == "")
            {
                MessageBox.Show("please select valid grid cell");
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do You Want To Delete " + fname + lname + " Data ???", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (SQLCMD.SQLExecute("delete user_details where user_id=" + u_id + ""))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "User succefully deleted", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroGrid1.DataSource = SQLCMD.SQLtable("select * from  user_details");
                        metroGrid1.Refresh();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "User not deleted!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Refresh_lnk_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = SQLCMD.SQLtable("select * from  user_details");
            metroGrid1.Refresh();
        }

        private void Add_tech_lnk_Click(object sender, EventArgs e)
        {
            add_user obj1 = new add_user();
            obj1.Show();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            update_panel.Visible = false;
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj1 = new Home();
            obj1.Show();
            
        }
    }
}

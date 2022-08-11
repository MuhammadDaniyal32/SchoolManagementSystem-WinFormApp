using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using school_managment_system.Functions;
using school_managment_system.Properties;

namespace school_managment_system.Forms
{
    public partial class Teachers : MetroForm
    {
        public Teachers()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }
        public string te_id;
        public string fname;
        public string lname;
        private void Teachers_Load(object sender, EventArgs e)
        {
            try
            {
                metroGrid1.DataSource = SQLCMD.SQLtable("select * from  teachers_details");
            }
            catch(Exception ex)
            {
                MessageBox.Show("data not load" + ex);
            }
            metroTile5.Text = DateTime.Now.ToLongDateString();
        }

        private void Search_box_TextChanged(object sender, EventArgs e)
        {
          (metroGrid1.DataSource as DataTable).DefaultView.RowFilter = string.Format("teacher_id LIKE '{0}%'", search_box.Text);
        }

        private void MetroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            update_panel.Visible = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                te_id = row.Cells[0].Value.ToString();
                fname = row.Cells[1].Value.ToString();
                lname = row.Cells[2].Value.ToString();
            }
        }

        private void Te_update_btn_Click(object sender, EventArgs e)
        {
            string id = te_id_box.Text.Trim();
            string f_name = te_firstn_box.Text;
            string l_name = te_lastn_box.Text;
            string father_name = te_fathern_box.Text;
            string dob = dob_combobox.Text;
            int age = Convert.ToInt32(age_box.Text.Trim());
            string qualif = qualif_box.Text;
            string sub = sub_box.Text;
            string salary = salary_box.Text;
            string phone = phone_box.Text.Trim();
            string classes = Classes_combobox.Text;

            string q = "UPDATE teachers_details SET teacher_firstname='"+ f_name + "',teacher_lastname='"+ l_name + "',father_name='"+ father_name + "',date_of_birth='"+ dob + "',age='"+ age + "',qualification='"+ qualif + "',subjects='"+ sub + "',salary='"+ salary + "',phone_no='"+ phone + "',classes_under='"+ classes + "' where teacher_id=" + id + "";

            if (SQLCMD.SQLExecute(q))
            {
                MetroFramework.MetroMessageBox.Show(this, "Data succefully updated", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                update_panel.Visible = false;
                metroGrid1.DataSource = SQLCMD.SQLtable("select * from  teachers_details");
                metroGrid1.Refresh();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "data not updated!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_tech_lnk_Click(object sender, EventArgs e)
        {
            add_teacher obj = new add_teacher();
            obj.Show();
        }
        private void Delete_tech_lnk_Click(object sender, EventArgs e)
        {
            if (te_id == "")
            {
                MessageBox.Show("please select valid grid cell");
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do You Want To Delete " + fname + lname + " Data ???", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (SQLCMD.SQLExecute("delete teachers_details where teacher_id=" + te_id + ""))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data succefully deleted", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroGrid1.DataSource = SQLCMD.SQLtable("select * from  teachers_details");
                        metroGrid1.Refresh();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "data not deleted!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MetroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            update_panel.Visible = true;
            te_id_box.Focus();

            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                te_id_box.Text = row.Cells[0].Value.ToString();
                te_firstn_box.Text = row.Cells[1].Value.ToString();
                te_lastn_box.Text = row.Cells[2].Value.ToString();
                te_fathern_box.Text = row.Cells[3].Value.ToString();
                dob_combobox.Text = row.Cells[4].Value.ToString();
                age_box.Text = row.Cells[5].Value.ToString();
                qualif_box.Text = row.Cells[6].Value.ToString();
                sub_box.Text = row.Cells[7].Value.ToString();
                salary_box.Text = row.Cells[8].Value.ToString();
                phone_box.Text = row.Cells[9].Value.ToString();
                Classes_combobox.Text = row.Cells[10].Value.ToString();

            }
        }

        private void Refresh_lnk_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = SQLCMD.SQLtable("select * from  teachers_details");
            metroGrid1.Refresh();
        }

        private void MetroLink1_MouseMove(object sender, MouseEventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_black));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void MetroLink1_MouseLeave(object sender, EventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_grey));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Delete_tech_lnk_MouseMove(object sender, MouseEventArgs e)
        {

            this.delete_tech_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete_user_black));
            this.delete_tech_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Delete_tech_lnk_MouseLeave(object sender, EventArgs e)
        {
            this.delete_tech_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete_user_grey));
            this.delete_tech_lnk.BackgroundImageLayout = ImageLayout.Zoom;
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

        private void Refresh_lnk_MouseMove(object sender, MouseEventArgs e)
        {
            this.refresh_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.refresh_black));
            this.refresh_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Refresh_lnk_MouseLeave(object sender, EventArgs e)
        {
            this.refresh_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.refresh_grey));
            this.refresh_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            update_panel.Visible = false;
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj1 = new Home();
            obj1.Show();
        }
        private void Age_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void Phone_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }
    }


}

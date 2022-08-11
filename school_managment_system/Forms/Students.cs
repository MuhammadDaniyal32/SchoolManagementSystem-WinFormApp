using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using school_managment_system.Functions;
using school_managment_system.Properties;
using System.Drawing;

namespace school_managment_system.Forms
{
    public partial class Students : MetroForm
    {
        public string te_id;
        public string s_fname;
        public string s_lname;
        public Students()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }
        private void Students_Load(object sender, EventArgs e)
        {
            try
            {
                metroGrid1.DataSource = SQLCMD.SQLtable("select * from  enrollment_details");
            }
            catch (Exception ex)
            {
                MessageBox.Show("data not load" + ex);
            }
            metroTile5.Text = DateTime.Now.ToLongDateString();
        }
        private void Refresh_lnk_MouseLeave_1(object sender, EventArgs e)
        {
            this.refresh_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.refresh_grey));
            this.refresh_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Refresh_lnk_MouseMove_1(object sender, MouseEventArgs e)
        {
                this.refresh_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.refresh_black));
                this.refresh_lnk.BackgroundImageLayout = ImageLayout.Zoom;
         }

        private void Add_student_lnk_MouseLeave(object sender, EventArgs e)
        {
            this.add_student_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add_user_grey));
            this.add_student_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void Add_student_lnk_MouseMove(object sender, MouseEventArgs e)
        {
        this.add_student_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add_user_black));
        this.add_student_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Delete_student_lnk_MouseLeave(object sender, EventArgs e)
        {
            this.delete_student_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete_user_grey));
            this.delete_student_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Delete_student_lnk_MouseMove(object sender, MouseEventArgs e)
        {
            this.delete_student_lnk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete_user_black));
            this.delete_student_lnk.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void MetroLink1_MouseLeave_1(object sender, EventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_grey));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void MetroLink1_MouseMove_1(object sender, MouseEventArgs e)
        {
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.home_icon_black));
            this.metroLink1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Refresh_lnk_Click_1(object sender, EventArgs e)
        {
            metroGrid1.DataSource = SQLCMD.SQLtable("select * from  enrollment_details");
            metroGrid1.Refresh();
        }

        private void Delete_student_lnk_Click(object sender, EventArgs e)
        {
            if (te_id == "")
            {
                MessageBox.Show("please select valid grid cell");
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do You Want To Delete " + s_fname + s_lname + " Data ???", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (SQLCMD.SQLExecute("delete enrollment_details where std_id =" + te_id + ""))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Data succefully deleted", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroGrid1.DataSource = SQLCMD.SQLtable("select * from  enrollment_details");
                        metroGrid1.Refresh();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "data not deleted!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
      
        private void Search_box_TextChanged_1(object sender, EventArgs e)
        {
            (metroGrid1.DataSource as DataTable).DefaultView.RowFilter = string.Format("std_id  LIKE '{0}%'", search_box.Text);
        }

        private void Add_student_lnk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Enrollment obj1 = new Enrollment();
                obj1.Show();
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj1 = new Home();
            obj1.Show();
        }

        private void MetroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                te_id = row.Cells[0].Value.ToString();
                s_fname = row.Cells[1].Value.ToString();
                s_lname = row.Cells[3].Value.ToString();
            }
        }
    }
}

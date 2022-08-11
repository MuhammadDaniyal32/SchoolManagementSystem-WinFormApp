using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using school_managment_system.Functions;
using school_managment_system.Properties;

namespace school_managment_system.Forms
{
    public partial class Attendence : MetroForm
    {
        DataSet da = SQLCMD.SQLDataset("select std_id,s_firstname,s_lastname,std_class from enrollment_details");
        int index_pos = 0;
      
        public Attendence()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
            metroStyleExtender1.StyleManager.Theme = StyleManager.Theme;
            
        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            metroTile5.Text = DateTime.Now.ToLongDateString();
            month_year_box.Text = DateTime.Now.Year.ToString() + " , " + DateTime.Now.ToString("MMMM");
            date_lbl.Text = DateTime.Now.ToString("dd");
            load_data(index_pos);
            try
            {
                metroGrid1.DataSource = SQLCMD.SQLtable("select * from  attendence_details");
            }
            catch (Exception ex)
            {
                MessageBox.Show("data not load" + ex);
            }
        }
        public void load_data(int index)
        {
            try
            {
                std_id_lbl.Text += da.Tables[0].Rows[index]["std_id"].ToString();
                std_firstname_lbl.Text += da.Tables[0].Rows[index]["s_firstname"].ToString() + "  ";
                std_lastname_lbl.Text += da.Tables[0].Rows[index]["s_lastname"].ToString();
                std_class_lbl.Text += da.Tables[0].Rows[index]["std_class"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }

        private void Nxt_btn_Click(object sender, EventArgs e)
        {
            std_id_lbl.Text = "";
            std_firstname_lbl.Text = "";
            std_lastname_lbl.Text = "";
            std_class_lbl.Text = "";

            index_pos++;
            if (index_pos < da.Tables[0].Rows.Count)
            {
                load_data(index_pos);
                no_data_lbl.Visible = false;
                std_id_lbl.Visible = true;
                std_firstname_lbl.Visible = true;
                std_lastname_lbl.Visible = true;
                std_class_lbl.Visible = true;
            }
            else
            {
                no_data_lbl.Visible = true;
                std_id_lbl.Visible = false;
                std_firstname_lbl.Visible = false;
                std_lastname_lbl.Visible = false;
                std_class_lbl.Visible = false;
                index_pos = da.Tables[0].Rows.Count - 1;
            }
        }

        private void Prev_btn_Click(object sender, EventArgs e)
        {
            std_id_lbl.Text = "";
            std_firstname_lbl.Text = "";
            std_lastname_lbl.Text = "";
            std_class_lbl.Text = "";

            index_pos--;
            if (index_pos == -1)
            {
                index_pos = 0;
                no_data_lbl.Visible = true;
            }
            else {
                if (index_pos >= 0)
                {
                    load_data(index_pos);
                    no_data_lbl.Visible = false;
                    std_id_lbl.Visible = true;
                    std_firstname_lbl.Visible = true;
                    std_lastname_lbl.Visible = true;
                    std_class_lbl.Visible = true;
                }
                else
                {
                    no_data_lbl.Visible = true;
                    std_id_lbl.Visible = false;
                    std_firstname_lbl.Visible = false;
                    std_lastname_lbl.Visible = false;
                    std_class_lbl.Visible = false;
                }
            }
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            string remarks="";
            if(prst_radio_btn.Checked)
            {
                remarks ="Present";
            }
            if (abst_radio_btn.Checked)
            {
                remarks = "Absent";
            }
            if (leav_radio_btn.Checked)
            {
                remarks = "On Leave";
            }
            if (late_radio_btn.Checked)
            {
                remarks = "Late";
            }

            string std_id = std_id_lbl.Text;
            string fname = std_firstname_lbl.Text;
            string lname = std_lastname_lbl.Text;
            string std_class = std_class_lbl.Text;
            string date = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            DataSet da = SQLCMD.SQLDataset("select * from attendence_details where date='"+date+ "'and std_id='"+std_id+"'");
            int cont = da.Tables[0].Rows.Count;
            if (cont == 1)
            {
                string q = "update attendence_details set remarks='"+remarks+ "' where date='" + date + "'and std_id='" + std_id + "'";
                try
                {
                    SQLCMD.SQLExecute(q);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {
                string q = "insert into attendence_details(std_id,firstname,lastname,class,date,remarks) values ('" + std_id + "','" + fname + "','" + lname + "','" + std_class + "','" + date + "','" + remarks + "')";
                try
                {
                    SQLCMD.SQLExecute(q);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

            metroGrid1.DataSource = SQLCMD.SQLtable("select * from  attendence_details");
            metroGrid1.Refresh();

           
        }

        private void Refresh_lnk_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = SQLCMD.SQLtable("select * from  attendence_details");
            metroGrid1.Refresh();
        }

        private void Search_box_TextChanged(object sender, EventArgs e)
        {
            (metroGrid1.DataSource as DataTable).DefaultView.RowFilter = string.Format("std_id LIKE '{0}%'", search_box.Text);
        }

        private void No_data_lbl_VisibleChanged(object sender, EventArgs e)
        {
            if (no_data_lbl.Visible == true)
            {
                done_btn.Enabled = false;
            }
            else
            {
                done_btn.Enabled = true;
            }
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

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }
    }

}

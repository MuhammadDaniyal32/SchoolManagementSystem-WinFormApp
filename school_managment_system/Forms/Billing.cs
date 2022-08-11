using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using school_managment_system.Functions;
using school_managment_system.Properties;

namespace school_managment_system.Forms
{
    public partial class Billing : MetroForm
    {
        DataSet da = SQLCMD.SQLDataset("select std_id,s_firstname,s_lastname,std_class,tution_fees,other_charges,total_amount from enrollment_details");
        int index_pos = 0;
        public Billing()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
            metroStyleExtender1.StyleManager.Theme = StyleManager.Theme;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            metroTile5.Text = DateTime.Now.ToLongDateString();
            month_year_box.Text = DateTime.Now.Year.ToString() + " , " + DateTime.Now.ToString("MMMM");
            date_lbl.Text = DateTime.Now.ToString("dd");
            load_data(index_pos);
            try
            {
                metroGrid1.DataSource = SQLCMD.SQLtable("select * from  billing_details");
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
                tutionfees_lbl.Text += da.Tables[0].Rows[index]["tution_fees"].ToString();
                other_lbl.Text += da.Tables[0].Rows[index]["other_charges"].ToString();
                total_lbl.Text += da.Tables[0].Rows[index]["total_amount"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Nxt_btn_Click(object sender, EventArgs e)
        {
            std_id_lbl.Text = "";
            std_firstname_lbl.Text = "";
            std_lastname_lbl.Text = "";
            std_class_lbl.Text = "";
            tutionfees_lbl.Text = "";
            other_lbl.Text = "";
            total_lbl.Text = "";
            index_pos++;
            if (index_pos < da.Tables[0].Rows.Count)
            {
                load_data(index_pos);
                no_data_lbl.Visible = false;
                std_id_lbl.Visible = true;
                std_firstname_lbl.Visible = true;
                std_lastname_lbl.Visible = true;
                std_class_lbl.Visible = true;
                tutionfees_lbl.Visible = true;
                other_lbl.Visible = true;
                total_lbl.Visible = true;
            }
            else
            {
                no_data_lbl.Visible = true;
                std_id_lbl.Visible = false;
                std_firstname_lbl.Visible = false;
                std_lastname_lbl.Visible = false;
                std_class_lbl.Visible = false;
                tutionfees_lbl.Visible = false;
                other_lbl.Visible = false;
                total_lbl.Visible = false;
                index_pos = da.Tables[0].Rows.Count - 1;
            }
        }

        private void Prev_btn_Click(object sender, EventArgs e)
        {
            std_id_lbl.Text = "";
            std_firstname_lbl.Text = "";
            std_lastname_lbl.Text = "";
            std_class_lbl.Text = "";
            tutionfees_lbl.Text = "";
            other_lbl.Text = "";
            total_lbl.Text = "";

            index_pos--;
            if (index_pos == -1)
            {
                index_pos = 0;
                no_data_lbl.Visible = true;
            }
            else
            {
                if (index_pos >= 0)
                {
                    load_data(index_pos);
                    no_data_lbl.Visible = false;
                    std_id_lbl.Visible = true;
                    std_firstname_lbl.Visible = true;
                    std_lastname_lbl.Visible = true;
                    std_class_lbl.Visible = true;
                    tutionfees_lbl.Visible = true;
                    other_lbl.Visible = true;
                    total_lbl.Visible = true;
                }
                else
                {
                    no_data_lbl.Visible = true;
                    std_id_lbl.Visible = false;
                    std_firstname_lbl.Visible = false;
                    std_lastname_lbl.Visible = false;
                    std_class_lbl.Visible = false;
                    tutionfees_lbl.Visible = false;
                    other_lbl.Visible = false;
                    total_lbl.Visible = false;
                }
            }
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            string status = "";
            if (paid_radio_btn.Checked)
            {
                status = "Paid";
            }
            if (unpaid_radio_btn.Checked)
            {
                status = "UnPaid";
            }
            if (latepaid_radio_btn.Checked)
            {
                status = "Late Paid";
            }
            
            string std_id = std_id_lbl.Text;
            string fname = std_firstname_lbl.Text;
            string lname = std_lastname_lbl.Text;
            string std_class = std_class_lbl.Text;
            string tution = tutionfees_lbl.Text;
            string other = other_lbl.Text;
            string total = total_lbl.Text;
            string date = DateTime.Now.ToString("dd/MMMM/yyyy");

            DataSet da = SQLCMD.SQLDataset("select * from billing_details where date='" + date + "' and std_id='" + std_id + "'");
            int cont = da.Tables[0].Rows.Count;
            if (cont == 1)
            {
                string q = "update billing_details set status='" + status + "' where date='" + date + "' and std_id='" + std_id + "'";
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
                string q = "insert into billing_details (std_id,firstname,lastname,class,date,tution_fees,other_charges,total_amount,status) values ('" + std_id + "','" + fname + "','" + lname + "','" + std_class + "','" + date + "','" + tution + "','" + other + "','" + total + "','" + status + "')";
                try
                {
                    SQLCMD.SQLExecute(q);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

            metroGrid1.DataSource = SQLCMD.SQLtable("select * from  billing_details");
            metroGrid1.Refresh();

        }

        private void Refresh_lnk_Click(object sender, EventArgs e)
        {

            metroGrid1.DataSource = SQLCMD.SQLtable("select * from  billing_details");
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

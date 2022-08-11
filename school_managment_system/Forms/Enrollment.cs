using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using school_managment_system.Functions;
using school_managment_system.Properties;
using System.Globalization;

namespace school_managment_system.Forms
{
    public partial class Enrollment : MetroForm
    {
        public int x;
        public int y;
        public Enrollment()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            metroTile5.Text = DateTime.Now.ToLongDateString();
            sfirstname_box.Focus();
            done_btn.Enabled = false;
        }
        
        private void Sfirstname_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sfirstname_box.Text)) { sfirst_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { sfirst_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text==""||occ_box.Text==""||address_box.Text == ""||homephone_box.Text == "" || receip_box.Text == "" || id_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true;}
        }
        private void Slastname_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(slastname_box.Text)) { slast_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { slast_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == "" || receip_box.Text == "" || id_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }
        private void Age_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(age_box.Text)) { age_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { age_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == "" || receip_box.Text == "" || id_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }

        private void Birthcity_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(birthcity_box.Text)) { birthplace_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { birthplace_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == "" || receip_box.Text == "" || id_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }

        private void Pfirstname_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pfirstname_box.Text)) { pfirst_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { pfirst_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == "" || receip_box.Text == "" || id_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }

        private void Plastname_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(plastname_box.Text)) { plast_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { plast_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == "" || receip_box.Text == "" || id_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }

        private void Occ_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(occ_box.Text)) { occu_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { occu_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == "" || receip_box.Text == "" || id_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }

        private void Address_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(address_box.Text)) { address_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { address_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == "" || receip_box.Text == "" || id_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }

        private void Homephone_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(homephone_box.Text)) { homephone_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { homephone_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == ""||receip_box.Text == "" || id_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }
        private void Id_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_box.Text)) { id_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { id_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == ""||receip_box.Text==""||id_box.Text=="") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }

        private void Class_combobox_TextChanged(object sender, EventArgs e)
        { 
            switch(class_combobox.SelectedItem.ToString())
            {
                case "Montessori":
                    tution_lbl.Text = "1,000";
                    other_lbl.Text = "300";
                    break; 
                case "Class 1":
                    tution_lbl.Text = "1,500";
                    other_lbl.Text = "400";
                    break;
                case "Class 2":
                    tution_lbl.Text = "1,500";
                    other_lbl.Text = "700";
                    break;
                case "Class 3":
                    tution_lbl.Text = "2,000";
                    other_lbl.Text = "700";
                    break;
                case "Class 4":
                    tution_lbl.Text = "2,500";
                    other_lbl.Text = "700";
                    break;
                case "Class 5":
                    tution_lbl.Text = "2,500";
                    other_lbl.Text = "800";
                    break;
                case "Class 6":
                    tution_lbl.Text = "3,000";
                    other_lbl.Text = "800";
                    break;
                case "Class 7":
                    tution_lbl.Text = "3,000";
                    other_lbl.Text = "800";
                    break;
                case "Class 8":
                    tution_lbl.Text = "3,000";
                    other_lbl.Text = "800";
                    break;
                case "Class 9":
                    tution_lbl.Text = "3,500";
                    other_lbl.Text = "900";
                    break;
                case "Class Matric":
                    tution_lbl.Text = "3,500";
                    other_lbl.Text = "900";
                    break;
                default:
                    tution_lbl.Text = "";
                    other_lbl.Text = "";
                    break;
            }

             x = Int32.Parse(tution_lbl.Text, NumberStyles.AllowThousands);
             y = Int32.Parse(other_lbl.Text, NumberStyles.AllowThousands);
            total_lbl.Text= string.Format("{0:n0}", x + y);
            
        }

        private void Receip_box_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(receip_box.Text)) { receipt_emptylbl.Visible = true; emptytxt_lbl.Visible = true; } else { receipt_emptylbl.Visible = false; emptytxt_lbl.Visible = false; }
            if (sfirstname_box.Text == "" || slastname_box.Text == "" || age_box.Text == "" || birthcity_box.Text == "" || pfirstname_box.Text == "" || pfirstname_box.Text == "" || plastname_box.Text == "" || occ_box.Text == "" || address_box.Text == "" || homephone_box.Text == "") { done_btn.Enabled = false; } else { done_btn.Enabled = true; }
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            string std_firstname = sfirstname_box.Text;
            string std_lastname = slastname_box.Text;
            string std_middlename = smiddlename_box.Text;
            string birth_date = birthdate_box.Text;
            string age = age_box.Text;
            string gender = gender_combobox.Text;
            string birth_city = birthcity_box.Text;
            string birth_prov = birthprovince_box.Text;
            string birth_reg = birthregion_box.Text;

            string p_firstname = pfirstname_box.Text;
            string p_lastname = plastname_box.Text;
            string occu = occ_box.Text;
            string address = address_box.Text;
            string h_phone = homephone_box.Text;
            string c_phone = cellphone_box.Text;

            string std_id = id_box.Text;
            string std_class = class_combobox.Text;
            string tution_fees = tution_lbl.Text;
            string other_charges = other_lbl.Text;
            string discount = discount_box.Text;
            string total_amou = total_lbl.Text;
            string rec_num = receip_box.Text;

            string q = "insert into enrollment_details (s_firstname, s_middlename , s_lastname , birthdate , age , gender , birth_city ,birth_province , birth_region , p_firstname , p_lastname ,occupation , address , home_phone  ,cell_phone , std_id , std_class , tution_fees , other_charges , discount , total_amount , receipt_number)" +
                " values ('"+std_firstname+"','"+std_middlename+"','"+ std_lastname+"','"+birth_date+ "','" + age + "','" + gender + "','" + birth_city + "','" + birth_prov + "','" + birth_reg + "','" + p_firstname + "','" + p_lastname + "','" + occu + "','" + address + "','" + h_phone + "','" + c_phone + "','" + std_id + "','" + std_class + "','" + tution_fees + "','" + other_charges + "','" + discount + "','" + total_amou + "','" + rec_num+"')";
            if(SQLCMD.SQLExecute(q))
            {
                MetroFramework.MetroMessageBox.Show(this, "data saved!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                sfirstname_box.Text = "";
                slastname_box.Text = "";
                smiddlename_box.Text = "";
                birthdate_box.Text = "";
                age_box.Text = "";
                gender_combobox.Text = "";
                birthcity_box.Text = "";
                birthprovince_box.Text = "";
                birthregion_box.Text = "";
                pfirstname_box.Text = "";
                plastname_box.Text = "";
                occ_box.Text = "";
                address_box.Text = "";
                homephone_box.Text = "";
                cellphone_box.Text = "";
                id_box.Text = "";
                class_combobox.Text = "";
                tution_lbl.Text = "";
                other_lbl.Text = "";
                discount_box.Text = "";
                total_lbl.Text = "";
                receip_box.Text = "";
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "data not saved!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Discount_box_TextChanged(object sender, EventArgs e)
        {
            if (discount_box.Text=="")
            {
                total_lbl.Text = string.Format("{0:n0}", x + y);
            }
            else {
                try
                {
                    float d = Int32.Parse(discount_box.Text);
                    float a = d / 100 * (x + y);
                    float q = (x + y - (a));
                    total_lbl.Text = string.Format("{0:n0}", q);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
            }

        }

       

        private void Clr_btn_Click(object sender, EventArgs e)
        {
            sfirstname_box.Text="";
            slastname_box.Text = "";
            smiddlename_box.Text = "";
            birthdate_box.Text = "";
            age_box.Text = "";
            gender_combobox.Text = "";
            birthcity_box.Text = "";
            birthprovince_box.Text = "";
            birthregion_box.Text = "";
            pfirstname_box.Text = "";
            plastname_box.Text = "";
            occ_box.Text = "";
            address_box.Text = "";
            homephone_box.Text = "";
            cellphone_box.Text = "";
            id_box.Text = "";
            class_combobox.Text = "";
            tution_lbl.Text = "";
            other_lbl.Text = "";
            discount_box.Text = "";
            total_lbl.Text = "";
            receip_box.Text = "";
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

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }

        private void Age_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void Homephone_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void Cellphone_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void Discount_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}

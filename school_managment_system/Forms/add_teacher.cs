using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using school_managment_system.Functions;
using school_managment_system.Properties;

namespace school_managment_system.Forms
{
    public partial class add_teacher :MetroForm
    {
        public add_teacher()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            this.StyleManager.Theme = Settings.Default.Theme;
            this.StyleManager.Style = Settings.Default.Style;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string id =te_id_box.Text.Trim();
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

            string q = "insert into teachers_details(teacher_id,teacher_firstname,teacher_lastname,father_name,date_of_birth,age,qualification,subjects,salary,phone_no,classes_under)" +
                "values('"+ id + "','"+ f_name + "','"+ l_name + "','"+ father_name + "','"+ dob + "','"+ age + "','"+ qualif + "','"+ sub + "','"+ salary + "','"+ phone + "','"+ classes + "')";
            if (SQLCMD.SQLExecute(q))
            {
                Teachers te = new Teachers();
                MetroFramework.MetroMessageBox.Show(te, "Data succefully added!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Teachers te = new Teachers();
                MetroFramework.MetroMessageBox.Show(te, "data not saved!!!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Add_teacher_Load(object sender, EventArgs e)
        {
            te_id_box.Focus();
            add_btn.Enabled = false;
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

        private void Te_id_box_TextChanged(object sender, EventArgs e)
        {
            if (te_id_box.Text == "" || te_firstn_box.Text == "" || age_box.Text == "")
            {
                add_btn.Enabled = false;
            }
            else
            {
                add_btn.Enabled = true;
            }
        }

        private void Te_firstn_box_TextChanged(object sender, EventArgs e)
        {
            if (te_id_box.Text == "" || te_firstn_box.Text == "" || age_box.Text == "")
            {
                add_btn.Enabled = false;
            }
            else
            {
                add_btn.Enabled = true;
            }
        }

        private void Age_box_TextChanged(object sender, EventArgs e)
        {
            if (te_id_box.Text == "" || te_firstn_box.Text == ""||age_box.Text=="")
            {
                add_btn.Enabled = false;
            }
            else
            {
                add_btn.Enabled = true;
            }
        }
    }
}

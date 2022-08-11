using school_managment_system.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using school_managment_system.Slide_Panel;

namespace school_managment_system.Functions
{
    class SQLCMD
    {
        public static SqlConnection _conn = new SqlConnection();
        public static SqlCommand _cmd = new SqlCommand();
        public static SqlDataAdapter _adapter = new SqlDataAdapter();

        public static string constring
        {
            
            get
            {
              return "Data Source=" + Settings.Default.Server + ";Initial Catalog=" + Settings.Default.Database + ";User ID=" + Settings.Default.Username + ";Password=" + Settings.Default.Password + ";";
            }

        }
       

        public static bool TestConnection()
        {
            bool b = true;
            using (SqlConnection con = new SqlConnection(constring))
            {
                try
                {
                    con.Open();
                   
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    b = false;
                }
            }
            return b;
        }

        public static DataSet SQLDataset(string q)
        {
            SqlConnection Con = null;
            SqlCommand Command = null;
            SqlDataAdapter Adapter = null;
            
            DataSet ds = new DataSet();

            try
            {
                Con = new SqlConnection(constring);
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                try
                {
                    Command = new SqlCommand(q, Con);
                    Adapter = new SqlDataAdapter(Command);

                    Adapter.Fill(ds);
                    Con.Close();
                    Con = null;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Data set Error!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ds = null;
                    Adapter = null;
                    Con.Close();
                    Con = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Connection Error!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ds = null;
                Adapter = null;
                Con.Close();
                Con = null;
            }
           
            return ds;
        }

        public static DataTable SQLtable(string q)
        {
            SqlConnection Con = null;
            SqlCommand Command = null;
            SqlDataReader reader = null;

            DataTable dt = new DataTable();

            try
            {
                Con = new SqlConnection(constring);
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                try
                {
                    Command = new SqlCommand(q, Con);
                    reader = Command.ExecuteReader();

                    dt.Load(reader);
                    Con.Close();
                    Con = null;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Data set Error!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dt = null;
                    reader = null;
                    Con.Close();
                    Con = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Connection Error!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt = null;
                reader = null;
                Con.Close();
                Con = null;
            }

            return dt;
        }

        public static bool SQLExecute(string q)
        {
            SqlConnection Con = null;
            SqlCommand Command = null;
            SqlTransaction trans = null;
            bool Mode = false;

            try
            {
                Con = new SqlConnection(constring);
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                Command = new SqlCommand(q, Con);
                Command.ExecuteNonQuery();
                trans = Con.BeginTransaction(IsolationLevel.ReadCommitted);
                Command.Transaction = trans;
                try
                {
                    trans.Commit();
                    Mode = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Data Read Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    trans.Rollback();
                    Mode = false;
                }
                Con.Close();
                Con = null;
                Command = null;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Data Read Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Con.Close();
                Con = null;
                Command = null;
            }
            return Mode;
        }
    }
}

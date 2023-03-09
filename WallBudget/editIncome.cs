using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallBudget
{
    public partial class editIncome : Form
    {
        public string[] rowContents;
        MySqlConnection conn;

        public editIncome(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void editIncome_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                txtDesc.Text = rowContents[0];
                txtNet.Text = rowContents[1];
                txtGross.Text = rowContents[2];
                txtTithe.Text = rowContents[3];
                cmbStatus.Text = rowContents[4];

                loadStatusComboBox();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadStatusComboBox()
        {
            cmbStatus.Items.Add("PAID");
            cmbStatus.Items.Add("POSTED");
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                string[] newContents = new string[5];
                newContents[0] = txtDesc.Text;
                newContents[1] = txtNet.Text;
                newContents[2] = txtGross.Text;
                newContents[3] = txtTithe.Text;
                newContents[4] = cmbStatus.Text;
                for (int i = 0; i < newContents.Length; i++)
                {
                    if (i == 1 || i == 2 || i == 3)
                    {
                        if (newContents[i] == "")
                        {
                            newContents[i] = "0.0";
                        }

                    }
                    else
                    {
                        if (newContents[i] == "")
                        {
                            newContents[i] = "= Null";
                        }
                        else
                        {
                            newContents[i] = $"= '{newContents[i]}'";
                        }
                    }
                }

                //update based on Description, which is the Primary Key
                string sql = $"UPDATE income set Description {newContents[0]}, Net = {Convert.ToDouble(newContents[1])}, Gross = {Convert.ToDouble(newContents[2])}, Tithe = {Convert.ToDouble(newContents[3])}, Status {newContents[4]} WHERE Description = '{rowContents[0]}';";


                MySqlCommand update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                MessageBox.Show("Done!");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}

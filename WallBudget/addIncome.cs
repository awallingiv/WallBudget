using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WallBudget
{
    public partial class addIncome : Form
    {

        mainForm F = new mainForm();
        MySqlConnection conn;
        string tithePercent;

        public addIncome(MySqlConnection connection, string t)
        {
            InitializeComponent();
            this.conn = connection;            
            this.tithePercent = $".{t}";
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
                string[] values = new string[5];
                values[0] = txtDesc.Text;
                values[1] = txtNet.Text;
                values[2] = txtGross.Text;
                values[3] = txtTithe.Text;
                values[4] = cmbStatus.Text;

                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i] == "")
                    {
                        if (i == 0 || i == 4)
                        {
                            values[i] = "NULL";
                        }
                        else
                        {
                            values[i] = "0.0";
                        }
                    }
                    else
                    {
                        if (i == 0 || i == 4)
                        {
                            values[i] = $"'{values[i]}'";
                        }
                        else
                        {
                            //do nothing, leave the dbl a dbl
                        }
                    }
                }



                string sql = $"INSERT INTO income (Description, Net, Gross, Tithe, Status) VALUES ({values[0]}, {Convert.ToDouble(values[1])}, {Convert.ToDouble(values[2])}, {Convert.ToDouble(values[3])}, {values[4]})";
                //string sql = $"INSERT INTO income (Description, Net, Gross, Tithe, Status) VALUES ('{txtDesc.Text}', {Convert.ToDouble(txtNet.Text)}, '{Convert.ToDouble(txtGross.Text)}', '{Convert.ToDouble(txtTithe.Text)}', '{cmbStatus.Text}')";
                MySqlCommand update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();

                DialogResult response = MessageBox.Show("Success! Add Another?", "Add another entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                //clear fields
                if (response == DialogResult.Yes)
                {
                    txtDesc.Text = "Description";
                    txtNet.Text = "0.0";
                    txtGross.Text = "0.0";
                    txtTithe.Text = "0.0";
                    cmbStatus.Text = "SUBMITTED";

                }
                else
                {
                    this.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void addIncome_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                
                loadStatusComboBox();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadStatusComboBox()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("SUBMITTED");
            cmbStatus.Items.Add("POSTED");

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGross_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGross.Text == "")
                {
                    txtTithe.Text = "0.0";
                }
                double gross = Convert.ToDouble(txtGross.Text);
                double convertedTithe = Convert.ToDouble(tithePercent);
                double tithe = gross * convertedTithe;
                txtTithe.Text = Convert.ToString(tithe);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }
    }
}

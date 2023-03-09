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
    
    public partial class editUtility : Form
    {
        public string[] rowContents;
        MySqlConnection conn;

        public editUtility(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void editUtility_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                txtDesc.Text = rowContents[0];
                txtAmt.Text = rowContents[1];
                txtDate.Text = rowContents[2];
                txtNotes.Text = rowContents[3];
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

        private void cmbSubmit_Click(object sender, EventArgs e)
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
                newContents[1] = txtAmt.Text;
                newContents[2] = txtDate.Text;
                newContents[3] = txtNotes.Text;
                newContents[4] = cmbStatus.Text;
                for (int i = 0; i < newContents.Length; i++)
                {
                    if (i == 1)
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

                string sql = $"UPDATE utilities set Description {newContents[0]}, Amount = {Convert.ToDouble(newContents[1])}, Due {newContents[2]}, Notes {newContents[3]}, Status {newContents[4]} WHERE Description = '{rowContents[0]}';";


                //old one: string sql = $"UPDATE bills set Description ='{txtDesc.Text}', Amount = {Convert.ToDouble(txtAmt.Text)}, Due = '{txtDate.Text}', Notes = '{txtNotes.Text}', Status = '{cmbStatus.Text}' WHERE Description = '{rowContents[0]}';";
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

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

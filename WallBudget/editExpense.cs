using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WallBudget
{
    public partial class editExpense : Form
    {
        mainForm F = new mainForm();
        public string[] rowContents;
        MySqlConnection conn;
        public editExpense(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void editExpense_Load(object sender, EventArgs e)
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
                cmbCategory.Text = rowContents[4];
                
                //loadStatusComboBox();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string[] cellContents = new string[6];

                cellContents[0] = txtDesc.Text;
                cellContents[1] = txtAmt.Text;
                cellContents[2] = txtDate.Text;
                cellContents[3] = txtNotes.Text;
                cellContents[4] = cmbCategory.Text;
                cellContents[5] = rowContents[5];

                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                if (cellContents[1] == "")
                {
                    cellContents[1] = "0.0";
                }
                for (int i = 0; i < 5; i++)
                {

                    if (cellContents[i] == "")
                    {
                        cellContents[i] = "= Null";
                    }
                    else if (i == 1)
                    {
                        //do nothing we want the double left a double
                    }
                    else
                    {
                        cellContents[i] = $"= '{cellContents[i]}'";
                    }
                }

                try
                {
                    double dblAmount = Convert.ToDouble(cellContents[1]);

                    string sql = $"UPDATE expenses set Description {cellContents[0]}, Amount = {dblAmount}, Date {cellContents[2]}, Notes {cellContents[3]}, Category {cellContents[4]}, transID = '{DateTime.Now}' WHERE transID = '{cellContents[5]}';";
                    MySqlCommand update = new MySqlCommand(@sql, conn);
                    update.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

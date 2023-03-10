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
    public partial class addUtility : Form
    {
        MySqlConnection conn;

        public addUtility(MySqlConnection connection)
        {
            InitializeComponent();
            this.conn = connection;
        }

        private void addUtility_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string[] cellContents = new string[5];
                cellContents[0] = txtDesc.Text;
                cellContents[1] = txtAmt.Text;
                cellContents[2] = txtDate.Text;
                cellContents[3] = txtNotes.Text;
                cellContents[4] = cmbUtilityStatus.Text;

                if (cellContents[1] == "")
                {
                    cellContents[1] = "0.0";
                }
                for (int i = 0; i < 5; i++)
                {

                    if (cellContents[i] == "")
                    {
                        cellContents[i] = "Null";
                    }
                    else if (i == 1)
                    {
                        //do nothing we want the double left a double
                    }
                    else
                    {
                        cellContents[i] = $"'{cellContents[i]}'";
                    }
                }

                try
                {
                    double dblAmount = Convert.ToDouble(cellContents[1]);

                    string sql = $"INSERT INTO utilities VALUES ({cellContents[0]}, {dblAmount}, {cellContents[2]}, {cellContents[3]}, {cellContents[4]})";
                    MySqlCommand update = new MySqlCommand(@sql, conn);
                    update.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                DialogResult response = MessageBox.Show("Success! Add Another?", "Add another entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //clear fields
                if (response == DialogResult.Yes)
                {
                    txtDesc.Text = "Description";
                    txtAmt.Text = "0.0";
                    txtDate.Text = "15th";
                    txtNotes.Text = "auto";
                    cmbUtilityStatus.Text = "PAID";

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

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



            
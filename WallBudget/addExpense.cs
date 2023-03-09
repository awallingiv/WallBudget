using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WallBudget
{
    public partial class addExpense : Form
    {
        mainForm F = new mainForm();
        MySqlConnection conn;
        public addExpense(MySqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addExpense_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                txtDate.Text = DateTime.Now.ToString("MM/dd");
                loadCategoryComboBox();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadCategoryComboBox()
        {
            List<string> categories = new List<string>();
            categories = getCategories();
            foreach (string category in categories)
            {
                cmbCategory.Items.Add(category);
            }
        }

        public List<string> getCategories()
        {
            string sql = "SELECT DISTINCT CATEGORY FROM expenses";

            try
            {
                MySqlDataAdapter MyDa = new MySqlDataAdapter();
                MyDa.SelectCommand = new MySqlCommand(sql, conn);

                List<string> results = new List<string>();
                using (MySqlDataReader mySqlDataReader = MyDa.SelectCommand.ExecuteReader())
                {
                    while (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader.IsDBNull("Category"))
                        {
                            //results.Add
                            //for now dont do anything
                        }
                        else
                        {
                            results.Add((string)mySqlDataReader["Category"]);
                        }


                    }
                }
                return results;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

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
                //load fields into an array
                string[] cellContents = new string[5];
                cellContents[0] = txtDesc.Text;
                cellContents[1] = txtAmt.Text;
                cellContents[2] = txtDate.Text;
                cellContents[3] = txtNotes.Text;
                cellContents[4] = cmbCategory.Text;
                //cellContents[5] = $"{DateTime.Now}";

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
                
                string sql = $"INSERT INTO expenses (Description, Amount, Date, Notes, Category, transID) VALUES ({cellContents[0]}, {dblAmount}, {cellContents[2]}, {cellContents[3]}, {cellContents[4]}, '{DateTime.Now}')";
                MySqlCommand update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
                DialogResult response = MessageBox.Show("Success! Add Another?", "Add another entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    txtAmt.Text = "";
                    //txtDate.Text = "";//DateTime.Now.ToString("MM/dd");
                    txtDesc.Text = "";
                    txtNotes.Text = "";
                    cmbCategory.Text = "";

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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Mozilla;
using Org.BouncyCastle.Bcpg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WallBudget
{

    public partial class mainForm : Form
    {              
        public MySqlConnection conn;
        public List<string> cats = new List<string>();
        public string currentDBString = "abc";
        List<Label> labels = new List<Label>();
    public mainForm()
    {
        InitializeComponent();
    }
    public void Main()
    {
        cmbYear.Text = "2022";
        setMonthCombo();
        cmbMonth.SelectedItem = "October";
        string monthAndYear = $"{cmbMonth.Text}{cmbYear.Text}";
        setConnection(monthAndYear);
        mnuFixDates.Enabled = false;
        mnuFixTransID.Enabled = true;
        loadTooltips();
        loadDataGridViewProperties();
        try
        {            
                defaultMode();
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            
        }

        private void loadTooltips()
        {
            try
            {
                ToolTip addExpense = new ToolTip();
                addExpense.ShowAlways = true;
                addExpense.SetToolTip(cmdAddExpense, "Click to Add an Expense to the expense table.");
                ToolTip editExpense = new ToolTip();
                editExpense.ShowAlways = true;
                editExpense.SetToolTip(cmdEditExpense, "Click to Edit an Expense in the expense table.");
                ToolTip deleteExpense = new ToolTip();
                deleteExpense.ShowAlways = true;
                deleteExpense.SetToolTip(cmdDeleteExpense, "Click to Delete an Expense from the expense table.");
                ToolTip lblExpensesTip = new ToolTip();
                lblExpensesTip.ShowAlways = true;
                lblExpensesTip.SetToolTip(lblExpenses, "This table contains purchases throughout the month other than bills and utilities");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        private void setMonthCombo()
        {
            try
            {
                string year = cmbYear.Text;
                year = "2022";
                setConnection("validdata", true);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                //List<string> result = new List<string>();
                string sql = $"SELECT * FROM vd{year}";

                MySqlDataAdapter MyDa = new MySqlDataAdapter();
                MyDa.SelectCommand = new MySqlCommand(sql, conn);

                using (MySqlDataReader mySqlDataReader = MyDa.SelectCommand.ExecuteReader())
                {
                    while (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader.IsDBNull("Month"))
                        {
                            //results.Add
                            //for now dont do anything
                        }
                        else
                        {
                            cmbMonth.Items.Add((string)mySqlDataReader["Month"]);
                        }


                    }
                }
                                
                //cmbMonth.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }

        public void setConnection(string monthAndYear)
        {
            string dummyUser = "";
            string dummyPass = "";
            
            
            try
            {
                dummyUser = StringCypher.Decrypt(dummyUser);
                dummyPass = StringCypher.Decrypt(dummyPass);
                conn = new MySqlConnection($"server=192.168.1.72;user={dummyUser};database={monthAndYear};port=3306;password={dummyPass};SSL Mode=Required");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        public void setConnection(string db, Boolean flag)
        {
            string dummyUser = "";
            string dummyPass = "";
            
            try
            {
                if (flag == true)
                {
                    dummyUser = StringCypher.Decrypt(dummyUser);
                    dummyPass = StringCypher.Decrypt(dummyPass);
                    conn = new MySqlConnection($"server=192.168.1.72;user={dummyUser};database={db};port=3306;password={dummyPass};SSL Mode=Required");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        void loadDataGridViewProperties()
        {
            try
            {
                dgvIncome.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUtilities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvIncome.ReadOnly = true;
                dgvBills.ReadOnly = true;
                dgvExpenses.ReadOnly = true;
                dgvUtilities.ReadOnly = true;
                dgvBills.AllowUserToAddRows = false;
                dgvIncome.AllowUserToAddRows = false;
                dgvExpenses.AllowUserToAddRows = false;
                dgvUtilities.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        public void refreshEverything()
        {
            try
            {
                Console.WriteLine("Connecting to MySQL Database...");

                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
               

                //load data into tables
                loadIncome();
                loadBills();
                loadExpenses();
                loadUtilities();

                //handles getting categories, loading into category tables
                refreshAndLoadCategories();

                setTotalsTable();
                setTithe();
                getTotals();
                loadOverview();
                refreshTables();

                setTotals();

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
                Console.WriteLine("Done");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        private void setTotals()
        {
            string sql;
            double result;

            try
            {


                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                
                //tithe
                sql = "SELECT Total FROM totals where TableName = 'tithe';";
                result = getDoubleFromTbl(sql);
                lblTotalTitheVal.Text = Convert.ToString(result);

                //utilities
                sql = "SELECT Total FROM totals where TableName = 'utilities';";
                result = getDoubleFromTbl(sql);
                lblTotalUtilVal.Text = Convert.ToString(result);

                //bills
                sql = "SELECT Total FROM totals where TableName = 'bills';";
                result = getDoubleFromTbl(sql);
                lblTotalBillsVal.Text = Convert.ToString(result);

                //expenses
                sql = "SELECT Total FROM totals where TableName = 'expenses';";
                result = getDoubleFromTbl(sql);
                lblTotalExpensesVal.Text = Convert.ToString(result);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshTables()
        {
            try
            {
                dgvIncome.Refresh();
                dgvUtilities.Refresh();
                dgvBills.Refresh();
                dgvExpenses.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }

        
        private void setTithe()
        {
            try
            {
                string sql = "select sum(Tithe) from income WHERE status = 'POSTED'";
                double result = getDoubleFromTbl(sql);


                sql = $"update totals SET Total = '{result}' where TableName = 'Tithe'";
                MySqlCommand update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshAndLoadCategories()
        {
            try
            {
                cats = getCategoriesFromExpenses();
                List<double> data = updateCategoriesInDB(cats);

                //uncomment if you want to put info in a datagridview instead of labels
                //sql = "SELECT * FROM categories;";
                //loadTable(dgvCategories, sql);

                ////////////adding this for now we just one top ten categories, remove to go back
                List<string> topTen = getTopTenCategories();

                double result = 0;
                List<double> topData = new List<double>();
                string sql = "";
                foreach (var item in topTen)
                {
                    //grab total in category
                    sql = $"SELECT SUM(Amount) FROM expenses where Category = '{item}'";
                    result = getDoubleFromTbl(sql);
                    topData.Add(result);

                }
                if (topTen.Count > 0)
                {
                    //category names
                    lblCat1.Text = topTen[0].ToString();
                    lblCat2.Text = topTen[1].ToString();
                    lblCat3.Text = topTen[2].ToString();
                    lblCat4.Text = topTen[3].ToString();
                    lblCat5.Text = topTen[4].ToString();
                    lblCat6.Text = topTen[5].ToString();
                    lblCat7.Text = topTen[6].ToString();
                    lblCat8.Text = topTen[7].ToString();
                    lblCat9.Text = topTen[8].ToString();
                    lblCat10.Text = topTen[9].ToString();
                }

                if (topData.Count > 0)
                {
                    //values
                    lblCat1Val.Text = topData[0].ToString();
                    lblCat2Val.Text = topData[1].ToString();
                    lblCat3Val.Text = topData[2].ToString();
                    lblCat4Val.Text = topData[3].ToString();
                    lblCat5Val.Text = topData[4].ToString();
                    lblCat6Val.Text = topData[5].ToString();
                    lblCat7Val.Text = topData[6].ToString();
                    lblCat8Val.Text = topData[7].ToString();
                    lblCat9Val.Text = topData[8].ToString();
                    lblCat10Val.Text = topData[9].ToString();
                }

                //createCatLabels(cats, data);
                //createCatLabels(topTen, topData); //uncomment to generate labels but they are on panel and need to be fixed
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private List<string> getTopTenCategories()
        {
            List<string> topTenCats = new List<string>();
            string sql = "SELECT * FROM categories ORDER BY Total DESC LIMIT 10; ";

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
                            topTenCats.Add((string)mySqlDataReader["Category"]);
                        }


                    }
                }
                return topTenCats;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return topTenCats;
            }
        }



        private void loadUtilities()
        {
            try
            {
                string sql = "SELECT * FROM utilities;";
                loadTable(dgvUtilities, sql);
                dgvUtilities.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void loadIncome()
        {
            double result;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                string sql = "SELECT * FROM income;";
                loadTable(dgvIncome, sql);
               

                //not doing anything with this, taking it out temp.
                //sql = "SELECT Total FROM totals where TableName = 'income'";
                //result = getDoubleFromTbl(sql);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void loadBills()
        {
            try
            {
                string sql = "SELECT * FROM bills;";
                loadTable(dgvBills, sql);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        public void loadExpenses()
        {
            try
            {
                string sql = "SELECT * FROM expenses ORDER BY Date;";
                loadTable(dgvExpenses, sql);
                dgvExpenses.Columns["transID"].Visible = false;
                //dgvExpenses.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        void getTotals()
        {
            try
            {
                //set TotalIn
                //string sql = $"SELECT SUM(Net) FROM income";
                string sql = $"SELECT Total FROM totals Where TableName = 'Income'";
                double result = getDoubleFromTbl(sql);
                result = Math.Round(result, 2);
                sql = $"UPDATE overview SET Total_In = {result} WHERE ID = 1";
                MySqlCommand update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();

                //Set Total Out
                //sql = $"SELECT Sum1 + Sum2 + Sum3 + Sum4 as Total FROM (SELECT SUM(Amount) as Sum1 FROM monthlyrecurring) T1 CROSS JOIN (SELECT SUM(Amount) as Sum2 FROM monthlyspending) T2 CROSS JOIN (SELECT SUM(Amount) as Sum3 FROM utilities) T3 CROSS JOIN (SELECT Total as Sum4 FROM totals WHERE TableName = 'Tithe') T4";
                sql = $"SELECT SUM(Total) as Total FROM totals WHERE NOT (TableName = 'income')";
                result = getDoubleFromTbl(sql);
                result = Math.Round(result, 2);

                sql = $"UPDATE overview SET Total_Out = {result} WHERE ID = 1";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();

                //Set Leftover
                sql = $"SELECT Total_In - Total_out as Total FROM overview";
                result = getDoubleFromTbl(@sql);
                result = Math.Round(result, 2);
                sql = $"UPDATE overview SET Leftover = {result} WHERE ID = 1";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        List<double> updateCategoriesInDB(List<string> categories)
        {

            string sql = "";
            double result = 0;
            Int64 flag = 0;
            //string strResult;
            List<double> data = new List<double>();
            MySqlCommand update;


            try
            {
                int x = 0;
                foreach (var item in categories)
                {
                    //grab total in category
                    sql = $"SELECT SUM(Amount) FROM expenses where Category = '{item}'";
                    result = getDoubleFromTbl(sql);
                    data.Add(result);

                    //if exists in category table
                    sql = $"SELECT EXISTS (SELECT 1 FROM categories where Category = '{item}') as doesExist;";
                    flag = getInt64FromTbl(sql);
                    //statement returns 0 if a result is not found, 1 if found
                    if (flag == 0)
                    {
                        sql = $"INSERT INTO categories values('{item}', {result})";
                        update = new MySqlCommand(@sql, conn);
                        update.ExecuteNonQuery();
                    }
                    else //this should never get hit first time through because were using distinct categories
                    {
                        //flag should be 1
                        sql = $"UPDATE categories set Total = {result} where Category = '{item}'";
                        update = new MySqlCommand(@sql, conn);
                        update.ExecuteNonQuery();
                    }
                    x++;
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
                return data;
            }

        }

        void setTotalsTable()
        {
            string sql;
            double result = 0;

            try
            {
                List<string> rows = getTotalsTableNames();

                foreach (var item in rows)
                {
                    if (item.ToLower() == "income")
                    {
                        sql = $"SELECT SUM(Net) as Sum FROM {item}";
                        result = getDoubleFromTbl(sql);
                    }
                    else if (item.ToLower() == "tithe")
                    {
                        sql = $"SELECT SUM(Tithe) as Sum FROM income WHERE Status = 'Posted'";
                        result = getDoubleFromTbl(sql);
                    }
                    else if (item.ToLower() == "utilities")
                    {
                        sql = $"SELECT SUM(Amount) as Sum FROM {item} WHERE Status = 'Posted' or Status = 'Paid'";
                        result = getDoubleFromTbl(sql);
                    }
                    else if (item.ToLower() == "bills")
                    {
                        sql = $"SELECT SUM(Amount) as Sum FROM {item} WHERE Status = 'Posted' or Status = 'Paid'";
                        result = getDoubleFromTbl(sql);
                    }
                    else
                    {
                        sql = $"SELECT SUM(Amount) as Sum FROM {item}";
                        result = getDoubleFromTbl(sql);
                    }


                    sql = $"UPDATE totals SET TOTAL = {result} WHERE TableName = '{item}'";
                    MySqlCommand update = new MySqlCommand(@sql, conn);
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }


        double getDoubleFromTbl(string sql)
        {
            double result = 0;

            try
            {
                MySqlDataAdapter MyDa = new MySqlDataAdapter();
                MyDa.SelectCommand = new MySqlCommand(sql, conn);
                result = (double)MyDa.SelectCommand.ExecuteScalar();
                result = Math.Round(result);
            }
            catch (Exception ex)
            {
                //return 0;
                //MessageBox.Show(ex.Message);
            }
            return result;
        }

        Int64 getInt64FromTbl(string sql)
        {
            Int64 result = 0;

            try
            {
                MySqlDataAdapter MyDa = new MySqlDataAdapter();
                MyDa.SelectCommand = new MySqlCommand(sql, conn);
                result = (Int64)MyDa.SelectCommand.ExecuteScalar();                
            }
            catch (Exception ex)
            {
                //return 0;
                //MessageBox.Show(ex.Message);
            }
            return result;
        }


        List<string> getTotalsTableNames()
        {
            string sql = $"SELECT TableName FROM totals";

            try
            {
                MySqlDataAdapter MyDa = new MySqlDataAdapter();
                MyDa.SelectCommand = new MySqlCommand(sql, conn);

                List<string> results = new List<string>();
                using (MySqlDataReader mySqlDataReader = MyDa.SelectCommand.ExecuteReader())
                {
                    while (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader.IsDBNull("TableName"))
                        {
                            //results.Add
                            //for now dont do anything
                        }
                        else
                        {
                            results.Add((string)mySqlDataReader["TableName"]);
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

        void createCatLabels(List<string> categories, List<double> data)
        {

            //List<Label> datas = new List<Label>();

            List<double> newData = new List<double>();

            try
            {
                foreach (double item in data)
                {
                    double x = Math.Round(item, 2);
                    newData.Add(x);
                }
                int z = 220;
                int half = (categories.Count / 2);

                for (int x = 0; x < half; x++)
                {

                    var temp = new Label();
                    var temp1 = new Label();
                    temp.Text = $"{categories[x]}:";
                    temp1.Text = $"{newData[x]}";
                    //temp.Location = new Point(70, z);
                    temp.Location = new Point(0, z);
                    //temp1.Location = new Point(180, z);
                    temp1.Location = new Point(180, z);
                    temp.Click += new EventHandler(mainForm_Load);
                    temp1.Click += new EventHandler(mainForm_Load);
                    temp.BackColor = System.Drawing.Color.Transparent;
                    temp.Font = new Font("Calibri", 12, FontStyle.Bold);
                    //temp.ForeColor = System.Drawing.Color.White;
                    temp1.BackColor = System.Drawing.Color.Transparent;
                    temp1.Font = new Font("Calibri", 12, FontStyle.Bold);
                    //temp1.ForeColor = System.Drawing.Color.White;
                    //this.Controls.Add(temp);
                    panelCats.Controls.Add(temp);
                    //this.Controls.Add(temp1);
                    panelCats.Controls.Add(temp1);
                    temp.Show();
                    temp1.Show();
                    labels.Add(temp);
                    labels.Add(temp1);
                    temp1.BringToFront();
                    z += 40;
                }
                z = 220;

                for (int x = half; x < categories.Count; x++)
                {

                    var temp = new Label();
                    var temp1 = new Label();
                    temp.Text = $"{categories[x]}:";
                    temp1.Text = $"{newData[x]}";
                    temp.Location = new Point(350, z);
                    temp1.Location = new Point(480, z);
                    temp.Click += new EventHandler(mainForm_Load);
                    temp1.Click += new EventHandler(mainForm_Load);
                    temp.BackColor = System.Drawing.Color.Transparent;
                    temp.Font = new Font("Calibri", 12, FontStyle.Bold);
                    //temp.ForeColor = System.Drawing.Color.White;
                    temp1.BackColor = System.Drawing.Color.Transparent;
                    temp1.Font = new Font("Calibri", 12, FontStyle.Bold);
                    //temp1.ForeColor = System.Drawing.Color.White;
                    //this.Controls.Add(temp);
                    panelCats.Controls.Add(temp);
                    //this.Controls.Add(temp1);
                    panelCats.Controls.Add(temp1);
                    temp.Show();
                    temp1.Show();
                    labels.Add(temp);
                    labels.Add(temp1);
                    temp.BringToFront();
                    z += 40;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }

        public List<string> getCategoriesFromExpenses()
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

        public List<string> getStatuses()
        {
            string sql = "SELECT DISTINCT status FROM income";

            try
            {
                MySqlDataAdapter MyDa = new MySqlDataAdapter();
                MyDa.SelectCommand = new MySqlCommand(sql, conn);

                List<string> results = new List<string>();
                using (MySqlDataReader mySqlDataReader = MyDa.SelectCommand.ExecuteReader())
                {
                    while (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader.IsDBNull("Status"))
                        {
                            //results.Add
                            //for now dont do anything
                        }
                        else
                        {
                            results.Add((string)mySqlDataReader["Status"]);
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

        private void mainForm_Load(object sender, EventArgs e)
        {
            Main();
        }

        private void loadTable(DataGridView dgv, string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand(sql, conn);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;

                dgv.DataSource = bsource;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        private void loadOverview()
        {
            string sql = "SELECT * FROM overview;";
            string[] rowValue;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand(sql, conn);

                DataTable table = new DataTable();
                MyDA.Fill(table);


                //  dont use foreach because there should only be one row here:
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];

                    if (row != null)
                    {
                        string totalIn = row["Total_In"].ToString();
                        string totalOut = row["Total_out"].ToString();
                        string leftover = row["Leftover"].ToString();

                        lblInValue.Text = totalIn;
                        lblOutValue.Text = totalOut;
                        lblLeftValue.Text = leftover;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }


            //need to build a condition for if the table is empty

        }

        private void loadTotals(string sql)
        {
            //string[] rowValue;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MyDA.SelectCommand = new MySqlCommand(sql, conn);

                DataTable table = new DataTable();
                MyDA.Fill(table);


                foreach (DataRow row in table.Rows)
                {

                    //string totalIn = row["TotalIn"].ToString();
                    //string totalOut = row["TotalOut"].ToString();
                    //string leftover = row["LeftOver"].ToString();

                    //lblInValue.Text = totalIn;
                    //lblOutValue.Text = totalOut;
                    //lblLeftValue.Text = leftover;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                addExpense expenseForm = new addExpense(conn);
                expenseForm.ShowDialog();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darkMode();

        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lightMode();
        }

        private void grayModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            defaultMode();
        }

        void darkMode()
        {
            try
            {
                this.BackColor = Color.Black;

                dgvIncome.BackgroundColor = Color.Black;
                dgvIncome.ForeColor = Color.Black;
                dgvIncome.GridColor = Color.White;
                dgvIncome.DefaultCellStyle.BackColor = Color.Black;
                dgvIncome.DefaultCellStyle.ForeColor = Color.White;
                dgvIncome.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvIncome.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvIncome.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvIncome.RowHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvUtilities.BackgroundColor = Color.Black;
                dgvUtilities.ForeColor = Color.Black;
                dgvUtilities.GridColor = Color.White;
                dgvUtilities.DefaultCellStyle.BackColor = Color.Black;
                dgvUtilities.DefaultCellStyle.ForeColor = Color.White;
                dgvUtilities.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvUtilities.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvUtilities.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvUtilities.RowHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvBills.BackgroundColor = Color.Black;
                dgvBills.ForeColor = Color.Black;
                dgvBills.GridColor = Color.White;
                dgvBills.DefaultCellStyle.BackColor = Color.Black;
                dgvBills.DefaultCellStyle.ForeColor = Color.White;
                dgvBills.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvBills.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvBills.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvBills.RowHeadersDefaultCellStyle.ForeColor = Color.White;

                dgvExpenses.BackgroundColor = Color.Black;
                dgvExpenses.ForeColor = Color.Black;
                dgvExpenses.GridColor = Color.White;
                dgvExpenses.DefaultCellStyle.BackColor = Color.Black;
                dgvExpenses.DefaultCellStyle.ForeColor = Color.White;
                dgvExpenses.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvExpenses.RowHeadersDefaultCellStyle.BackColor = Color.Black;
                dgvExpenses.RowHeadersDefaultCellStyle.ForeColor = Color.White;

                lblTotalExpenses.ForeColor = Color.White;
                lblTotalBills.ForeColor = Color.White;
                lblTotalTithe.ForeColor = Color.White;
                lblTotalUtil.ForeColor = Color.White;

                lblTopTen.ForeColor = Color.White;
                lblCat1.ForeColor = Color.White;
                lblCat2.ForeColor = Color.White;
                lblCat3.ForeColor = Color.White;
                lblCat4.ForeColor = Color.White;
                lblCat5.ForeColor = Color.White;
                lblCat6.ForeColor = Color.White;
                lblCat7.ForeColor = Color.White;
                lblCat8.ForeColor = Color.White;
                lblCat9.ForeColor = Color.White;
                lblCat10.ForeColor = Color.White;

                foreach (Label item in labels)
                {
                    item.ForeColor = Color.White;
                }

                lblTotalIn.ForeColor = Color.White;
                lblTotalOut.ForeColor = Color.White;
                lblLeftover.ForeColor = Color.White;

                lblBills.ForeColor = Color.White;
                lblExpenses.ForeColor = Color.White;
                lblIncome.ForeColor = Color.White;
                lblUtilities.ForeColor = Color.White;                

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        void lightMode()
        {
            try
            {
                this.BackColor = SystemColors.Control;

                dgvIncome.BackgroundColor = SystemColors.Control;
                dgvIncome.ForeColor = SystemColors.Control;
                dgvIncome.GridColor = Color.Black;
                dgvIncome.DefaultCellStyle.BackColor = SystemColors.Control;
                dgvIncome.DefaultCellStyle.ForeColor = Color.Black;
                dgvIncome.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvIncome.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvIncome.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvIncome.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvUtilities.BackgroundColor = SystemColors.Control;
                dgvUtilities.ForeColor = SystemColors.Control;
                dgvUtilities.GridColor = Color.Black;
                dgvUtilities.DefaultCellStyle.BackColor = SystemColors.Control;
                dgvUtilities.DefaultCellStyle.ForeColor = Color.Black;
                dgvUtilities.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvUtilities.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvUtilities.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvUtilities.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvBills.BackgroundColor = SystemColors.Control;
                dgvBills.ForeColor = SystemColors.Control;
                dgvBills.GridColor = Color.Black;
                dgvBills.DefaultCellStyle.BackColor = SystemColors.Control;
                dgvBills.DefaultCellStyle.ForeColor = Color.Black;
                dgvBills.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvBills.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvBills.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvBills.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvExpenses.BackgroundColor = SystemColors.Control;
                dgvExpenses.ForeColor = SystemColors.Control;
                dgvExpenses.GridColor = Color.Black;
                dgvExpenses.DefaultCellStyle.BackColor = SystemColors.Control;
                dgvExpenses.DefaultCellStyle.ForeColor = Color.Black;
                dgvExpenses.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvExpenses.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgvExpenses.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

                lblTotalExpenses.ForeColor = Color.Black;
                lblTotalBills.ForeColor = Color.Black;
                lblTotalTithe.ForeColor = Color.Black;
                lblTotalUtil.ForeColor = Color.Black;

                lblTopTen.ForeColor = Color.Black;
                lblCat1.ForeColor = Color.Black;
                lblCat2.ForeColor = Color.Black;
                lblCat3.ForeColor = Color.Black;
                lblCat4.ForeColor = Color.Black;
                lblCat5.ForeColor = Color.Black;
                lblCat6.ForeColor = Color.Black;
                lblCat7.ForeColor = Color.Black;
                lblCat8.ForeColor = Color.Black;
                lblCat9.ForeColor = Color.Black;
                lblCat10.ForeColor = Color.Black;

                foreach (Label item in labels)
                {
                    item.ForeColor = Color.Black;
                }
                lblTotalIn.ForeColor = Color.Black;
                lblTotalOut.ForeColor = Color.Black;
                lblLeftover.ForeColor = Color.Black;

                lblBills.ForeColor = Color.Black;
                lblExpenses.ForeColor = Color.Black;
                lblIncome.ForeColor = Color.Black;
                lblUtilities.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        void defaultMode()
        {
            try
            {
                this.BackColor = SystemColors.ControlDarkDark;

                dgvIncome.BackgroundColor = SystemColors.ControlDarkDark;
                dgvIncome.ForeColor = SystemColors.ControlDarkDark;
                dgvIncome.GridColor = Color.Black;
                dgvIncome.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvIncome.DefaultCellStyle.ForeColor = Color.Black;
                dgvIncome.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvIncome.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvIncome.RowHeadersDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvIncome.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvUtilities.BackgroundColor = SystemColors.ControlDarkDark;
                dgvUtilities.ForeColor = SystemColors.ControlDarkDark;
                dgvUtilities.GridColor = Color.Black;
                dgvUtilities.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvUtilities.DefaultCellStyle.ForeColor = Color.Black;
                dgvUtilities.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvUtilities.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvUtilities.RowHeadersDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvUtilities.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvBills.BackgroundColor = SystemColors.ControlDarkDark;
                dgvBills.ForeColor = SystemColors.ControlDarkDark;
                dgvBills.GridColor = Color.Black;
                dgvBills.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvBills.DefaultCellStyle.ForeColor = Color.Black;
                dgvBills.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvBills.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvBills.RowHeadersDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvBills.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

                dgvExpenses.BackgroundColor = SystemColors.ControlDarkDark;
                dgvExpenses.ForeColor = SystemColors.ControlDarkDark;
                dgvExpenses.GridColor = Color.Black;
                dgvExpenses.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvExpenses.DefaultCellStyle.ForeColor = Color.Black;
                dgvExpenses.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvExpenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgvExpenses.RowHeadersDefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                dgvExpenses.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

                lblTotalExpenses.ForeColor = Color.Black;
                lblTotalBills.ForeColor = Color.Black;
                lblTotalTithe.ForeColor = Color.Black;
                lblTotalUtil.ForeColor = Color.Black;

                lblTopTen.ForeColor = Color.Black;
                lblCat1.ForeColor = Color.Black;
                lblCat2.ForeColor = Color.Black;
                lblCat3.ForeColor = Color.Black;
                lblCat4.ForeColor = Color.Black;
                lblCat5.ForeColor = Color.Black;
                lblCat6.ForeColor = Color.Black;
                lblCat7.ForeColor = Color.Black;
                lblCat8.ForeColor = Color.Black;
                lblCat9.ForeColor = Color.Black;
                lblCat10.ForeColor = Color.Black;

                foreach (Label item in labels)
                {
                    item.ForeColor = Color.Black;
                }
                lblTotalIn.ForeColor = Color.Black;
                lblTotalOut.ForeColor = Color.Black;
                lblLeftover.ForeColor = Color.Black;

                lblBills.ForeColor = Color.Black;
                lblExpenses.ForeColor = Color.Black;
                lblIncome.ForeColor = Color.Black;
                lblUtilities.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {

                int index = dgvExpenses.CurrentCell.RowIndex;
                DataGridViewRow row = dgvExpenses.Rows[index];
                string[] cellContents = new string[row.Cells.Count];
                string sql;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                for (int x = 0; x < row.Cells.Count; x++)
                {
                    DataGridViewCell cell = row.Cells[x];
                    cellContents[x] = cell.Value.ToString();
                }

                for (int x = 0; x < 5; x++)
                {
                    if (cellContents[x] == "")
                    {
                        if (x == 1)
                        {
                            cellContents[x] = "0.0";
                        }
                        else
                        {
                            cellContents[x] = "NULL";
                        }
                    }
                }
                sql = $"DELETE FROM expenses where transID = '{cellContents[5]}'";
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this row:\r\n Description = '{cellContents[0]}' amount = {cellContents[1]} date = '{cellContents[2]}' notes = '{cellContents[3]}' category = '{cellContents[4]}'", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MySqlCommand update = new MySqlCommand(@sql, conn);
                    update.ExecuteNonQuery();
                    refreshEverything();
                }
                else
                {
                    MessageBox.Show("Operation Cancelled");
                    conn.Close();
                }
                conn.Close();
                //dgvMonthlySpending.Rows.RemoveAt(index); shouoldnt actually need this because were going to delete from the DB and then refresh the DB
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void fixDates()
        {

            try
            {
                //string[] wrongDates = new string[10];
                if (conn != null && conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                for (int x = 1; x < 9; x++)
                {

                    string wrongDate = $"7/{x}";
                    string fixedDate = $"07/0{x}";
                    string sql = $"UPDATE expenses SET DATE = '{fixedDate}' where DATE = '{wrongDate}'";
                    MySqlCommand update = new MySqlCommand(@sql, conn);
                    update.ExecuteNonQuery();

                }
                for (int x = 10; x < 31; x++)
                {

                    string wrongDate = $"7/{x}";
                    string fixedDate = $"07/0{x}";
                    string sql = $"UPDATE expenses SET DATE = '{fixedDate}' where DATE = '{wrongDate}'";
                    MySqlCommand update = new MySqlCommand(@sql, conn);
                    update.ExecuteNonQuery();

                }
                conn.Close();
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        private void fixDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fixDates();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            refreshEverything();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                int index = dgvIncome.CurrentCell.RowIndex;
                DataGridViewRow row = dgvIncome.Rows[index];
                string[] cellContents = new string[row.Cells.Count];
                string sql;

                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                for (int x = 0; x < row.Cells.Count; x++)
                {
                    DataGridViewCell cell = row.Cells[x];
                    cellContents[x] = cell.Value.ToString();
                }

                //if it is null, change value to is NULL
                if (cellContents[4] == "= ''")
                {
                    cellContents[4] = "is NULL";
                }
                for (int x = 0; x < 5; x++)
                {
                    if (x == 1 || x == 2 || x == 3)
                    {
                        if (cellContents[x] == "")
                        {
                            cellContents[x] = "0.00";
                        }
                    }
                    else
                    {
                        if (cellContents[x] == "")
                        {
                            cellContents[x] = "is Null";
                        }
                        else
                        {
                            cellContents[x] = $"= '{cellContents[x]}'";
                        }
                    }
                }

                sql = $"DELETE FROM income where Description {cellContents[0]}";
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this row:\r\n Description = '{cellContents[0]}'\r\n Net = {cellContents[1]}\r\n Gross = '{cellContents[2]}'\r\n Tithe = '{cellContents[3]}'\r\n Status = '{cellContents[4]}'", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MySqlCommand update = new MySqlCommand(@sql, conn);
                    update.ExecuteNonQuery();
                    refreshEverything();
                }
                else
                {
                    MessageBox.Show("Operation Cancelled");
                    conn.Close();
                }
                conn.Close();
                //dgvMonthlySpending.Rows.RemoveAt(index); shouoldnt actually need this because were going to delete from the DB and then refresh the DB
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        private void cmdAddIncome_Click(object sender, EventArgs e)
        {
            string amt  = txtTithePercent.Text;
            try
            {
                addIncome incomeForm = new addIncome(conn, amt);
                incomeForm.ShowDialog();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void lblInValue_Click(object sender, EventArgs e)
        {

        }

        private void cmdAddBill_Click(object sender, EventArgs e)
        {
            try
            { 
                addBill billForm = new addBill(conn);
                billForm.ShowDialog();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        private void cmdDeleteBill_Click(object sender, EventArgs e)
        {

            try
            {
                int index = dgvBills.CurrentCell.RowIndex;
                DataGridViewRow row = dgvBills.Rows[index];
                string[] cellContents = new string[row.Cells.Count];
                string sql;

                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                for (int x = 0; x < row.Cells.Count; x++)
                {
                    DataGridViewCell cell = row.Cells[x];
                    cellContents[x] = cell.Value.ToString();
                }
                //set cell contents[4] to have its own quotes in case it is null
                //cellContents[4] = $"= '{cellContents[4]}'";
                ////if it is null, change value to is NULL
                //if (cellContents[4] == "= ''")
                //{
                //    cellContents[4] = "is NULL";
                //}
                for (int x = 0; x < cellContents.Length; x++)
                {
                    if (x == 1)
                    {
                        cellContents[x] = $"= {cellContents[x]}";
                    }
                    else
                    {
                        cellContents[x] = $"= '{cellContents[x]}'";
                    }

                    //for text
                    //if it is null, change value to is NULL
                    if (cellContents[x] == "= ''")
                    {
                        cellContents[x] = "is NULL";
                    }


                }



                //description, amouunt, date, notes, category
                sql = $"DELETE FROM bills where Description {cellContents[0]} and Amount {cellContents[1]} and Due {cellContents[2]} and Notes {cellContents[3]} and Status {cellContents[4]}";
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this row:\r\n Description = '{cellContents[0]}'\r\n Amount = {cellContents[1]}\r\n Due Date = '{cellContents[2]}'\r\n Notes = '{cellContents[3]}'\r\n Status = '{cellContents[4]}'", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MySqlCommand update = new MySqlCommand(@sql, conn);
                    update.ExecuteNonQuery();
                    refreshEverything();
                }
                else
                {
                    MessageBox.Show("Operation Cancelled");
                    conn.Close();
                }
                conn.Close();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void newMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newMonthButton();
        }
        private void newMonthButton()
        {
            try
            {
                string tempPath = Path.GetTempPath();
                string file = $"{tempPath}WallBudgetTemp.sql";

                exportToFile(file);

                createNewMonth(file);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        private int convertMonthStringToInt(string month)
        {
            int result = 0;

            switch (month)
            {
                case "January":
                    result = 1;
                    break;

                case "February":
                    result = 2;
                    break;

                case "March":
                    result = 3;
                    break;

                case "April":
                    result = 4;
                    break;

                case "May":
                    result = 5;
                    break;

                case "June":
                    result = 6;
                    break;

                case "July":
                    result = 7;
                    break;

                case "August":
                    result = 8;
                    break;

                case "September":
                    result = 9;
                    break;

                case "October":
                    result = 10;
                    break;

                case "November":
                    result = 11;
                    break;

                case "December":
                    result = 12;
                    break;

            }

            return result;
        }

        private string convertMonthIntToString(int month)
        {
            string result = "";

            switch (month)
            {
                case 1:
                    result = "January";
                    break;

                case 2:
                    result = "February";
                    break;

                case 3:
                    result = "March";
                    break;

                case 4:
                    result = "April";
                    break;

                case 5:
                    result = "May";
                    break;

                case 6:
                    result = "June";
                    break;

                case 7:
                    result = "July";
                    break;

                case 8:
                    result = "August";
                    break;

                case 9:
                    result = "September";
                    break;

                case 10:
                    result = "October";
                    break;

                case 11:
                    result = "November";
                    break;

                case 12:
                    result = "December";
                    break;

            }

            return result;
        }


        private string getNewMonth()
        {
            string nextMonth;
            try
            {
                int month = convertMonthStringToInt(cmbMonth.Text);
                month++;
                nextMonth = convertMonthIntToString(month);
                return nextMonth;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private void createNewMonth(string filename)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string sql = "";
                string file = filename;
                string month = getNewMonth();
                string year = cmbYear.Text;
                /////////////////////////////////////////////////
                //// create new table for next month
                //// then import from file
                ////
                string schema = $"{month}{year}";

                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                sql = $"DROP SCHEMA IF EXISTS `{schema}`;";
                MySqlCommand update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                sql = $"CREATE SCHEMA `{schema}`;";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                sql = $"USE `{schema}`;";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                conn.Close();


                setConnection($"{month}{year}");


                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(file);
                            conn.Close();
                        }
                    }
                }

                /////
                ///// once now tables are there
                ///// delete * from tables monthlyspending and income
                ///// delete all from income but create br it will fail to load
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                sql = "TRUNCATE TABLE expenses; TRUNCATE TABLE categories;";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                //sql = "UPDATE income SET Net = Null; UPDATE income SET Gross = Null; UPDATE income SET Tithe = Null; UPDATE income SET Status = Null;";
                sql = $"TRUNCATE TABLE income;";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                sql = "UPDATE bills SET Status = Null;";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                sql = "UPDATE utilities SET Status = Null;";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                sql = "UPDATE totals SET Total = 0;";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();
                sql = "UPDATE overview SET Total_In = 0; UPDATE overview SET Total_out = 0; UPDATE overview SET Leftover = 0;";
                update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();


                addToVDData(month, year);


                lblInValue.Text = "0";
                lblOutValue.Text = "0";
                lblLeftValue.Text = "0";
                cmbYear.Text = $"{year}";
                cmbMonth.Items.Add($"{month}");//this will set connection and reload everything
                cmbMonth.SelectedItem = month;

                resetCategoryLabels();

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        private void exportToFile(string filename)
        {

            string file = filename;

            //if (conn.State != ConnectionState.Open)
            //{
            //    conn.Close();
            //    conn.Open();
            //}
            try
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }
        private void addTransID()
        {
            DateTime dt;
            string date;
            MySqlCommand update;

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                //string sql = $"UPDATE monthlyspending SET transID = '{DateTime.Now}' where transID is NULL";
                List<List<string>> rows = getTransIDs();

                for (int i = 0; i < rows.Count; i++)
                {
                    List<string> row = rows[i];
                    if (row[5] == "")
                    {
                        date = getRandomDate();
                        string sql = $"UPDATE expenses SET transID = '{date}' WHERE Description = '{row[0]}' and Amount = {row[1]};";
                        update = new MySqlCommand(@sql, conn);
                        update.ExecuteNonQuery();
                    }

                }

                


                conn.Close();
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        private string getRandomDate()
        {
            //    example format '2022-10-07 12:00:00'                      
            Thread.Sleep(1000);
            //create datetime object
            DateTime dt = DateTime.Now;

            //format DateTime and put in string
            string result = dt.ToString("yyyy-MM-dd HH:mm:ss");

            //return string
            return result;

        }

        private void fixTransactinIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTransID();
        }

        public List<List<string>> getTransIDs()
        {

            
            string sql = "SELECT *  FROM expenses where transID is NULL";

            try
            {
                MySqlDataAdapter MyDa = new MySqlDataAdapter();
                MyDa.SelectCommand = new MySqlCommand(sql, conn);

                List<List<string>> rows = new List<List<string>>();

                using (MySqlDataReader mySqlDataReader = MyDa.SelectCommand.ExecuteReader())
                {
                    while (mySqlDataReader.Read())
                    {
                        //rowzData newRow = new rowzData();
                        //rowzData.Description = (string)mySqlDataReader["Description"];
                        List<string> element = new List<string>();
                        element.Add(Convert.ToString(mySqlDataReader["Description"]));
                        element.Add(Convert.ToString(mySqlDataReader["Amount"]));
                        element.Add(Convert.ToString(mySqlDataReader["Date"]));
                        element.Add(Convert.ToString(mySqlDataReader["Notes"]));
                        element.Add(Convert.ToString(mySqlDataReader["Category"]));
                        element.Add(Convert.ToString(mySqlDataReader["transID"]));
                        rows.Add(element);

                    }
                }
                return rows;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        private void resetCategoryLabels()
        {
            lblCat1Val.Text = "0";
            lblCat2Val.Text = "0";
            lblCat3Val.Text = "0";
            lblCat4Val.Text = "0";
            lblCat5Val.Text = "0";
            lblCat6Val.Text = "0";
            lblCat7Val.Text = "0";
            lblCat8Val.Text = "0";
            lblCat9Val.Text = "0";
            lblCat10Val.Text = "0";
            lblCat1.Text = "1. Category";
            lblCat2.Text = "2. Category";
            lblCat3.Text = "3. Category";
            lblCat4.Text = "4. Category";
            lblCat5.Text = "5. Category";
            lblCat6.Text = "6. Category";
            lblCat7.Text = "7. Category";
            lblCat8.Text = "8. Category";
            lblCat9.Text = "9. Category";
            lblCat10.Text = "10. Category";
        }
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbMonth.Text == "July" & cmbYear.Text == "2022")
            //{

            //    conn = new MySqlConnection($"server=192.168.1.72;user=BudgetApp;database=july22;port=3306;password=WallBudge22#");
            //    refreshEverything();
            //}
            //else if (cmbMonth.Text == "August" & cmbYear.Text == "2022")
            //{
            //    conn = new MySqlConnection("server=192.168.1.72;user=BudgetApp;database=aug22;port=3306;password=WallBudge22#");
            //    refreshEverything();
            //}
            //else if (cmbMonth.Text == "September" & cmbYear.Text == "2022")
            //{
            //    conn = new MySqlConnection("server=192.168.1.72;user=BudgetApp;database=september22;port=3306;password=WallBudge22#");
            //    refreshEverything();
            //}
            string monthAndYear = $"{cmbMonth.Text}{cmbYear.Text}";
            setConnection(monthAndYear);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }
                resetCategoryLabels();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEditExpense_Click(object sender, EventArgs e)
        {

            try
            {
                int index = dgvExpenses.CurrentCell.RowIndex;
                DataGridViewRow row = dgvExpenses.Rows[index];
                string[] cellContents = new string[row.Cells.Count];
                string sql;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                for (int x = 0; x < row.Cells.Count; x++)
                {
                    DataGridViewCell cell = row.Cells[x];
                    cellContents[x] = cell.Value.ToString();
                }

                editExpense editExpenseForm = new editExpense(conn);
                editExpenseForm.rowContents = cellContents;
                editExpenseForm.ShowDialog();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbEditBill_Click(object sender, EventArgs e)
        {

            try
            {
                int index = dgvBills.CurrentCell.RowIndex;
                DataGridViewRow row = dgvBills.Rows[index];
                string[] cellContents = new string[row.Cells.Count];


                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                for (int x = 0; x < row.Cells.Count; x++)
                {
                    DataGridViewCell cell = row.Cells[x];
                    cellContents[x] = cell.Value.ToString();
                }

                editBill editBillForm = new editBill(conn);
                editBillForm.rowContents = cellContents;
                editBillForm.ShowDialog();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEditIncome_Click(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        //private void setTithe()
        //{

        //}

        private void addToVDData(string month, string year)
        {
            try
            {
                //set connection:
                setConnection("validdata", true);

                //test connection
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                //create string
                string sql = $"INSERT INTO vd{year} Values('{month}');";

                //add month to year table
                MySqlCommand update = new MySqlCommand(@sql, conn);
                update.ExecuteNonQuery();

                //set connection back to what it was
                string monthAndYear = $"{cmbMonth.Text}{cmbYear.Text}";
                setConnection(monthAndYear);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdEditIncome_Click(object sender, EventArgs e)
        {

            try
            {
                int index = dgvIncome.CurrentCell.RowIndex;
                DataGridViewRow row = dgvIncome.Rows[index];
                string[] cellContents = new string[row.Cells.Count];

                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                for (int x = 0; x < row.Cells.Count; x++)
                {
                    DataGridViewCell cell = row.Cells[x];
                    cellContents[x] = cell.Value.ToString();
                }

                editIncome editIncomeForm = new editIncome(conn);
                editIncomeForm.rowContents = cellContents;
                editIncomeForm.ShowDialog();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            try
            {
                addUtility utilityForm = new addUtility(conn);
                utilityForm.ShowDialog();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDeleteUtility_Click(object sender, EventArgs e)
        {

            try
            {
                int index = dgvUtilities.CurrentCell.RowIndex;
                DataGridViewRow row = dgvUtilities.Rows[index];
                string[] cellContents = new string[row.Cells.Count];
                string sql;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                for (int x = 0; x < row.Cells.Count; x++)
                {
                    DataGridViewCell cell = row.Cells[x];
                    cellContents[x] = cell.Value.ToString();
                }
                //set cell contents[4] to have its own quotes in case it is null
                //cellContents[4] = $"= '{cellContents[4]}'";
                ////if it is null, change value to is NULL
                //if (cellContents[4] == "= ''")
                //{
                //    cellContents[4] = "is NULL";
                //}
                for (int x = 0; x < cellContents.Length; x++)
                {
                    if (x == 1)
                    {
                        cellContents[x] = $"= {cellContents[x]}";
                    }
                    else
                    {
                        cellContents[x] = $"= '{cellContents[x]}'";
                    }

                    //for text
                    //if it is null, change value to is NULL
                    if (cellContents[x] == "= ''")
                    {
                        cellContents[x] = "is NULL";
                    }


                }


                //description, amouunt, date, notes, category
                sql = $"DELETE FROM utilities where Description {cellContents[0]} and Amount {cellContents[1]} LIMIT 1";
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this row:\r\n Description = '{cellContents[0]}'\r\n Amount = {cellContents[1]}\r\n Due Date = '{cellContents[2]}'\r\n Notes = '{cellContents[3]}'\r\n Status = '{cellContents[4]}'", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MySqlCommand update = new MySqlCommand(@sql, conn);
                    update.ExecuteNonQuery();
                    refreshEverything();
                }
                else
                {
                    MessageBox.Show("Operation Cancelled");
                    conn.Close();
                }
                conn.Close();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            try
            {
                int index = dgvUtilities.CurrentCell.RowIndex;
                DataGridViewRow row = dgvUtilities.Rows[index];
                string[] cellContents = new string[row.Cells.Count];


                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                    conn.Open();
                }

                for (int x = 0; x < row.Cells.Count; x++)
                {
                    DataGridViewCell cell = row.Cells[x];
                    cellContents[x] = cell.Value.ToString();
                }

                editUtility editUtilityForm = new editUtility(conn);
                editUtilityForm.rowContents = cellContents;
                editUtilityForm.ShowDialog();
                refreshEverything();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void lblCat5_Click(object sender, EventArgs e)
        {

        }

        private void cmbSetTithe_Click(object sender, EventArgs e)
        {
            
            DialogResult dResult;
            string temp = txtTithePercent.Text.Replace("%", "");
            temp = temp.Insert(0, ".");
            double tithePercent = Convert.ToDouble(temp);
            double result;
            string sql;


            try
            {
                dResult = MessageBox.Show("This is used to update all tithe fields. This is irreversible. Continue?", "Adjust all tithe?", MessageBoxButtons.YesNo);
                if (dResult == DialogResult.Yes)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Open();
                    }

                    //(hopefully) load all the contents of the dgv into a temporary array and then use that to
                    //make updates to sql table
                    foreach (DataGridViewRow row in dgvIncome.Rows)
                    {
                        string[] cellContents = new string[row.Cells.Count];

                        for (int x = 0; x < row.Cells.Count; x++)
                        {
                            DataGridViewCell cell = row.Cells[x];
                            cellContents[x] = cell.Value.ToString();
                        }
                        //now cellContents should be full, lets do some operations
                        //sql = $"SELECT Gross from income where Description = '{cellContents[0]}'";
                        //result = getDoubleFromTbl(sql);
                        //were just using the cellContents but comment this out and uncomment above ^ to use sql data (result should be the same but this way we do one less query)
                        result = Convert.ToDouble(cellContents[2]);
                        result = result * tithePercent;
                        result = Math.Round(result, 2);
                        //we got the juice, now lets set it in the Tithe Column
                        sql = $"UPDATE income SET Tithe = {result} WHERE Description = '{cellContents[0]}'";
                        MySqlCommand update = new MySqlCommand(@sql, conn);
                        update.ExecuteNonQuery();

                    }
                    conn.Close();
                    refreshEverything();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        private void exportAllDBsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string tempPath = Path.GetTempPath();

            Cursor.Current = Cursors.WaitCursor;

            string filename = $"{tempPath}July2022.sql";
            setConnection("July2022");
            exportToFile(filename);

            filename = $"{tempPath}August2022.sql";
            setConnection("August2022");
            exportToFile(filename);

            filename = $"{tempPath}September2022.sql";
            setConnection("September2022");
            exportToFile(filename);

            filename = $"{tempPath}October2022.sql";
            setConnection("October2022");
            exportToFile(filename);

            filename = $"{tempPath}November2022.sql";
            setConnection("November2022");
            exportToFile(filename);

            filename = $"{tempPath}validdata.sql";
            setConnection("validdata");
            exportToFile(filename);



            Cursor.Current = Cursors.Default;
        }

        private void tableCreatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableCreation newForm = new TableCreation();
            newForm.Show();
        }
    }

}

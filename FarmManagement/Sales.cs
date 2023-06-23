using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FarmManagement
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            SalesTimer1.Start();
            showSalesTable();
            fillCusID();
            fillCattleID();
        }
        int key = 0;

        public static string orderId;

        public static string showOrderID
        {
            get => orderId;
            set => orderId = value;
        }

        SqlConnection sales = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");
        private void fillCusID()
        {
            sales.Open();
            SqlCommand cmd = new SqlCommand("select CusID from CusTable", sales);
            SqlDataReader dReader;
            dReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CusID", typeof(int));
            dt.Load(dReader);
            SalesCusIDComboBox.ValueMember = "CusID";
            SalesCusIDComboBox.DataSource = dt;
            sales.Close();
        }

        private void fillCattleID()
        {
            sales.Open();
            SqlCommand cmd2 = new SqlCommand("select Tag from CattleTable", sales);
            SqlDataReader dReader2;
            dReader2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Tag", typeof(int));
            dt2.Load(dReader2);
            SalesTagComboBox.ValueMember = "Tag";
            SalesTagComboBox.DataSource = dt2;
            sales.Close();
        }

        private void SalesExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SalesTimer1_Tick(object sender, EventArgs e)
        {
            SalesTimeLabel.Text = DateTime.Now.ToLongTimeString();
            SalesDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            this.AcceptButton = SalesSaveButton;
        }

        private void MPortalHomeIcon_Click_1(object sender, EventArgs e)
        {
            ManagerPortal obj = new ManagerPortal();
            obj.Show();
            this.Hide();
        }

        private void MPortalHomeLabel_Click_1(object sender, EventArgs e)
        {
            ManagerPortal obj = new ManagerPortal();
            obj.Show();
            this.Hide();
        }

        private void SalesTotalPriceTB_Leave(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(SalesQuantityTB.Text) * Convert.ToInt32(SalesUnitPriceTB.Text);
            SalesTotalPriceTB.Text = "" + total;
        }

        private void SalesDBDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SalesCusIDComboBox.SelectedValue = SalesDBDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            SalesTagComboBox.SelectedValue = SalesDBDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            SalesQuantityTB.Text = SalesDBDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            SalesUnitPriceTB.Text = SalesDBDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            SalesTotalPriceTB.Text = SalesDBDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            
            if (SalesQuantityTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(SalesDBDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void SalesSaveButton_Click(object sender, EventArgs e)
        {
            if (SalesQuantityTB.Text == "" || SalesUnitPriceTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    sales.Open();

                    if (sales.State == ConnectionState.Open)
                    {
                        string Query = "insert into SalesTable values('" + SalesCusIDComboBox.SelectedValue.ToString() + "', '" + SalesTagComboBox.SelectedValue.ToString() + "','" + SalesQuantityTB.Text.Replace("'", "''") + "', '" + SalesUnitPriceTB.Text.Replace("'", "''") + "', '" + SalesTotalPriceTB.Text.Replace("'", "''") + "', '"+ SalesDateTimePicker.Value.Date+"')";
                        SqlCommand salesCommand = new SqlCommand(Query, sales);
                        salesCommand.ExecuteNonQuery();
                        MessageBox.Show("Detailes added successfully!", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        sales.Close();
                    }

                    //orderId 
                    //refreshEmpPage();
                    showSalesTable();
                    clearButtonFunc();

                    sales.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sales.Close();
                }
            }
        }
        private void clearButtonFunc()
        {
            SalesQuantityTB.Text = "";
            SalesUnitPriceTB.Text = "";
            SalesTotalPriceTB.Text = "";
        }

        private void RefreshSalesPage()
        {
            Sales obj = new Sales();
            obj.Show();
            this.Hide();
        }
        private void SalesClearButton_Click(object sender, EventArgs e)
        {
            clearButtonFunc();
        }

        private void SalesRefreshButton_Click(object sender, EventArgs e)
        {
            RefreshSalesPage();
        }

        private void showSalesTable()
        {
            sales.Open();
            string Query = "select * from SalesTable";
            SqlDataAdapter salesSda = new SqlDataAdapter(Query, sales);
            SqlCommandBuilder salesScb = new SqlCommandBuilder(salesSda);
            var salesDs = new DataSet();
            salesSda.Fill(salesDs);
            SalesDBDataGrid.DataSource = salesDs.Tables[0];

            sales.Close();
        }
        private void SalesUpdateButton_Click(object sender, EventArgs e)
        {
            if (SalesQuantityTB.Text == "" || SalesUnitPriceTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    sales.Open();

                    if (sales.State == ConnectionState.Open)
                    {
                        string Query = "update SalesTable set CustomerID=('" + SalesCusIDComboBox.SelectedValue.ToString() + "', Tag='" + SalesTagComboBox.SelectedValue.ToString() + "', Quantity='" + SalesQuantityTB.Text.Replace("'", "''") + "', UnitPrice='" + SalesUnitPriceTB.Text + "', TotalPrice='" + SalesTotalPriceTB.Text + "', Date = '" + SalesDateTimePicker.Value.Date + "')";
                        SqlCommand salesCommand = new SqlCommand(Query, sales);
                        salesCommand.ExecuteNonQuery();
                        MessageBox.Show("Detailes has been updated successfully!", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        sales.Close();
                    }

                    //refreshEmpPage();
                    showSalesTable();
                    clearButtonFunc();

                    sales.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sales.Close();
                }
            }
        }

        private void SalesDeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Nothing selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    sales.Open();

                    if (sales.State == ConnectionState.Open)
                    {
                        string Query = "delete from SalesTable where OrderID = "+ key +"";
                        SqlCommand salesCommand = new SqlCommand(Query, sales);
                        salesCommand.ExecuteNonQuery();
                        MessageBox.Show("Detailes has been deleted successfully!", "Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        sales.Close();
                    }


                    //refreshEmpPage();
                    showSalesTable();
                    clearButtonFunc();

                    sales.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sales.Close();
                }
            }
        }

        private void SalesSearchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sales.Open();
                if (sales.State == ConnectionState.Open)
                {
                    string Query = "select * from SalesTable where OrderID like '" + SalesSearchTB.Text + "%'";
                    SqlCommand salesCommand = new SqlCommand(Query, sales);
                    SqlDataAdapter salesSda = new SqlDataAdapter(Query, sales);
                    DataTable dt = new DataTable();
                    salesSda.Fill(dt);
                    SalesDBDataGrid.DataSource = dt;

                    sales.Close();
                }
                sales.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sales.Close();
            }
        }
    }
}

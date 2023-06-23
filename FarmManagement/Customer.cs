using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FarmManagement
{
    public partial class Customer : Form
    {
        SqlConnection cus = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");
        int key = 0;

        public Customer()
        {
            InitializeComponent();
            CusTimer1.Start();
            showCusTable();
        }
        private void customer_Load(object sender, EventArgs e)
        {
            this.AcceptButton = CusSaveButton;
        }
        private void showCusTable()
        {
            cus.Open();
            string Query = "select * from CusTable";
            SqlDataAdapter cusSda = new SqlDataAdapter(Query, cus);
            SqlCommandBuilder cusScb = new SqlCommandBuilder(cusSda);
            var cusDs = new DataSet();
            cusSda.Fill(cusDs);
            CusDBDataGrid.DataSource = cusDs.Tables[0];

            cus.Close();
        }
        private void CusTimer1_Tick(object sender, EventArgs e)
        {
            CusDateLabel.Text = DateTime.Now.ToLongDateString();
            CusTimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void CusExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /*public static string cusName;

        public static string showCusName
        {
            get => cusName;
            set => cusName = value;
        }*/
        private void refreshCusPage()
        {
            Customer obj = new Customer();
            obj.Show();
            this.Hide();
        }
        private void CusRefreshButton_Click(object sender, EventArgs e)
        {
            refreshCusPage();
        }
        private void MPortalHomeIcon_Click(object sender, EventArgs e)
        {
            ManagerPortal obj = new ManagerPortal();
            obj.Show();
            this.Hide();
        }
        private void MPortalHomeLabel_Click(object sender, EventArgs e)
        {

            ManagerPortal obj = new ManagerPortal();
            obj.Show();
            this.Hide();
        }
        private void CusClearButton_Click(object sender, EventArgs e)
        {
            CusNameTB.Text = "";
            CusContact1TB.Text = "";
            CusContact2TB.Text = "";
            CusCardNoTB.Text = "";
            CusAddressTB.Text = "";
        }
        private void CusSaveButton_Click(object sender, EventArgs e)
        {
            if(CusNameTB.Text == "" || CusContact1TB.Text == "" || CusContact2TB.Text == "" || CusCardNoTB.Text == "" || CusAddressTB.Text == "" )
            {
                MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    cus.Open();

                    if (cus.State == ConnectionState.Open)
                    {
                        string Query = "insert into CusTable values('"+CusNameTB.Text.Replace("'","''")+"', '"+CusContact1TB.Text.Replace("'","''")+"','"+CusContact2TB.Text.Replace("'", "''")+"','"+CusCardNoTB.Text.Replace("'", "''")+"','"+CusAddressTB.Text.Replace("'", "''")+"')";
                        SqlCommand cusCommand = new SqlCommand(Query, cus);
                        cusCommand.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully!", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cus.Close();
                    }
                    //refreshCusPage();
                    showCusTable();
                        

                    cus.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cus.Close();
                }

            }
        }

        private void CusUpdateButton_Click(object sender, EventArgs e)
        {
            if (CusNameTB.Text == "" || CusContact1TB.Text == "" || CusContact2TB.Text == "" || CusCardNoTB.Text == "" || CusAddressTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(MessageBox.Show("Are you sure want to update?", "Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cus.Open();

                        if (cus.State == ConnectionState.Open)
                        {
                            string Query = "update CusTable set CusName='" + CusNameTB.Text.Replace("'", "''") + "',  CusContactNumber1='" + CusContact1TB.Text.Replace("'", "''") + "', CusContactNumber2='" + CusContact2TB.Text.Replace("'", "''") + "', CusCardNumber='" + CusCardNoTB.Text.Replace("'", "''") + "',CusAddress='" + CusAddressTB.Text.Replace("'", "''") + "' where CusID = "+ key + ";";
                            SqlCommand cusCommand = new SqlCommand(Query, cus);
                            cusCommand.ExecuteNonQuery();
                            MessageBox.Show("Customer details has been updated successfully!", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cus.Close();
                        }


                       // refreshCusPage();
                        showCusTable();


                        cus.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cus.Close();
                    }
                }
            }
        }

        private void CusDeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("No rows selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete??", "Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cus.Open();

                        if (cus.State == ConnectionState.Open)
                        {
                            string Query = "delete from CusTable where CusID=" + key+ ";" ;
                            SqlCommand cusCommand = new SqlCommand(Query, cus);
                            cusCommand.ExecuteNonQuery();
                            MessageBox.Show("Customer details has been deleted successfully!", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cus.Close();
                        }


                        //refreshCusPage();
                        showCusTable();


                        cus.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cus.Close();
                    }
                }


            }
        }

        private void CusDBDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CusNameTB.Text = CusDBDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            CusContact1TB.Text = CusDBDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            CusContact2TB.Text = CusDBDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            CusCardNoTB.Text = CusDBDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            CusAddressTB.Text = CusDBDataGrid.SelectedRows[0].Cells[5].Value.ToString();

            if (CusNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CusDBDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CusSearchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cus.Open();
                if (cus.State == ConnectionState.Open)
                {
                    string Query = "select * from CusTable where CusName like '" + CusSearchTB.Text + "%' ";
                    SqlCommand cusCommand = new SqlCommand(Query, cus);
                    SqlDataAdapter cusSda = new SqlDataAdapter(Query, cus);
                    DataTable dt = new DataTable();
                    cusSda.Fill(dt);
                    CusDBDataGrid.DataSource = dt;

                    cus.Close();
                }
                cus.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cus.Close();
            }
        }
    }
}

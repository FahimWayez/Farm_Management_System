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
    public partial class Production : Form
    {
        public Production()
        {
            InitializeComponent();
            ProdTimer1.Start();
            showProdTable();
            fillCattleTag();
        }

        int key = 0;
        SqlConnection prod = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");

        private void showProdTable()
        {
            prod.Open();
            string Query = "select * from ProductionTable";
            SqlDataAdapter prodSda = new SqlDataAdapter(Query, prod);
            SqlCommandBuilder prodScb = new SqlCommandBuilder(prodSda);
            var prodDs = new DataSet();
            prodSda.Fill(prodDs);
            ProdDBDataGrid.DataSource = prodDs.Tables[0];

            prod.Close();
        }

        private void refreshProdPage()
        {
            Production obj = new Production();
            obj.Show();
            this.Hide();
        }
        private void clearButtonFunc()
        {
            ProdQuantityTB.Text = ""; 
            ProdTagComboBox.Text = "";
            //ProdTypeOfProductTB.Text = "";
            ProdUPriceTB.Text = "";
            key = 0;
        }
        private void ProdTimer1_Tick(object sender, EventArgs e)
        {
            ProdTimeLabel.Text = DateTime.Now.ToLongTimeString();
            ProdDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void ProdExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void fillCattleTag()
        {
            prod.Open();
            SqlCommand cmd = new SqlCommand("select Tag from CattleTable", prod);
            SqlDataReader dReader;
            dReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tag", typeof(int));
            dt.Load(dReader);
            ProdTagComboBox.ValueMember = "Tag";
            ProdTagComboBox.DataSource = dt;
            prod.Close(); 
        }

        private void Production_Load(object sender, EventArgs e)
        {
            this.AcceptButton = ProdSaveButton;
        }

        private void ProdClearButton_Click(object sender, EventArgs e)
        {
            clearButtonFunc();
        }

        private void ProdRefreshButton_Click(object sender, EventArgs e)
        {
            refreshProdPage();
        }

        private void ProdSaveButton_Click(object sender, EventArgs e)
        {
            if (ProdTagComboBox.SelectedIndex == -1 || ProdQuantityTB.Text == "" || ProdUPriceTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    prod.Open();

                    if (prod.State == ConnectionState.Open)
                    {
                        string Query = "insert into ProductionTable values(" + ProdTagComboBox.SelectedValue.ToString() + ",  '" + "Milk" + "' , '" + ProdQuantityTB.Text + "', '" + ProdUPriceTB.Text + "','" + ProdDateTimePicker.Value.Date + "', '"+ProdDateTimePicker.Value.AddDays(7)+"')";
                        SqlCommand prodCommand = new SqlCommand(Query, prod);
                        prodCommand.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully!", "Production", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        prod.Close();
                    }

                    //refreshProdPage();
                    showProdTable();
                    clearButtonFunc();

                    prod.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    prod.Close();
                }
            }
        }

        private void ProdUpdateButton_Click(object sender, EventArgs e)
        {
            if (ProdTagComboBox.SelectedIndex == -1 || ProdQuantityTB.Text == "" || ProdUPriceTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure want to change the selected product details?", "Production", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        prod.Open();
                        if (prod.State == ConnectionState.Open)
                        {
                            string Query = "update ProductionTable set Tag='" + ProdTagComboBox.SelectedValue.ToString() + "' , Quantity='" + ProdQuantityTB.Text + "', UnitPrice='" + ProdUPriceTB.Text + "', Date='" + ProdDateTimePicker.Value.Date + "', EDate ='" + ProdDateTimePicker.Value.AddDays(7) + "' where ProdID = " + key + ";";
                            SqlCommand prodCommand = new SqlCommand(Query, prod);
                            prodCommand.ExecuteNonQuery();
                            MessageBox.Show("Details has been updated successfully!", "Production", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            prod.Close();
                        }

                        //refreshProdPage();
                        showProdTable();
                        clearButtonFunc();

                        prod.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    prod.Close();
                }
            }
        }

        private void ProdDeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)       
            {
                MessageBox.Show("No item selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure want to delete the selected product details?", "Production", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        prod.Open();
                        if (prod.State == ConnectionState.Open)
                        {
                            string Query = "delete from ProductionTable where ProdID=" + key + ";";
                            SqlCommand prodCommand = new SqlCommand(Query, prod);
                            prodCommand.ExecuteNonQuery();
                            MessageBox.Show("Product removed successfully!", "Production", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            prod.Close();
                        }

                        //refreshProdPage();
                        showProdTable();
                        clearButtonFunc();

                        prod.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    prod.Close();
                }
            }
        }
        
        private void ProdDBDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdTagComboBox.SelectedValue = ProdDBDataGrid.SelectedRows[0].Cells[1].Value.ToString(); 
            ProdTypeOfProductTB.Text = ProdDBDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            ProdQuantityTB.Text = ProdDBDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            ProdUPriceTB.Text = ProdDBDataGrid.SelectedRows[0].Cells[4].Value.ToString();

            if (ProdTypeOfProductTB.Text == "")
            {
                key = 0;
            }
            else
            {
                try
                {
                    key = Convert.ToInt32(ProdDBDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void ProdSearchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                prod.Open();
                if (prod.State == ConnectionState.Open)
                {
                    string Query = "select * from ProductionTable where Tag like '" + ProdSearchTB.Text + "%'";
                    SqlCommand prodCommand = new SqlCommand(Query, prod);
                    SqlDataAdapter prodSda = new SqlDataAdapter(Query, prod);
                    DataTable dt = new DataTable();
                    prodSda.Fill(dt);
                    ProdDBDataGrid.DataSource = dt;

                    prod.Close();
                }
                prod.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                prod.Close();
            }
        }
    }
}

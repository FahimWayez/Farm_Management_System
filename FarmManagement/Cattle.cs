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
using System.Threading;

namespace FarmManagement
{
    public partial class Cattle : Form
    {
        public Cattle()
        {
            InitializeComponent();
            CuttleTimer1.Start();
            showCattleTable();
        }

        private void cuttle_Load(object sender, EventArgs e)
        {
            this.AcceptButton = CattleSaveButton;
        }

        int key = 0;

        SqlConnection cattle = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");


        private void CuttleTimer1_Tick(object sender, EventArgs e)
        {
            CattleDateLabel.Text = DateTime.Now.ToLongDateString();
            CattleTimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void CuttleExitLabel_Click(object sender, EventArgs e)
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

        private void showCattleTable()
        {
            cattle.Open();
            string Query = "select * from CattleTable";
            SqlDataAdapter cattleSda = new SqlDataAdapter(Query, cattle);
            SqlCommandBuilder cattleScb = new SqlCommandBuilder(cattleSda);
            var cattleDs = new DataSet();
            cattleSda.Fill(cattleDs);
            CattleDBDataGrid.DataSource = cattleDs.Tables[0];

            cattle.Close();
        }

        private void refreshCattlePage()
        {
            Cattle obj = new Cattle();
            obj.Show();
            this.Hide();
        }

        private void clearButtonFunc()
        {
            CattleColorTB.Text = "";
            CattleBreedTB.Text = "";
            CattleAgeTB.Text = "";
            CattleWeightTB.Text = "";
            key = 0;
        }

        int age = 0;
        private void CattleSaveButton_Click(object sender, EventArgs e)
        {
            if (CattleColorTB.Text == "" || CattleBreedTB.Text == "" || CattleAgeTB.Text == "" || CattleWeightTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    cattle.Open();

                    if (cattle.State == ConnectionState.Open)
                    {
                        string Query = "insert into CattleTable values('" + CattleColorTB.Text + "',  '" + CattleBreedTB.Text + "', "+age+", '" + CattleWeightTB.Text + "', '"+CattleDOBDateTimePicker.Value.Date+"')";
                        SqlCommand cattleCommand = new SqlCommand(Query, cattle);
                        cattleCommand.ExecuteNonQuery();
                        MessageBox.Show("Cow added successfully!", "Cattle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cattle.Close();
                    }

                   // refreshCattlePage();
                    showCattleTable();
                    clearButtonFunc();

                    cattle.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cattle.Close();
                }
            }
        }

        private void CattleClearButton_Click(object sender, EventArgs e)
        {
            clearButtonFunc();
        }

        private void cattleRefreshButton_Click(object sender, EventArgs e)
        {
            refreshCattlePage();
        }

        private void CattleDOBDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            age = Convert.ToInt32((DateTime.Today.Date - CattleDOBDateTimePicker.Value.Date).Days)/365;
        }

        private void CattleDOBDateTimePicker_MouseLeave(object sender, EventArgs e)
        {
            age = Convert.ToInt32(( DateTime.Today.Date - CattleDOBDateTimePicker.Value.Date).Days) / 365;
            CattleAgeTB.Text = "" + age;
        }

        private void CattleDBDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CattleColorTB.Text = CattleDBDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            CattleBreedTB.Text = CattleDBDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            CattleWeightTB.Text = CattleDBDataGrid.SelectedRows[0].Cells[4].Value.ToString();

            if (CattleColorTB.Text == "")
            {
                key = 0;
                age = 0;
            }
            else
            {
                key = Convert.ToInt32(CattleDBDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                age = Convert.ToInt32(CattleDBDataGrid.SelectedRows[0].Cells[3].Value.ToString());
            }
        }

        private void CattleDeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("No Item Selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure want to delete the selectedd cow's details?", "Cattle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cattle.Open();

                        if (cattle.State == ConnectionState.Open)
                        {
                            string Query = "delete from CattleTable where Tag=" + key + ";";
                            SqlCommand cattleCommand = new SqlCommand(Query, cattle);
                            cattleCommand.ExecuteNonQuery();
                            MessageBox.Show("Cow Removed successfully!", "Cattle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cattle.Close();
                        }

                        //refreshCattlePage();
                        showCattleTable();
                        clearButtonFunc();

                        cattle.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cattle.Close();
                }
            }
        }

        private void CattleUpdateButton_Click(object sender, EventArgs e)
        {
            if (CattleColorTB.Text == "" || CattleBreedTB.Text == "" || CattleAgeTB.Text == "" || CattleWeightTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure want to change the selected cow's details?", "Cattle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cattle.Open();

                        if (cattle.State == ConnectionState.Open)
                        {
                            string Query = "update CattleTable set Color='" + CattleColorTB.Text + "',  Breed='" + CattleBreedTB.Text + "', Age=" + age + ", Weight='" + CattleWeightTB.Text + "', DOB='" + CattleDOBDateTimePicker.Value.Date + "' where Tag=" + key + ";";
                            SqlCommand cattleCommand = new SqlCommand(Query, cattle);
                            cattleCommand.ExecuteNonQuery();
                            MessageBox.Show("Details has been updated successfully!", "Cattle", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cattle.Close();
                        }

                        //refreshCattlePage();
                        showCattleTable();
                        clearButtonFunc();

                        cattle.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cattle.Close();
                }
            }
        }

        private void CattleSearchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cattle.Open();
                if (cattle.State == ConnectionState.Open)
                {
                    string Query = "select * from CattleTable where Tag like '" + CattleSearchTB.Text + "%'";
                    SqlCommand cattleCommand = new SqlCommand(Query, cattle);
                    SqlDataAdapter cattleSda = new SqlDataAdapter(Query, cattle);
                    DataTable dt = new DataTable();
                    cattleSda.Fill(dt);
                    CattleDBDataGrid.DataSource = dt;

                    cattle.Close();
                }
                cattle.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cattle.Close();
            }
        }

        private void CattleRefreshButton_Click_1(object sender, EventArgs e)
        {
            Cattle obj = new Cattle();
            obj.Show();
            this.Hide();
        }
    }
}

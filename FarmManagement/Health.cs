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
    public partial class Health : Form
    {
        public Health()
        {
            InitializeComponent();
            HealthTimer1.Start();
            showHealthTable();
            fillCattleTag();
        }

        int key = 0;
        SqlConnection health = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");

        private void health_Load(object sender, EventArgs e)
        {
            this.AcceptButton = HealthSaveButton;
        }

        private void HealthTimer1_Tick(object sender, EventArgs e)
        {
            HealthTimeLabel.Text = DateTime.Now.ToLongTimeString();
            HealthDateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void HealthExitLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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


        private void clearButtonFunc()
        {
            HealthSicknessTB.Text = "";
            HealthTreatmentTB.Text = "";
            HealthCostTB.Text = "";
            key = 0;
        }

        private void fillCattleTag()
        {
            health.Open();
            SqlCommand cmd = new SqlCommand("select Tag from CattleTable", health);
            SqlDataReader dReader;
            dReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Tag", typeof(int));
            dt.Load(dReader);
            HealthTagComboBox.ValueMember = "Tag";
            HealthTagComboBox.DataSource = dt;
            health.Close();
        }

        private void showHealthTable()
        {
            health.Open();
            string Query = "select * from HealthTable";
            SqlDataAdapter healthSda = new SqlDataAdapter(Query, health);
            SqlCommandBuilder healthScb = new SqlCommandBuilder(healthSda);
            var healthDs = new DataSet();
            healthSda.Fill(healthDs);
            HealthDBDataGrid.DataSource = healthDs.Tables[0];

            health.Close();
        }
        private void HealthClearButton_Click(object sender, EventArgs e)
        {
            clearButtonFunc();
        }

        private void refreshHealthPage()
        {
            Health obj = new Health();
            obj.Show();
            this.Hide();
        }

        private void HealthRefreshButton_Click(object sender, EventArgs e)
        {
            refreshHealthPage();
        }

        private void HealthSaveButton_Click(object sender, EventArgs e)
        {
            if (HealthTagComboBox.SelectedIndex == -1 || HealthSicknessTB.Text == "" || HealthTreatmentTB.Text == "" || HealthCostTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    health.Open();

                    if (health.State == ConnectionState.Open)
                    {
                        string Query = "insert into HealthTable values('" + HealthTagComboBox.SelectedValue.ToString() + "',  '" + HealthSicknessTB.Text + "' , '" + HealthTreatmentTB.Text + "', '" + HealthCostTB.Text + "','" + HealthDateTimePicker.Value.Date + "')";
                        SqlCommand healthCommand = new SqlCommand(Query, health);
                        healthCommand.ExecuteNonQuery();
                        MessageBox.Show("Condition added successfully!", "Health", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        health.Close();
                    }

                    //refreshHealthPage();
                    showHealthTable();
                    clearButtonFunc();

                    health.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    health.Close();
                }
            }
        }
        private void HealthUpdateButton_Click(object sender, EventArgs e)
        {
            if (HealthTagComboBox.SelectedIndex == -1 || HealthSicknessTB.Text == "" || HealthTreatmentTB.Text == "" || HealthCostTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure want to change the selected product details?", "Production", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        health.Open();

                        if (health.State == ConnectionState.Open)
                        {
                            string Query = "update HealthTable set Tag='" + HealthTagComboBox.SelectedValue.ToString() + "',  Sickness='" + HealthSicknessTB.Text + "' , Treatment='" + HealthTreatmentTB.Text + "', Cost='" + HealthCostTB.Text + "', Date='" + HealthDateTimePicker.Value.Date + "'";
                            SqlCommand healthCommand = new SqlCommand(Query, health);
                            healthCommand.ExecuteNonQuery();
                            MessageBox.Show("Condition added successfully!", "Health", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            health.Close();
                        }

                       //refreshHealthPage();
                        showHealthTable();
                        clearButtonFunc();

                        health.Close();
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    health.Close();
                }
            }
        }

        private void HealthDeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("No item selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure want to delete the selected health condition?", "Health", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        health.Open();

                        if (health.State == ConnectionState.Open)
                        {
                            string Query = "delete from HealthTable where HealthID =" + key+ ";";
                            SqlCommand healthCommand = new SqlCommand(Query, health);
                            healthCommand.ExecuteNonQuery();
                            MessageBox.Show("Condition removed successfully!", "Health", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            health.Close();
                        }

                        //refreshHealthPage();
                        showHealthTable();
                        clearButtonFunc();

                        health.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    health.Close();
                }
            }
        }

        private void HealthDBDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HealthTagComboBox.SelectedValue = HealthDBDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            HealthSicknessTB.Text = HealthDBDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            HealthTreatmentTB.Text = HealthDBDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            HealthCostTB.Text = HealthDBDataGrid.SelectedRows[0].Cells[4].Value.ToString();

            if (HealthSicknessTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HealthDBDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void HealthSearchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                health.Open();
                if (health.State == ConnectionState.Open)
                {
                    string Query = "select * from healthTable where Tag like '" + HealthSearchTB.Text + "%'";
                    SqlCommand healthCommand = new SqlCommand(Query, health);
                    SqlDataAdapter healthSda = new SqlDataAdapter(Query, health);
                    DataTable dt = new DataTable();
                    healthSda.Fill(dt);
                    HealthDBDataGrid.DataSource = dt;

                    health.Close();
                }
                health.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                health.Close();
            }
        }
    }
}

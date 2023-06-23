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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            EmpTimer1.Start();
            showEmpTable();
        }

        int key = 0;

        SqlConnection emp = new SqlConnection(@"Data Source=HP-BB0072TU\SQLEXPRESS;Initial Catalog=DairyFarm;Integrated Security=True");
        
        private void EmpTimer1_Tick(object sender, EventArgs e)
        {
            EmpTimeLabell.Text = DateTime.Now.ToLongTimeString();
            EmpDateLabel.Text = DateTime.Now.ToLongDateString();
        }

 
        private void showEmpTable()
        {
            emp.Open();
            string Query = "select * from EmpTable";
            SqlDataAdapter empSda = new SqlDataAdapter(Query, emp);
            SqlCommandBuilder empScb = new SqlCommandBuilder(empSda);
            var empDs = new DataSet();
            empSda.Fill(empDs);
            EmpDBDataGrid.DataSource = empDs.Tables[0];

            emp.Close();
        }

        private void refreshEmpPage()
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();
        }

        private void clearButtonFunc()
        {
            EmpNameTB.Text = "";
            EmpContact1TB.Text = "";
            EmpContact2TB.Text = "";
            EmpPositionTB.Text = "";
            EmpAddressTB.Text = "";
            key = 0;
        }
 

        private void EmpExitLabel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void EmpDBDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTB.Text = EmpDBDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            EmpPositionTB.Text = EmpDBDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            EmpContact1TB.Text = EmpDBDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            EmpContact2TB.Text = EmpDBDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            EmpAddressTB.Text = EmpDBDataGrid.SelectedRows[0].Cells[5].Value.ToString();

            if (EmpNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmpDBDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EmpSaveButton_Click(object sender, EventArgs e)
        {
            if (EmpNameTB.Text == "" || EmpPositionTB.Text == "" || EmpContact1TB.Text == "" || EmpAddressTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    emp.Open();

                    if (emp.State == ConnectionState.Open)
                    {
                        string Query = "insert into EmpTable values('" + EmpNameTB.Text.Replace("'", "''") + "',  '" + EmpPositionTB.Text.Replace("'", "''") + "', '" + EmpContact1TB.Text + "', '" + EmpContact2TB.Text + "', '" + EmpAddressTB.Text.Replace("'", "''") + "', '" + EmpDOBDateTimePicker.Value.Date + "')";
                        SqlCommand empCommand = new SqlCommand(Query, emp);
                        empCommand.ExecuteNonQuery();
                        MessageBox.Show("Employee added successfully!", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        emp.Close();
                    }
                   

                    //refreshEmpPage();
                    showEmpTable();
                    clearButtonFunc();

                    emp.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    emp.Close();
                }
            }
        }

        private void EmpUpdateButton_Click(object sender, EventArgs e)
        {
            if (EmpNameTB.Text == "" || EmpPositionTB.Text == "" || EmpContact1TB.Text == "" || EmpAddressTB.Text == "")
            {
                MessageBox.Show("Missing Information", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure want to change the selected employee's details?", "Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        emp.Open();
                        if (emp.State == ConnectionState.Open)
                        {
                            string Query = "update EmpTable set EmpName='" + EmpNameTB.Text.Replace("'", "''") + "',  EmpPosition='" + EmpPositionTB.Text.Replace("'", "''") + "', EmpContactNumber1='" + EmpContact1TB.Text + "', EmpContactNumber2='" + EmpContact2TB.Text + "', EmpAddress='" + EmpAddressTB.Text.Replace("'", "''") + "', DOB='" + EmpDOBDateTimePicker.Value.Date + "' where EmpID=" + key + ";";
                            SqlCommand empCommand = new SqlCommand(Query, emp);
                            empCommand.ExecuteNonQuery();
                            MessageBox.Show("Details has been updated successfully!", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            emp.Close();
                        }

                        //refreshEmpPage();
                        showEmpTable();
                        clearButtonFunc();

                        emp.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    emp.Close();
                }
            }
        }
        private void EmpDeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("No Item Selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    if(MessageBox.Show("Are you sure want to delete the selected employee's details?", "Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        emp.Open();

                        if (emp.State == ConnectionState.Open)
                        {
                            string Query = "delete from EmpTable where EmpID=" + key + ";";
                            SqlCommand empCommand = new SqlCommand(Query, emp);
                            empCommand.ExecuteNonQuery();
                            MessageBox.Show("Employee Removed successfully!", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            emp.Close();
                        }

                        //refreshEmpPage();
                        showEmpTable();
                        clearButtonFunc();

                        emp.Close();
                    }   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    emp.Close();
                }
            }
        }

        

        private void EmpClearButton_Click(object sender, EventArgs e)
        {
            clearButtonFunc();
        }

        private void EmpRefreshButton_Click(object sender, EventArgs e)
        {
            refreshEmpPage();
        }

        private void MPortalHomeIcon_Click_1(object sender, EventArgs e)
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

        private void Employee_Load(object sender, EventArgs e)
        {
            showEmpTable();
            this.AcceptButton = EmpSaveButton;
        }

        private void EmpSearchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                emp.Open();
                if (emp.State == ConnectionState.Open)
                {
                    string Query = "select * from EmpTable where EmpName like '" + EmpSearchTB.Text + "%'";
                    SqlCommand empCommand = new SqlCommand(Query, emp);
                    SqlDataAdapter empSda = new SqlDataAdapter(Query, emp);
                    DataTable dt = new DataTable();
                    empSda.Fill(dt);
                    EmpDBDataGrid.DataSource = dt;

                    emp.Close();
                }      
                emp.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                emp.Close();
            }
        }
    }
}

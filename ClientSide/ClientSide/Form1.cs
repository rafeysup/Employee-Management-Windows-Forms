using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using DAL.Entitities;
using DAL.Operations;
using System.Runtime.Serialization.Json;




namespace ClientSide
{
    public partial class frm_employees : Form
    {
        TcpClient client = null;
        NetworkStream ns = null;
        StreamReader sr;
        StreamWriter sw;

        public frm_employees()
        {
            InitializeComponent();
            TcpClient client = new TcpClient("127.0.0.1", 8000);
            ns = client.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            BindGrid();

        }

        private void BindGrid()
        {

            DataTable dt = Deserialize(sr.ReadLine());
            dataGridView1.DataSource = dt;

        }

        private DataTable Deserialize(string Json)
        {
            DataTable dt = new DataTable();
            if (Json != null)
            {
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(Json));
                DataContractJsonSerializer ser = new DataContractJsonSerializer(dt.GetType());
                dt = ser.ReadObject(ms) as DataTable;
                return dt;
            }
            return null;
        }

        private string Serialize(EEmployees emp)
        {

            MemoryStream ms = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(emp.GetType());
            ser.WriteObject(ms, emp);
            byte[] json = ms.ToArray();
            return Encoding.UTF8.GetString(json);


        }


        private void button1_Click(object sender, EventArgs e)
        {


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            EEmployees emp = new EEmployees();
            emp.Emp_Code = txt_empcode.Text;
            emp.Emp_Name = txt_empname.Text;
            emp.Date_of_Birth = dt_dob.Value;
            emp.Date_of_Joining = dt_doj.Value;
            emp.Department = txt_department.Text;
            emp.Report_To = txt_reportto.Text;
            emp.Contact_Number = txt_contactnumber.Text;
            emp.Resigned = chk_resigned.Checked;
            emp.Resigned_Date = dt_resigneddate.Value;
            emp.Option = "Insert";

            string json = Serialize(emp);
            sw.WriteLine(json);

            MessageBox.Show("Inserted");

            BindGrid();
        }



        private void btn_Get_Click(object sender, EventArgs e)
        {
            EEmployees emp = new EEmployees();
            emp.Option = "Show";
            sw.WriteLine(Serialize(emp));
            BindGrid();



        }

        
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            txt_empid.Text = Convert.ToString(dataGridView1[0, row].Value);
            txt_empcode.Text = Convert.ToString(dataGridView1[1, row].Value);
            txt_empname.Text = Convert.ToString(dataGridView1[2, row].Value);
            dt_dob.Value = Convert.ToDateTime(dataGridView1[3, row].Value);
            dt_doj.Value = Convert.ToDateTime(dataGridView1[4, row].Value);
            txt_department.Text = Convert.ToString(dataGridView1[5, row].Value);
            txt_reportto.Text = Convert.ToString(dataGridView1[6, row].Value);          
            txt_contactnumber.Text = Convert.ToString(dataGridView1[7, row].Value);
            chk_resigned.Checked = Convert.ToBoolean(dataGridView1[8, row].Value);
            chk_resigned.Checked = Convert.ToBoolean(dataGridView1[8, row].Value);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        public class Utilities
        {
            public static void ResetAllControls(Control form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                    }
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            EEmployees emp = new EEmployees();
            emp.Emp_Id = Convert.ToInt32(txt_empid.Text);
            emp.Emp_Code = txt_empcode.Text;
            emp.Emp_Name = txt_empname.Text;
            emp.Date_of_Birth = dt_dob.Value;
            emp.Date_of_Joining = dt_doj.Value;
            emp.Department = txt_department.Text;
            emp.Report_To = txt_reportto.Text;
            emp.Contact_Number = txt_contactnumber.Text;
            emp.Resigned = chk_resigned.Checked;
            emp.Resigned_Date = dt_resigneddate.Value;
            emp.Option = "update";

            string json = Serialize(emp);
            sw.WriteLine(json);

            MessageBox.Show("Updated");                 
            
            BindGrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            EEmployees emp = new EEmployees();
            emp.Emp_Id = Convert.ToInt32(txt_empid.Text);
            emp.Emp_Code = txt_empcode.Text;
            emp.Emp_Name = txt_empname.Text;
            emp.Date_of_Birth = dt_dob.Value;
            emp.Date_of_Joining = dt_doj.Value;
            emp.Department = txt_department.Text;
            emp.Report_To = txt_reportto.Text;
            emp.Contact_Number = txt_contactnumber.Text;
            emp.Resigned = chk_resigned.Checked;
            emp.Resigned_Date = dt_resigneddate.Value;
            emp.Option = "delete";

            string json = Serialize(emp);
            sw.WriteLine(json);

            MessageBox.Show("Deleted");

            BindGrid();
        }
    }

}







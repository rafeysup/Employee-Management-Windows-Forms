using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Entitities;
namespace DAL.Operations
{
    public class OEmployees
    {
        // For Crud Operations
        SqlConnection conn = new SqlConnection(@"data source=CRKRL-SALEERAF1\SQL2019;initial catalog=employee_list;trusted_connection=true");
        public int Insert(EEmployees emp)
        {
            conn.Open();

            string query = "insert into employees (emp_code, emp_name, date_of_birth, date_of_joining, department, report_to, contact_number, resigned, resigned_date) values ('" + emp.Emp_Code + "', '" + emp.Emp_Name + "','" + emp.Date_of_Birth + "','" + emp.Date_of_Joining + "','" + emp.Department + "','" + emp.Report_To + "','" + emp.Contact_Number + "', '" + emp.Resigned + "', '" + emp.Resigned_Date + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedRows = cmd.ExecuteNonQuery();

            return effectedRows;
        }

        public int Delete(EEmployees emp, int empid)
        {
            conn.Open();

            string query = "delete from employees where emp_id = '" + emp.Emp_Id + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedRows;
        }

        public int Update(EEmployees emp, int empid)
        {
            conn.Open();

            string query = "update employees set emp_code = '" + emp.Emp_Code + "', emp_name = '" + emp.Emp_Name + "', Date_of_Birth = '" + emp.Date_of_Birth + "', Date_of_Joining = '" + emp.Date_of_Joining + "', Department = '" + emp.Department + "', Report_To = '" + emp.Report_To + "', Contact_Number = '" + emp.Contact_Number + "', Resigned = '" + emp.Resigned + "', Resigned_Date = '" + emp.Resigned_Date + "' where emp_id = '" + emp.Emp_Id + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedRows = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedRows;
        }

        public SqlDataReader Select()
        {
            conn.Open();

            string query = "select * from employees";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            return reader;

        }
    }
}

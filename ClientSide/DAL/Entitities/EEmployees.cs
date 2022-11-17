using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entitities
{
   public class EEmployees
    {
        public int Emp_Id { get; set; }
        public String Emp_Code { get; set; }
        public String Emp_Name { get; set; }
        public DateTime? Date_of_Birth { get; set; }
        public DateTime? Date_of_Joining { get; set; }
        public String Department { get; set; }
        public String Report_To { get; set; }
        public String Contact_Number { get; set; }
        public Boolean Resigned { get; set; }
        public DateTime? Resigned_Date { get; set; }
        public String Option { get; set; }
        
    }
}

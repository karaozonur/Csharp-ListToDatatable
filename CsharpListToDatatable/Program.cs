using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpListToDatatable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>() { 
            new Student() { Name = "Onur", Id = 1, Department = "Bilişim" },
            new Student() { Name = "Abone Ol", Id = 2, Department = "beğen" }
            };

            ListToDatatableConvert convert = new ListToDatatableConvert();  
            DataTable dataTable = convert.ToDataTable(list);

          foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn col  in dataTable.Columns)
                {
                    Console.WriteLine(row["Name"].ToString());
                }
            }
          
            Console.ReadKey();
        }
    }
}

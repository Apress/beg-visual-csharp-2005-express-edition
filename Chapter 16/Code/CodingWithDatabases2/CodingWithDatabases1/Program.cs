using System;
using System.Collections.Generic;
using System.Text;

namespace CodingWithDatabases1
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureWorks_DataDataSetTableAdapters.EmployeeTableAdapter da =
                new AdventureWorks_DataDataSetTableAdapters.EmployeeTableAdapter();

            AdventureWorks_DataDataSet.EmployeeDataTable employees =
                da.GetData();

            AdventureWorks_DataDataSet.EmployeeRow row =
                employees[0];

            Console.WriteLine("Current row state: {0}", row.RowState);
            
            row.BeginEdit();
            row.LoginID = "Test";
            row.EndEdit();

            Console.WriteLine("Current row state: {0}\nNo. of rows changed:{1}", 
                row.RowState, 
                employees.GetChanges().Rows.Count);
                        
            da.Update(employees);
            employees.AcceptChanges();
            Console.ReadLine();
        }
    }
}



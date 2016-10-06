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

            AdventureWorks_DataDataSet.EmployeeDataTable table =
                new AdventureWorks_DataDataSet.EmployeeDataTable();

            da.Fill(table);

            foreach (AdventureWorks_DataDataSet.EmployeeRow row in table.Rows)
            {
                Console.WriteLine("ID:{0}, {1}", row.EmployeeID, row.LoginID);
            }

            Console.ReadLine();
        }
    }
}

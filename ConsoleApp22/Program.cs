using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "2 / 2 + 3 * 4 - 6";
            expression = Regex.Replace(expression, @"\s+", "");
            DataTable MyTable = new DataTable();
            DataColumn MyColumn = new DataColumn();
            MyColumn.ColumnName = "MyColumn";
            MyColumn.Expression = expression;
            MyColumn.DataType = typeof(double);
            MyTable.Columns.Add(MyColumn);
            DataRow MyRow = MyTable.NewRow();
            MyTable.Rows.Add(MyRow);
            double num = (double)(MyTable.Rows[0]["MyColumn"]);
            num = Math.Truncate(1000000 * num) / 1000000;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

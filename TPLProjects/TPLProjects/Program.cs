using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read data from CSV file and Write data into CSV File");
            //Read write Operation of CSV file
            // CSVHandler.ImplementingCSVDataHandler();
            //ReadCSV_and_WriteJSON.ImplementingCSV_To_Json();
            ReadJSON_and_WriteCSV.ImplementingJSONToCSV();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace TPLProjects
{
    public class CSVHandler
    {
        public static void ImplementingCSVDataHandler()
        {
            string ImportFilePath = @"C:\Users\HP\source\repos\TPLProjects\TPLProjects\Utility\Address.csv";
            string ExportFileParh = @"C:\Users\HP\source\repos\TPLProjects\TPLProjects\Utility\Export.csv";

            using (var reader = new StreamReader(ImportFilePath))
            using (var csv=new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read Data  successfully from Address Csv.");
                foreach(AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.FirstName);
                    Console.Write("\t" + addressData.LastName);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.City);
                    Console.Write("\t" + addressData.State);
                    Console.Write("\t" + addressData.Code);
                    Console.WriteLine();
                }
                Console.WriteLine("*************Now reading from CSV file and Write to CSV file*************");

                //Writting CSV files
                using (var writer = new StreamWriter(ExportFileParh))
                using (var csvExport=new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
            
        }
    }
}

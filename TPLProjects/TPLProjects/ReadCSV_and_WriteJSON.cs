using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;

namespace TPLProjects
{
    public class ReadCSV_and_WriteJSON
    {
        public static void ImplementingCSV_To_Json()
        {
            string ImportFilePath = @"C:\Users\HP\source\repos\TPLProjects\TPLProjects\Utility\Address.csv";
            string ExportFileParh = @"C:\Users\HP\source\repos\TPLProjects\TPLProjects\Utility\Export.json";

            using (var reader = new StreamReader(ImportFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read Data  successfully from Address data.");
                foreach (AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.FirstName);
                    Console.Write("\t" + addressData.LastName);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.City);
                    Console.Write("\t" + addressData.State);
                    Console.Write("\t" + addressData.Code);
                    Console.WriteLine();
                }
                Console.WriteLine("*************Now reading from CSV file and Write to Json file*************");

                //Writting CSV files
                JsonSerializer serializer = new JsonSerializer();
                using (var jwrite = new StreamWriter(ExportFileParh))
                using (JsonWriter write = new JsonTextWriter(jwrite))
                {
                    serializer.Serialize(write, records);
                }
            }
        }
    }
}

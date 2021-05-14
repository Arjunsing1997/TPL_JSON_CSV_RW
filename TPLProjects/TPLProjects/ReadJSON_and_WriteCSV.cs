using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace TPLProjects
{
    public class ReadJSON_and_WriteCSV
    {
        public static void ImplementingJSONToCSV()
        {
            string ImportFilePath = @"C:\Users\HP\source\repos\TPLProjects\TPLProjects\Utility\Export.json";
            string ExportFileParh = @"C:\Users\HP\source\repos\TPLProjects\TPLProjects\Utility\CSVWrite.csv";

            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(ImportFilePath));

            Console.WriteLine("*********************Now Reading from Json file to Write to CSV file*************");

            //Writing CSV file
            using (var writer = new StreamWriter(ExportFileParh))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecord(addressData);
            }
        }
    }
}

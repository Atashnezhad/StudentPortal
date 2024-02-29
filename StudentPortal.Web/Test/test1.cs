using System.Globalization;
using CsvHelper;
using Newtonsoft.Json;
using NUnit.Framework;

namespace StudentPortal.Web.Test
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void CsvToJson()
        {
            // read the csv file
            var csvFile = File.ReadAllText(Path.Combine("Resources", "StudentData.csv"));
        
            using(var csvReader = new CsvReader(new StringReader(csvFile), CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<Student>().ToList();
            
                // convert the rows to json
                var json = JsonConvert.SerializeObject(records);
            
                // save the json to a file
                File.WriteAllText(Path.Combine("Resources", "StudentData.json"), json);
            }
        }
    }

    public class Student
    {
        // define Student properties here
    }
}



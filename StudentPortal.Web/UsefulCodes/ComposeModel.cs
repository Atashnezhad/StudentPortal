using Newtonsoft.Json;

namespace StudentPortal.Web.UsefulCodes
{
    // Combined data model using composition
    public class CombinedDataModel
    {
        public FirstDataModel FirstData { get; set; }
        public SecondDataModel SecondData { get; set; }
    }

    // First data model
    public class FirstDataModel
    {
        public DateTime Timestamp { get; set; }
        // Other properties specific to the first data model
    }

    // Second data model
    public class SecondDataModel
    {
        public DateTime Timestamp { get; set; }
        // Other properties specific to the second data model
    }

    public static class MyModelsExamination
    {
        public static void MyRun(string[] args)
        {
            // Deserialize JSON data for the first data model
            var firstJsonData = @"{""Timestamp"":""2024-03-01T10:00:00"",""Property1"":""Value1""}";
            FirstDataModel firstData = JsonConvert.DeserializeObject<FirstDataModel>(firstJsonData);

            // Deserialize JSON data for the second data model
            var secondJsonData = @"{""Timestamp"":""2024-03-01T10:00:00"",""Property2"":""Value2""}";
            SecondDataModel secondData = JsonConvert.DeserializeObject<SecondDataModel>(secondJsonData);

            // Create an object of the combined data model
            var combinedData = new CombinedDataModel
            {
                FirstData = firstData,
                SecondData = secondData
            };

            // Use the combined data model as needed
        }
    }
}
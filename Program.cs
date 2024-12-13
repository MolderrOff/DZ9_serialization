// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Xml.Serialization;

namespace DZCx0023Atestation
{
    public class Wheather
    {
        public DateTime Time { get; set; }
        public double Temperature { get; set; }
        public int WheatherCode { get; set; }
        public double WindSpeed { get; set; }

        public int WindDirection { get; set; }

    }

    public class WheatherFull
    {
        public Wheather Current { get; set; }
        public List<Wheather> History { get; set; }
    }
    internal class Program
    {
        static void ConvertJsonToXml(string jsonStr)
        {
            var wheatherFull = JsonSerializer.Deserialize<WheatherFull>(jsonStr);
            var serializer = new XmlSerializer(typeof(WheatherFull));

            serializer.Serialize(Console.Out, wheatherFull);

        }


        static void Main(string[] args)
        {
            //Напишите приложение, конвертирующее произвольный JSON в XML. 

            var myJsonStr = """{"Current":{"Time":"2023-11-18T20:35:06.722127+04:00","Temperature":28,"WeatherCode":1,"WindSpeed":2.1,"WindDirection":1},"History":[{"Time":"2023-11-17T20:35:06.77707+04:00","Temperature":28,"WeatherCode":2,"WindSpeed":2.4,"WindDirection":1},{"Time":"2023-11-16T20:35:06.777081+04:00","Temperature":21,"WeatherCode":2,"WindSpeed":2.4,"WindDirection":1},{"Time":"2023-11-15T20:35:06.777082+04:00","Temperature":20,"WeatherCode":4,"WindSpeed":2.2,"WindDirection":1}]}""";

            ConvertJsonToXml(myJsonStr);
        }
    }
}
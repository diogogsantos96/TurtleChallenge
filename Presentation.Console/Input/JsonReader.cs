namespace TurtleChallenge.Input
{
    using Newtonsoft.Json;
    using System.IO;

    public class JsonReader<T> : IFileReader<T>
    {
        public T Read(string location)
        {
            using StreamReader r = new StreamReader(location);
            string json = r.ReadToEnd();
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}

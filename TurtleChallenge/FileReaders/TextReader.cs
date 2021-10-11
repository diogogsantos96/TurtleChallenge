namespace TurtleChallenge.FileReaders
{
    using Newtonsoft.Json;
    using System.IO;

    public class TextReader : IFileReader<string>
    {
        public string Read(string location)
        {
            using (StreamReader r = new StreamReader(location))
            {
                string text = r.ReadToEnd();
                return text;
            }
        }
    }
}

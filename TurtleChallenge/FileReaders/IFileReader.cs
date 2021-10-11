namespace TurtleChallenge.FileReaders
{
    public interface IFileReader<T>
    {
        T Read(string location);
    }
}
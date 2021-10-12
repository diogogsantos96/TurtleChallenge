namespace TurtleChallenge.Input
{
    public interface IFileReader<T>
    {
        T Read(string location);
    }
}
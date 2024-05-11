namespace ScoresApplication.Interfaces
{
    public interface IScoreFileReaderService
    {
        List<(string, string, int)> ReadScores(string filePath);
    }
}
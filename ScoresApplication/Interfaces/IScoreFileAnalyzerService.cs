namespace ScoresApplication.Interfaces
{
    public interface IScoreFileAnalyzerService
    {
        void AnalyzeScores(List<(string, string, int)> scores);
    }
}
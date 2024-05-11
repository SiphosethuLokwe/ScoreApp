using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoresApplication.Helpers;
using ScoresApplication.Interfaces;

namespace ScoresApplication.Services
{
    public class ScoreFileAnalyzerService : IScoreFileAnalyzerService
    {
        public void AnalyzeScores(List<(string, string, int)> scores)
        {
            scores.Sort((x, y) => string.Compare($"{x.Item1} {x.Item2}", $"{y.Item1} {y.Item2}", StringComparison.OrdinalIgnoreCase));

            int maxScore = scores.Max(s => s.Item3);

            foreach (var (firstName, lastName, score) in scores.Where(s => s.Item3 == maxScore))
            {
                MessageHelper.GetUserDetails(firstName, lastName);
            }
            MessageHelper.GetHighestScore(maxScore);

        }
    }
}

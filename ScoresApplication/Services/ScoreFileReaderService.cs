using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoresApplication.Helpers;
using ScoresApplication.Interfaces;

namespace ScoresApplication.Services
{
    public class ScoreFileReaderService : IScoreFileReaderService
    {
        public List<(string, string, int)> ReadScores(string filePath)
        {
            List<(string, string, int)> scores = new List<(string, string, int)>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && int.TryParse(parts[2], out int score))
                    {
                        scores.Add((parts[0].Trim(), parts[1].Trim(), score));
                    }
                   
                }
            }

            return scores;
        }
    }
}

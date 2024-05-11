using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoresApplication.Helpers;
using ScoresApplication.Interfaces;

namespace ScoresApplication.Services
{
    public class ScoreService : IScoreService
    {
        public readonly IScoreFileReaderService _scoreReaderService;
        public readonly IScoreFileAnalyzerService _scoreAnalyzerrService;

        public ScoreService(IScoreFileReaderService scoreReaderService, IScoreFileAnalyzerService scoreAnalyzerService)
        {

            _scoreReaderService = scoreReaderService;
            _scoreAnalyzerrService = scoreAnalyzerService;
        }

        public void GetScore()
        {
            string binDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (binDirectory != null)
            {
                string input = Path.Combine(binDirectory, "TestData.txt");
                if (!File.Exists(input))
                {
                    MessageHelper.GetInputValidationMessage();
                }

                var scores = _scoreReaderService.ReadScores(input);
                _scoreAnalyzerrService.AnalyzeScores(scores);
            }
        }

    }
}

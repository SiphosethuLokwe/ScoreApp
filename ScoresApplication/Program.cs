

using ScoresApplication.Interfaces;
using ScoresApplication.Services;

IScoreFileAnalyzerService scoreFileAnalyzerService  = new ScoreFileAnalyzerService();
IScoreFileReaderService readerService = new ScoreFileReaderService();
IScoreService scoreService = new ScoreService(readerService, scoreFileAnalyzerService);

scoreService.GetScore();

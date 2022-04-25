// See https://aka.ms/new-console-template for more information

using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .CreateLogger();

LogData logData = new LogData() { Message ="Hello word", Number = 123};

Log.Information($"{logData.Message}, inforamtie {logData.Number}");
Log.Information("{@log}",logData);
Log.Warning("Hello word, Warning");
Log.Error(new ArgumentOutOfRangeException(), "Hello word, Fout");

Console.WriteLine("Hello, World!");

class LogData
{
    public int Number { get; set; }
    public string Message { get; set; }
}
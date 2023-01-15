namespace BankStatementAnalyzerOops;

public class BankStatementAnalyzer
{
    private readonly IBankStatementParser _bankStatementParser;

    public BankStatementAnalyzer(IBankStatementParser bankStatementParser)
    {
        _bankStatementParser = bankStatementParser;
    }

    public void Analyze(string path)
    {
        var lines = File.ReadAllLines(path);
        var transactions = _bankStatementParser.Parse(lines);
        var processor = new BankTransactionProcessor(transactions);
        Console.WriteLine($"Net balance : {processor.CalculateNetBalance()}");
        Console.WriteLine($"Net balance for February : {processor.CalculateNetBalance("February")}");
    }
}
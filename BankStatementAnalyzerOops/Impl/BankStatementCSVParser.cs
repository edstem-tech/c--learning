namespace BankStatementAnalyzerOops.Impl;

public class BankStatementCsvParser : IBankStatementParser
{
    public BankTransaction Parse(string line)
    {
        var columns = line.Split(',');
        var date = DateOnly.Parse(columns[0]);
        var amount = double.Parse(columns[1]);
        var description = columns[2];
        return new BankTransaction(date, amount, description);
    }

    public List<BankTransaction> Parse(string[] lines)
    {
        var result = new List<BankTransaction>();
        foreach (var line in lines)
        {
            result.Add(Parse(line));
        }
        
        return result;
    }
}
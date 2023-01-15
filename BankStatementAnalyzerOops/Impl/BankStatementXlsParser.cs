namespace BankStatementAnalyzerOops.Impl;

public class BankStatementXlsParser: IBankStatementParser
{
    public BankTransaction Parse(string line)
    {
        throw new NotImplementedException();
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
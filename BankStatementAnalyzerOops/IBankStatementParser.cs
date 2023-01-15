namespace BankStatementAnalyzerOops;

public interface IBankStatementParser
{
    BankTransaction Parse(string line);
    
    List<BankTransaction> Parse(string[] lines);
}
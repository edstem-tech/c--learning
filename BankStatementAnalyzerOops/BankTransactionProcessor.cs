using System.Globalization;

namespace BankStatementAnalyzerOops;

public class BankTransactionProcessor
{
    private readonly List<BankTransaction> _bankTransactions;

    public BankTransactionProcessor(List<BankTransaction> bankTransactions)
    {
        _bankTransactions = bankTransactions;
    }

    public double CalculateNetBalance()
    {
        double netBalance = 0;
        foreach (var bankTransaction in _bankTransactions)
        {
            netBalance += bankTransaction.Amount;
        }

        return netBalance;
    }

    public double CalculateNetBalance(string month)
    {
        double netBalance = 0;
        foreach (var bankTransaction in _bankTransactions)
        {
            if (bankTransaction.Date.Month == DateTime.ParseExact(month, "MMMM", CultureInfo.InvariantCulture).Month)
            {
                netBalance += bankTransaction.Amount;
            }
        }

        return netBalance;
    }
}
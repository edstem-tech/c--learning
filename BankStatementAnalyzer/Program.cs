using System.Globalization;

var path = @"../../../Data/test.csv";

double CalculateNetBalance()
{
    var lines = File.ReadAllLines(path);
    var csv = from line in lines
        select (line.Split(","));
    double netBalance = 0;
    foreach (var item in csv)
    {
        netBalance += Convert.ToDouble(item[1]);
    }

    return netBalance;
}

double CalculateNetBalanceByMonth(string month)
{
    var lines = File.ReadAllLines(path);
    var csv = from line in lines
        select (line.Split(","));
    double netBalance = 0;
    foreach (var item in csv)
    {
        // convert string to date
        DateTime date = DateTime.ParseExact(item[0], "dd-MM-yyyy", CultureInfo.InvariantCulture);
        if (date.Month == DateTime.ParseExact(month, "MMMM", CultureInfo.InvariantCulture).Month)
        {
            netBalance += Convert.ToDouble(item[1]);
        }
    }

    return netBalance;
}

Console.WriteLine("Net Balance: " + CalculateNetBalance());
Console.WriteLine("Net Balance by Month: " + CalculateNetBalanceByMonth("February"));
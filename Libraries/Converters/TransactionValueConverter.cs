using System.Globalization;
using AppControleFinanceiro.Models;

namespace AppControleFinanceiro.Libraries.Converters;

public class TransactionValueConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        Transaction transaction = (Transaction) value!;
        if(transaction == null)
        {
            return string.Empty;
        }
        if(transaction.Type == TransactionType.Income)
        {
            return transaction.Value.ToString("C");
        }
        else
        {
            return $"R$ - {transaction.Value.ToString()}";
        }
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
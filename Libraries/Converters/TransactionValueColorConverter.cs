using System.Globalization;
using AppControleFinanceiro.Models;

namespace AppControleFinanceiro.Libraries.Converters;

public class TransactionValueColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        Transaction transaction = (Transaction) value!;
        if(transaction == null)
        {
            return Colors.Black;
        }
        if(transaction.Type == TransactionType.Income)
        {
            return Color.FromArgb("#FF93955A");
        }
        else
        {
            return Colors.Red;
        }
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
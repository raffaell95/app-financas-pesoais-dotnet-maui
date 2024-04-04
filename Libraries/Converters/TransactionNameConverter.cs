using System.Globalization;

namespace AppControleFinanceiro.Libraries.Converters;

public class TransactionNameConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if(value == null)
        {
            return string.Empty;
        }
        
        string transactionName = (string) value!;

        return transactionName.ToUpper()[0];
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
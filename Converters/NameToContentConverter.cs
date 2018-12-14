using System;

//Convert string to UserControl or .cs ViewModel

public class NameToContentConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null && value != "")
        {
            Type userControl = Type.GetType(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".path to control/viewmodel." + value, null, null);
            return Activator.CreateInstance(userControl);
        }

        return "";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

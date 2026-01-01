using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace TodoApp;

public class CompletedToOpacityConverter : IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		bool flag = default(bool);
		int num;
		if (value is bool)
		{
			flag = (bool)value;
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (((uint)num & (flag ? 1u : 0u)) != 0) ? 0.7 : 1.0;
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}

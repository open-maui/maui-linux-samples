using System;
using System.Globalization;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace TodoApp;

public class CompletedToColorConverter : IValueConverter
{
	private static readonly Color AccentColor = Color.FromArgb("#26A69A");

	private static readonly Color CompletedColor = Color.FromArgb("#9E9E9E");

	private static readonly Color TextPrimaryLight = Color.FromArgb("#212121");

	private static readonly Color TextSecondaryLight = Color.FromArgb("#757575");

	private static readonly Color TextPrimaryDark = Color.FromArgb("#FFFFFF");

	private static readonly Color TextSecondaryDark = Color.FromArgb("#B0B0B0");

	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
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
		bool flag2 = (byte)((uint)num & (flag ? 1u : 0u)) != 0;
		string text = (parameter as string) ?? "";
		Application current = Application.Current;
		bool flag3 = current != null && (int)current.RequestedTheme == 2;
		if (text == "indicator")
		{
			if (!flag2)
			{
				return AccentColor;
			}
			return CompletedColor;
		}
		if (flag2)
		{
			return CompletedColor;
		}
		if (text == "notes")
		{
			if (!flag3)
			{
				return TextSecondaryLight;
			}
			return TextSecondaryDark;
		}
		if (!flag3)
		{
			return TextPrimaryLight;
		}
		return TextPrimaryDark;
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}

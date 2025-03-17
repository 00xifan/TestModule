using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows;
using TestModule.Model;

namespace TestModule.Converters
{
	public class PositionerXOffsetConverter : IValueConverter
	{
		#region Implementation of IValueConverter
		/// <inheritdoc />
		public object? Convert(object? value,
							   Type targetType,
							   object? parameter,
							   CultureInfo culture)
		{
			if (value == null) return null;

			return System.Convert.ToDouble(value.ToString());
		}

		/// <inheritdoc />
		public object? ConvertBack(object? value,
								   Type targetType,
								   object? parameter,
								   CultureInfo culture)
		{
			return null;
		}
		#endregion
	}

	public class PositionerYOffsetConverter : IValueConverter
	{
		#region Implementation of IValueConverter
		/// <inheritdoc />
		public object? Convert(object? value,
							   Type targetType,
							   object? parameter,
							   CultureInfo culture)
		{
			if (value == null) return null;

			return System.Convert.ToDouble(value.ToString());
		}

		/// <inheritdoc />
		public object? ConvertBack(object? value,
								   Type targetType,
								   object? parameter,
								   CultureInfo culture)
		{
			return null;
		}
		#endregion
	}

	public class LabwareNumToVisibilityConverter : IValueConverter
	{
		#region Implementation of IValueConverter
		/// <inheritdoc />
		public object? Convert(object? value,
							   Type targetType,
							   object? parameter,
							   CultureInfo culture)
		{
			if (value == null) return null;

			return System.Convert.ToInt32(value.ToString()) > 0 ? Visibility.Visible : Visibility.Hidden;
		}

		/// <inheritdoc />
		public object? ConvertBack(object? value,
								   Type targetType,
								   object? parameter,
								   CultureInfo culture)
		{
			return null;
		}
		#endregion
	}

	public class PositionerTypeEnumToColorConverter : IValueConverter
	{
		#region Implementation of IValueConverter
		/// <inheritdoc />
		public object? Convert(object? value,
							   Type targetType,
							   object? parameter,
							   CultureInfo culture)
		{


			if (value != null && value is CellEnum positionerType)
			{
				return positionerType == CellEnum.Pod
					? new SolidColorBrush(Color.FromRgb(95, 120, 146))
					: new SolidColorBrush(Color.FromRgb(95, 151, 208));
			}
			return null;
		}

		/// <inheritdoc />
		public object? ConvertBack(object? value,
								   Type targetType,
								   object? parameter,
								   CultureInfo culture)
		{
			return null;
		}
		#endregion
	}

	public class PositionerTypeAndAllowDropToColorMultiConverter : IMultiValueConverter
	{
		public object Convert(object[] values,
							  Type targetType,
							  object parameter,
							  CultureInfo culture)
		{
			if (values != null
			   && values.Length > 0
			   && values[0] is CellEnum positionerType
			   && values[1] is bool allowDrop)
			{
				if (allowDrop)
				{
					return new SolidColorBrush(Color.FromRgb(76, 198, 171));
				}
				else
				{
					return positionerType == CellEnum.Pod
						? new SolidColorBrush(Color.FromRgb(95, 120, 146))
						: new SolidColorBrush(Color.FromRgb(95, 151, 208));
				}
			}
			return null;
		}


		public object[] ConvertBack(object value,
									Type[] targetTypes,
									object parameter,
									CultureInfo culture)
		{
			return new object[] { };
		}
	}

	public class SubStringConverter : IValueConverter
	{
		#region Implementation of IValueConverter
		/// <inheritdoc />
		public object? Convert(object? value,
							   Type targetType,
							   object? parameter,
							   CultureInfo culture)
		{
			if (value != null)
			{
				return (value.ToString().Length > 25) ? $"{value.ToString().Substring(0, 25)}..." : value;
			}
			return null;
		}

		/// <inheritdoc />
		public object? ConvertBack(object? value,
								   Type targetType,
								   object? parameter,
								   CultureInfo culture)
		{
			return null;
		}
		#endregion
	}



}

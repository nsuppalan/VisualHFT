﻿using VisualHFT.Helpers;
using System;
using System.Windows.Data;

namespace VisualHFT.Converters
{
    public class DispatchedObservableCollectionConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return new DispatchedObservableCollection(value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}

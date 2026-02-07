using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

using ColorEnum = LiveCaptionsTranslator.Utils.Color;

namespace LiveCaptionsTranslator.converters
{
    /// <summary>
    /// Converts Utils.Color enum to SolidColorBrush for the overlay palette.
    /// </summary>
    public class OverlayColorToBrushConverter : IValueConverter
    {
        private static readonly Dictionary<ColorEnum, SolidColorBrush> Map = new()
        {
            { ColorEnum.White, Brushes.White },
            { ColorEnum.Yellow, Brushes.Yellow },
            { ColorEnum.LimeGreen, Brushes.LimeGreen },
            { ColorEnum.Aqua, Brushes.Aqua },
            { ColorEnum.Blue, Brushes.Blue },
            { ColorEnum.DeepPink, Brushes.DeepPink },
            { ColorEnum.Red, Brushes.Red },
            { ColorEnum.Black, Brushes.Black },
        };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ColorEnum c && Map.TryGetValue(c, out var brush))
                return brush;
            return Brushes.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}

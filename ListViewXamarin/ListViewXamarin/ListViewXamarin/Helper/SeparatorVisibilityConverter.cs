using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class SeparatorVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var listView = parameter as SfListView;

            if (value == null)
                return false;

            return listView.DataSource.DisplayItems[listView.DataSource.DisplayItems.Count - 1] != value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
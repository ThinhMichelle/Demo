using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Demo_First
{
    public class ResourceUtils
    {
        public static ImageSource GetImage(string name)
        {
            return new BitmapImage(new Uri("pack://application:,,,/Demo_First;component/Resources/" + name));
        }
    }
}

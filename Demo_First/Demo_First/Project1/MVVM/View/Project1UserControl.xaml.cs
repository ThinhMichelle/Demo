using Autodesk.Revit.UI;
using Demo_First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project1
{
    /// <summary>
    /// UI Events
    /// </summary>
    public partial class Project1UserControl : UserControlBase
    {
        public static Project1UserControl Instance;

        public Project1ViewModel ViewModel;
        public ExternalEvent _event;

        public Project1UserControl(ExternalEvent exEvent, UIApplication uiapp) : base()
        {
            InitializeComponent();
            Instance = this;
            ViewModel = new Project1ViewModel(uiapp);
            DataContext = ViewModel;
            _event = exEvent;
        }
    }
}

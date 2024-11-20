﻿using Autodesk.Revit.UI;
using Demo_First;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project1
{
    public class Project1ViewModel : ViewModelValidateBase
    {
        private int _Value;

        public int Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                OnPropertyChanged();
            }
        }

        public ICommand Loaded { get; set; }
        public ICommand OKCmd { get; set; }
        public ICommand CancelCmd { get; set; }
        public Project1ViewModel(UIApplication uiapp)
        {
            Loaded = new RelayCommand<object>((q) =>
            {
                return true;
            }, (q) =>
            {
                Debug.WriteLine("Da chay vo day!");
            });
            OKCmd = new RelayCommand<object>(q =>
            {
                return ErrorCount == 0;
            }, (q) =>
            {
                MessageboxUtils.Show(Value.ToString(), ShowType.Infomation);
            });
            CancelCmd = new RelayCommand<object>(q =>
            {
                return true;
            }, (q) =>
            {
                Project1Controller.Instance.Window.Close();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Demo_First
{
    public enum NumberInputType
    {
        NONE,
        INTETER,
        DOUBLE,
        INTEGER_BIGGER,
        DOUBLE_BIGGER,
        INTEGER_BIGGER_EQUAL,
        DOUBLE_BIGGER_EQUAL,
    }
    public class TextBoxInteraction : DependencyObject
    {
        public static readonly DependencyProperty ValueProperty =
         DependencyProperty.RegisterAttached(
             "Value",
             typeof(double),
             typeof(TextBoxInteraction),
             new PropertyMetadata(0.0));

        public static double GetValue(TextBox textBox)
        {
            return (double)textBox.GetValue(ValueProperty);
        }

        public static void SetValue(TextBox textBox, double value)
        {
            textBox.SetValue(ValueProperty, value);
        }


        public static readonly DependencyProperty NumberInputProperty = DependencyProperty
                .RegisterAttached("NumberInput", typeof(NumberInputType), typeof(TextBoxInteraction),
                new PropertyMetadata(NumberInputType.NONE, OnNumberInputChanged));


        public static void SetNumberInput(DependencyObject d, NumberInputType use)
        {
            d.SetValue(NumberInputProperty, use);
        }

        private static void OnNumberInputChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBox txt = d as TextBox;
            if (txt != null)
            {
                NumberInputType inputValue = (NumberInputType)e.NewValue;
                if (inputValue != NumberInputType.NONE)
                {
                    InputMethod.SetIsInputMethodEnabled(txt, false);
                    txt.TextChanged += Txt_TextChanged;
                    txt.PreviewKeyDown += Txt_PreviewKeyDown;
                    txt.PreviewTextInput += Txt_PreviewTextInput;
                }
                else
                {
                    txt.TextChanged -= Txt_TextChanged;
                    txt.PreviewKeyDown -= Txt_PreviewKeyDown;
                    txt.PreviewTextInput -= Txt_PreviewTextInput;
                    InputMethod.SetIsInputMethodEnabled(txt, true);
                }
            }
        }

        private static NumberInputType GetNumberInputTypeCurrent(object sender)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return NumberInputType.NONE;
            return (NumberInputType)txt.GetValue(NumberInputProperty);
        }
        private static double GetValueCurrent(object sender)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return 0.0;
            return (double)txt.GetValue(ValueProperty);
        }


        private static void Txt_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            var numberInput = GetNumberInputTypeCurrent((object)sender);
            if (numberInput == NumberInputType.NONE) return;
            System.Windows.Clipboard.Clear();
            var textBox = sender as System.Windows.Controls.TextBox;
            // var fullText = textBox.Text.Insert(textBox.Text.Length - 1 < 0 ? 0 : textBox.Text.Length - 1, e.Text);
            if ((numberInput == NumberInputType.DOUBLE || numberInput == NumberInputType.INTETER) && e.Text == "-" && textBox.Text.Length == 0)
            {
                e.Handled = false;
                return;
            }
            double value = GetValueCurrent(sender);
            var fullText = textBox.Text.Insert(textBox.SelectionStart, e.Text);
            if (numberInput == NumberInputType.DOUBLE || numberInput == NumberInputType.DOUBLE_BIGGER || numberInput == NumberInputType.DOUBLE_BIGGER_EQUAL)
            {
                double val;
                e.Handled = !double.TryParse(fullText, out val);
                if (e.Handled == false)
                {
                    if (numberInput == NumberInputType.DOUBLE_BIGGER) if (val <= value) e.Handled = true;
                    if (numberInput == NumberInputType.DOUBLE_BIGGER_EQUAL) if (val < value) e.Handled = true;
                }
            }
            else if (numberInput == NumberInputType.INTETER || numberInput == NumberInputType.INTEGER_BIGGER || numberInput == NumberInputType.INTEGER_BIGGER_EQUAL)
            {
                int valueCompare = (int)value;
                int val;
                e.Handled = !int.TryParse(fullText, out val);
                if (e.Handled == false)
                {
                    if (numberInput == NumberInputType.INTEGER_BIGGER) if (val <= valueCompare) e.Handled = true;
                    if (numberInput == NumberInputType.INTEGER_BIGGER_EQUAL) if (val < valueCompare) e.Handled = true;
                }
            }
        }
        private static void Txt_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var numberInput = GetNumberInputTypeCurrent((object)sender);
            if (numberInput == NumberInputType.NONE) return;
            System.Windows.Clipboard.Clear();
            e.Handled = e.Key == Key.Space ? true : false;
        }

        private static void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            var numberInput = GetNumberInputTypeCurrent((object)sender);
            if (numberInput == NumberInputType.NONE) return;
            Regex regex = new Regex("[^0-9.\\-]+");
            if (numberInput == NumberInputType.INTETER || numberInput == NumberInputType.INTEGER_BIGGER) regex = new Regex("[^0-9\\-]+");
            System.Windows.Controls.TextBox tb = sender as System.Windows.Controls.TextBox;
            if (tb == null) return;

            bool handle = regex.IsMatch(tb.Text);
            if (handle)
            {
                StringBuilder dd = new StringBuilder();
                int i = -1;
                int cursor = -1;
                foreach (char item in tb.Text)
                {
                    i++;
                    if (char.IsDigit(item))
                        dd.Append(item);
                    else if (cursor == -1)
                        cursor = i;
                }
                tb.Text = dd.ToString();

                if (i == -1)
                    tb.SelectionStart = tb.Text.Length;
                else
                    tb.SelectionStart = cursor;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Splendid.POCO.UI.Controls
{
    public class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            
            GotFocus += OnGotFocus;
            LostFocus += OnLostFocus;
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Foreground = new SolidColorBrush(Colors.LightGray);
            Text = PlaceHolder;
        }

        private void OnLostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text))
            {
                Foreground = new SolidColorBrush(Colors.LightGray);
                Text = PlaceHolder;
            }
        }

        private void OnGotFocus(object sender, RoutedEventArgs e)
        {
            if (PlaceHolder.Equals(Text, StringComparison.InvariantCultureIgnoreCase))
                Text = string.Empty;
            Foreground = new SolidColorBrush(Colors.Black);
        }

        public string PlaceHolder
        {
            get { return (string)GetValue(PlaceHolderProperty); }
            set { SetValue(PlaceHolderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceHolder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.Register("PlaceHolder", typeof(string), typeof(CustomTextBox), new PropertyMetadata(string.Empty));

    }
}

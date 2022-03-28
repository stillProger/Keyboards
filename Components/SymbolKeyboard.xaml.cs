﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApp.Components
{
    /// <summary>
    /// Interaction logic for SymbolKeyboard.xaml
    /// </summary>
    public partial class SymbolKeyboard : UserControl
    {

        private bool changeKeyboard = true;
        public string SymbolKeyboardInput
        {
            get { return (string)GetValue(SymbolKeyboardInputProperty); }
            set { SetValue(SymbolKeyboardInputProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SymbolKeyboardInput.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SymbolKeyboardInputProperty =
            DependencyProperty.Register("SymbolKeyboardInput", typeof(string), typeof(SymbolKeyboard), new PropertyMetadata(""));


        public SymbolKeyboard()
        {
            InitializeComponent();
        }

        private void Button_Click_Key(object sender, RoutedEventArgs e)
        {
            //SymbolKeyboardInput += ((TextBlock)((Viewbox)((Button)sender).Content).Child).Text;

            Button buttonKey = (Button)sender;
            Viewbox viewBox = (Viewbox)buttonKey.Content;
            TextBlock keyContent = (TextBlock)viewBox.Child;
            SymbolKeyboardInput += keyContent.Text;
        }

        private void Button_Click_ChangeKeyboard(object sender, RoutedEventArgs e)
        {
            changeKeyboard = true;
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            int countInput = SymbolKeyboardInput.Length - 1;
            SymbolKeyboardInput = countInput >= 0 ? SymbolKeyboardInput.Remove(countInput) : SymbolKeyboardInput;
        }

        private void Button_Click_Space(object sender, RoutedEventArgs e)
        {
            SymbolKeyboardInput += " ";
        }
    }
}
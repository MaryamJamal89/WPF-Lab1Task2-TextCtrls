using System;
using System.Windows;
using System.Windows.Controls;

namespace lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RadioButton checkedAlign;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void selectAll(object sender, RoutedEventArgs e)
        {
            txtbox.SelectAll();
            txtbox.Focus();
        }

        private void cleartxt(object sender, RoutedEventArgs e)
        {
            txtbox.Clear();
            txtbox.Focus();
            
        }

        private void cut(object sender, RoutedEventArgs e)
        {
            txtbox.Cut();
            txtbox.Focus();
        }

        private void paste(object sender, RoutedEventArgs e)
        {
            txtbox.Paste();
            txtbox.Focus();
        }

        private void append(object sender, RoutedEventArgs e)
        {
            txtbox.AppendText("<append new text>");
            txtbox.Focus();
        }

        private void insert(object sender, RoutedEventArgs e)
        {
            txtbox.Text = txtbox.Text.Insert(txtbox.CaretIndex, "<insert new text here>");
        }

        private void prepend(object sender, RoutedEventArgs e)
        {
            txtbox.Text = "<prepend new text>" + txtbox.Text;
        }

        private void setText(object sender, RoutedEventArgs e)
        {
            txtbox.Focus();
        }

        private void undo(object sender, RoutedEventArgs e)
        {
            txtbox.Undo();
            txtbox.Focus();
        }

        private void txtalign(object sender, RoutedEventArgs e)
        {
            RadioButton ck = sender as RadioButton;
            if (ck.IsChecked.Value)
            {
                switch ((String)ck.Content)
                {
                    case "Left":
                        txtbox.TextAlignment = TextAlignment.Left;
                        break;
                    case "Center":
                        txtbox.TextAlignment = TextAlignment.Center;
                        break;
                    case "Right":
                        txtbox.TextAlignment = TextAlignment.Right;
                        break;
                }
                txtbox.Focus();
               
            }
        }

        private void parmision(object sender, RoutedEventArgs e)
        {
            RadioButton ck = sender as RadioButton;
            if (ck.IsChecked.Value)
            {
                if ((string)ck.Content == "Editable")
                    txtbox.IsReadOnly = false;
                else
                    txtbox.IsReadOnly = true;

            }
        }
    }
}

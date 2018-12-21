using System;
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

namespace Basic_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> memory = new List<string>(); //stores everything the user types in
        public double answer = new double(); //the answer
        private bool is_clicked;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }
            number_box.Text += '1';
        }

        private void Zero_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }
            number_box.Text += '0';
        }

        private void Two_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }
            number_box.Text += '2';
        }

        private void Three_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }
            number_box.Text += '3';
        }

        private void Four_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }
            number_box.Text += '4';
        }

        private void Five_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }
            number_box.Text += '5';
        }

        private void Six_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }
            number_box.Text += '6';
        }

        private void Seven_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }
            number_box.Text += '7';
        }

        private void Eight_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }
            number_box.Text += '8';
        }

        private void Nine_click(object sender, RoutedEventArgs e)
        {
            if (is_clicked == true)
            {
                number_box.Text = "";
                is_clicked = false;
            }                
            number_box.Text += '9';
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if(number_box.Text != "")
            {
                memory_block.Text += number_box.Text;
                memory.Add(number_box.Text);
                memory.Add("-");
                memory_block.Text += " - ";
                is_clicked = true;
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (number_box.Text != "")
            {
                memory_block.Text += number_box.Text;
                memory.Add(number_box.Text);
                memory.Add("/");
                is_clicked = true;
                memory_block.Text += " / ";
            }
        }
        
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (number_box.Text != "")
            {
                memory_block.Text += number_box.Text;
                memory.Add(number_box.Text);
                memory.Add("+");
                is_clicked = true;
                memory_block.Text += " + ";
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (number_box.Text == "")
            {
                return;
            }
            memory.Add(number_box.Text);
            memory_block.Text += number_box.Text;
            if (memory != null)
            {
                answer = Convert.ToDouble(memory[0]);
            }
            //calculate()
        }

        private void Times_Click(object sender, RoutedEventArgs e)
        {
            if(number_box.Text != "")
            {
                memory_block.Text += number_box.Text;
                memory.Add(number_box.Text);
                memory.Add("*");
                is_clicked = true;
                memory_block.Text += " * ";
            }
        }

        private void CLR_click(object sender, RoutedEventArgs e)
        {
            memory = new List<string>();
            memory_block.Text = "";
            number_box.Text = "";
            is_clicked = false;
        }

        private void calculate()
        {
            //iterate through each element in the list and detetmine if it is a number or an operation to be performed
        }

        private void order()
        {
            //somehow need to reorder the list into the correct order of operations before calling the calculate function
        }
    }
}

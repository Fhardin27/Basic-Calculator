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

namespace Basic_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Queue<string> memory = new Queue<string>(); //stores everything the user types in
        public double answer = new double(); //the answer
        private bool is_clicked = false;
        private bool enter_clicked = false;

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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
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
            else if (enter_clicked == true)
            {
                CLR_click(sender, e);
                enter_clicked = false;
            }
            number_box.Text += '9';
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if(number_box.Text != "")
            {
                memory_block.Text += number_box.Text;
                memory.Enqueue(number_box.Text);
                memory.Enqueue("-");
                memory_block.Text += " - ";
                is_clicked = true;

                if (enter_clicked is true)
                {
                    enter_clicked = false;
                    memory_block.Text = Convert.ToString(answer);
                    memory_block.Text += " - ";
                }
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (number_box.Text != "")
            {
                memory_block.Text += number_box.Text;
                memory.Enqueue(number_box.Text);
                memory.Enqueue("/");
                is_clicked = true;
                memory_block.Text += " / ";

                if (enter_clicked is true)
                {
                    enter_clicked = false;
                    memory_block.Text = Convert.ToString(answer);
                    memory_block.Text += " / ";
                }
            }
        }
        
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (number_box.Text != "")
            {
                memory_block.Text += number_box.Text;
                memory.Enqueue(number_box.Text);
                memory.Enqueue("+");
                is_clicked = true;
                memory_block.Text += " + ";

                if (enter_clicked is true)
                {
                    enter_clicked = false;
                    memory_block.Text = Convert.ToString(answer);
                    memory_block.Text += " + ";
                }
            }

        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (number_box.Text == "")
            {
                return;
            }
            memory.Enqueue(number_box.Text);
            memory_block.Text += number_box.Text;
            if (memory == null)
            {
                return;
            }
            calculate();
            enter_clicked = true;
            is_clicked = false;
        }

        private void Times_Click(object sender, RoutedEventArgs e)
        {
            if(number_box.Text != "")
            {
                memory_block.Text += number_box.Text;
                memory.Enqueue(number_box.Text);
                memory.Enqueue("*");
                is_clicked = true;
                memory_block.Text += " * ";

                if (enter_clicked is true)
                {
                    enter_clicked = false;
                    memory_block.Text = Convert.ToString(answer);
                    memory_block.Text += " * ";
                }
            }
        }

        private void CLR_click(object sender, RoutedEventArgs e)
        {
            memory = new Queue<string>();
            memory_block.Text = "";
            number_box.Text = "";
            is_clicked = false;
            enter_clicked = false;
            answer = 0;
        }

        private void calculate()
        {
            answer = Convert.ToDouble(memory.Dequeue());

            while (memory.Count != 0)
            {
                char op = Convert.ToChar(memory.Dequeue());

                switch(op)
                {
                    case '+':
                        answer += Convert.ToDouble(memory.Dequeue());
                        break;
                    case '-':
                        answer -= Convert.ToDouble(memory.Dequeue());
                        break;
                    case '/':
                        answer /= Convert.ToDouble(memory.Dequeue());
                        break;
                    case '*':
                        answer *= Convert.ToDouble(memory.Dequeue());
                        break;
                    default:
                        return;
                }
            }

            number_box.Text = Convert.ToString(answer);
        }

        private void order()
        {
            //somehow need to reorder the list into the correct order of operations before calling the calculate function
        }
    }
}

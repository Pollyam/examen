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


namespace exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void Click1_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Купить 1000 кг гречки";
            textBlock.Text = "Построить вечный двигатель";

        }

        private void Click2_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "Купить 1000 кг гречки";
        }
        /* private void button4_Click(object sender, RoutedEventArgs e)
{
    if (button4.Text == "Добавить список")
    {
        button4.Text = "Добавить список";
    }
    else
    {
        button4.Text = "Название списка";
    }
    Properties.Settings.Default.button4 = button4.Text;
    Properties.Settings.Default.Save();
}


private void Form_Load(object sender, EventArgs e)
{
    button4.Text = Properties.Settings.Default.button4;
}*/
    }  
}

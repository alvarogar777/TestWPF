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

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public decimal CalcularPorcentaje(decimal montoUno,decimal montoDos)
        {
            return (montoUno-montoDos) / montoUno*100;
        }

        private void ButtonCalcular_Click(object sender, RoutedEventArgs e){
            string valorUno=TxtMontoUno.Text;
            string valorDos=TxtMontoDos.Text;
            TxtResultado.Text = Convert.ToString(CalcularPorcentaje(decimal.Parse(valorUno),decimal.Parse(valorDos)));
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

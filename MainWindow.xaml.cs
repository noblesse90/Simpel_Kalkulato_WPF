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

namespace KalkulatorEksempel_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variabler for kalkulatoren
        long tall_1 = 0;
        long tall_2 = 0;
        string operasjon = "";
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Tall knapp funksjoner
        private void Knapp1_Click(object sender, RoutedEventArgs e)
        {
            //Legger til et tall
                tall_1 = (tall_1 * 10) + 1;
                TekstBoksen.Text = tall_1.ToString();
           
            
        }

        private void Knapp2_Click(object sender, RoutedEventArgs e)
        {
                tall_1 = (tall_1 * 10) + 2;
                TekstBoksen.Text = tall_1.ToString();
            
        }

        private void Knapp3_Click(object sender, RoutedEventArgs e)
        {

                tall_1 = (tall_1 * 10) + 3;
                TekstBoksen.Text = tall_1.ToString();
  
        }

        private void Knapp4_Click(object sender, RoutedEventArgs e)
        {

                tall_1 = (tall_1 * 10) + 4;
                TekstBoksen.Text = tall_1.ToString();
            
        }

        private void Knapp5_Click(object sender, RoutedEventArgs e)
        {
                tall_1 = (tall_1 * 10) + 5;
                TekstBoksen.Text = tall_1.ToString();

        }

        private void Knapp6_Click(object sender, RoutedEventArgs e)
        {
                tall_1 = (tall_1 * 10) + 6;
                TekstBoksen.Text = tall_1.ToString();

        }

        private void Knapp7_Click(object sender, RoutedEventArgs e)
        {
                tall_1 = (tall_1 * 10) + 7;
                TekstBoksen.Text = tall_1.ToString();

        }

        private void Knapp8_Click(object sender, RoutedEventArgs e)
        {
                tall_1 = (tall_1 * 10) + 8;
                TekstBoksen.Text = tall_1.ToString();
        }

        private void Knapp9_Click(object sender, RoutedEventArgs e)
        {
                tall_1 = (tall_1 * 10) + 9;
                TekstBoksen.Text = tall_1.ToString();

        }

        private void Knapp0_Click(object sender, RoutedEventArgs e)
        {
                tall_1 = (tall_1 * 10);
                TekstBoksen.Text = tall_1.ToString();
        }

        #endregion

        #region Matte funksjoner og erLik
        private void KnappPluss_Click(object sender, RoutedEventArgs e)
        {
            operasjon = "+";
            tall_2 = tall_1;
            tall_1 = 0;
            TekstBoksen.Text = "0";
        }

        private void KnappMinus_Click(object sender, RoutedEventArgs e)
        {
            operasjon = "-";
            tall_2 = tall_1;
            tall_1 = 0;
            TekstBoksen.Text = "0";
        }

        private void KnappGange_Click(object sender, RoutedEventArgs e)
        {
            operasjon = "*";
            tall_2 = tall_1;
            tall_1 = 0;
            TekstBoksen.Text = "0";
        }

        private void KnappDele_Click(object sender, RoutedEventArgs e)
        {
            operasjon = "/";
            tall_2 = tall_1;
            tall_1 = 0;
            TekstBoksen.Text = "0";
        }

        private void KnappErLik_Click(object sender, RoutedEventArgs e)
        {
            switch (operasjon)
            {
                case "+":
                    tall_1 = (tall_2 + tall_1);
                    TekstBoksen.Text = tall_1.ToString();
                    break;
                case "-":
                    tall_1 = tall_2 - tall_1;
                    TekstBoksen.Text = tall_1.ToString();
                    break;
                case "*":
                    tall_1 = tall_2 * tall_1;
                    TekstBoksen.Text = tall_1.ToString();
                    break;
                case "/":
                    tall_1 = tall_2 / tall_1;
                    TekstBoksen.Text = tall_1.ToString();
                    break;
            }
            
        }

        #endregion

        #region Clear tall funksjoner
        private void KnappCE_Click(object sender, RoutedEventArgs e)
        {
            //Tilbakestiller variabelen til 0
                tall_1 = 0;
            TekstBoksen.Text = "0";
        }

        private void KnappC_Click(object sender, RoutedEventArgs e)
        {
            //Tilbakestiller kalkulatoren
            tall_1 = 0;
            tall_2 = 0;
            operasjon = "";
            TekstBoksen.Text = "0";
        }

        private void KnappTilbake_Click(object sender, RoutedEventArgs e)
        {
            //Går et tall tilbake (tilbakeknapp)
                tall_1 = (tall_1 / 10);
                TekstBoksen.Text = tall_1.ToString();
        }

        private void KnappPositivNegativ_Click(object sender, RoutedEventArgs e)
        {
                tall_1 *= -1;
                TekstBoksen.Text = tall_1.ToString();
        }
        #endregion
    }
}

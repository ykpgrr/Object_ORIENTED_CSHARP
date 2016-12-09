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
using System.IO;
using Microsoft.Win32;

namespace _1.Soru
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı       Burak EDE 040140705
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Str_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                Counters n = new Counters();
                n.strCount(deneme.metin);
                Sonuc.Text = deneme.str;
            }
            catch
            {
                string metin = File.ReadAllText("Mtn.txt");
                Counters n = new Counters();
                n.strCount(metin);
                Sonuc.Text = deneme.str;
            }
        }

        private void Tact_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Counters n = new Counters();
                n.TacWord(deneme.metin);
                Sonuc.Text = deneme.tac;
            }
            catch
            {
                string metin = File.ReadAllText("Mtn.txt");
                Counters n = new Counters();
                n.TacWord(metin);
                Sonuc.Text = deneme.tac;
            }
            
        }

        private void Operational_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Counters n = new Counters();
                n.opCount(deneme.metin);
                Sonuc.Text = deneme.op;
            }
            catch
            {
                string metin = File.ReadAllText("Mtn.txt");
                Counters n = new Counters();
                n.opCount(metin);
                Sonuc.Text = deneme.op;
            }
        }

        public void Button_Click(object  sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.Title = "Metnin olduğu dosyayı seçin";
                dosya.ShowDialog();
                StreamReader file = new StreamReader(dosya.FileName);
                deneme.metin = file.ReadToEnd();
            }
            catch { Exception ex; }
        }
    }
}

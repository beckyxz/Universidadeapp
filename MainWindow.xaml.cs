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

namespace App.Universidade
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
            private void UniversidadeWindow_Click(object sender, RoutedEventArgs e)
            {
                UniversidadeWindow w = new UniversidadeWindow();
                w.ShowDialog();
            }
            private void DepartamentoWindow_Click(object sender, RoutedEventArgs e)
            {
                DepartamentoWindow w = new DepartamentoWindow();
                w.ShowDialog();
            }
            private void CursoWindow_Click(object sender, RoutedEventArgs e)
            {
                CursoWindow w = new CursoWindow();
                w.ShowDialog();
            }
            private void Cad_DepWindow_Click(object sender, RoutedEventArgs e)
            {
                Cad_DepWindow w = new Cad_DepWindow();
                w.ShowDialog();
            }
            private void Cad_CursoWindow_Click(object sender, RoutedEventArgs e)
            {
                Cad_CursoWindow w = new Cad_CursoWindow();
                w.ShowDialog();
            }
        }
    }
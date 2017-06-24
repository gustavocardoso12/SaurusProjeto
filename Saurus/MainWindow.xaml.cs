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

namespace Saurus
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

        private void sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            // abre a aba inserir
            frame.Navigate(new Saurus.Inserir.Inserir());
            logo_saurus.Visibility = Visibility.Collapsed;
            nome.Visibility = Visibility.Collapsed;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

          
        }

        private void saurus_tabela_clientesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // abrir a aba atualizar
            frame.Navigate(new Saurus.Atualizar.atualizar());
            logo_saurus.Visibility = Visibility.Collapsed;
            nome.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //abrir a aba deletar
            frame.Navigate(new Saurus.Deletar.Deletar());
            logo_saurus.Visibility = Visibility.Collapsed;
            nome.Visibility = Visibility.Collapsed;
        }

        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {
            //abre a aba pesquisar
            frame.Navigate(new Saurus.Pesquisar.Pesquisar());
            logo_saurus.Visibility = Visibility.Collapsed;
            nome.Visibility = Visibility.Collapsed;
        }
    }
}

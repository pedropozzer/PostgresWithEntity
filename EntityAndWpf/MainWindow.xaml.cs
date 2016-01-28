using Business.BusinessModels;
using Entities.Models;
using System.Linq;
using System.Windows;

namespace EntityAndWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var albumBus = new AlbumBus())
            {
                this.Title = albumBus.GetById(5).Artist.Name;
                this.DataGridTeste.ItemsSource  = albumBus.GetAll().OrderBy(album => album.Id).ToList();
            }
        }
    }
}

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

namespace Konevskii_PR19.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public List<Classes.Item> items = new List<Classes.Item>();
        public Main()
        {
            InitializeComponent();

            items.Add(new Classes.Item("Шкаф", 20000, "Shkaf.jpg"));
            items.Add(new Classes.Item("Диван", 45000, "Divan.jpg"));
            items.Add(new Classes.Item("Полка", 1700, "Polka.jpg"));
            items.Add(new Classes.Item("Тумба", 6500, "Tymba.jpg"));
            items.Add(new Classes.Item("Стул", 4300, "Styl.jpg"));
            items.Add(new Classes.Item("Стол", 45000, "Stol.jpg"));
            LoadItems();

        }

        public void LoadItems()
        {
            parent.Children.Clear();
            foreach(Classes.Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
                
        }
    }
}

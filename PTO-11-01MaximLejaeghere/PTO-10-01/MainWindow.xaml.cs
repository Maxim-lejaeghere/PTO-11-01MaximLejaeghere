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
using Cartoons.BL;
namespace PTO_10_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        StudioModel studio = new StudioModel();
        CartoonModel cartoon = new CartoonModel();
        public MainWindow()
        {
            InitializeComponent();
            //Modellen initialiseren
            
            //Zet de beginnende cartoons in de lijst
            cartoon.SetCartoons();
            

        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            //Methode dat controleerd als alles goed is ingevuld en zo ja nieuwe cartoon toevoegen aan list
            cartoon.CartoonsToevoegen(txtName.Text, $"Images/{txtImage.Text}", dateCreation.SelectedDate.Value, comboStudio.Text);
            listCartoons.ItemsSource = null;
            cartoon.CartoonsInListbox(comboStudio.Text);
            listCartoons.ItemsSource = cartoon.Templist;
        }



        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            cartoon.CartoonAanpassen(cartoon.Name, txtName.Text, dateCreation.DisplayDate, txtImage.Text, comboStudio.Text);
        }

        private void comboStudio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //source terug resetten
            listCartoons.ItemsSource = null;
            // Methode met foreach zetten voor iedere cartoon in CartoonModel waar studio gelijk is aan combobox
            cartoon.CartoonsInListbox(comboStudio.SelectedItem.ToString());
            listCartoons.ItemsSource = cartoon.Templist;
            
        }

        private void listCartoons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (e.AddedItems.Count > 0)
            {
                cartoon = (CartoonModel)e.AddedItems[0];
                cartoon.Name = cartoon.Name;
                cartoon.CartoonGegevensInvoegen(selectedName);
                txtName.Text = cartoon.Name;
                txtImage.Text = cartoon.Image;
                dateCreation.DisplayDate = cartoon.DateCreation;
            }

            
        }


    }
}

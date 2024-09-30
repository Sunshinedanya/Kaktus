using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WpfKaktus.DB;

namespace WpfKaktus
{
    public partial class KaktusWindow : Window
    {
        public Kaktus currentKaktus;
        public List<Kaktus> KaktusCollection;

        public Exibition currentExibition;
        public List<Exibition> exibitionCollection;

        public KaktusWindow()
        {
            InitializeComponent();
            LoadKaktus();
            LoadExibition();
        }

        public void LoadKaktus()
        {
            var Kaktuses = DBConnector.DB.Kaktus.ToList();
            ListKaktus.ItemsSource = Kaktuses;
            KaktusCollection = Kaktuses;
        }

        public void LoadExibition()
        {
            var exibitions = DBConnector.DB.Exibition.ToList();
            ListExibition.ItemsSource = exibitions;
            exibitionCollection = exibitions;
        }

        private void ChangeUhod(object sender, RoutedEventArgs e)
        {
            var stringUhod = UhodTextBox.Text;

            currentKaktus.Uhod = stringUhod;

            DBConnector.DB.SaveChanges();

            LoadKaktus();
        }

        private void ChangePlace(object sender, RoutedEventArgs e)
        {
            var place = ExibitionTextBox.Text;

            currentExibition.Place = place;

            DBConnector.DB.SaveChanges();
            LoadExibition();
        }

        private void AddKaktus(object sender, RoutedEventArgs e)
        {
            var kaktus = new Kaktus();
            DBConnector.DB.Kaktus.Add(kaktus);
            DBConnector.DB.SaveChanges();

            LoadKaktus();
        }

        private void RemoveKaktus(object sender, RoutedEventArgs e)
        {
            var kaktus = ListKaktus.SelectedItem as Kaktus;

            DBConnector.DB.Kaktus.Remove(kaktus);
            DBConnector.DB.SaveChanges();
            LoadKaktus();
        }

        private void AddExibition(object sender, RoutedEventArgs e)
        {
            var exibition = new Exibition();
            DBConnector.DB.Exibition.Add(exibition);
            DBConnector.DB.SaveChanges();

            LoadExibition();
        }

        private void RemoveExibition(object sender, RoutedEventArgs e)
        {
            var exibition = ListExibition.SelectedItem as Exibition;

            DBConnector.DB.Exibition.Remove(exibition);
            DBConnector.DB.SaveChanges();
            LoadExibition();
        }

        private void ChangeDate(object sender, RoutedEventArgs e)
        {
            var Date = ExibitionTextBox.Text;

            currentExibition.Date = ExibitionDatePicker.DisplayDate;

            DBConnector.DB.SaveChanges();
            LoadExibition();
        }

        private void ChangeComments(object sender, RoutedEventArgs e)
        {
            var Comments = ExibitionTextBox.Text;

            currentExibition.Comments = Comments;

            DBConnector.DB.SaveChanges();
            LoadExibition();
        }

        private void OnKaktusSelected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            currentKaktus = ListKaktus.SelectedItem as Kaktus;
            if (currentKaktus != null)
                UhodTextBox.Text = currentKaktus.Uhod;
        }

        private void OnVistavkaSelected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            currentExibition = ListExibition.SelectedItem as Exibition;
            ExibitionTextBox.Text = currentExibition.Place;
        }

        private void Update()
        {
            LoadKaktus();
            UhodTextBox.Text = currentKaktus.Uhod;
        }
    }
}

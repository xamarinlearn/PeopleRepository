using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using People.Models;


namespace People
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnNewButtonClicked(object sender, EventArgs e)
        {
            
            // Get data base path
            string dbPath =
                Path.Combine
                (Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData),
                "dbPeople.db");

            PersonRepositoryCRUD personRepo = 
                new PersonRepositoryCRUD(dbPath);

            string name = EntryPersonName.Text;

            // Crer un objeto Person
            Person newPerson = new Person();
            newPerson.Name = name;

            personRepo.CreatePerson(newPerson);

            LabelStatusMessage.Text = personRepo.StatusMessage;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}

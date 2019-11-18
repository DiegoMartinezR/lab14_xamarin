using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace Lab14
{
    public partial class App : Application
    {

        static ModelDatabase database;
        public App()
        {
            //InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

            Resources = new ResourceDictionary();
            Resources.Add("primaryGreen", Color.FromHex("91CA47"));
            Resources.Add("primaryDarkGreen", Color.FromHex("6FA22E"));

            var nav = new NavigationPage(new ListaPersonas());
            nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            nav.BarTextColor = Color.White;

            MainPage = nav;

            //MainPage = new MainPage();
        }
        public static ModelDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ModelDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

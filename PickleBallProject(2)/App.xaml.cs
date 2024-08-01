using PickleBallProject_2_.Data;

namespace PickleBallProject_2_
{
    public partial class App : Application
    {
        static DataSource database;

        public static DataSource Database
        {
            get
            {
                if (database == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "OpeningsApp.db3");
                    database = new DataSource(dbPath);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}

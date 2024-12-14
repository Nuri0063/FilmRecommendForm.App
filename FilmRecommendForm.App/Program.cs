using FilmRecommend.Business;
using FilmRecommend.Data;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Json;

namespace FilmRecommendForm.App
{
    internal static class Program
    {

        public static FilmMoodDBContext DbContext;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           // Application.Run(new LoginForm());

            //DataOperations dataOperations = new DataOperations();
            //dataOperations.AddMoviesToDatabase();

            //DataOperations dataOperations = new DataOperations();
            //dataOperations.UpdatePosterURLs();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                DbContext = new FilmMoodDBContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"DbContext ba�lat�l�rken bir hata olu�tu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // E�er DbContext ba�lat�lamazsa uygulamay� sonland�r�n
            }


            Program.DbContext.Database.EnsureCreated();
            

            // Uygulaman�n ba�lang�� formunu �al��t�r�n
            Application.Run(new LoginForm());

            // Uygulama kapan�rken DbContext'i dispose edin
            DbContext.Dispose();







        }
    }
}
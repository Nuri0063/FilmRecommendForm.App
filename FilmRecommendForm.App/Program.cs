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
                MessageBox.Show($"DbContext baþlatýlýrken bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Eðer DbContext baþlatýlamazsa uygulamayý sonlandýrýn
            }


            Program.DbContext.Database.EnsureCreated();
            

            // Uygulamanýn baþlangýç formunu çalýþtýrýn
            Application.Run(new LoginForm());

            // Uygulama kapanýrken DbContext'i dispose edin
            DbContext.Dispose();







        }
    }
}
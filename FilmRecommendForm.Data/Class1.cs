using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.Jet;
using FilmRecommend.Entities;
using FilmRecommend.Data;
using System.Data.OleDb;
using EntityFrameworkCore.Jet.Data;
using System.Diagnostics;


//FilmMoodDBContext context = new();

namespace FilmRecommend.Data
{

    //DbContext sınıfı
    public class FilmMoodDBContext : DbContext
    {
        //DbContext ile kalıtımladığımız class'a tablolarımızı EF core'un anlayacağı dilden yazdık
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieSubCategory> MovieSubCategories { get; set; }

        //Bağlantı ayarlarımızı gerçekleştirdik
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                

                //optionsBuilder.UseSqlServer("Server=localhost;Database=FilmRecommendDB;Trusted_Connection=True;TrustServerCertificate=True;"); SQL BAĞLANTISI
                optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\nurii\OneDrive\Belgeler\Database1.accdb;"); //ACCESS BAĞLANTISI
                                                                                                                                           //access ile bağlantı da access de veritabanı oluşturup sonu .accdb bağlantılı yolu optionsBuilder.UseJet e yazıyoruz
            }
            else
            {
                Debug.WriteLine("OnConfiguring atlandı çünkü zaten yapılandırılmış.");
            }
        }

        //Fluent API ayarlarımızı gerçekleştirdik
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<MovieCategory>()
                .HasMany(c => c.SubCategories)
                .WithOne(sc => sc.Category)
                .HasForeignKey(sc => sc.MovieCategoryID);

            modelBuilder.Entity<MovieSubCategory>()
                .HasMany(sc => sc.Movies)
                .WithOne(m => m.SubCategory)
                .HasForeignKey(m => m.MovieSubCategoryID);
        }

        //onconfriug çok çağırıldığı için chatin verdiği yöntemlerden. yüksel ihtimal silinecek
        /*
        public static class DbContextFactory
        {
            private static FilmMoodDBContext _context;

            public static FilmMoodDBContext GetDbContext()
            {
                if (_context == null)
                {
                    _context = new FilmMoodDBContext();
                }
                return _context;
            }
            public static void DisposeContext()
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }

        }


        */





    }

 }



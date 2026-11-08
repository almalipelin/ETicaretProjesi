using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Entities;//Entities katmanındaki malzemeleri kullanabilmek için
using Microsoft.EntityFrameworkCore;//Yüklediğimiz EF Core kütüphanesini kullanmak için

namespace ETicaret.DataAccess
{
    public class ETicaretDbContext : DbContext//DbContext'ten miras alarak bu sınıfın sıradan bir sınıf değil,veritabanı yöneticisi olduğunu belirliyoruz. 
    {
        //Constructor(Yapıcı Metot):Veritabanı bağlantı ayarlarını(şifre,sunucu adı vb.) API katmanından almanızı sağlar.
        public ETicaretDbContext(DbContextOptions<ETicaretDbContext> options) : base(options) 
        {
        }
        //DbSet'ler veritabanındaki tablolaeımızın karşılığıdır.
        //SQL'de "Products" adında bir tablo oluşturacak ve içini Product özellikleriyle dolduracak.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

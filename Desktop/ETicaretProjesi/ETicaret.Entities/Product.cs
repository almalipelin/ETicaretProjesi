using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        //---İLİŞKİ KODLARI---

        //Foreign Key: Veritabanında ürünün hangi kategoriye ait olduğunu tutan sadece bir sayıdır.
        public int CategoryId { get; set; }
        //Navigation Property(Sanal Köprü):C# tarafında kod yazarken, ürünün kategorisinin detaylarına doğrudan erişmemizi sağlar.Veritabanında fazladan sütun oluşturmaz.
        public Category Category { get; set; } = null!;
    }
}

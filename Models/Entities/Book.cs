using Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Book:IEntity //Kitap bilgilerini tutacağım tabloya karşılık gelecek entity
    {
        [Key]//Primary key belirttim
        public int BookId { get; set; }
        
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; } // Kitabın Türü/Kategorisi

        public string Title { get; set; }//Kitabın Başlığı
        public string ISBN { get; set; }
        public string Condition { get; set; }//Kitabın kalitesinin durumunu belirttiğimiz alandır
        public int NumberOfPages { get; set; } //Sayfa Sayısı
        public string PublicationYear { get; set; }// yayın yılı
        public float UnitPrice { get; set; }//Adet Fiyatı
        public ICollection<OrderItem> OrderItems { get; set; }
        public Stock Stock { get; set; }
    }
}

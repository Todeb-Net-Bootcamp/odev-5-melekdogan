using Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Publisher:IEntity //Yayıncı tabloma karşılık gelecek entity. Kitabı yayınlayan yayın evleri tutulur. 
    {
        [Key]//Primary key belirttim
        public int PublisherId { get; set; }
        public string PublisherInfo { get; set; }// Yayıncı bilgileri (yayınevi adı vs. )
        public ICollection<Book> Books { get; set; }

    }
}

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
    public class Stock:IEntity //Stock tabloma karşılık gelecek entity
    {
        [Key]//Primary key belirttim
        public int StockId { get; set; }
        public int SoldInStock { get; set; }// Stoktan satılan kitap sayısı
        public int AvailableInStock { get; set; }//Stokta mevcut kitap sayısı
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}

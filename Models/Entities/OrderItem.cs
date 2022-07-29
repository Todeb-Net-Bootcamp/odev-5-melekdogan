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
    public class OrderItem:IEntity //Sipariş Öğelerimi tutacağım tabloya karşılık gelecek entity
    {
        [Key]//Primary key belirttim
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book{ get; set; }
        public int Quantity { get; set; } //Sipariş verilen kitabın adedi
    }
}

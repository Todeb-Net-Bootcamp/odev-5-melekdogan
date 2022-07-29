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
    public class Order:IEntity //Siparişleri tutacağım tabloya karşılık gelecek entity
    {
        [Key]//Primary key belirttim
        public int OrderId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public DateTime OrderDate { get; set; } //Sipariş edildiği tarih
        public float TotalPrice { get; set; }//Toplam tutar

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

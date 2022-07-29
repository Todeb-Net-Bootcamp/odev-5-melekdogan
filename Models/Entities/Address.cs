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
    public class Address:IEntity //Kullanıcıların adreslerini tutacağım tabloya karşılık gelecek entity
    {
        [Key] //Primary key belirttim
        public int AddressId { get; set; }
        public string AddressInfo { get; set; }//Açık adresin girileceği alan 
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int CountyId { get; set; }
        [ForeignKey("CountyId")]
        public County County { get; set; }//İlçe bilgisi ve il bilgisi ilişkili tablolar ve ilçe tablosundan ile de ulaşılır. Bu yüzden sadece ilçe bilgisini ekledim. 
    }
}

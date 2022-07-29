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
    public class County:IEntity //İlçeleri tutacağım tabloya karşılık gelecek entity
    {
        [Key]//Primary key belirttim
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}

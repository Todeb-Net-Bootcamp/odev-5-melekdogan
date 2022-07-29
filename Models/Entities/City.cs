using Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class City:IEntity //İlleri tutacağım tabloya karşılık gelecek entity
    {
        [Key]//Primary key belirttim
        public int CityId { get; set; }
        public string CityName { get; set; }
        public ICollection<County> Counties { get; set; }
    }
}

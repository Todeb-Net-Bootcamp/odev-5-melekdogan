using Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Category:IEntity //Kategörileri tutacağım tabloya karşılık gelecek entity
    {
        [Key]//Primary key belirttim
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

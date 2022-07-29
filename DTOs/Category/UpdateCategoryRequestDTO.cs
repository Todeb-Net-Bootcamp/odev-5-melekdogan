using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Category
{
    public class UpdateCategoryRequestDTO //Kategori Güncelleme İsteğinde kullanılacak veri transfer objesi
    {
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryDescription { get; set; }
    }
}

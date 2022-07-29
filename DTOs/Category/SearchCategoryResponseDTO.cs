using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Category
{
    public class SearchCategoryResponseDTO //Kategori Listeleme İsteğinden gelecek cevap için kullanılacak veri transfer objesi
    {
        public string CategoryTitle { get; set; }
        public string CategoryDescription { get; set; }
    }
}

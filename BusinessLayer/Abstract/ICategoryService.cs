using BusinessLayer.Configuration.Response;
using DTOs.Category;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        public IEnumerable<SearchCategoryResponseDTO> GetAll();//Kategori listeleme işleminde kullanılacak metot
        public CommandResponse Add(AddCategoryRequestDTO category);//Kategori ekleme işleminde kullanılacak metot
        public CommandResponse Update(UpdateCategoryRequestDTO category);//Kategori güncelleme işleminde kullanılacak metot
        public CommandResponse Delete(Category category);//Kategori silme işleminde kullanılacak metot

    }
}

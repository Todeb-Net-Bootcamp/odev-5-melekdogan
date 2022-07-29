using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Configuration.Extensions;
using BusinessLayer.Configuration.Response;
using BusinessLayer.Configuration.Validator.FluentValidation;
using DataAccessLayer.Abstract;
using DTOs.Category;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;
        private IMapper _mapper;
        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
 
        public IEnumerable<SearchCategoryResponseDTO> GetAll() //Kategori listeleme işleminde kullanılacak metot
        {
            var data = _repository.GetAll();
            var mappedData = data.Select(x => _mapper.Map<SearchCategoryResponseDTO>(x)).ToList();
            // gelen veriyi SearchCategoryResponseDTO türüne dönüştürüp belleğe alıyoruz denebilir. Bunu yapmazsak Convert hatası verecektir ve projeyi build etmeyecektir.
            return mappedData;
        }

        public CommandResponse Add(AddCategoryRequestDTO category) //Kategori ekleme işleminde kullanılacak metot
        {
           
            var validation = new AddCategoryRequestValidator();
            validation.Validate(category).ThrowIfException();

            // gelen veriyi Category türüne dönüştürüp belleğe alıyoruz denebilir. Bunu yapmazsak Convert hatası verecektir ve projeyi build etmeyecektir.
            var mappedEntity = _mapper.Map<Category>(category);
            _repository.Add(mappedEntity);

            return new CommandResponse
            {
                Status = true,
                Message = $"Kategori Eklendi."
            };
        }
        public CommandResponse Delete(Category category) //Kategori silme işleminde kullanılacak metot
        { 
            _repository.Delete(category);

            return new CommandResponse
            {
                Status = true,
                Message = "Kategori Silindi"
            }; 
        }       
        public CommandResponse Update(UpdateCategoryRequestDTO category) //Kategori güncelleme işleminde kullanılacak metot
        {
            //Validation
            var validation = new UpdateCategoryRequestValidator();
            validation.Validate(category).ThrowIfException();
            
          

            var entity = _repository.Get(category.CategoryId);
            if (entity == null)
            {
                return new CommandResponse()
                {
                    Status = false,
                    Message = "Veri tabanında bu Id de kayıt bulunmamaktadır"
                };
            }

            var mappedEntity = _mapper.Map<Category>(category);

            _repository.Update(mappedEntity);

            return new CommandResponse
            {
                Status = true,
                Message = $"Müşteri Güncellendi"
            };
        } 
    }
}

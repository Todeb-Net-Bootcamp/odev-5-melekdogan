using AutoMapper;
using BusinessLayer.Abstract;
using DTOs.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCategories()//Kategorileri listeleme isteği 
        {
            var data=_service.GetAll();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult AddCategory(AddCategoryRequestDTO category)//Kategori ekleme isteği 
        {
            var response = _service.Add(category);
            return Ok(response);
        } 
        [HttpDelete]
        public IActionResult DeleteCategory(Category category)//Kategori silme isteği 
        {
            var response = _service.Delete(category);
            return Ok(response);
        } 
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryRequestDTO category)//Kategori güncelleme isteği
        {
            var response = _service.Update(category);
            return Ok(response);
        }
    }
}

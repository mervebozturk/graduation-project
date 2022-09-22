using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using PycApi.Base;
using PycApi.Data;
using PycApi.Dto;
using PycApi.Service;
using System.Collections.Generic;
using System.Linq;
using ISession = NHibernate.ISession;

namespace PycApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory_Service category_Service;
        public CategoryController(ICategory_Service category_Service)
        {
            this.category_Service = category_Service;
        }


        [HttpGet]   //kategorilerin hepsini getirmek için bu metodu kullanıyoruz.
        public BaseResponse<IEnumerable<CategoryDto>> GetAll()
        {
            var response = category_Service.GetAll();
            return response;
        }


        [HttpPost]  //kategori eklemek için bu metodu kullandık.
        public BaseResponse<CategoryDto> AddProduct([FromBody] CategoryDto request)
        {
            var response = category_Service.Insert(request);
            return response;
        }

        [HttpPut]
        public BaseResponse<CategoryDto> Update(int id, [FromBody] CategoryDto dto)
        {
            var response = category_Service.Update(id, dto);
            return response;
        }

    }
}




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
    public class ProductController : ControllerBase
    {
        private readonly IProduct_Service product_Service;
        public ProductController(IProduct_Service product_Service)
        {
            this.product_Service = product_Service;
        }


        [HttpGet]   //ürünlerin hepsini getirmek için bu metodu kullanıyoruz.
        public BaseResponse<IEnumerable<ProductDto>> GetAll()
        {
            var response = product_Service.GetAll();
            return response;
        }

        [HttpGet("Get Product By {CategoryId}")]  //ürünün ait olduğu kategori ide göre ürünü getirir.
        public BaseResponse<List<ProductDto>> GetById(long CategoryId)
        {

            var products = product_Service.GetAll().Response.Where(x => x.categoryid == CategoryId).ToList();
            return new BaseResponse<List<ProductDto>>(products);
        }


        [HttpPost]  //ürün eklemek için bu metodu kullandık.
        public BaseResponse<ProductDto> AddProduct([FromBody] ProductDto request)
        {
            var response = product_Service.Insert(request);
            return response;
        }

    }
}


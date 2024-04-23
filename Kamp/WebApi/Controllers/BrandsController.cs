using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandServices _brandServices;

        public BrandsController(IBrandServices brandServices)
        {
            _brandServices = brandServices;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
           CreatedBrandResponse createdBrandResponse= _brandServices.Add(createBrandRequest);
            return Ok(createdBrandResponse);
        }
        [HttpGet]
        public IActionResult Get()
        {
           return Ok( _brandServices.GetAll());
        }
    }
}

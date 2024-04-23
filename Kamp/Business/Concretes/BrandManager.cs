
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class BrandManager : IBrandServices
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            Brand brand = new();
            brand.Name = createBrandRequest.Name;
            brand.CreatedDate = DateTime.Now;

            _brandDal.Add(brand);

            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = createdBrandResponse.Name;
            createdBrandResponse.Id = 4;
            createdBrandResponse.CreatedDate = brand.CreatedDate;
            return createdBrandResponse;
        }

        public List<GetAllBrandResponse> GetAll()
        {
            List<Brand> brands = _brandDal.GelAll();
            List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();
           foreach(var brand in brands)
            {
                GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
                getAllBrandResponse.Name = brand.Name;
                getAllBrandResponse.Id = brand.Id;
                getAllBrandResponse.CreatedDate = brand.CreatedDate;

                getAllBrandResponses.Add(getAllBrandResponse);
            }
            return getAllBrandResponses;
            
        }
    }
}

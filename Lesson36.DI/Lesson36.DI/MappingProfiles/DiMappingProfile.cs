using AutoMapper;
using Lesson36.Di.Models;
using Lesson36.Entities;

namespace Lesson36.Di.MappingProfiles
{
    public class DiMappingProfile : Profile
    {
        public DiMappingProfile()
        {
            this.CreateMap<Car, CarModel>();
            this.CreateMap<CarModel, Car>();
        }
    }
}
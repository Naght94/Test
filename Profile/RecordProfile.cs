using AutoMapper;
using Test.DTOS;
using Test.Models;

namespace Test.Profiles 
{
    public class RecordProfile : Profile
    {
        public RecordProfile()
        {
            CreateMap<RecordCreateDTO, Record>();
        }
        
    }

}


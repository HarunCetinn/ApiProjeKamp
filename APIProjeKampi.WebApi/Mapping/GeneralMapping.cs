using APIProjeKampi.WebApi.Dtos.FeatureDtos;
using APIProjeKampi.WebApi.Dtos.MessageDtos;
using APIProjeKampi.WebApi.Entities;
using AutoMapper;

namespace APIProjeKampi.WebApi.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
                CreateMap<Feature,ResultFeatureDto>().ReverseMap();
                CreateMap<Feature,CreateFeatureDto>().ReverseMap();
                CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
                CreateMap<Feature,GetByIdFeatureDto>().ReverseMap();

                CreateMap<Message,ResultMessageDto>().ReverseMap();
                CreateMap<Message,CreateMessageDto>().ReverseMap();
                CreateMap<Message,UpdateMessageDto>().ReverseMap();
                CreateMap<Message,GetByIdMessageDto>().ReverseMap();
        }
    }
}

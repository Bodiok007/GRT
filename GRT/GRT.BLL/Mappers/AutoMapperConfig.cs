using AutoMapper;
using GRT.DAL.Models.Tokens;
using GRT.DAL.Models.UserProject;
using GRT.Models.Tokens;
using GRT.Models.UserProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRT.BLL.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            /*AutoMapper.Mapper.CreateMap<User, UserDal>()
                .ForMember(dest => dest.Author,
                           opts => opts.MapFrom(src => src.Author.Name));*/

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDal>();
                cfg.CreateMap<UserDal, User>();
                cfg.CreateMap<TokenDal, Token>();
                cfg.CreateMap<Token, TokenDal>();
            });

            /*Mapper.Initialize(cfg => {
                cfg.CreateMap<User, UserDal>();
                cfg.CreateMap<UserDal, User>();
            });*/

            //IMapper mapper = config.CreateMapper();
            /*var source = new AbcEditViewModel();
            var dest = mapper.Map<AbcEditViewModel, Abct>(source);*/

            return config.CreateMapper();
        }
    }
}

using Application.Artists;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Artist, Artist>();
            CreateMap<Artist, ArtistDto>();

        }
    }
}
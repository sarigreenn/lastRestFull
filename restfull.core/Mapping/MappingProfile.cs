using AutoMapper;
using restFul.Entities;
using restfull.core.DTOs;
using restfull.core.Entities;
using RestFull.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restfull.core.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Guest, GuestDTO>().ReverseMap();
            CreateMap<Room, RoomDTO>().ReverseMap();
            CreateMap<Invetation, InvetationDTO>().ReverseMap();




        }
    }
}

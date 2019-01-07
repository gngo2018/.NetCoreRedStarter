using AutoMapper;
using RedStarter.API.DataContract.Note;
using RedStarter.Business.DataContract.Note;
using RedStarter.Database.DataContract.Note;
using RedStarter.Database.Entities.Note;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class NoteMappingProfile : Profile
    {
        public NoteMappingProfile()
        {
            CreateMap<NoteCreateRequest, NoteCreateDTO>();
            CreateMap<NoteCreateDTO, NoteCreateRAO>();
            CreateMap<NoteCreateRAO, NoteEntity>();
        }
    }
}

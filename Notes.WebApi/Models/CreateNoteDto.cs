using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Application.Common.Notes.Commands.CreateNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.WebApi.Models
{
    public class CreateNoteDto : IMapWith<CreateNoteCommand>
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateNoteDto, CreateNoteCommand>()
                .ForMember(notecommand => notecommand.Title, opt => opt.MapFrom(noteDto => noteDto.Title))
                .ForMember(notecommand => notecommand.Details, opt => opt.MapFrom(noteDto => noteDto.Details));
        }
    }
}

﻿using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Application.Common.Notes.Commands.UpdateNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.WebApi.Models
{
    public class UpdateNoteDto :IMapWith<UpdateNoteCommand>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateNoteDto, UpdateNoteCommand>()
                .ForMember(updatecommand => updatecommand.Id, opt => opt.MapFrom(updateDto => updateDto.Id))
                .ForMember(updatecommand => updatecommand.Title, opt => opt.MapFrom(updateDto => updateDto.Title))
                .ForMember(updatecommand => updatecommand.Details, opt => opt.MapFrom(updateDto => updateDto.Details));
        } 
    }
}

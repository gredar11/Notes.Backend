using MediatR;
using System;

namespace Notes.Application.Common.Notes.Queries.GetNoteDetail
{
    public class GetNoteDetaislQuery : IRequest<NoteDetailsVm>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}

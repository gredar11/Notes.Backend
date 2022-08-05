using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Nodes.Application.Common.Exceptions;
using Nodes.Application.Interfaces;
using Notes.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace Nodes.Application.Common.Notes.Queries.GetNoteDetail
{
    public class GetNoteDetailsQueryHandler : IRequestHandler<GetNoteDetailQuery, NoteDetailsVm>
    {
        private readonly INotesDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetNoteDetailsQueryHandler(INotesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<NoteDetailsVm> Handle(GetNoteDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Notes.FirstOrDefaultAsync(note => note.Id == request.Id, cancellationToken);
            if (entity == null || entity.UserId != request.UserId)
                throw new NotFoundException(nameof(Note), request.Id);
            return _mapper.Map<NoteDetailsVm>(entity);
        }
    }
}

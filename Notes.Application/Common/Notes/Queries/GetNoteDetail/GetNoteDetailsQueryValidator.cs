using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Common.Notes.Queries.GetNoteDetail
{
    public class GetNoteDetailsQueryValidator: AbstractValidator<GetNoteDetaislQuery>
    {
        public GetNoteDetailsQueryValidator()
        {
            RuleFor(query => query.Id).NotEqual(Guid.Empty);
            RuleFor(query => query.UserId).NotEqual(Guid.Empty);

        }
    }
}

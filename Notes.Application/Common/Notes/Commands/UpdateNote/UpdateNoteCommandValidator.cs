using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Common.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandValidator:AbstractValidator<UpdateNoteCommand>
    {
        public UpdateNoteCommandValidator()
        {
            RuleFor(createcommand =>
                createcommand.Title).NotEmpty().MaximumLength(250);
            RuleFor(createcommand =>
                createcommand.UserId).NotEqual(Guid.Empty);
            RuleFor(createcommand =>
                createcommand.Id).NotEqual(Guid.Empty);
        }
    }
}

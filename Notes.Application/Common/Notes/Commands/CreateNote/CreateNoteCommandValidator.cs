using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Common.Notes.Commands.CreateNote
{
    public class CreateNoteCommandValidator:AbstractValidator<CreateNoteCommand>
    {
        public CreateNoteCommandValidator()
        {
            RuleFor(createcommand =>
                createcommand.Title).NotEmpty().MaximumLength(250);
            RuleFor(createcommand =>
                createcommand.UserId).NotEqual(Guid.Empty);
        }
    }
}

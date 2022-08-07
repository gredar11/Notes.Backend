using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Common.Notes.Commands.DeleteCommand
{
    public class DeleteCommandValidator:AbstractValidator<DeleteNoteCommand>
    {
        public DeleteCommandValidator()
        {
            RuleFor(createcommand =>
                createcommand.UserId).NotEqual(Guid.Empty);
            RuleFor(createcommand =>
                createcommand.Id).NotEqual(Guid.Empty);
        }
    }
}

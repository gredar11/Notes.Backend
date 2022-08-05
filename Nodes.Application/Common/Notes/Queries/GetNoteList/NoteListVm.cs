using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes.Application.Common.Notes.Queries.GetNoteList
{
    public class NoteListVm
    {
        public IList<NoteLookUpDto> Notes { get; set; }
    }
}

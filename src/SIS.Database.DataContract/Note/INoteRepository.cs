using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Note
{
    public interface INoteRepository
    {
        Task<bool> CreateNote(NoteCreateRAO rao);
    } 
}

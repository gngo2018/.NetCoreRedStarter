using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Note
{
    public interface INoteManager
    {
        Task<bool> CreateNote(NoteCreateDTO dto);
    }
}

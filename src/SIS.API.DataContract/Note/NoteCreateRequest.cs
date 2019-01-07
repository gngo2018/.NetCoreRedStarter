using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.API.DataContract.Note
{
    public class NoteCreateRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }

    }
}

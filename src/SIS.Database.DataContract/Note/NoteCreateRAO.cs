using System;
using System.Collections.Generic;
using System.Text;

namespace RedStarter.Database.DataContract.Note
{
    public class NoteCreateRAO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset DateCreate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RedStarter.Database.Entities.Note
{
    public class NoteEntity
    {
        [Key]
        public int NoteEntityId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Content { get; set; }
        [Required]
        public DateTimeOffset DateCreate { get; set; }
    }
}

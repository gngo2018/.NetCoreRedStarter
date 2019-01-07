using AutoMapper;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Note;
using RedStarter.Database.Entities.Note;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Note
{
    public class NoteRepository : INoteRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public NoteRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateNote(NoteCreateRAO rao)
        {
            var entity = _mapper.Map<NoteEntity>(rao);

            _context.NoteTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;

        }
    }
}

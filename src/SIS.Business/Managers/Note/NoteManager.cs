using AutoMapper;
using RedStarter.Business.DataContract.Note;
using RedStarter.Database.DataContract.Note;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Note
{
    public class NoteManager : INoteManager
    {
        private readonly IMapper _mapper;
        private readonly INoteRepository _repository;

        public NoteManager(IMapper mapper, INoteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreateNote(NoteCreateDTO dto)
        {
            var rao = _mapper.Map<NoteCreateRAO>(dto);

            if (await _repository.CreateNote(rao))
                return true;

            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learner.DAL.Abstract;
using Learner.Entities;

namespace Learner.DAL
{
    public class LearnerFakeDAL : ILearnerDAL
    {
        HashSet<WordDTO> storage = new HashSet<WordDTO>();

        public bool Add(WordDTO data)
        {
            storage.Add(data);

            return true;
        }

        public WordDTO Get(Guid Id)
        {
            var data = storage.FirstOrDefault(x => x.Id == Id);

            if (data == null)
            {
                throw new NotFoundException($"Can not found word by Id {Id}");
            }

            return data;
        }

        public IEnumerable<WordDTO> GetAllWords()
        {
            return storage;
        }

        public bool Remove(Guid Id)
        {
            WordDTO data;

            try
            {
                data = Get(Id);
            }
            catch (NotFoundException e)
            {
                throw e;
            }

            storage.Remove(data);

            return true;
        }

        public bool Update(WordDTO data)
        {
            if (data == null)
                throw new NullReferenceException();

            var oldWord = storage.FirstOrDefault(x => x.Id == data.Id);

            if (oldWord == null)
                throw new NotFoundException($"Can not found and update word by Id {data.Id}");

            storage.Remove(oldWord);
            storage.Add(data);

            return true;
        }
    }
}

using Learner.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learner.DAL.Abstract
{
    public interface ILearnerDAL
    {
        bool Add(WordDTO data);

        bool Remove(Guid Id);

        WordDTO Get(Guid Id);

        IEnumerable<WordDTO> GetAllWords();

        bool Update(WordDTO data);
    }
}

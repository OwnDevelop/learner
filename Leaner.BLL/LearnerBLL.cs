using Learner.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learner.Entities;
using Learner.DAL.Abstract;
using Learner.DAL;

namespace Leaner.BLL
{
    public class LearnerBLL : ILearnerBLL
    {
        ILearnerDAL dal;

        public LearnerBLL()
        {
             dal = new LearnerFakeDAL();
        }

        public bool Add(WordDTO data)
        {
            return dal.Add(data);
        }

        public WordDTO Get(Guid Id)
        {
            dal.Get(Id);
        }

        public IEnumerable<WordDTO> GetAllWords()
        {
            return dal.GetAllWords().ToArray();
        }

        public bool Remove(WordDTO data)
        {
            return dal.Remove(data);
        }

        public bool Update(WordDTO data)
        {
            throw new NotImplementedException();
        }
    }
}

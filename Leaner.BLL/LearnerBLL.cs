using Learner.BLL.Abstract;
using Learner.DAL;
using Learner.DAL.Abstract;
using Learner.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
           return dal.Get(Id);
        }

        public IEnumerable<WordDTO> GetAllWords()
        {
            return dal.GetAllWords().ToArray();
        }

        public bool Remove(Guid Id)
        {
            return dal.Remove(Id);
        }

        public bool Update(WordDTO data)
        {
            throw new NotImplementedException();
        }
    }
}

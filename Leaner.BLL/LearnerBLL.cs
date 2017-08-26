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
            try
            {
                return dal.Add(data);
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
        }

        public WordDTO Get(Guid Id)
        {
            try
            {
                return dal.Get(Id);
            }
            catch (NotFoundException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new UnknowException("Unknow exception", e);
            }
        }

        public IEnumerable<WordDTO> GetAllWords()
        {
            return dal.GetAllWords().ToArray();
        }

        public bool Remove(Guid Id)
        {
            try
            {
                return dal.Remove(Id);
            }
            catch (NotFoundException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new UnknowException("Unknow exception", e);
            }
        }

        public bool Update(WordDTO data)
        {
            try
            {
                return dal.Update(data);
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
            catch(NotFoundException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw new UnknowException("Unknow exception", e);
            }
        }
    }
}

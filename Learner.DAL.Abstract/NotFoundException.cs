using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learner.DAL.Abstract
{
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {

        }

        public NotFoundException(string massage) : base(massage)
        {

        }

        public NotFoundException(string massage, Exception innerException) : base(massage, innerException)
        {

        }
    }
}

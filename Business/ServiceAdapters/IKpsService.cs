using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.ServiceAdapters
{
    public interface IKpsService
    {
        bool ValidateUser(Member member);
    }
}

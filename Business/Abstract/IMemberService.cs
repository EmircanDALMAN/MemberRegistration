using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Shared.Utilities.Results;

namespace Business.Abstract
{
    public interface IMemberService
    {
        IDataResult<Member> Add(Member member);
    }
}

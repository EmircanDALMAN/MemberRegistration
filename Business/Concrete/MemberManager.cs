using Business.Abstract;
using Business.Constants;
using Business.ServiceAdapters;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using Shared.Aspects.Postsharp.ValidationAspects;
using Shared.Utilities.Business;
using Shared.Utilities.Results;

namespace Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private readonly IMemberDal _memberDal;
        private readonly IKpsService _kpsService;

        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public IDataResult<Member> Add(Member member)
        {
            var result = BusinessRules.Run(CheckIfMemberExists(member),
                CheckIfMemberValidFromKps(member));
            if (result!=null)
            {
                return new ErrorDataResult<Member>(result.Message);
            }
            return new SuccessDataResult<Member>(_memberDal.Add(member));
        }

        private IResult CheckIfMemberExists(Member member)
        {
            var result = _memberDal.Get(m => m.TcNo == member.TcNo);
            if (result!=null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfMemberValidFromKps(Member member)
        {
            var result = _kpsService.ValidateUser(member);
            if (result==false)
            {
                return new ErrorResult(Messages.UserValidateError);
            }

            return new SuccessResult();
        }
    }
}

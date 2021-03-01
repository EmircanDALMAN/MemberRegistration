using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business.Abstract;
using Entities.Concrete;
using MvcWebUI.Filters;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(Member member)
        {
            _memberService.Add(member);
            return View(new MemberAddViewModel());
        }
    }
}
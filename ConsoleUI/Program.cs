using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program 
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            var result = memberService.Add(new Member
            {
                FirstName = "Emircan",
                LastName = "Dalman",
                DateOfBirth = new DateTime(1998,11,22),
                TcNo = "1235235",
                Email = "emircandalman28@gmail.com",
                Id = 1
            });
            Console.WriteLine(result.Success ? "Eklendi" : result.Message);
        }
    }
}

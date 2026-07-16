using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    public class Member
    {
        public string Name { get; }
        public int MembershipNumber { get; }
        public int Age { get; }
        public Member(string name, int age, int membershipNumber)
        {
            this.Name = name;
            this.Age = age;
            this.MembershipNumber = membershipNumber;
        }
    }
}

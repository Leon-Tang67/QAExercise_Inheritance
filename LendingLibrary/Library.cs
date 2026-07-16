using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    public class Library
    {
        Dictionary<int, Member> members = new Dictionary<int, Member>();
        public int NumberOfMembers => members.Keys.Count;
        
        int GetNextFreeMembershipNumber()
        {
            return (members.Keys.Count == 0) ? 1 : members.Keys.Max() + 1;
        }
        
        public Member Add(string name, int age)
        {
            Member member =
            new Member(name, age, GetNextFreeMembershipNumber());
            members.Add(member.MembershipNumber, member);
            return member;
        }
    }
}

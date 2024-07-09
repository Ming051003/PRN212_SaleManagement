using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class MemberRepository : IMemberRepository
    {
        MemberDAO memberDAO = new MemberDAO();
        public Member CheckLogin(string email, string password)
        {
            Member member = GetMemberByEmail(email);
            if(member == null && !member.Password.Equals(password))
            {
                return null;
            }
            return member;
        }

        public Member GetMemberByEmail(string email)
        {
            return memberDAO.GetMemberByEmail(email);
        }

        public Member GetMemberById(int memberID)
        {
            return memberDAO.GetMemberById(memberID);
        }
    }
}

using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MemberDAO
    {
        public Member GetMemberById(int id)
        {
            using (SaleStoreDbContext db = new SaleStoreDbContext())
            {
                return db.Members.FirstOrDefault(m => m.MemberId.Equals(id));
            }
        }

        public Member GetMemberByEmail(string email)
        {
            using (SaleStoreDbContext db = new SaleStoreDbContext())
            {
                return db.Members.FirstOrDefault(m => m.Email.Equals(email));
            }
        }

    }
}

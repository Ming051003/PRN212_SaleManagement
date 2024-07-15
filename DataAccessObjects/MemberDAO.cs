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

        public void AddMember(Member member)
        {
            using (SaleStoreDbContext db = new SaleStoreDbContext())
            {
                db.Members.Add(member);
                db.SaveChanges();
            }
        }

        public void DeleteMember(int id)
        {
            using (SaleStoreDbContext db = new SaleStoreDbContext())
            {
                Member member = GetMemberById(id);
                if (member != null)
                {
                    db.Members.Remove(member);
                    db.SaveChanges();
                }
            }
        }

        public void UpdateMember(Member member) 
        {
            using (SaleStoreDbContext db = new SaleStoreDbContext())
            {
                db.Members.Update(member);
                db.SaveChanges();
            }
        }

        public List<Member> GetAllMembers()
        {
            using(SaleStoreDbContext db = new SaleStoreDbContext())
            {
                return db.Members.ToList();
            }
        }



    }
}

using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibraryApp.DataAccess.Implementations
{
    public class MemberRepository : IRepository<Member>
    {
        public void Delete(int id)
        {
            Member memberDb = StaticDb.Members.FirstOrDefault(x => x.Id == id);
            if (memberDb == null)
            {
                throw new Exception($"Member with id {id} not found");
            }
            StaticDb.Members.Remove(memberDb);
        }

        public List<Member> GetAll()
        {
            return StaticDb.Members;
        }

        public Member GetById(int id)
        {
            return StaticDb.Members.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Member entity)
        {
            entity.Id = ++StaticDb.MemberId;
            entity.ReservationsPerMember = new List<Reservation>();
            StaticDb.Members.Add(entity);
            return entity.Id;
        }

        public void Update(Member entity)
        {
            Member memberDb = StaticDb.Members.FirstOrDefault(x => x.Id == entity.Id);
            if (memberDb == null)
            {
                throw new Exception($"Member with id {entity.Id} not found");
            }
            int index = StaticDb.Members.IndexOf(memberDb);
            StaticDb.Members[index] = entity;
        }
    }
}

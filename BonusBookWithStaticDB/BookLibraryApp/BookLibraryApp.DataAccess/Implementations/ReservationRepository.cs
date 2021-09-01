using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibraryApp.DataAccess.Implementations
{
    public class ReservationRepository : IRepository<Reservation>
    {
        public void Delete(int id)
        {
            Reservation reservationDb = StaticDb.Reservations.FirstOrDefault(x => x.Id == id);
            if (reservationDb == null)
            {
                throw new Exception($"Reservation with id {id} not found");
            }
            StaticDb.Reservations.Remove(reservationDb);
            int memberIndex = reservationDb.MemberId - 1;
            Reservation reservationMember = StaticDb.Members[memberIndex].ReservationsPerMember.FirstOrDefault(x => x.Id == id);
            StaticDb.Members[memberIndex].ReservationsPerMember.Remove(reservationMember);

        }

        public List<Reservation> GetAll()
        {
            return StaticDb.Reservations;
        }

        public Reservation GetById(int id)
        {
            return StaticDb.Reservations.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Reservation entity)
        {
            entity.Id = ++StaticDb.ReservationId;
            StaticDb.Reservations.Add(entity);
            int memberIndex = entity.MemberId - 1;
            StaticDb.Members[memberIndex].ReservationsPerMember.Add(entity);
            return entity.Id;
        }

        public void Update(Reservation entity)
        {
            Reservation reservationDb = StaticDb.Reservations.FirstOrDefault(x => x.Id == entity.Id);
            if (reservationDb == null)
            {
                throw new Exception($"Reservation with id {entity.Id} not found");
            }
            if (reservationDb.MemberId != entity.MemberId)
            {
                int oldMemberIndex = reservationDb.MemberId - 1;
                Reservation reservationMember = StaticDb.Members[oldMemberIndex].ReservationsPerMember.FirstOrDefault(x => x.Id == entity.Id);
                StaticDb.Members[oldMemberIndex].ReservationsPerMember.Remove(reservationMember);
                int newMemberIndex = entity.MemberId - 1;
                StaticDb.Members[newMemberIndex].ReservationsPerMember.Add(entity);
            }
            int index = StaticDb.Reservations.IndexOf(reservationDb);
            StaticDb.Reservations[index] = entity;
        }
    }
}

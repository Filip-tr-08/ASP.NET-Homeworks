using BookLibraryApp.DataAccess;
using BookLibraryApp.DataAccess.Implementations;
using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Mappers;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.ReservationViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibraryApp.Services.Implementations
{
    public class ReservationService : IReservationServices
    {
        private IRepository<Reservation> _reservationRepository;
        private IRepository<Member> _memberRepository;
        private IBookRepository _bookRepository;

        public ReservationService(IRepository<Reservation> reservationRepository,IRepository<Member> memberRepository, IBookRepository bookRepository)
        {
            _reservationRepository = reservationRepository;
            _memberRepository = memberRepository;
            _bookRepository = bookRepository;
        }


        public List<ReservationListViewModel> GetAllReservations()
        {
            List<Reservation> dbReservations = _reservationRepository.GetAll();
            return dbReservations.Select(x => x.ReservationToReservationListViewModel()).ToList();
        }


        public ReservationDetailsViewModel GetReservationById(int id)
        {
            Reservation reservationDb = _reservationRepository.GetById(id);
            if (reservationDb == null)
            {
                throw new Exception($"The reservation with id {id} was not found");
            }
            return reservationDb.ReservationToReservationDetailsViewModel();
        }


        public void CreateReservation(ReservationViewModel reservationViewModel)
        {
            Member memberDb = _memberRepository.GetById(reservationViewModel.MemberId);
            if (memberDb == null)
            {
                throw new Exception($"Member with id {reservationViewModel.MemberId} was not found");
            }
            Reservation reservation = reservationViewModel.ToReservation();
            reservation.Member = memberDb;
            int newReservationId = _reservationRepository.Insert(reservation);
            if (newReservationId <= 0)
            {
                throw new Exception("An error occured while saving in db");
            }
        }
        public ReservationViewModel GetReservationForEditing(int id)
        {
            Reservation reservationDb = _reservationRepository.GetById(id);
            if (reservationDb == null)
            {
                throw new Exception($"The reservation with id {id} was not found");
            }
            return reservationDb.ReservationToReservatioViewModel();
        }
        public void EditReservation(ReservationViewModel reservationViewModel)
        {
            Reservation reservation = _reservationRepository.GetById(reservationViewModel.Id);
            if (reservation == null)
            {
                throw new Exception($"The reservation with id {reservationViewModel.Id} was not found");
            }
            Member memberDb = _memberRepository.GetById(reservationViewModel.MemberId);
            if (memberDb == null)
            {
                throw new Exception($"The member with id {reservationViewModel.Id} was not found");
            }
            Reservation editedReservation = reservationViewModel.ToReservation();
            editedReservation.Member = memberDb;
            editedReservation.Id = reservationViewModel.Id; ;
            editedReservation.BookReservations = reservation.BookReservations;
            _reservationRepository.Update(editedReservation);
    }
        public void DeleteReservation(int id)
        {
            Reservation reservationDb = _reservationRepository.GetById(id);
            if (reservationDb == null)
            {
                throw new Exception($"The reservation with id {id} was not found");
            }
            _reservationRepository.Delete(id);
        }
        public void AddBookToReservation(BookReservationViewModel bookReservationViewModel)
        {
            Book bookDb = _bookRepository.GetById(bookReservationViewModel.BookId);
            if (bookDb == null)
            {
                throw new Exception($"Book with id {bookReservationViewModel.BookId} was not found");
            }
            Reservation reservationDb = _reservationRepository.GetById(bookReservationViewModel.ReservationId);
            if (reservationDb == null)
            {
                throw new Exception($"Reservation with id {bookReservationViewModel.ReservationId} was not found");
            }
            reservationDb.BookReservations.Add(new BookReservation
            {
                Book = bookDb,
                BookId = bookDb.Id,
                BookGenre=bookReservationViewModel.BookGenre
            });;
        }
    }
   
}

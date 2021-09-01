using BookLibraryApp.Domain.Models;
using BookLibraryApp.ViewModels.ReservationViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLibraryApp.Domain.Enums;

namespace BookLibraryApp.Mappers
{
    public static class ReservationMapper
    {
        public static ReservationListViewModel ReservationToReservationListViewModel(this Reservation reservation)
        {
            return new ReservationListViewModel()
            {
                Id=reservation.Id,
                MemberFullName = $"{reservation.Member.FirstName} {reservation.Member.LastName}",
                BookTitles = reservation.BookReservations.Select(x => x.Book.Title).ToList(),
                DateTimeBegin = reservation.DateTimeBegin,
                DateTimeEnd = reservation.DateTimeEnd,
                ReservationMethod = reservation.ReservationMethod == ReservationMethod.AtLibrary ? "at library" : "at home",
            };
        }
        public static ReservationDetailsViewModel ReservationToReservationDetailsViewModel(this Reservation reservation)
        {
            return new ReservationDetailsViewModel
            {
                Id=reservation.Id,
                PaymentMethod = reservation.PaymentMethod,
                ReservationMethod = reservation.ReservationMethod==ReservationMethod.AtLibrary?"at library":"at home",
                DateTimeBegin = reservation.DateTimeBegin,
                DateTimeEnd = reservation.DateTimeEnd,
                MemberFullName = $"{reservation.Member.FirstName} {reservation.Member.LastName}",
                Books = reservation.BookReservations.Select(x => x.Book).ToList(),
            };
        }
        public static Reservation ToReservation(this ReservationViewModel reservationViewModel)
        {
            return new Reservation
            {
                Id=reservationViewModel.Id,
                DateTimeBegin = reservationViewModel.DateTimeBegin,
                DateTimeEnd = reservationViewModel.DateTimeEnd,
                PaymentMethod = reservationViewModel.PaymentMethod,
                ReservationMethod = reservationViewModel.ReservationMethod,
                MemberId = reservationViewModel.MemberId,
                BookReservations = new List<BookReservation>()
            };
        }
        public static ReservationViewModel ReservationToReservatioViewModel(this Reservation reservation)
        {
            return new ReservationViewModel
            {
                Id=reservation.Id,
                MemberId=reservation.MemberId,
                PaymentMethod=reservation.PaymentMethod,
                ReservationMethod=reservation.ReservationMethod,
                DateTimeBegin=reservation.DateTimeBegin,
                DateTimeEnd=reservation.DateTimeEnd
            };
        }
    }
}

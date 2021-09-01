using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.ViewModels.ReservationViewModel;

namespace BookLibraryApp.Services.Interfaces
{
    public interface IReservationServices
    {
        List<ReservationListViewModel> GetAllReservations();
        ReservationDetailsViewModel GetReservationById(int id);
        void CreateReservation(ReservationViewModel reservationViewModel);
        ReservationViewModel GetReservationForEditing(int id);
        void EditReservation(ReservationViewModel reservationViewModel);
        void DeleteReservation(int id);
        void AddBookToReservation(BookReservationViewModel bookReservationViewModel);
    }
}

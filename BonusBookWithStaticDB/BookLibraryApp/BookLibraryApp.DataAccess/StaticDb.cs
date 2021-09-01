using BookLibraryApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryApp.Domain.Enums;
using System.Linq;

namespace BookLibraryApp.DataAccess
{
    public static class StaticDb
    {
        public static int AuthorId { get; set; }
        public static int BookId { get; set; }
        public static int MemberId { get; set; }
        public static int ReservationId { get; set; }
        public static int BookReservationId { get; set; }
        public static List<Author> Authors { get; set; }
        public static List<Book> Books { get; set; }
        public static List<Reservation> Reservations { get; set; }
        public static List<Member> Members { get; set; }

        static StaticDb()
        {
            AuthorId = 2;
            BookId = 2;
            MemberId = 2;
            ReservationId = 2;
            BookReservationId = 2;
            Authors = new List<Author>
            {
                new Author
                {
                    Id=1,
                    FirstName="William",
                    LastName="Shakespare",
                    Nationality="English",
                    ImageLink="https://upload.wikimedia.org/wikipedia/commons/3/3c/Dostoevsky_1872.jpg",
                    Biography="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Books=new List<Book>
                    {
                                 new Book
                {
                    Id=1,
                    Title="Book1",
                    Pages=100,
                    Price=150,
                    Genre=Genre.Thriller,
                    AuthorId=1,
                    IsOnPromotion=true,
                    ImageLink="https://mir-s3-cdn-cf.behance.net/project_modules/1400_opt_1/56d96263885635.5acd0047cf3e6.jpg",
                    BookContent="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.",
                    BookReservations=new List<BookReservation>
                    {

                    }
                },
                    }
                },
                 new Author
                {
                    Id=2,
                    FirstName="Author2",
                    LastName="SecondAuthor",
                    Nationality="Macedonian",
                    ImageLink="https://upload.wikimedia.org/wikipedia/commons/3/3c/Dostoevsky_1872.jpg",
                    Biography="t is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                    Books=new List<Book>
                    {
                
                           new Book
                {
                    Id=2,
                    Title="Book2",
                    Pages=130,
                    Price=200,
                    Genre=Genre.Mystery,
                    AuthorId=2,
                    IsOnPromotion=false,
                    ImageLink="https://mir-s3-cdn-cf.behance.net/project_modules/1400_opt_1/56d96263885635.5acd0047cf3e6.jpg",
                    BookContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    BookReservations=new List<BookReservation>
                    {

                    }
                }
                    }
                }
            };
            Books = new List<Book>
            {
                new Book
                {
                    Id=1,
                    Title="Book1",
                    Pages=100,
                    Price=150,
                    Genre=Genre.Thriller,
                    AuthorId=1,
                    Author=Authors[0],
                    IsOnPromotion=true,
                    ImageLink="https://mir-s3-cdn-cf.behance.net/project_modules/1400_opt_1/56d96263885635.5acd0047cf3e6.jpg",
                    BookContent="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.",
                    BookReservations=new List<BookReservation>
                    {

                    }
                },
                 new Book
                {
                    Id=2,
                    Title="Book2",
                    Pages=130,
                    Price=200,
                    Genre=Genre.Mystery,
                    AuthorId=2, 
                    Author=Authors[1],
                    IsOnPromotion=false,
                    ImageLink="https://mir-s3-cdn-cf.behance.net/project_modules/1400_opt_1/56d96263885635.5acd0047cf3e6.jpg",
                    BookContent="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    BookReservations=new List<BookReservation>
                    {

                    }
                }
            };
            Members = new List<Member>
            {
                new Member
                {
                    Id=1,
                    FirstName="Member1",
                    LastName="Number1",
                    Address="Address1",
                    Age=25,
                    DateJoined=DateTime.Now,
                    ReservationsPerMember=new List<Reservation>
                    {
                       new Reservation
                {
                    Id=1,
                    PaymentMethod=PaymentMethod.Card,
                    ReservationMethod=ReservationMethod.Home,
                    DateTimeBegin=DateTime.Now,
                    DateTimeEnd=DateTime.Now.AddDays(2).AddHours(5),
                    MemberId=1,
                    BookReservations=new List<BookReservation>()
                    {
                         new BookReservation
                         {
                             Id=1,
                             BookId=Books[1].Id,
                             ReservationId=1,
                             Book=Books[1],
                             BookGenre=Books[1].Genre
                         }
                    }
                    }
                    }
                },
                 new Member
                {
                    Id=2,
                    FirstName="Member2",
                    LastName="Number2",
                    Address="Address2",
                    DateJoined=DateTime.Now,
                    Age=27,
                    ReservationsPerMember=new List<Reservation>
                    {
               new Reservation
                {
                    Id=2,
                    PaymentMethod=PaymentMethod.Cash,
                    ReservationMethod=ReservationMethod.AtLibrary,
                    DateTimeBegin=DateTime.Now,
                    MemberId=2,
                    DateTimeEnd=DateTime.Now.AddDays(2).AddHours(5),
                    BookReservations=new List<BookReservation>
                    {
                         new BookReservation
                         {
                             Id=2,
                             BookId=Books[0].Id,
                             ReservationId=2,
                             Book=Books[0],
                             BookGenre=Books[0].Genre
                         }
                    },
                }

                     }
                 }
            };
            Reservations = new List<Reservation>
            {
                new Reservation
                {
                    Id=1,
                    PaymentMethod=PaymentMethod.Card,
                    ReservationMethod=ReservationMethod.Home,
                    DateTimeBegin=DateTime.Now,
                    DateTimeEnd=DateTime.Now.AddDays(2).AddHours(5),
                    MemberId=1,
                    BookReservations=new List<BookReservation>()
                    {
                         new BookReservation
                         {
                             Id=1,
                             BookId=Books[1].Id,
                             ReservationId=1,
                             Book=Books[1],
                             BookGenre=Books[1].Genre
                         }
                    },
                    Member=Members[0],
              },
                new Reservation
                {
                    Id=2,
                    PaymentMethod=PaymentMethod.Cash,
                    ReservationMethod=ReservationMethod.AtLibrary,
                    DateTimeBegin=DateTime.Now,
                    MemberId=2,
                    DateTimeEnd=DateTime.Now.AddDays(2).AddHours(5),
                    BookReservations=new List<BookReservation>
                    {
                         new BookReservation
                         {
                             Id=2,
                             BookId=Books[0].Id,
                             ReservationId=2,
                             Book=Books[0],
                             BookGenre=Books[0].Genre
                         }
                    },
                    Member=Members[1]

                }
            };


        }



    }
}

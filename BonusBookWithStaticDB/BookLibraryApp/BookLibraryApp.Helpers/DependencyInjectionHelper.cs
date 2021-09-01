using BookLibraryApp.DataAccess;
using BookLibraryApp.DataAccess.Implementations;
using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Services.Implementations;
using BookLibraryApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; //instalirame Nuget paket
using System;
using System.Collections.Generic;
using System.Text;


namespace BookLibraryApp.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IReservationServices, ReservationService>();
            services.AddTransient<IMemberServices, MemberService>();
            services.AddTransient<IBookServices, BookService>();
            services.AddTransient<IAuthorServices, AuthorService>();
        }
        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<Reservation>, ReservationRepository>();
            services.AddTransient<IRepository<Member>, MemberRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IRepository<Author>, AuthorRepository>();
        }
    }
}

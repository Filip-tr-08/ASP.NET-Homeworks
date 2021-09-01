using BookLibraryApp.Domain.Models;
using BookLibraryApp.ViewModels.MemberViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Mappers
{
    public static class MemberMapper
    {
        public static MemberDDViewModel MemberToMemberDDViewModel(this Member member)
        {
            return new MemberDDViewModel
            {
                Id = member.Id,
                MemberFullName = $"{member.FirstName} {member.LastName}"
            };
        }
        public static MemberListViewModel MemberToMemberListViewModel(this Member member)
        {
            return new MemberListViewModel
            {
                Id = member.Id,
                Age=member.Age,
                FullName=$"{member.FirstName} {member.LastName}"
            };
        }
        public static MemberDetailsViewModel MemberToMemberDetailsViewModel(this Member member)
        {
            return new MemberDetailsViewModel
            {
                Id = member.Id,
                FullName = $"{member.FirstName} {member.LastName}",
                Age = member.Age,
                Address = member.Address,
                DateJoined = member.DateJoined,
                ReservationsPerMember = member.ReservationsPerMember,
            };
        }
        public static Member MemberViewModelToMember (this MemberViewModel memberViewModel)
        {
            return new Member
            {
                FirstName = memberViewModel.FirstName,
                LastName=memberViewModel.LastName,
                Address=memberViewModel.Address,
                Age=memberViewModel.Age,
                DateJoined=memberViewModel.DateJoined
            };
        }
        public static MemberViewModel MemberToMemberViewModel(this Member member)
        {
            return new MemberViewModel
            {
                Id=member.Id,
                FirstName=member.FirstName,
                LastName=member.LastName,
                Address=member.Address,
                Age=member.Age,
                DateJoined=member.DateJoined
            };
        }
    }
}

using BookLibraryApp.DataAccess.Interfaces;
using BookLibraryApp.Domain.Models;
using BookLibraryApp.Mappers;
using BookLibraryApp.Services.Interfaces;
using BookLibraryApp.ViewModels.MemberViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibraryApp.Services.Implementations
{
    public class MemberService : IMemberServices
    {
        private IRepository<Member> _memberRepository;
        public MemberService(IRepository<Member> memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public void CreateMember(MemberViewModel memberViewModel)
        {
            Member memberDb = memberViewModel.MemberViewModelToMember();
            int newMemberId=_memberRepository.Insert(memberDb);
            if (newMemberId <= 0)
            {
                throw new Exception("An error occured while saving member to the db");
            }
        }

        public List<MemberDDViewModel> GetMembersForDropDown()
        {
            List<Member> membersDb = _memberRepository.GetAll();
            return membersDb.Select(x => x.MemberToMemberDDViewModel()).ToList();
        }

        public MemberDetailsViewModel GetMember(int id)
        {
            Member member = _memberRepository.GetById(id);
            if (member == null)
            {
                throw new Exception($"Member with id {id} was not found");
            }
            return member.MemberToMemberDetailsViewModel();
        }

        public List<MemberListViewModel> GetMembersList()
        {
            List<Member> members = _memberRepository.GetAll();
            return members.Select(x => x.MemberToMemberListViewModel()).ToList();
        }
        public MemberViewModel GetMemberForEditing(int id)
        {
            Member memberDb = _memberRepository.GetById(id);
            if (memberDb == null)
            {
                throw new Exception($"The member with id {id} was not found");
            }
            return memberDb.MemberToMemberViewModel();
        }
        public void EditMember(MemberViewModel memberViewModel)
        {
            Member memberDb = _memberRepository.GetById(memberViewModel.Id);
            if (memberDb == null)
            {
                throw new Exception($"The member with id {memberViewModel.Id} was not found");
            }
           
            Member editedMember = memberViewModel.MemberViewModelToMember();
          
            editedMember.Id = memberViewModel.Id; ;
            
            _memberRepository.Update(editedMember);
        }
        public void DeleteMember(int id)
        {
            Member memberDb = _memberRepository.GetById(id);
            if (memberDb == null)
            {
                throw new Exception($"The member with id {id} was not found");
            }
            _memberRepository.Delete(id);
        }
    }
}

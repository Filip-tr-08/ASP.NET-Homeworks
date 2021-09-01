using BookLibraryApp.ViewModels.MemberViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryApp.Services.Interfaces
{
   public interface IMemberServices
    {
        List<MemberDDViewModel> GetMembersForDropDown();
        public List<MemberListViewModel> GetMembersList();
        MemberDetailsViewModel GetMember(int id);
        void CreateMember(MemberViewModel memberViewModel);
        MemberViewModel GetMemberForEditing(int id);
        void EditMember(MemberViewModel memberViewModel);
        void DeleteMember(int id);
    }
}

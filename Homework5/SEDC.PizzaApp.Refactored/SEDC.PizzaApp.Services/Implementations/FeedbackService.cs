using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class FeedbackService : IFeedbackService
    {
        private IFeedbackRepository _feedbackRepository;

        public FeedbackService(IFeedbackRepository feedbackRepository, IRepository<User> userRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public void CreateFeedback(FeedbackViewModel feedbackViewModel)
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll().Where(x => x.Email == (feedbackViewModel.FeedbackViewModelToFeedback()).Email).ToList();
            if (feedbacks.Count == 3)
            {
                throw new Exception("Can't post anymore feedbacks you have already posted three");
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(feedbackViewModel.Email);
            if (!match.Success) 
            {
                throw new Exception("Email is not in correct format");
            }
            Feedback feedback = feedbackViewModel.FeedbackViewModelToFeedback();
            int newFeedbackId = _feedbackRepository.Insert(feedback);
            if (newFeedbackId <= 0)
            {
                throw new Exception("An error occured while saving to db");
            }
        }

        public void DeleteFeedback(int id)
        {
            Feedback feedback = _feedbackRepository.GetById(id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            _feedbackRepository.DeleteById(id);
        }

        public void EditFeedback(FeedbackViewModel feedbackViewModel)
        {
            Feedback feedback = _feedbackRepository.GetById(feedbackViewModel.Id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {feedbackViewModel.Id} was not found");
            }
            List<Feedback> feedbacks = _feedbackRepository.GetAll().Where(x => x.Email == (feedbackViewModel.FeedbackViewModelToFeedback()).Email).ToList();
            if (feedbacks.Count == 3)
            {
                throw new Exception("Can't post anymore feedbacks you have already posted three");
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(feedbackViewModel.Email);
            if (!match.Success)
            {
                throw new Exception("Email is not in correct format");
            }
            Feedback editedFeedback = feedbackViewModel.FeedbackViewModelToFeedback();
            editedFeedback.Id = feedbackViewModel.Id;
            _feedbackRepository.Update(editedFeedback);

        }

        public List<FeedbackListViewModel> GetAllFeedbacks()
        {
            List<Feedback> feedbacks = _feedbackRepository.GetAll();
            return feedbacks.Select(x => x.FeedbackToFeedbackListViewModel()).ToList();
        }

        public FeedbackDetailsViewModel GetFeedbackDetails(int id)
        {
            Feedback feedback = _feedbackRepository.GetById(id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            return feedback.FeedbackToFeedbackDetailsViewModel();
        }

        public FeedbackViewModel GetFeedbackForEditing(int id)
        {
            Feedback feedback = _feedbackRepository.GetById(id);
            if (feedback == null)
            {
                throw new Exception($"Feedback with id {id} was not found");
            }
            return feedback.FeedbackToFeedbackViewModel();
        }
    }
}

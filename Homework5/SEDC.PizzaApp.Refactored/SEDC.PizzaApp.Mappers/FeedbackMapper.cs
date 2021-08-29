using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Mappers
{
    public static class FeedbackMapper
    {
        public static FeedbackDetailsViewModel FeedbackToFeedbackDetailsViewModel(this Feedback feedback)
        {
            return new FeedbackDetailsViewModel
            {
                Id=feedback.Id,
                Name=feedback.Name,
                Email=feedback.Email,
                Message=feedback.Message
            };
        }
        public static FeedbackListViewModel FeedbackToFeedbackListViewModel (this Feedback feedback)
        {
            return new FeedbackListViewModel
            {
                Id = feedback.Id,
                Email = feedback.Email,
                 Name=feedback.Name
            };
        }
        public static Feedback FeedbackViewModelToFeedback(this FeedbackViewModel feedbackViewModel)
        {
            return new Feedback
            {
                Id = feedbackViewModel.Id,
                Email=feedbackViewModel.Email,
                Name=feedbackViewModel.Name,
                Message=feedbackViewModel.Message
            };
        }
        public static FeedbackViewModel FeedbackToFeedbackViewModel(this Feedback feedback)
        {
            return new FeedbackViewModel
            {
                Id = feedback.Id,
                Email = feedback.Email,
                Name = feedback.Name,
                Message = feedback.Message
            };
        }
    }
}

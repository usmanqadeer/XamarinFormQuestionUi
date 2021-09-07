using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XFUIDesign.Models;
using XFUIDesign.Services;

namespace XFUIDesign.ViewModels
{
    public class QuestionsDetailPageViewModel : BaseViewModel
    {
        public  QuestionsModel Questions { get; set; }
        public ObservableCollection<QuestionsSteps> questionsSteps { get; set; }
        public QuestionsDetailPageViewModel(QuestionsModel questionsModel)
        {
            Questions = questionsModel;
            questionsSteps = new ObservableCollection<QuestionsSteps>();
            GetAllSteps();
        }

        private void GetAllSteps()
        {
            var steps = MockDataStore.GetStepsAsync();
            foreach (var item in steps)
            {
                questionsSteps.Add(item);
            }
        }
    }
}

using System.Collections.ObjectModel;
using XFUIDesign.Models;
using System.Threading.Tasks;
using XFUIDesign.Services;
using System.Collections.Generic;

namespace XFUIDesign.ViewModels
{
    public class QuestionsViewModel :BaseViewModel
    {
        public  ObservableCollection<QuestionsModel> QuestionsModel { get; set; }
        public QuestionsViewModel()
        {
            QuestionsModel = new ObservableCollection<QuestionsModel>();
            LoadAllQuestions();
        }

        private void  LoadAllQuestions()
        {
            var allQuestions = MockDataStore.GetItemsAsync();
            foreach (var item in allQuestions)
            {
                QuestionsModel.Add(item);
            }
        }
    }
}

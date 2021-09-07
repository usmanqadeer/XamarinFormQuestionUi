using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFUIDesign.Models;
using XFUIDesign.ViewModels;

namespace XFUIDesign.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionDetailPage : ContentPage
    {
      
        public QuestionDetailPage(QuestionsModel questionsModel)
        {
            InitializeComponent();
            this.BindingContext = new QuestionsDetailPageViewModel(questionsModel);
           
        }
    }
}
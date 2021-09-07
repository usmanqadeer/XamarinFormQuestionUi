using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFUIDesign.Models;

namespace XFUIDesign.Views
{
    public partial class QuestionPage : ContentPage
    {
        public QuestionPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var questionsModel = (sender as View).BindingContext as QuestionsModel;
            await Navigation.PushAsync(new QuestionDetailPage(questionsModel));

        }
    }
}
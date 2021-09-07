using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XFUIDesign.Models;

namespace XFUIDesign.Services
{
    public class MockDataStore 
    {
        public MockDataStore()
        {
            GetItemsAsync();
        }
        public static List<QuestionsModel> GetItemsAsync()
        {
            List<QuestionsModel> items = new List<QuestionsModel>()
            {
               
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1630520525949-4989e89dbbb5?ixid=MnwxMjA3fDB8MHxlZGl0b3JpYWwtZmVlZHw3NXx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description." ,Time = 23, Likes = 50, Users = 60 },
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1630523628169-0e0863cdf69a?ixid=MnwxMjA3fDB8MHxlZGl0b3JpYWwtZmVlZHw4OHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description." ,Time = 34, Likes = 720, Users = 30 },
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1630557802094-cee065ff725b?ixid=MnwxMjA3fDB8MHxlZGl0b3JpYWwtZmVlZHw5OXx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description."  ,Time = 36, Likes = 720, Users = 930 },
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1630518615523-0d82e3985c06?ixid=MnwxMjA3fDB8MHxlZGl0b3JpYWwtZmVlZHwxMjR8fHxlbnwwfHx8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description."  , Time = 44,Likes = 250, Users = 130 },
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1630513807049-9a9858825508?ixid=MnwxMjA3fDB8MHxlZGl0b3JpYWwtZmVlZHwxMjh8fHxlbnwwfHx8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description."  ,Time = 64, Likes = 20, Users = 30 },
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1630446400630-88dacc493459?ixid=MnwxMjA3fDB8MHxlZGl0b3JpYWwtZmVlZHwxMzJ8fHxlbnwwfHx8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description." , Time = 34,Likes = 50, Users = 60 },
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1630522791300-ba628fef4d34?ixid=MnwxMjA3fDB8MHxlZGl0b3JpYWwtZmVlZHwxMzR8fHxlbnwwfHx8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description."  , Time = 84,Likes = 320, Users = 530 },
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1586227740560-8cf2732c1531?ixid=MnwxMjA3fDF8MHxlZGl0b3JpYWwtZmVlZHwxMzh8fHxlbnwwfHx8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description." , Time = 37,Likes = 720, Users = 30 },
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1630512996510-c6a301d874cc?ixid=MnwxMjA3fDB8MHxlZGl0b3JpYWwtZmVlZHwxNTR8fHxlbnwwfHx8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description."  , Time = 124,Likes = 720, Users = 930 },
                new QuestionsModel { Id = Guid.NewGuid().ToString(), ImageUri = "https://images.unsplash.com/photo-1593642702909-dec73df255d7?ixid=MnwxMjA3fDF8MHxlZGl0b3JpYWwtZmVlZHwxOTh8fHxlbnwwfHx8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", Question="This is an item description."  ,Time = 44, Likes = 250, Users = 130 }
            };
            return items;
        }
        public static List<QuestionsSteps> GetStepsAsync()
        {
            List<QuestionsSteps> items = new List<QuestionsSteps>()
            {

                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number one"},
                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number two"},
                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number three"},
                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number four"},
                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number five"},
                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number six"},
                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number one"},
                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number two"},
                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number four"},
                new QuestionsSteps { StepId = Guid.NewGuid().ToString(),Steps = "Step number zero"}
            }; 
            return items;
        }
    }
}
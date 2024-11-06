using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EngHotel.Models;
using Syncfusion.Maui.Chat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngHotel.ViewModels.Shared
{
    public partial class NotesViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<NoteModel> notes = new ObservableCollection<NoteModel>();
        [ObservableProperty]
        private ObservableCollection<object> messages;

        /// <summary>
        /// Current user of the chat.
        /// </summary>
        [ObservableProperty]
        private Author currentUser;
        public NotesViewModel()
        {
            Messages = new ObservableCollection<object>();
            CurrentUser = new Author() { Name = "Nancy" };
            GenerateMessages();
            //LoadData();
        }
        
        void LoadData()
        {
            Notes.Add(new NoteModel
            {
                EmployeeName = "Abdullah Akl",
                Department = "Room Service",
                Note = "This mission needs more time."
            });

            Notes.Add(new NoteModel
            {
                EmployeeName = "Sara Alwan",
                Department = "Housekeeping",
                Note = "Completed all tasks for the day."
            });

            Notes.Add(new NoteModel
            {
                EmployeeName = "Omar Nassar",
                Department = "Maintenance",
                Note = "Waiting for new supplies to proceed."
            });

            Notes.Add(new NoteModel
            {
                EmployeeName = "Layla Hassan",
                Department = "Front Desk",
                Note = "Received multiple customer complaints."
            });

            Notes.Add(new NoteModel
            {
                EmployeeName = "Khalid Noor",
                Department = "IT Support",
                Note = "Network issue resolved successfully."
            });

            Notes.Add(new NoteModel
            {
                EmployeeName = "Maya Qasim",
                Department = "Room Service",
                Note = "Additional cleaning supplies requested."
            });

            Notes.Add(new NoteModel
            {
                EmployeeName = "Ahmed Bakr",
                Department = "Security",
                Note = "Need additional personnel for night shift."
            });

            Notes.Add(new NoteModel
            {
                EmployeeName = "Nadine Saleh",
                Department = "Catering",
                Note = "Special event scheduled for tomorrow."
            });

            Notes.Add(new NoteModel
            {
                EmployeeName = "Youssef Hadi",
                Department = "Customer Support",
                Note = "Issue with payment portal ongoing."
            });

            Notes.Add(new NoteModel
            {
                EmployeeName = "Rana Shaker",
                Department = "Maintenance",
                Note = "Urgent repair needed in guest room 210."
            });

        }

        [RelayCommand]
        async Task BackCLick()
        {
            await App.Current!.MainPage!.Navigation.PopAsync();
        }

        private void GenerateMessages()
        {
            Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
            });

            Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Andrea", Avatar = "user.png" },
                Text = "Oh! That's great.",
            });

            Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Harrison", Avatar = "user.png" },
                Text = "That is good news.",
            });

            Messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Margaret", Avatar = "user.png" },
                Text = "Are we going to develop the app natively or hybrid?",
            });

            Messages.Add(new TextMessage()
            {
                Author = CurrentUser,
                Text = "We should develop this app in .NET MAUI, since it provides native experience and performance.",
            });
        }
    }
}

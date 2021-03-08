﻿using ReactiveUI;

namespace System.Application.UI.ViewModels
{
    public class WindowViewModel : ViewModelBase
    {
        string title = string.Empty;
        public string Title
        {
            get => title;
            set => this.RaiseAndSetIfChanged(ref title, value);
        }

        public bool IsInitialized { get; set; }

        protected void InvokeOnUIDispatcher(Action action)
        {
            MainThreadDesktop.BeginInvokeOnMainThread(action);
        }
    }
}
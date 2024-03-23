﻿using Prism.Mvvm;

namespace Outlook.WPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly int resizeBorderThickness = 10;

        public int ResizeBorderThickness
        {
            get => resizeBorderThickness;
        }


        private int cornerRadius = 5;

        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                SetProperty(ref cornerRadius, value);
            }
        }

        private int captionHeight = 40;

        public int CaptionHeight
        {
            get => captionHeight;
            set
            {
                SetProperty(ref captionHeight, value);
            }
        }




        public MainWindowViewModel()
        {

        }
    }
}
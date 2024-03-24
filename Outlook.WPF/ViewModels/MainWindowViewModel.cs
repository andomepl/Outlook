using Prism.Mvvm;

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

        public const int DefaultResizeThickness= 10;

        private int resizeBorderThickness = DefaultResizeThickness;

        public int ResizeBorderThickness
        {
            get => resizeBorderThickness;
            set
            {
                SetProperty(ref resizeBorderThickness, value);
            }
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

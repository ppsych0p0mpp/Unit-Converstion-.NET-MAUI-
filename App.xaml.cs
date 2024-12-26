using Unit_Conversion.MVVM.Views;
namespace Unit_Conversion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ViewMenu());

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
            {
        #if __ANDROID__
                    handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);   
        #endif
            });
            Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping(nameof(BorderlessPicker), (handler, view) =>
            {
        #if __ANDROID__
                    handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);   
        #endif
            });

        }
    }
}

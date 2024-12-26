using Unit_Conversion.MVVM.ViewModels;

namespace Unit_Conversion.MVVM.Views;

public partial class ViewMenu : ContentPage
{
    public Command<string> TapCommand { get; }

    public ViewMenu()
	{
		InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var element = (Grid)sender;
        var option = ((Label)element.Children.LastOrDefault()).Text;
        var converterView =
            new ConvertView
            {
                BindingContext = new ConvertViewModel(option)
            };

        Navigation.PushAsync(converterView);
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {

        string option = LabelRef.Text;

        var converterView = new ConvertView
        {
            BindingContext = new ConvertViewModel(option)
        };

        Navigation.PushAsync(converterView);
    }
}
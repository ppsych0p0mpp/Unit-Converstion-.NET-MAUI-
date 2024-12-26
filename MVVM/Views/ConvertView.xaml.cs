using Unit_Conversion.MVVM.ViewModels;
using Microsoft.Maui.Devices;

namespace Unit_Conversion.MVVM.Views;

public partial class ConvertView : ContentPage
{
	public ConvertView()
	{
		InitializeComponent();

    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var viewModel
            = (ConvertViewModel)BindingContext;

        viewModel.Convert();
    }


}
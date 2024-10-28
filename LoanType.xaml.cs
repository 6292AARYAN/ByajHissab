using Microsoft.Maui.Media;
using System.IO;
namespace BYAJHISSAB;

public partial class LoanType : ContentPage
{
	public LoanType()
	{
		InitializeComponent();
        Routing.RegisterRoute("LoanType", typeof(LoanType));
        Routing.RegisterRoute("Emi", typeof(Emi));
    }
    private async void OnCapturePhotoButtonClicked(object sender, EventArgs e)
    {
        try
        {
            // Ensure the device has a camera and camera permission is granted
            if (MediaPicker.Default.IsCaptureSupported)
            {
                // Capture photo
                var photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    // Save to a temporary location
                    var stream = await photo.OpenReadAsync();
                    var memoryStream = new MemoryStream();
                    await stream.CopyToAsync(memoryStream);
                    memoryStream.Position = 0;
                    // Display the captured photo
                    CapturedImage.Source = ImageSource.FromStream(() => memoryStream);
                }
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"An error occurred while capturing the photo: {ex.Message}", "OK");
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/LoanType");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/Emi");
    }
}
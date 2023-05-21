using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace lab08QR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnScannerQR_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = new ZXing.Mobile.MobileBarcodeScanner(); // abre la cámara
                scanner.TopText = "QR Scan";
                scanner.BottomText = "Asegurarse de enfocar correctamente el código QR";
                
                // lee y valida el código QR
                var result = await scanner.Scan();
                if (result != null) 
                {
                    txtResultado.Text = result.Text;
                }
            }
            catch (Exception ex) 
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }

        }
    }
}

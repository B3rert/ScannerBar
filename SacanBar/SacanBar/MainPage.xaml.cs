using SacanBar.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SacanBar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async  void btnScan_Clicked(object sender, EventArgs e)
        {

            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtBarCode.Text = result;
                }
            }catch(Exception ex)
            {
                throw;
            }
            

        }
    }
}

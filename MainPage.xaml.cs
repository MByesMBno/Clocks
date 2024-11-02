using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;
using System.Data.Common;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Clocks
{
    public partial class MainPage : ContentPage
    {
        DateTime current;
        public MainPage()
        {
            InitializeComponent();
            Start();
        }
        private async Task Start()
        {
            var period = new PeriodicTimer(TimeSpan.FromSeconds(1));
            while (await period.WaitForNextTickAsync())
            {
                current = DateTime.Now;
                decimalHours.ClearCell();
                unitHours.ClearCell();
                decimalHours.PrintNumber(current.Hour / 10);
                unitHours.PrintNumber(current.Hour % 10);
                decimalMinutes.ClearCell();
                unitMinutes.ClearCell();
                decimalMinutes.PrintNumber(current.Minute / 10);
                unitMinutes.PrintNumber(current.Minute % 10);
                decimalSeconds.ClearCell();
                unitSeconds.ClearCell();
                decimalSeconds.PrintNumber(current.Second / 10);
                unitSeconds.PrintNumber(current.Second % 10);
                              
            }
        }


    }

}

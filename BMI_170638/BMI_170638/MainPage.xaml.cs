using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI_170638
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string Result = "";
            String Tm = hei.Text;
            String Hu = wei.Text;



            double height = double.Parse(Tm);
            double weight = double.Parse(Hu);

            height = height * 0.01;

            double BMI;
            BMI = weight / (height * height);

            double ret1 = Math.Floor(BMI);

            Result = ret1.ToString();

            Resu.Text = Result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabA_3_
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Btn_Clicked(object sender, System.EventArgs e)

{ 
            int weight = Int32.Parse(Inp_weight.Text);

            int height = Int32.Parse(Inp_height.Text);

            int final = (weight / height) * 2 * 703;

            Lbl_BMI.Text = $"Your BMI is {final}."; 

        }
    }
}

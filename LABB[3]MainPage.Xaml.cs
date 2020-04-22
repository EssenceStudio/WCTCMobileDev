[DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Btn_Clicked(object sender, System.EventArgs e)

{ 
            
            int age = Int32.Parse(Inp_Age.Text);

            int allow = 21;

            if (age > allow)
            {
                Lbl_Age.Text = $"You can Legally Buy Alcohol";
            }
            else
            {
                int time = allow - age;

                Lbl_Age.Text = $"You cannot Legally Buy Alcohol. You need to wait {time} more years";


            }
        }
    }
}

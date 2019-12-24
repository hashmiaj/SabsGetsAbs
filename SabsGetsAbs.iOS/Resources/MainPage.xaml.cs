using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SabsGetsAbs.Utilities;
using SabsGetsAbs.ViewModels;
using Xamarin.Forms;

namespace SabsGetsAbs
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// The width of the phone screen
        /// </summary>
        private new double Width;
        /// <summary>
        /// The height of the phone screen
        /// </summary>
        private new double Height;

        /// <summary>
        /// View Model
        /// </summary>
        MainPageVM ViewModel;


        public MainPage()
        {
            InitializeComponent();

            ViewModel = new MainPageVM();
            GuestName.Text = ViewModel.GetGuestByBarcode("123456");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

        /// <summary>
        /// Overriding this method to determine the orientation of the phone and positioning the views accordingly
        /// </summary>
        /// <param name="width">Width.</param>
        /// <param name="height">Height.</param>
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            //Checks to see if the orientation changed
            if (this.Width != width || this.Height != height)
            {
                this.Width = width;
                this.Height = height;

                RelativeLayoutUtil.ViewPositioning(BackgroundPic, 0, 0, 1, 1);
                RelativeLayoutUtil.ViewPositioning(MainGrid, 0, 0, 1, 1);
            }


        }
    }
}

using System;
using testeAds.Controls;
using Xamarin.Forms;

namespace testeAds
{
    public partial class testeAdsPage : ContentPage
    {
        public testeAdsPage()
        {
            InitializeComponent();

            LoadLayout();
        }

        void LoadLayout()
        {
            StackLayout stack = new StackLayout();

            Label label = new Label()
            {
                Text = "Label teste"
            };

            stack.Children.Add(label);

            AdView adview = new AdView();
            stack.Children.Add(adview);

            this.Content = stack;
        }
   }
}

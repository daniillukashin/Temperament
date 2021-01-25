using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Temperament

{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            ImageButton btn1;
            ImageButton btn2;
            ImageButton btn3;
            ImageButton btn4;
            ImageButton btn5;
            btn1 = new ImageButton
            {
                Source = "temp.jpg"
            };
            btn1.Clicked += Btn1_Clicked;
            var start = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "\nВиды темперамента",
                            TextColor = Color.Black,
                            BackgroundColor = Color.Yellow,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))

                        },
                        btn1
                    }
                }
            };
            btn2 = new ImageButton
            {
                Source = "holerik.PNG"
            };
            btn2.Clicked += Btn2_Clicked;
            var holerik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Холерик",
                            TextColor = Color.Black,
                            BackgroundColor = Color.Yellow,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        },
                        btn2
                    }
                }
            };
            btn3 = new ImageButton
            {
                Source = "sangvinik.PNG"
            };
            btn3.Clicked += Btn3_Clicked;
            var sangvinik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Сангвиник",
                            TextColor = Color.Black,
                            BackgroundColor = Color.Yellow,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                        },
                        btn3
                    }
                }
            };
            btn4 = new ImageButton
            {
                Source = "flegmatik.PNG"
            };
            btn4.Clicked += Btn4_Clicked;
            var flegmatik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Флегматик",
                            TextColor = Color.Black,
                            BackgroundColor = Color.Yellow,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        },
                        btn4
                    }
                }
            };
            btn5 = new ImageButton
            {
                Source = "melanholik.PNG"
            };
            btn5.Clicked += Btn5_Clicked;
            var melanholik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Меланхолик",
                            TextColor = Color.Black,
                            BackgroundColor = Color.Yellow,
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                        },
                        btn5
                    }
                }
            };
            Children.Add(start);
            Children.Add(holerik);
            Children.Add(sangvinik);
            Children.Add(flegmatik);
            Children.Add(melanholik);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }
        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/", BrowserLaunchMode.SystemPreferred);
        }
    }
}
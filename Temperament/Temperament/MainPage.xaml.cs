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
                        btn2,

                        new Label
                        {
                            Text = " это субъект, обладающий одним из четырёх основных типов темперамента, характеризующийся высоким уровнем психической активности, энергичностью действий, резкостью, стремительностью, силой движений, их быстрым темпом, порывистостью. Холерик вспыльчив, нетерпелив, подвержен эмоциональным срывам, всегда бывает агрессивным.Иван Петрович Павлов относил холерика к сильному неуравновешенному типу. При отсутствии надлежащего воспитания недостаточная эмоциональная уравновешенность может привести к неспособности контролировать свои эмоции в трудных жизненных обстоятельствах.",
                            TextColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Center,
                        },
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
                        btn3,

                        new Label
                        {
                            Text = "это личность, характеризующаяся высокой психической активностью, энергичностью, работоспособностью, быстротой и живостью движений, разнообразием и богатством мимики, быстрым темпом речи. Сангвиник стремится к частой смене впечатлений, легко и быстро отзывается на окружающие события, общителен. Эмоции у сангвиника преимущественно положительные, они быстро возникают и быстро сменяются. Он быстро приспосабливается к новым условиям и быстро сходится с людьми. Его чувства легко возникают и сменяются новыми, ему свойственна выразительность, но иногда и непостоянство.Иван Петрович Павлов считал, что у сангвиника возбудительный и тормозной процессы достаточно сильны, уравновешенны и подвижны[5]. Он [Павлов] относил данный тип темперамента к сильному типу[6]. При неблагоприятных условиях и отрицательных воспитательных влияниях эта подвижность может вылиться в отсутствие сосредоточенности, неоправданную поспешность поступков и поверхностность.",
                            TextColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Center,
                        },


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
                        btn4,

                        new Label
                        {
                            Text = "Человека флегматического темперамента можно охарактеризовать как медлительного, спокойного, с устойчивыми стремлениями и более или менее постоянным настроением, со слабым внешним выражением душевных состояний. Флегматик отличается сильным, уравновешенным, инертным типом нервной системы. Такие люди имеют надёжную память, а их решение является продуманным, взвешенным и без риска.У флегматика преобладает спокойное, ровное настроение; его чувства и эмоции обычно отличаются постоянством.Флегматик трудно переключается с одного вида деятельности на другой и приспосабливается к новой обстановке. Характерно то, что новые формы поведения у флегматика вырабатываются медленно, но долго сохраняются. Он редко выходит из себя, не склонен к конфликтам; ему свойственны ровность, спокойствие, выдержка, иногда вялость, безразличие к окружающим, лень. Павлов относил данный тип темперамента к сильному типу.При неблагоприятных условиях у флегматика может развиться вялость, бедность эмоций и склонность к выполнению однообразных привычных действий.",
                            TextColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Center,
                        },

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
                        btn5,

                        new Label
                        {
                            Text = "Человека меланхолического темперамента можно охарактеризовать как легкоранимого, склонного глубоко переживать даже незначительные трудности и неудачи, но внешне вяло реагирующего на окружающее. Меланхолики отличаются высокой сенситивностью и эмоциональной чувствительностью, как следствие возникает легкоранимость[4]. В некоторых сферах деятельности это является желательной личностной чертой, так как высокая эмоциональная чувствительность людей с меланхолическим темпераментом позволяет улавливать тончайшие эмоциональные выражения окружающих, особенно утончённых личностей.Для меланхоликов также характерно преобладание подавленного настроения и слабость волевой деятельности, проявляющаяся, например, в неуверенности в себе и нерешительности.При неблагоприятных условиях у них может развиться повышенная эмоциональная ранимость, замкнутость, отчуждённость. В спокойной, привычной для них обстановке, меланхолики могут успешно справляться с жизненными задачами.",
                            TextColor = Color.Black,
                            HorizontalTextAlignment = TextAlignment.Center,
                        },
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
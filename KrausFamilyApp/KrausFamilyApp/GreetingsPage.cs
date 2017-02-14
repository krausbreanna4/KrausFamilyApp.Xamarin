using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KrausFamilyApp
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            //BackgroundColor = Color.Teal;

            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    new Label
                     {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        VerticalTextAlignment = TextAlignment.End,
                        FormattedText = new FormattedString
                         {
                             Spans =
                             {
                                 
                                 new Span
                                 {
                                     Text = "\u2003Welcome! Let me introduce you to my family."+
                                     "I must warn you, its is small but it is great! \n",
                                     FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                     ForegroundColor = Color.Black,
                                     BackgroundColor = Color.Teal,


                                 },

                                 new Span
                                 {
                                     Text= "\u2003The First and most important member of my family is my mom, ",
                                     FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                     ForegroundColor = Color.Black,
                                     BackgroundColor = Color.Pink,
                                 },

                                 new Span
                                 {
                                     Text = "Julie",
                                     FontAttributes = FontAttributes.Bold,
                                     FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                     ForegroundColor = Color.Black,
                                     BackgroundColor = Color.Pink,


                                 },

                                 new Span
                                 {
                                     Text = " My mom is one of the strongest, most determined, woman I know." +
                                     "She raised me as a single parent, while continuing her education and working full time. " +
                                     "She inspired me to go to college and work hard. \n" ,
                                     FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                     ForegroundColor = Color.Black,
                                     BackgroundColor = Color.Pink

                                 },

                                 new Span
                                 {

                                    Text = "\u2003Next family member is the cutest one, she is one of a kind. " +
                                    "She's a loveable ball of fluff. Her name is ",
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.White,
                                    BackgroundColor = Color.Red

                                 },

                                 new Span
                                 {
                                    Text = "Sadie. \n\n\n" + Environment.NewLine + "",
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                    ForegroundColor = Color.White,
                                    BackgroundColor = Color.Red

                                 },

                                 new Span
                                 {

                                    Text = "\u2003Another member of my family is my grandma. Her name is ",
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.Black,
                                    BackgroundColor = Color.Yellow

                                 },

                                 new Span
                                 {
                                    Text = "Irene.",
                                    FontAttributes = FontAttributes.Bold,
                                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                    ForegroundColor = Color.Black,
                                    BackgroundColor = Color.Yellow

                                 },

                                 new Span
                                 {

                                    Text = "She is my favorite grandma, and I can say that because she's the only one I've known." +
                                    "She loves to sew and put puzzles together. Fun Fact about Irene, she has an identical twin sister, Iris.  \n",
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.Black,
                                    BackgroundColor = Color.Yellow
                                 },

                                 new Span
                                 {
                                     Text = "\u2003Abbigail ",
                                     FontAttributes = FontAttributes.Bold,
                                     FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                    ForegroundColor = Color.Black,
                                    BackgroundColor = Color.Lime

                                 },

                                 new Span
                                 {
                                     Text = "is the 2nd cutest member of my family. She, is what some people consider, a rainbow baby." +
                                     "A rainbow baby is a baby who has come after a miscarraige or two." + "She is one of the happiest of babies I have had the pleasure of meeting in my lifetime." +
                                     "I am very lucky to call her my cousin.  \n",
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.Black,
                                    BackgroundColor = Color.Lime

                                 },

                                 new Span
                                 {
                                     Text = "\u2003And then there is me,",
                                     FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                     ForegroundColor = Color.Black,
                                     BackgroundColor = Color.Purple
                                 },

                                 new Span
                                 {
                                     Text = " Breanna.",
                                     FontAttributes = FontAttributes.Bold,
                                     FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                                     ForegroundColor = Color.Black,
                                     BackgroundColor = Color.Purple

                                 },

                                 new Span
                                 {
                                    Text = " I'm 24 years old and have 3 half siblings that I met, online, last year." +
                                    "I love my small family and can't wait to see what the future holds.",
                                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                                    ForegroundColor = Color.Black,
                                    BackgroundColor = Color.Purple

                                 }
                             }
                         }
                     }


                 }
            };
            Content = new ScrollView
            {
                Orientation = ScrollOrientation.Vertical,
                Content = stackLayout
            };
        }

        //HorizontalOptions = LayoutOptions.Center,
        //VerticalOptions = LayoutOptions.Center,
        //TextColor = Color.White,


         
       };
 }
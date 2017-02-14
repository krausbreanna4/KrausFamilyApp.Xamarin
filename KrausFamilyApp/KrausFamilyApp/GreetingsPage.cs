﻿using System;
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
            BackgroundColor = Color.Teal;

            StackLayout stackLayout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                     new Label
                    {
                        Text = "\u2003Welcome! Let me introduce you to my family."+
                               "I must warn you, its is small but it is great! \n\n\n" + Environment.NewLine
                              + "The first and most important member of my family is my mom, ",
                        TextColor = Color.White,
                        FontSize = 20
                     },
                  new Label
                    {
                        Text = "Julie",
                        FontAttributes = FontAttributes.Bold,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        TextColor = Color.White

                     },
                   new Label
                    {
                        Text = " My mom is one of the strongest, most determined, woman I know." +
                                "She raised me as a single parent, while continuing her education and working full time. " +
                                "She inspired me to go to college and work hard.\n\n\n" + Environment.NewLine + ",
                        TextColor = Color.White,
                        FontSize = 20
                     },

                   new Label
                    {
                        Text = "Next family member is the cutest one, she is one of a kind. " +
                                       "She's a loveable ball of fluff. Her name is "
                        TextColor = Color.White,
                        FontSize = 20
                     },

                    new Label
                            {
                                Text = "Sadie. \n\n\n" + Environment.NewLine + "",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                            },

                     new Label
                            {
                                Text = "Another family member is my grandma "
                            },

                     new Label
                            {
                                Text = " Irene",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                            },

                      new Label
                            {
                                Text ="She loves to sew and work in her garden. She has an identical twin sister, Iris." +
                                "They love to sew Barbie doll and American Doll clothes together."

                            },

                     new Label
                            {
                                Text = " Abbigail ",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                            },

                     new Label
                            {
                                Text = "She is one of the cutest babies I have ever met. She is my cousins 1st child." +
                                "She is loved by many because she is very special. She is what is considered to be a 'Rainbow baby'" +
                                "A rainbow baby is a baby that comes after a failed pregnancy." + "She is special to all of our family and would trade her for the world."

                            },

                      new Label
                            {
                                Text = "And then there was me,"
                            },
                     new Label
                            {
                                Text = " Breanna.",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))

                            },
                      new Label
                            {
                                Text = " I'm 24 years old and have 3 half siblings that I met, online, last year." +
                                "I love my small family and can't wait to see what the future holds."
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
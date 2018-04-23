using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DataContext_Ex {

    class Person : DependencyObject {
        public string FirstName {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        public string LastName {
            get { return (string)GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }

        public string Title {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string Country {
            get { return (string)GetValue(CountryProperty); }
            set { SetValue(CountryProperty, value); }
        }

        public string City {
            get { return (string)GetValue(CityProperty); }
            set { SetValue(CityProperty, value); }
        }

        public string HomePhone {
            get { return (string)GetValue(HomePhoneProperty); }
            set { SetValue(HomePhoneProperty, value); }
        }

        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register("FirstName", typeof(string), typeof(Person), new UIPropertyMetadata(string.Empty));

        public static readonly DependencyProperty LastNameProperty =
            DependencyProperty.Register("LastName", typeof(string), typeof(Person), new UIPropertyMetadata(string.Empty));

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Person), new UIPropertyMetadata(string.Empty));

        public static readonly DependencyProperty CountryProperty =
            DependencyProperty.Register("Country", typeof(string), typeof(Person), new UIPropertyMetadata(string.Empty));

        public static readonly DependencyProperty CityProperty =
            DependencyProperty.Register("City", typeof(string), typeof(Person), new UIPropertyMetadata(string.Empty));
        
        public static readonly DependencyProperty HomePhoneProperty =
            DependencyProperty.Register("HomePhone", typeof(string), typeof(Person), new UIPropertyMetadata(string.Empty));
    }


    class MyDescriptionClass : DependencyObject {
        public string Description {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(MyDescriptionClass), new UIPropertyMetadata(string.Empty));

    }
}

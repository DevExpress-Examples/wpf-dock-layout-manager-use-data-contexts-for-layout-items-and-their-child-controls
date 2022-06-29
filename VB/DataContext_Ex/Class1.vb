Imports System.Windows

Namespace DataContext_Ex

    Friend Class Person
        Inherits DependencyObject

        Public Property FirstName As String
            Get
                Return CStr(GetValue(FirstNameProperty))
            End Get

            Set(ByVal value As String)
                SetValue(FirstNameProperty, value)
            End Set
        End Property

        Public Property LastName As String
            Get
                Return CStr(GetValue(LastNameProperty))
            End Get

            Set(ByVal value As String)
                SetValue(LastNameProperty, value)
            End Set
        End Property

        Public Property Title As String
            Get
                Return CStr(GetValue(TitleProperty))
            End Get

            Set(ByVal value As String)
                SetValue(TitleProperty, value)
            End Set
        End Property

        Public Property Country As String
            Get
                Return CStr(GetValue(CountryProperty))
            End Get

            Set(ByVal value As String)
                SetValue(CountryProperty, value)
            End Set
        End Property

        Public Property City As String
            Get
                Return CStr(GetValue(CityProperty))
            End Get

            Set(ByVal value As String)
                SetValue(CityProperty, value)
            End Set
        End Property

        Public Property HomePhone As String
            Get
                Return CStr(GetValue(HomePhoneProperty))
            End Get

            Set(ByVal value As String)
                SetValue(HomePhoneProperty, value)
            End Set
        End Property

        Public Shared ReadOnly FirstNameProperty As DependencyProperty = DependencyProperty.Register("FirstName", GetType(String), GetType(Person), New UIPropertyMetadata(String.Empty))

        Public Shared ReadOnly LastNameProperty As DependencyProperty = DependencyProperty.Register("LastName", GetType(String), GetType(Person), New UIPropertyMetadata(String.Empty))

        Public Shared ReadOnly TitleProperty As DependencyProperty = DependencyProperty.Register("Title", GetType(String), GetType(Person), New UIPropertyMetadata(String.Empty))

        Public Shared ReadOnly CountryProperty As DependencyProperty = DependencyProperty.Register("Country", GetType(String), GetType(Person), New UIPropertyMetadata(String.Empty))

        Public Shared ReadOnly CityProperty As DependencyProperty = DependencyProperty.Register("City", GetType(String), GetType(Person), New UIPropertyMetadata(String.Empty))

        Public Shared ReadOnly HomePhoneProperty As DependencyProperty = DependencyProperty.Register("HomePhone", GetType(String), GetType(Person), New UIPropertyMetadata(String.Empty))
    End Class

    Friend Class MyDescriptionClass
        Inherits DependencyObject

        Public Property Description As String
            Get
                Return CStr(GetValue(DescriptionProperty))
            End Get

            Set(ByVal value As String)
                SetValue(DescriptionProperty, value)
            End Set
        End Property

        Public Shared ReadOnly DescriptionProperty As DependencyProperty = DependencyProperty.Register("Description", GetType(String), GetType(MyDescriptionClass), New UIPropertyMetadata(String.Empty))
    End Class
End Namespace

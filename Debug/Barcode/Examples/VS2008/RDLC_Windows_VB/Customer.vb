Public Class Customer
    Private m_name As String
    Private m_address As String
    Private m_city As String
    Private m_state As String
    Private m_zip As String

    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(ByVal value As String)
            m_name = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return m_address
        End Get
        Set(ByVal value As String)
            m_address = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return m_city
        End Get
        Set(ByVal value As String)
            m_city = value
        End Set
    End Property

    Public Property State() As String
        Get
            Return m_state
        End Get
        Set(ByVal value As String)
            m_state = value
        End Set
    End Property

    Public Property Zip() As String
        Get
            Return m_zip
        End Get
        Set(ByVal value As String)
            m_zip = value
        End Set
    End Property

End Class

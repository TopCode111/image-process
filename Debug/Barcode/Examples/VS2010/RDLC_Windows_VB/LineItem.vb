Public Class LineItem
    Private m_product As String
    Private m_unitPrice As Decimal
    Private m_quantity As Integer

    Public Property Product() As String
        Get
            Return m_product
        End Get
        Set(ByVal value As String)
            m_product = value
        End Set
    End Property

    Public Property UnitPrice() As Decimal
        Get
            Return m_unitPrice
        End Get
        Set(ByVal value As Decimal)
            m_unitPrice = value
        End Set
    End Property

    Public Property Quantity() As Integer
        Get
            Return m_quantity
        End Get
        Set(ByVal value As Integer)
            m_quantity = value
        End Set
    End Property
End Class

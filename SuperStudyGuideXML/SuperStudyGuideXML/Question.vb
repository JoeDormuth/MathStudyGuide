Public Class Question
    Private QImage As Image
    Private ansA, ansB, ansC, ansD, QType As Boolean

    Public Sub New(ByVal QImage As Image, ByVal ansA As Boolean, ByVal ansB As Boolean, _
    ByVal ansC As Boolean, ByVal ansD As Boolean, ByVal QType As Boolean)
        Me.QImage = QImage
        Me.ansA = ansA
        Me.ansB = ansB
        Me.ansC = ansC
        Me.ansD = ansD
        Me.QType = QType
    End Sub

    Public ReadOnly Property QuestionImage() As Image
        Get
            Return QImage
        End Get
    End Property

    Public ReadOnly Property QuestionAnsA() As Boolean
        Get
            Return ansA
        End Get
    End Property

    Public ReadOnly Property QuestionAnsB() As Boolean
        Get
            Return ansB
        End Get
    End Property

    Public ReadOnly Property QuestionAnsC() As Boolean
        Get
            Return ansC
        End Get
    End Property

    Public ReadOnly Property QuestionAnsD() As Boolean
        Get
            Return ansD
        End Get
    End Property

    Public ReadOnly Property QuestionQType() As Boolean
        Get
            Return QType
        End Get
    End Property
End Class

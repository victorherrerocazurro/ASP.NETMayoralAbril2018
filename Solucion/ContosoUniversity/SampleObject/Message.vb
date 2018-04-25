Namespace SampleObject
    Public Class Message
        Implements IMessage
        Sub New()

        End Sub

        Public Function Display() As String Implements IMessage.Display
            Return "This Class has been Injected"
        End Function
    End Class
End Namespace
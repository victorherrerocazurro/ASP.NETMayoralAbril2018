Imports System.Runtime.CompilerServices

Public Module LabelExtensions
    <Extension>
    Public Function SimpleLabel(ByVal helper As HtmlHelper,
                                ByVal target As String,
                                ByVal text As String) As MvcHtmlString
        Return New MvcHtmlString(String.Format("<label for='{0}'>{1}</label>", target, text))
    End Function
End Module

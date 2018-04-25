Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private _SchoolService As ISchoolService

    'Será Unity, quien instancie este constructor, y por tanto deberá conocer un SchoolService
    'Aqui se produce Inyeccion de Dependencias por constructor
    Public Sub New(_SchoolService As ISchoolService)
        Me._SchoolService = _SchoolService
    End Sub

    'Home/Index/12?nombre=Victor

    Function Index(id As Integer, nombre As String) As ActionResult

        'Este New nos estorba prar tener las capas desacopladas, para poder desarrollar en paralelo

        Dim listadoDeCursos As IEnumerable(Of Course) = _SchoolService.ListarCursos()

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class

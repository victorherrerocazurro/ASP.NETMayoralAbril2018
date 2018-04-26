Public Class CoursesModelBinder
    Implements IModelBinder

    Public Function BindModel(controllerContext As ControllerContext, bindingContext As ModelBindingContext) As Object Implements IModelBinder.BindModel

        Dim Request As HttpRequestBase = controllerContext.HttpContext.Request
        Dim id As Integer = 0
        Integer.TryParse(Request.Form.Get("CourseID"), id)
        Dim Title As String = Request.Form.Get("Title")
        Dim Credits As String = Request.Form.Get("Credits")
        'Dim fechaNacimiento As DateTime
        'DateTime.TryParse(Request.Form.Get("FechaNacimiento"), fechaNacimiento)
        Dim Course = New With {.CourseID = id, .Title = Title, .Credits = Credits}
        Return Course


    End Function
End Class

'Describir las herramientas que ponemos en manos del Servicio para que implemente ek requisito
Public Interface ICourseDao

    Function Alta(Course As Course) As Integer

    Function Baja(CourseID As Integer) As Integer

    Function Baja() As Integer

    Function Modificacion(Course As Course) As Integer

    Function Consulta() As IEnumerable(Of Course)

    Function Consulta(CourseID As Integer) As Course

    Function Consulta(Title As String) As IEnumerable(Of Course)

End Interface

Imports ContosoUniversity

Public Class EntityFrameworkCourseDao
    Implements ICourseDao

    Private _SchoolContext As SchoolContext

    'Será Unity, quien instancie este constructor, y por tanto deberá conocer un SchoolService
    'Aqui se produce Inyeccion de Dependencias por constructor
    Public Sub New(_SchoolContext As SchoolContext)
        Me._SchoolContext = _SchoolContext
    End Sub

    Public Function Alta(Course As Course) As Integer Implements ICourseDao.Alta
        Dim NewCourse = _SchoolContext.Courses.Add(Course)
        Return NewCourse.CourseID
    End Function

    Public Function Baja(CourseID As Integer) As Integer Implements ICourseDao.Baja
        Throw New NotImplementedException()
    End Function

    Public Function Baja() As Integer Implements ICourseDao.Baja
        Throw New NotImplementedException()
    End Function

    Public Function Modificacion(Course As Course) As Integer Implements ICourseDao.Modificacion
        Throw New NotImplementedException()
    End Function

    Public Function Consulta() As IEnumerable(Of Course) Implements ICourseDao.Consulta
        Throw New NotImplementedException()
    End Function

    Public Function Consulta(CourseID As Integer) As Course Implements ICourseDao.Consulta
        Return _SchoolContext.Courses.Find(CourseID)
    End Function

    Public Function Consulta(Title As String) As IEnumerable(Of Course) Implements ICourseDao.Consulta

        Dim queryResults = From course In _SchoolContext.Courses
                           Where course.Title = Title

        Return queryResults.ToList

    End Function
End Class

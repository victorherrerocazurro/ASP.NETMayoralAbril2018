Imports System.Data.Entity
Imports ContosoUniversity

Public Class SchoolService
    Implements ISchoolService

    Private _CourseDao As ICourseDao

    'Será Unity, quien instancie este constructor, y por tanto deberá conocer un SchoolService
    'Aqui se produce Inyeccion de Dependencias por constructor
    Public Sub New(_CourseDao As ICourseDao)
        Me._CourseDao = _CourseDao
    End Sub

    'Represente un requisito funcional
    Private Function ListarCursos() As IEnumerable(Of Course) Implements ISchoolService.ListarCursos

        'Dim context As SchoolContext = New SchoolContext
        'Dim context As New SchoolContext
        'Dim context = New SchoolContext

        Return _CourseDao.Consulta

    End Function

End Class

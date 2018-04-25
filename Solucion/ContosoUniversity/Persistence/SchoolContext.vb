Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Public Class SchoolContext
    Inherits DbContext

    Public Sub New()
        'Define el nombre de la cadena de conexion a emplear
        MyBase.New("SchoolContext")
    End Sub

    'Representan una cache de las tablas de la base de datos
    Public Property Students As DbSet(Of Student)
    Public Property Enrollments As DbSet(Of Enrollment)
    Public Property Courses As DbSet(Of Course)

    'Permite cambiar los comportamientos por defecto
    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        'Se quita la configuracion por defecto que pone los nombres de las tablas en plural
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
    End Sub
End Class

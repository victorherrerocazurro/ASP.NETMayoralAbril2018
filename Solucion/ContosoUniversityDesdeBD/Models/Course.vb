Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Course")>
Partial Public Class Course
    Public Sub New()
        Enrollment = New HashSet(Of Enrollment)()
    End Sub

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property CourseID As Integer

    Public Property Title As String

    Public Property Credits As Integer

    Public Overridable Property Enrollment As ICollection(Of Enrollment)
End Class

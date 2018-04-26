Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Course")>
Partial Public Class Course
    Public Property CourseID As Integer

    Public Property Title As String

    Public Property Credits As Integer
End Class

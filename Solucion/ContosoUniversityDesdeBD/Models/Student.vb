Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Student")>
Partial Public Class Student
    Public Sub New()
        Enrollment = New HashSet(Of Enrollment)()
    End Sub

    Public Property StudentID As Integer

    Public Property LastName As String

    Public Property FirstMidName As String

    Public Property EnrollementDate As Date

    Public Overridable Property Enrollment As ICollection(Of Enrollment)
End Class

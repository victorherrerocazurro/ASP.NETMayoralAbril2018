Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Enrollment")>
Partial Public Class Enrollment
    Public Property EnrollmentID As Integer

    Public Property Grade As Integer

    Public Property CourseID As Integer

    Public Property StudentID As Integer

    Public Overridable Property Course As Course

    Public Overridable Property Student As Student
End Class

Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class ContosoUniversity
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=ContosoUniversity")
    End Sub

    Public Overridable Property Course As DbSet(Of Course)
    Public Overridable Property Enrollment As DbSet(Of Enrollment)
    Public Overridable Property Student As DbSet(Of Student)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class

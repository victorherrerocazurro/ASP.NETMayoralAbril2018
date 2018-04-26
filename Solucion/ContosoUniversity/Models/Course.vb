Imports System.ComponentModel.DataAnnotations

Public Class Course
    Implements IValidatableObject

    'PK
    Public Property CourseID() As Integer

    'Other
    <Required>
    Public Property Title() As String
    Public Property Credits() As Integer

    'Navigation Property
    Public Overridable Property Enrollments() As ICollection(Of Enrollment)

    Public Function Validate(validationContext As ValidationContext) As IEnumerable(Of ValidationResult) Implements IValidatableObject.Validate
        If Title <> Nothing And Title.Split(" ").Length > 2 Then
            Return New ValidationResult("El nombre tiene muchas palabras!", {"Nombre"})
        End If
    End Function
End Class

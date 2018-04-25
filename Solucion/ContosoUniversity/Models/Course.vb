Public Class Course
    'PK
    Public Property CourseID() As Integer

    'Other
    Public Property Title() As String
    Public Property Credits() As Integer

    'Navigation Property
    Public Overridable Property Enrollments() As ICollection(Of Enrollment)
End Class

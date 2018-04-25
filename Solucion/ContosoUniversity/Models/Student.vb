Public Class Student
    'PK
    Public Property StudentID() As Integer

    'Other
    Public Property LastName() As String
    Public Property FirstMidName() As String
    Public Property EnrollementDate() As DateTime

    'Navigation Property
    Public Overridable Property Enrollments() As ICollection(Of Enrollment)
End Class

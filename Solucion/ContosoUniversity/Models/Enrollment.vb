Public Class Enrollment
    'PK
    Public Property EnrollmentID() As Integer

    'Other
    Public Property Grade() As Grade

    'FK
    Public Property CourseID() As Integer
    Public Property StudentID() As Integer

    'Navigation Property
    'Entity Framework, me esta ejecutando la consultasobre la tabla Course sinque yo escriba SQL
    Public Overridable Property Course() As Course
    Public Overridable Property Student() As Student
End Class

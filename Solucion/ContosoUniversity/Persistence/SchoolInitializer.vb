Imports System.Data.Entity

Public Class SchoolInitializer
    Inherits DropCreateDatabaseIfModelChanges(Of SchoolContext)

    Protected Overrides Sub Seed(context As SchoolContext)
        MyBase.Seed(context)
        Dim students As List(Of Student) = New List(Of Student)()

        students.Add(New Student With {.FirstMidName = "Carson",
        .LastName = "Alexander", .EnrollementDate = DateTime.Parse("2005-09-01")})
        students.Add(New Student With {.FirstMidName = "Arturo",
        .LastName = "Anand", .EnrollementDate = DateTime.Parse("2003-09-01")})
        students.Add(New Student With {.FirstMidName = "Gytis",
        .LastName = "Barzdukas", .EnrollementDate = DateTime.Parse("2002-09-01")})
        students.Add(New Student With {.FirstMidName = "Yan",
        .LastName = "Li", .EnrollementDate = DateTime.Parse("2002-09-01")})
        students.Add(New Student With {.FirstMidName = "Peggy",
        .LastName = "Justice", .EnrollementDate = DateTime.Parse("2001-09-01")})
        students.Add(New Student With {.FirstMidName = "Laura",
        .LastName = "Norman", .EnrollementDate = DateTime.Parse("2003-09-01")})
        students.Add(New Student With {.FirstMidName = "Nino",
        .LastName = "Olivetto", .EnrollementDate = DateTime.Parse("2005-09-01")})

        For Each student As Student In students
            context.Students.Add(student)
        Next

        context.SaveChanges()

        Dim courses As List(Of Course) = New List(Of Course)()

        courses.Add(New Course With {.Title =
        "Chemistry", .Credits = 3})
        courses.Add(New Course With {.Title =
        "Microeconomics", .Credits = 3})
        courses.Add(New Course With {.Title =
        "Macroeconomics", .Credits = 3})
        courses.Add(New Course With {.Title =
        "Calculus", .Credits = 4})
        courses.Add(New Course With {.Title =
        "Trigonometry", .Credits = 4})
        courses.Add(New Course With {.Title =
        "Composition", .Credits = 3})
        courses.Add(New Course With {.Title =
        "Literature", .Credits = 4})

        For Each course As Course In courses
            context.Courses.Add(course)
        Next

        context.SaveChanges()

        Dim enrollments As List(Of Enrollment) = New List(Of Enrollment)()

        enrollments.Add(New Enrollment With {.StudentID = 1,
        .CourseID = 1, .Grade = Grade.A})
        enrollments.Add(New Enrollment With {.StudentID = 1,
        .CourseID = 4, .Grade = Grade.C})
        enrollments.Add(New Enrollment With {.StudentID = 1,
        .CourseID = 4, .Grade = Grade.B})
        enrollments.Add(New Enrollment With {.StudentID = 2,
        .CourseID = 1, .Grade = Grade.B})
        enrollments.Add(New Enrollment With {.StudentID = 2,
        .CourseID = 3, .Grade = Grade.F})
        enrollments.Add(New Enrollment With {.StudentID = 2,
        .CourseID = 2, .Grade = Grade.F})
        enrollments.Add(New Enrollment With {.StudentID = 3,
        .CourseID = 1})
        enrollments.Add(New Enrollment With {.StudentID = 4,
        .CourseID = 1})
        enrollments.Add(New Enrollment With {.StudentID = 4,
        .CourseID = 4, .Grade = Grade.F})
        enrollments.Add(New Enrollment With {.StudentID = 5,
        .CourseID = 4, .Grade = Grade.C})
        enrollments.Add(New Enrollment With {.StudentID = 6,
        .CourseID = 1})
        enrollments.Add(New Enrollment With {.StudentID = 7,
        .CourseID = 3, .Grade = Grade.A})

        For Each enrollment As Enrollment In enrollments
            context.Enrollments.Add(enrollment)
        Next

        context.SaveChanges()

    End Sub
End Class

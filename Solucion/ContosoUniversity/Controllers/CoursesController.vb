Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace ContosoUniversity
    Public Class CoursesController
        Inherits System.Web.Mvc.Controller

        Private db As New SchoolContext

        ' GET: Courses
        Function Index() As ActionResult
            Return PartialView(db.Courses.ToList())
        End Function

        ' GET: Courses/Details?id=5
        ' GET: Courses/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim course As Course = db.Courses.Find(id)
            If IsNothing(course) Then
                Return HttpNotFound()
            End If
            Return View(course)
        End Function

        ' GET: Courses/Create
        'Acceder al formulario
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Courses/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.

        'Si por debajo no hay EF, y tenemos una consulta que contempla el CourseID, al no recibirlo, 
        'nunca se establecera en la consulta
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Title,Credits")> ByVal course As Course) As ActionResult
            If ModelState.IsValid Then
                'Petcicion http a un web api
                db.Courses.Add(course)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(course)
        End Function

        ' GET: Courses/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim course As Course = db.Courses.Find(id)
            If IsNothing(course) Then
                Return HttpNotFound()
            End If
            Return View(course)
        End Function

        ' POST: Courses/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<ModelBinder(GetType(CoursesModelBinder))> ByVal course As Course) As ActionResult
            'Function Edit(<Bind(Include:="CourseID,Title,Credits")> ByVal course As Course) As ActionResult
            If ModelState.IsValid Then
                db.Entry(course).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(course)
        End Function

        ' GET: Courses/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim course As Course = db.Courses.Find(id)
            If IsNothing(course) Then
                Return HttpNotFound()
            End If
            Return View(course)
        End Function

        ' POST: Courses/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim course As Course = db.Courses.Find(id)
            db.Courses.Remove(course)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace

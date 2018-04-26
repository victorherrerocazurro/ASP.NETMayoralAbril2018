﻿<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Mi aplicación ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Nombre de aplicación", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li>@Html.ActionLink("Acerca de", "About", "Home")</li>
                    <li>@Html.ActionLink("Contacto", "Contact", "Home")</li>
                    <li>@Html.ActionLink("Estudiantes", "Index", "Students")</li>
                    <li>
                        @Ajax.ActionLink("Cursos", "Index", "Courses",
New AjaxOptions With {
.UpdateTargetId = "contenido-principal",
.InsertionMode = InsertionMode.Replace,
.HttpMethod = "GET"})
                </li>
            </ul>
        </div>
    </div>
</div>
<div id="contenido-principal" class="container body-content">
    @RenderBody()
    <hr />
    <footer>
        @Html.SimpleLabel("target", "testo")
        
        @helper TextoResaltado(ByVal text As String)
            @If String.IsNullOrWhiteSpace(text) Then
                @<h2>Default name</h2>
            Else
                @<h2>@text</h2>                                     
            End If
        End helper
        
        @TextoResaltado("Titulo")
        
        <p>&copy; @DateTime.Now.Year - Mi aplicación ASP.NET</p>
    </footer>
</div>

@Scripts.Render("~/bundles/jquery")
@Scripts.Render("~/bundles/bootstrap")
@Scripts.Render("~/Scripts/jquery.unobtrusive-ajax.min.js")
@RenderSection("scripts", required:=False)
</body>
</html>

﻿@ModelType ContosoUniversity.Student
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Student</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FirstMidName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FirstMidName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EnrollementDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EnrollementDate)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>

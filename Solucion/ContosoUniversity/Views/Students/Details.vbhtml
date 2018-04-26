@ModelType ContosoUniversity.Student
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.StudentID }) |
    @Html.ActionLink("Back to List", "Index")
</p>

@ModelType IEnumerable(Of ContosoUniversity.Student)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstMidName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EnrollementDate)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FirstMidName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EnrollementDate)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.StudentID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.StudentID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.StudentID })
        </td>
    </tr>
Next

</table>

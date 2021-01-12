@ModelType IEnumerable(Of MVCControllerDemo.User)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Home/index.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Username)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CreationDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Password)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Username)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CreationDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Password)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Email)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>

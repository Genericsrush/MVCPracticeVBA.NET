@ModelType MVCControllerDemo.User
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Home/index.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>User</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Username)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Username)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CreationDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CreationDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Password)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Password)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>

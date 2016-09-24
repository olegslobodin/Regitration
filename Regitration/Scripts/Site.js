$(document).ready(function () {
    var errorFields = $("span.field-validation-error:not(:empty)");
    errorFields.each(function (index) {
        var icon = "<span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\" style=\"color : red\"></span>";
        var errorField = errorFields.eq(index);
        var newErrorField = $("<a></a>").attr("title", errorField.text()).append(icon).qtip();
        errorField.after(newErrorField);
        errorField.remove();
    });
});
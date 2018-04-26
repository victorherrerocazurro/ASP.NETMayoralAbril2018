$(function () {
    $("#boton").click(function () {
        $.ajax({
            url: "/api/Courses",
            success: function (result) {
                $("#resultado").html(result);
            }
        });
    });
});
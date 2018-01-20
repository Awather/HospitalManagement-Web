$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#wrapper").toggleClass("toggled");

});

$(function () {
    $(".sidebar-wrapper").stick_in_parent({
        offset_top: 10
    });
});


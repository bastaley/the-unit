$(document).ready(function () {
    $('#account-btn').click(function (e) {
        $(this).toggleClass('active');
        $('#account').toggleClass('active');
    });

    $('#search-btn').click(function (e) {
        $(this).toggleClass('active');
        $('#search').toggleClass('active');
    });
});



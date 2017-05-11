$(document).ready(function () {
    $("button").click(function (event) {
        event.preventDefault();
        $.ajax({
            type: 'GET',
            dataType: 'json',
            data: { searchQuery: "bUlbaSaur" },
            url: $(this).data('request-url'),
            success: function (result) {
                console.log("Ajax is good.");
                console.log(result);
            }
        });
    });
});
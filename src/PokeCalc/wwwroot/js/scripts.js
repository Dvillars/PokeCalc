$(document).ready(function () {
    $(".first-pokemon").submit(function (event) {
        event.preventDefault();
        $.ajax({
            type: 'GET',
            dataType: 'json',
            data: { searchQuery: $(".first-chosen-pokemon").val() },
            url: $(this).data('request-url'),
            success: function (result) {
                console.log(result);
                $(".result").text("");
                result.moves.forEach(function (thisMove) {
                    $(".result").append("<h5 class='col-sm-3'>" + thisMove.move.name + "</h5>");
                });
                $(".img-result").html("<img class='center-image' src='" + result.sprites.front_shiny + "' />");
                $(".result-name").html("<h1 class='text-center'>" + result.name + "</h1>");
            }
        });
    });
});
$(document).ready(function () {
    $(".player1 .first-pokemon").submit(function (event) {
        event.preventDefault();
        $.ajax({
            type: 'GET',
            dataType: 'json',
            data: { searchQuery: $(".first-chosen-pokemon").val() },
            url: $(this).data('request-url'),
            success: function (result) {
                console.log(result);
                $(".player1 .result").text("");
                result.moves.forEach(function (thisMove) {
                    $(".player1 .result").append("<h5 class='col-sm-3'>" + thisMove.move.name + "</h5>");
                });
                $(".player1 .img-result").html("<img class='center-image' src='" + result.sprites.front_shiny + "' />");
                $(".player1 .result-name").html("<h1 class='text-center'>" + result.name + "</h1>");
            }
        });
    });

    $(".second-pokemon").submit(function (event) {
        event.preventDefault();
        $.ajax({
            type: 'GET',
            dataType: 'json',
            data: { searchQuery: $(".second-chosen-pokemon").val() },
            url: $(this).data('request-url'),
            success: function (result) {
                console.log(result);
                $(".player2 .result").text("");
                result.moves.forEach(function (thisMove) {
                    $(".player2 .result").append("<h5 class='col-sm-3'>" + thisMove.move.name + "</h5>");
                });
                $(".player2 .img-result").html("<img class='center-image' src='" + result.sprites.front_shiny + "' />");
                $(".player2 .result-name").html("<h1 class='text-center'>" + result.name + "</h1>");
            }
        });
    });
});
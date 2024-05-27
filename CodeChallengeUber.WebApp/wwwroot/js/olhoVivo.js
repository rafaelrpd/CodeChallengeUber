$(document).ready(() => {
    $("#autenticarButton").click(() => {
        $.ajax({
            url: "/OlhoVivo/Autenticar",
            type: "POST",
            success: (response) => {
                $("#result").html(response)
            }
        })
    })

    $("#getPosicaoButton").click(() => {
        $.ajax({
            url: "/OlhoVivo/Posicao",
            type: "GET",
            success: (response) => {
                $("#result").html(response)
            }
        })
    })
})
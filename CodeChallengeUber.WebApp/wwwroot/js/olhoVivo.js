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
})
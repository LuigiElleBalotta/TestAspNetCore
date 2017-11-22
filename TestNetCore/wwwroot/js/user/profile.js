

$( document ).ready(function() {
});

function aggiornaBiografia() {
    var biografia = $('#textareaBiografia').val();
    alert( biografia );

    $.ajax({
        type: "POST",
        data: { 'content': biografia },
        url: "/User/UpdateBiography", 
        success: function(result){
            window.location.reload( true );
        }
    });

}
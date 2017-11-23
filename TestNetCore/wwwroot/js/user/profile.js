

$( document ).ready(function() {
});

function aggiornaBiografia() {
    var biografia = $('#textareaBiografia').val();

    $.ajax({
        type: "POST",
        data: { 'content': biografia },
        url: "/User/UpdateBiography", 
        success: function(result){
            window.location.reload( true );
        }
    });

}

function aggiornaGeneriPreferiti() {
    var generi = $('#textareaFavouriteGenres').val();

    $.ajax({
            type: "POST",
            data: { 'content': generi },
            url: "/User/UpdateGenres", 
            success: function(result){
                window.location.reload( true );
            }
        });
}

function aggiornaArtistiPreferiti() {
    var artisti = $('#textareaFavouriteArtists').val();

    $.ajax({
            type: "POST",
            data: { 'content': artisti },
            url: "/User/UpdateArtists", 
            success: function(result){
                window.location.reload( true );
            }
        });
}

function aggiornaSetUp() {
    var setup = $('#textareaPersonalSetup').val();

    $.ajax({
            type: "POST",
            data: { 'content': setup },
            url: "/User/UpdateSetup", 
            success: function(result){
                window.location.reload( true );
            }
        });
}

function aggiornaCoverSuonate() {
    var covers = $('#textareaPlayedCovers').val();

    $.ajax({
            type: "POST",
            data: { 'content': covers },
            url: "/User/UpdateCovers", 
            success: function(result){
                window.location.reload( true );
            }
        });
}

function aggiornaStrumenti() {
    var strumentiSelezionati = getSelectedCheckboxesIn( 'modalContainterStrumenti' );

    var arrayValue = $( strumentiSelezionati ).map( function() { return $( this ).val(); }).get();

    $.ajax({
            type: "POST",
            data: { 'strumentiSelezionati': arrayValue },
            url: "/User/UpdatePlayedInstruments", 
            success: function(result){
                window.location.reload( true );
            }
        });

}
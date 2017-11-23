$( document ).ready(function() {
    $('#tabellaStrumenti').DataTable();
});

function aggiungiStrumento() {
    var descrizione = $( '#descrizioneStrumento' ).val();

    if( descrizione !== '' ) {
        $.ajax({
                type: "POST",
                data: { 'descrizione': descrizione },
                url: "/Anagrafiche/AddInstrument", 
                success: function(result){
                    window.location.reload( true );
                }
            });
    }
    else {
        alert( 'non hai inserito nulla' );
    }
    
}

function openModificaModal( el ) {
    var obj = $( el ).data( 'item' );

    $('#idStrumento').val( obj.id );
    $('#modificaDescrizioneStrumento').val( obj.descrizione );

    $('#modalModificaStrumento').modal('show');
}

function modificaStrumento() {
    var id = $('#idStrumento').val();
    var descrizione = $('#modificaDescrizioneStrumento').val();

    if( descrizione !== '' ) {
        $.ajax({
                type: "POST",
                data: { 'descrizione': descrizione, 'id': id },
                url: "/Anagrafiche/UpdateInstrument", 
                success: function(result){
                    window.location.reload( true );
                }
            });
    }
    else {
        alert( 'non hai inserito nulla' );
    }
}

function rimuoviStrumenti() {
    var checkboxSelezionati = getSelectedCheckboxesIn( 'tabellaStrumenti' );
    
    var arrayValue = $( checkboxSelezionati ).map( function() { return $( this ).val(); }).get();

    if( arrayValue.length > 0 ) {
        $.ajax({
                type: "POST",
                data: { 'ids': arrayValue },
                url: "/Anagrafiche/DeleteInstrument", 
                success: function(result){
                    window.location.reload( true );
                }
            });
    }
    else {
        alert( 'non hai inserito nulla' );
    }
}
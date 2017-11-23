var handlingShiftClick = false;
var handlingCheckAll = false;

function checkAll( cbAll )
{

    handlingCheckAll = true;

    var tabella = cbAll.closest( 'table' );

    $( '#' + tabella.id +  ' td input:checkbox' ).each( function(  )
    {
        this.checked = cbAll.checked;
    } );
	
    handlingCheckAll = false;
}

function aggiornaCheckAll( cbAll )
{
    if( !handlingCheckAll ) {
        var table = cbAll.up( 'table' );
        var cbs = table.select( 'input[type="checkbox"]' ).without( cbAll );

        cbAll.checked = cbs.all( function( item ) { return( item.checked ); } );
    }
}

function getDataAttr( el, name )
{
    name = name.toLowerCase();

    return el.dataset ? el.dataset[ name.camelize() ] : el.readAttribute( 'data-' + name );
}

function setDataAttr( el, name, value )
{
    name = name.toLowerCase();

    if( el.dataset )
        el.dataset[ name.camelize() ] = value;
    else
        el.writeAttribute( 'data-' + name, value );
}

function toBool( str ) 
{
    switch( str.trim().toLowerCase() ) {

    case 'true': 
    case 'yes': 
    case '1': 
    case true:
        return true;

    case 'false': 
    case 'no': 
    case '0': 
    case null: 
    case false: 
        return false;

    default: 
        return Boolean( str );
    }
}

function getSelectedCheckboxesIn( containerID )
{
    return getSelectedCheckboxes( '#' + containerID + ' input' );
}

function getSelectedCheckboxes( filter )
{
    var selectedCheckboxes = $( filter + ':checked' );
    var ret = [];

    for( var i = 0; i < selectedCheckboxes.length; i++) {
        if( !$( selectedCheckboxes[ i ] ).hasClass( 'checkAll' ) && !$( selectedCheckboxes[ i ] ).hasClass( 'ignoreSelected' ))
            ret.push( selectedCheckboxes[ i ] );
    }

    return ret;
}
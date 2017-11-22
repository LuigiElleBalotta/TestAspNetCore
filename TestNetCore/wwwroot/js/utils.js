var handlingShiftClick = false;
var handlingCheckAll = false;

function checkAll( cbAll )
{
    var checked = !cbAll.checked;

    handlingCheckAll = true;

    cbAll.up( 'table' ).select( 'input[type="checkbox"]' ).without( cbAll ).each( function( cb )
    {
        cb.checked = checked;
		
        cb.click();
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
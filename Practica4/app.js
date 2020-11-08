$(document).ready(function() {
   
    $("button.clear").click(function() { clear() });

    $("button.submit").click(function(event) { validate(event) });
});

function clear() {
    $("#nombres").val('');
    $("#Apellidos").val('');
    $("#edad").val('');
    $("#empresas").val('');
}

function validate(event) {
    var msg = '';

    if( !$("#nombres").val()) {
        msg = msg.concat('falta nombre! \n')
    };

    if( !$("#apellidos").val()) {
        msg = msg.concat('falta apellido! \n')
    };

    if( !$("#edad").val() ) {
        msg = msg.concat('falta edad! \n')
    }else if($("#edad").val() < 0){
        msg = msg.concat('solo se admiten numeros positivos!!\n')
    };

    if (msg) {
        event.preventDefault();
        alert(msg);
    }else{
        msg = 'Cargado con exito!';
        alert(msg)
    }
}
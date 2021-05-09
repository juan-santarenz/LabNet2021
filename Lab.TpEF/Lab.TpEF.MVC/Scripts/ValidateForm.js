$(document).ready(function () {
    $("#form").validate({
        rules: {
            Name: {
                required: true,
                minlength: 3,
                maxlength: 15
            },
            Description: {
                required: true,
                maxlength: 50
            },
        },
        messages: {
            Name: {
                required: "Ingrese un nombre",
                minlength: "El nombre debe tener al menos 3 caracteres",
                maxlength: "El nombre no puede superar los 15 caracteres"
            },
            Description: {
                required: "Ingrese una descripcion",
                maxlength: "La descripcion no debe superar 50 caracteres"
            }
        }
    });
});
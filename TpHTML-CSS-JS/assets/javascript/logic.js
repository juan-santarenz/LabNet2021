var expr = /^1[8-9]|[2-8]\d|89$/;

$(document).ready(function () {
  $("#enviar").click(function () {
    var nombre = $("#nombre").val();
    if (nombre == "") {
      $("#validarUno").fadeIn();
      return false;
    } else $("#validarUno").fadeOut();
  });

  $("#enviar").click(function () {
    var apellido = $("#apellido").val();
    if (apellido == "") {
      $("#validarDos").fadeIn();
      return false;
    } else $("#validarDos").fadeOut();
  });

  $("#enviar").click(function () {
    var edad = $("#edad").val();
    if (edad == "" || !expr.test(edad)) {
      $("#validarTres").fadeIn();
      return false;
    } else $("#validarTres").fadeOut();
  });

  $("#enviar").click(function () {
    var empresa = $("#empresa").val();
    if (empresa == "") {
      $("#validarCinco").fadeIn();
      return false;
    } else $("#validarCinco").fadeOut();
  });

  $("#enviar").click(function () {
    if (!$("#radio input[name='genero']").is(":checked")) {
      $("#validarCuatro").fadeIn();
      return false;
    } else $("#validarCuatro").fadeOut();
  });

  $("#borrar").click(function (event) {
    event.preventDefault();
    $("#form").find("input[type=text]").val("");
    $("#form")[0].reset();
  });
});

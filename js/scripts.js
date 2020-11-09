$(document).ready(function () {

});

$("#limpiar").click(function () {
  limpiar();
});

function limpiar() {
  $("#name").val("");
  $("#lastName").val("");
  $("#age").val("");
  $("#empresa").val("");
}

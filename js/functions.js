document.addEventListener("DOMContentLoaded", function () {
  document.getElementById("formulario").addEventListener('submit', validarFormulario);
});

function validarFormulario(event) {
  event.preventDefault();
  var name = document.getElementById('name').value;
  if (name.length == 0) {
    alert('Debe completar el campo Nombre');
    return;
  }
  var lastName = document.getElementById('lastName').value;
  if (lastName.length == 0) {
    alert('Debe completar el campo Apellido');
    return;
  }
  var age = document.getElementById('age').value;
  if (age.length == 0) {
    alert('Debe completar el campo Edad');
    return;
  }
  if (age < 18) {
    alert("Debe ser mayor de 18 años");
  }
  if (isNaN(age)) {
    alert("Revise los datos");
  }
  this.submit();
}
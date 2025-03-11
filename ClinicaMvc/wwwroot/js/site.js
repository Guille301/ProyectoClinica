
function confirmarEliminacion(id) {
    // Confirmar si realmente desea eliminar el paciente
    var confirmacion = confirm("¿Está seguro de que desea eliminar este paciente?");
    if (confirmacion) {
        // Si el usuario acepta, redirigimos a la acción de eliminación
       window.location.href = '/Home/Delete/' + id;  // Asegúrate de que esta URL sea correcta
    }
}

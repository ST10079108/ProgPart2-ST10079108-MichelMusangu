// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function calculateTotal() {
    var total;
    var hoursWorked = document.getElementsByName('Hours')[0].value; 
    var hourlyRate = document.getElementsByName('Rate')[0].value;    

    total = parseFloat(hoursWorked) * parseFloat(hourlyRate);

    document.getElementById('Total').value = total;
}
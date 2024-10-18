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

var uploadField = document.getElementById("myFile");
var isFileValid = true;

uploadField.onchange = function () {
    if (this.files[0].size > 2097152) {  
        alert("Maximum allowed size is 2 MB.");
        this.value = "";  
        document.getElementById('fileError').style.display = 'block';
        isFileValid = false;  
    } else {
        document.getElementById('fileError').style.display = 'none';
        isFileValid = true;  
    }
};


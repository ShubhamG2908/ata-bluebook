// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function showToastr(type, message) {
    const position = "bottom center";
    DevExpress.ui.notify({
        message: message,
        width: 400,
        minWidth: 400,
        type: type,
        displayTime: 3500
    },
        {
            position
        }
    );
}
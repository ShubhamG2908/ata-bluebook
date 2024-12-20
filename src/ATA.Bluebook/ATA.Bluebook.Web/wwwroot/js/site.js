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

function showSuccessToastr(message) {
    showToastr("success", message);
}

function showErrorToastr(message) {
    showToastr("error", message);
}

function showInfoToastr(message) {
    showToastr("info", message);
}

function showWarningToastr(message) {
    showToastr("warning", message);
}

function preRenderAllViews(multiview) {
    var itemCount = multiview.option("animationEnabled", false);
    var itemCount = multiview.option("items").length;
    for (var i = 0; i < itemCount; i++) {
        multiview.option("selectedIndex", i);
    }
    // Optionally, set the active view back to the initial view
    multiview.option("selectedIndex", 0);
    var itemCount = multiview.option("animationEnabled", true);
}
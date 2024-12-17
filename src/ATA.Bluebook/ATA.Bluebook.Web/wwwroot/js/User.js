let personalDetailForm
let userTypeForm
let accountDetailForm;

// User Type Form 
function onUserTypeFormInitialized(e) {
    userTypeForm = e.component;
}

function handleUserTypePrevious() {
    stepper.previous();
}

function handleUserTypeNext() {
    var formdata = userTypeForm.option("formData");
    if (formdata.UserType == 0) {	// Client
        showControl(personalDetailForm, ["ClosedCode", "CloseDays", "WhiteMailCode"]);
    } else {
        hideControl(personalDetailForm, ["ClosedCode", "CloseDays", "WhiteMailCode"]);
    }
    stepper.next();
}

function UserTypeSelectionChanged(e) {
}

// ------------------------------------------------------------------------------------
// Personal Details Form 
function onPersonalDetailFormInitialized(e) {
    personalDetailForm = e.component;
}

function handlePersonalDetailStepPrevious() {
    stepper.previous();
}

function handlePersonalDetailStepNext() {
    const validationStatus = personalDetailForm.validate();
    if (validationStatus.isValid) {
        var formdata = userTypeForm.option("formData");
        if (formdata.UserType == 0) {	// Client
            showControl(accountDetailForm, "ClientId");
            hideControl(accountDetailForm, ["AgencyId", "ClientList"]);
        } else {		// Agency
            showControl(accountDetailForm, ["AgencyId", "ClientList"]);
            hideControl(accountDetailForm, "ClientId");
        }
        stepper.next()
    }
}

// ------------------------------------------------------------------------------------
// Account Details Form
function onUserAccountDetailInitialized(e) {
    accountDetailForm = e.component;
}

// Temperory put this code here. make centrolize this code after finalize all things.
function changePasswordMode(name, iconId) {
    let editor = accountDetailForm.getEditor(name);

    if (!editor)
        return;

    editor.option('mode', editor.option('mode') === 'text' ? 'password' : 'text');

    let iconElement = $(`#${iconId}`).find("i");

    if (!iconElement)
        return;

    iconElement.toggleClass("dx-icon-eyeopen");
    iconElement.toggleClass("dx-icon-eyeclose")
}

function ClientSelectionChanged(e) {
}
function handleUserAccountStepPrevious() {
    stepper.previous();
}

function handleUserAccountStepNext() {
    const validationStatus = accountDetailForm.validate();
    if (validationStatus.isValid) {
        stepper.next()
    }
}

// ------------------------------------------------------------------------------------
// User Form Done
function handleFormDoneStepPrevious() {
    stepper.previous();
}

function handleFormDoneStepNext() {
    var userTypeFormData = userTypeForm.option("formData");
    var personalDetailFormData = personalDetailForm.option("formData");
    var accountDetailFormData = accountDetailForm.option("formData");

    $.ajax({
        url: 'CreateUser',
        method: 'POST',
        async: true,
        data: {
            PersonalDetailForm: personalDetailFormData,
            AccountDetailForm: accountDetailFormData,
            UserTypeForm: userTypeFormData
        },
        success: function (res) {
            console.log(res);
            // Move to user listing screen.
        },
        error: function (res) {
            console.log(res);
        }
    });
}

// ------------------------------------------------------------------------------------
// Common Methods 
// Need to create common js for that and move these functions into that js after finalization.
function hideControl(formInstance, itemName) {
    if (Array.isArray(itemName)) {
        itemName.forEach(function (item) {
            formInstance.itemOption(item, "visible", false);
        })
    } else {
        formInstance.itemOption(itemName, "visible", false);
    }
}

function showControl(formInstance, itemName) {
    if (Array.isArray(itemName)) {
        itemName.forEach(function (item) {
            formInstance.itemOption(item, "visible", true);
        })
    } else {
        formInstance.itemOption(itemName, "visible", true);
    }
}
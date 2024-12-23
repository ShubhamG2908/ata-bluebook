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


// ------------------------------------------------------------------------------------
// User Edit Screen (Tabs & Multiview)

let userMultiview;
let userTabs;

function onUserMultiviewInitialized(e) {
    userMultiview = e.component;
}

function onUserMultiviewContentReady(e) {
    preRenderAllViews(userMultiview);
}

function onUserTabsInitialized(e) {
    userTabs = e.component;
}

function setUserEditSelection(value) {
    if (userTabs) {
        userTabs.option('selectedItem', value);
    }
    if (userMultiview) {
        userMultiview.option('selectedItem', value);
    }
}

function userEditSelectionChanged(e) {
    if (e.selectedItem || e.addedItems?.length) {
        setUserEditSelection(e.selectedItem || e.addedItems[0])
    }
}

const userEditTabs = [
    {
        id: 0,
        text: 'Personal Details',
        partialViewName: "_UserPersonalDetails"
    },
    {
        id: 1,
        text: 'Account Details',
        partialViewName: "_UserAccountDetails"
    },
    {
        id: 2,
        text: 'Permissions',
        partialViewName: "_UserFormDone"
    }
];

function handleUserEditCancel() {
    window.location.href = "/Settings/Users";
}

function handleUserEdit() {

    if (personalDetailForm) {
        const personalDetailValidation = personalDetailForm.validate();
        if (!personalDetailValidation.isValid) {
            setUserEditSelection(userEditTabs[0]);
            return;
        }
    }

    if (accountDetailForm) {
        const accountDetailValidation = accountDetailForm.validate();
        if (!accountDetailValidation.isValid) {
            setUserEditSelection(userEditTabs[1]);
            return;
        }
    }

}

function onUserEditClick(columnData) {
    window.location.href = "/Users/Edit/" + columnData.row.key
}

function onUserAddClick(e) {
    window.location.href = "/Users/New";
}

let selectedItemForDelete;
function onUserDeleteClick(columnData) {
    selectedItemForDelete = columnData.row.key;
    var popup = $("#delete-user-popup").dxPopup("instance");
    popup.show();
}

function hideUserPopup() {
    const popup = $('#delete-user-popup').dxPopup('instance');
    popup.hide();
}

function deleteUser() {
    if (selectedItemForDelete) {

        // call delete api

        showSuccessToastr("User is deleted successfully.");
        hideUserPopup();
    }
}
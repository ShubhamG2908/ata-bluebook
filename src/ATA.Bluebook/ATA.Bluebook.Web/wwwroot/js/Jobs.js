let jobDetailForm;
function handleUserTypePrevious() {
    stepper.previous();
}

function handleUserTypeNext() {
    var formdata = jobDetailForm.option("formData");
    console.log(formdata);
    const validationStatus = jobDetailForm.validate();
    if (validationStatus.isValid) {
        stepper.next();
    }
}

function onJobDetailsFormInitialized(e) {
    jobDetailForm = e.component;
}
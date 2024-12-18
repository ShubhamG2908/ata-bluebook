let jobDetailForm;

// ------------------------------------------------------------------------------------
// Job Details Form 
function onJobDetailsFormInitialized(e) {
    jobDetailForm = e.component;
}

function handleJobDetailsPrevious() {
    stepper.previous();
}

function handleJobDetailsNext() {
    const validationStatus = jobDetailForm.validate();
    if (validationStatus.isValid) {
        stepper.next();
    }
}

// ------------------------------------------------------------------------------------
// Job Events Form 
function handleJobEventPrevious() {
    stepper.previous();
}

function handleJobEventNext() {
    stepper.next();
}

// ------------------------------------------------------------------------------------
// Job Files Form 
function handleJobFilesPrevious() {
    stepper.previous();
}

function handleJobFilesNext() {
    const type = "success";
    const message = "Job is created successfully.";

    showToastr(type, message);

    stepper.next();
}
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

// ------------------------------------------------------------------------------------
// Job Edit Screen (Tabs & Multiview)

let jobsMultiview;
let jobsTabs;

function onJobMultiviewInitialized(e) {
    jobsMultiview = e.component;
}

function onJobTabsInitialized(e) {
    jobsTabs = e.component;
}

function setJobEditSelection(value) {
    if (jobsTabs) {
        jobsTabs.option('selectedItem', value);
    }
    if (jobsMultiview) {
        jobsMultiview.option('selectedItem', value);
    }
}

function jobEditSelectionChanged(e) {
    if (e.selectedItem || e.addedItems?.length) {
        setJobEditSelection(e.selectedItem || e.addedItems[0])
    }
}

const jobEditTabs = [
    {
        id: 0,
        text: 'Job Details',
        partialViewName: "_JobDetailsForm"
    },
    {
        id: 1,
        text: 'Job Events',
        partialViewName: "_JobEventsForm"
    },
    {
        id: 2,
        text: 'Job Files',
        partialViewName: "_JobFilesForm"
    }
];

function handleJobEditCancel() {
    window.location.href = "/Jobs/Index";
}

function handleJobEdit() {
    // Update Job api call
}

function onJobEditClick(columnData) {
    window.location.href = "/Jobs/Edit/" + columnData.row.key
}

let selectedItemForDelete;
function onJobDeleteClick(columnData) {
    selectedItemForDelete = columnData.row.key;
    var popup = $("#delete-job-popup").dxPopup("instance");
    popup.show();
}

function hideJobPopup() {
    const popup = $('#delete-job-popup').dxPopup('instance');
    popup.hide();
}

function deleteJob() {
    if (selectedItemForDelete) {

        // call delete api

        showSuccessToastr("Job is deleted successfully.");
        hideJobPopup();
    }
}

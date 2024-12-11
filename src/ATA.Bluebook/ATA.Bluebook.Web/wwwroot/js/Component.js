
function onTabsInitialized(e) {
    loadPartialView(0);
}

function selectionChanged(e) {
    var selectedItem;
    if (e.selectedItem || e.addedItems?.length) {
        selectedItem = e.selectedItem || e.addedItems[0]
    }
    loadPartialView(selectedItem?.id ?? 0);
}

function loadPartialView(_id) {
    $.ajax({
        url: 'Components/GetSelectedTabContent',
        method: 'GET',
        async: true,
        data: {
            id: _id
        },
        success: function (res) {
            console.log(res);
            $("#component-partial-container").empty().append(res);
        },
        error: function (res) {
            console.log(res);
        }
    });
}

function onInitialized(e) {
    console.log("Init");
}

function GenderSelectionChanged(e) {
    console.log(e);
}
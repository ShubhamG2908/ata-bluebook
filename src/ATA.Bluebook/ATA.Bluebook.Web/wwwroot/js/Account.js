let formInstance;

function onInitialized(e) {
	formInstance = e.component;
}

function changePasswordMode(name, iconId) {
	let editor = formInstance.getEditor(name);

	if (!editor)
		return;

	editor.option('mode', editor.option('mode') === 'text' ? 'password' : 'text');

	let iconElement = $(`#${iconId}`).find("i");

	if (!iconElement)
		return;

	iconElement.toggleClass("dx-icon-eyeopen");
	iconElement.toggleClass("dx-icon-eyeclose")
}
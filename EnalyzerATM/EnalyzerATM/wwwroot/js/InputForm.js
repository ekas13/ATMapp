
function handleButtonClick(value) {
        const inputValue = document.getElementById("inputValue");
        const hiddenInput = document.getElementById("hiddenInput");
        inputValue.value += value;
        hiddenInput.value = inputValue.value; 
        checkInput()
}

function handleBackspaceClick() {
        const inputValue = document.getElementById("inputValue");
        const hiddenInput = document.getElementById("hiddenInput");
        inputValue.value = inputValue.value.slice(0, -1);
        hiddenInput.value = inputValue.value;
        checkInput()
}

function handleSubmit() {
        const form = document.getElementById("numpadForm");
    form.submit();
}

function checkInput() {
    var hiddenInput = document.getElementById('hiddenInput');
    var submitButton = document.getElementById('submitButton');

    if (hiddenInput.value.trim() !== '') {
        submitButton.removeAttribute('disabled');
    } else {
        submitButton.setAttribute('disabled', 'disabled');
    }
}
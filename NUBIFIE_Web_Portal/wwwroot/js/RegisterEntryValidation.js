function validateInput(iptId, errId1, errId2) {
    validateText(iptId, errId1);
    validateNoWildcards(iptId, errId2);
}

function validateText(iptId, errId) {
    var input = document.getElementById(iptId);
    var errorMessage = document.getElementById(errId);
    var regex = /^[A-Za-z\s]*$/;

    if (!regex.test(input.value)) {
        input.setCustomValidity("Only letters and spaces are allowed.");
        errorMessage.style.display = 'inline';
    } else {
        input.setCustomValidity("");
        errorMessage.style.display = 'none';
    }
}

function validateNumbers(iptId, errId) {
    var input = document.getElementById(iptId);
    var errorMessage = document.getElementById(errId);
    var regex = /^[0-9]*$/;

    if (!regex.test(input.value)) {
        input.setCustomValidity("Only numbers are allowed.");
        errorMessage.style.display = 'inline';
    } else {
        input.setCustomValidity("");
        errorMessage.style.display = 'none';
    }
}

function validateNoWildcards(iptId, errId) {
    var input = document.getElementById(iptId);
    var errorMessage = document.getElementById(errId);
    var regex = /^[^!#@$%^&*()_+=[\]{};':"\\|<>/?]*$/;

    if (!regex.test(input.value)) {
        input.setCustomValidity("No wildcard characters are allowed.");
        errorMessage.style.display = 'inline';
    } else {
        input.setCustomValidity("");
        errorMessage.style.display = 'none';
    }
}

function validateEmail(iptId, errId) {
    var input = document.getElementById(iptId);
    var errorMessage = document.getElementById(errId);
    var regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if (!regex.test(input.value)) {
        input.setCustomValidity("Please enter a valid email address.");
        errorMessage.style.display = 'block';
    } else {
        input.setCustomValidity("");
        errorMessage.style.display = 'none';
    }
}

function validateSelect(iptId, errId) {
    var input = document.getElementById(iptId);
    var errorMessage = document.getElementById(errId);

    if (input.value === "") {
        input.setCustomValidity("Please make valid selection.");
        errorMessage.style.display = 'inline';
    } else {
        input.setCustomValidity("");
        errorMessage.style.display = 'none';
    }
}

function validatePassword(iptId, errId) {
    var input = document.getElementById(iptId);
    var errorMessage = document.getElementById(errId);
    var regex = /^(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$/;

    if (!regex.test(input.value)) {
        input.setCustomValidity("Password has not met minimum criteria.");
        errorMessage.style.display = 'block';
    } else {
        input.setCustomValidity("");
        errorMessage.style.display = 'none';
    }
}

function toggleForm(event, errId) {
    var selectedValue = event.target.value;
    var additionalForm = document.getElementById('additionalForm');
    var errorMessage = document.getElementById(errId);

    errorMessage.style.display = 'none';
    if (selectedValue === "01") {
        additionalForm.classList.remove('hidden');
    } else {
        additionalForm.classList.add('hidden');
    }
}
 

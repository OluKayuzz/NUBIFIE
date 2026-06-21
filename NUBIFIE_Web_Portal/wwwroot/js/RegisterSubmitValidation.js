document.getElementById('btnRegister').addEventListener('click', validateSubmission);

function validateSubmission(event) {
    let isValid = true;
    let firstInvalidElement = null;

    const formElements = [
        { id: 'iptPictureImg', type: 'file', message: 'Please upload picture file. Maximum image size of 200KB' },
        { id: 'selSector', type: 'select', message: 'Please select the sector you belong to.' },
        { id: 'selTitle', type: 'select', message: 'Please select your title.' },
        { id: 'iptSurname', type: 'text', message: 'Please enter valid surname (letters only).' },
        { id: 'iptOthername', type: 'text', message: 'Please enter valid other name (letters only).' },
        { id: 'iptDOB', type: 'date', message: 'Please enter valid date of birth.' },
        { id: 'selGender', type: 'select', message: 'Please select your gender.' },
        { id: 'iptContactNumber', type: 'tel', message: 'Please enter valid contact number (10-15 digits).' },
        { id: 'iptEmail', type: 'email', message: 'Please enter valid email address.' },
        { id: 'txaResidentialAddress', type: 'textarea', message: 'Please enter valid residential address.' },
        { id: 'selState', type: 'select', message: 'Please select your State of residence.' },
        { id: 'selLGA', type: 'select', message: 'Please select your LGA of residence.' },
        { id: 'iptUserID', type: 'text', message: 'Please enter valid User ID.' },
        { id: 'iptPassword', type: 'password', message: 'Please enter valid password.' },
        { id: 'iptConfirmPassword', type: 'password', message: 'Please password confirmation error.' },
        { id: 'iptAgreement', type: 'checkbox', message: 'You must agree to all terms and conditions.' }
    ];

    // Additional fields to validate when "Agency and Mobile Banking Unit" is selected
    const additionalElements = [
        { id: 'selMMO', type: 'select', message: 'Please select the MMO.' },
        { id: 'iptBusinessName', type: 'textarea', message: 'Please enter valid business name.' },
        { id: 'iptBusinessAddress', type: 'textarea', message: 'Please enter valid business address.' },
        { id: 'selAdminOfficeState', type: 'select', message: 'Please select the state of the administrative office.' },
        { id: 'selAdminOfficeLGA', type: 'select', message: 'Please select the LGA of the administrative office.' },
        { id: 'iptNumberOfOutlets', type: 'number', message: 'Please enter valid number of outlets.' },
        { id: 'iptBusinessLocation', type: 'textarea', message: 'Please enter valid business location.' }
    ];

    formElements.forEach(element => {
        validateElement(element);
    });

    // Check if "Agency and Mobile Banking Unit" is selected
    if (document.getElementById('selSector').value === '01') {
        additionalElements.forEach(element => {
            validateElement(element);
        });
    }

    if (isValid) {
        document.querySelector('form').submit(); // Submit the form if all validations pass
    } else {
        event.preventDefault(); // Prevent the form from submitting if there are validation errors
        if (firstInvalidElement) {
            firstInvalidElement.focus();
        }
    }

    function validateElement(element) {
        let inputElement = document.getElementById(element.id);
        let errorMessageSpan = document.getElementById('err' + element.id.charAt(3).toUpperCase() + element.id.slice(4));

        if (inputElement) {
            if (element.type === 'file' && !inputElement.files.length) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if (element.type === 'select' && !inputElement.value) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if ((element.type === 'text' && !inputElement.value.match(inputElement.pattern)) || falseFilling(inputElement.value)) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if (element.type === 'date' && !inputElement.value) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if (element.type === 'tel' && !inputElement.value.match(inputElement.pattern)) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if (element.type === 'email' && !inputElement.value.match(/^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/)) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if ((element.type === 'textarea' && !inputElement.value.match(/^[^!#@$%^&*()_+=[\]{};':"\\|,.<>/?]*$/)) || falseFilling(inputElement.value)) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if (element.type === 'password' && inputElement.id === 'iptPassword' && !validatePassword()) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if (element.type === 'password' && inputElement.id === 'iptConfirmPassword' && !confirmPassword()) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if (element.type === 'number' && inputElement.value < 1) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else if (element.type === 'checkbox' && !inputElement.checked) {
                displayError(inputElement, errorMessageSpan, element.message);
            } else {
                clearError(inputElement, errorMessageSpan);
            }
        }
    }

    function validatePassword() {
        const password = document.getElementById('iptPassword').value;
        const regex = /^(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{8,}$/;
        return regex.test(password);
    }

    function confirmPassword() {
        const password = document.getElementById('iptPassword').value;
        const confirmPassword = document.getElementById('iptConfirmPassword').value;
        return password === confirmPassword;
    }

    function falseFilling(textElementValue) {
        return textElementValue.trim().length === 0;
    }

    function displayError(inputElement, errorMessageSpan, message) {
        isValid = false;
        if (!firstInvalidElement) {
            firstInvalidElement = inputElement;
        }
        inputElement.classList.add('is-invalid');
        if (errorMessageSpan) {
            errorMessageSpan.textContent = message;
            errorMessageSpan.style.display = 'inline';
        }
    }

    function clearError(inputElement, errorMessageSpan) {
        inputElement.classList.remove('is-invalid');
        if (errorMessageSpan) {
            errorMessageSpan.textContent = '';
        }
    }
}



//var Category = document.getElementById('<%=selSector.ClientID %>').value;
//var Title = document.getElementById('<%=selTitle.ClientID %>').value;
//var Surname = document.getElementById('<%=iptSurname.ClientID %>').value;
//var Othernames = document.getElementById('<%=iptOthername.ClientID %>').value;
//var DoB = document.getElementById('<%=iptDOB.ClientID %>').value;
//var GMale = document.getElementById('<%=selGender.ClientID %>');
//var Telephone = document.getElementById('<%=iptContactNumber.ClientID %>').value;
//var eMail = document.getElementById('<%=iptEmail.ClientID %>').value;
//var HomeAddress = document.getElementById('<%=iptResidentialAddress.ClientID %>').value;
//var State = document.getElementById('<%=selState.ClientID %>').value;
//var LGA = document.getElementById('<%=selLGA.ClientID %>').value;
//var BusinessAddress = document.getElementById('<%=iptBusinessAddress.ClientID %>').value;

//var UserID = document.getElementById('<%=iptUserID.ClientID %>').value;
//var NewPassword = document.getElementById('<%=ipttPassword.ClientID %>').value;
//var RepeatPassword = document.getElementById('<%=iptConfirmPassword.ClientID %>').value;

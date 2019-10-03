// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function(){
    console.log('Hi');
    $("#patient").validate({
        // Specify validation rules
        rules: {
            // The key name on the left side is the name attribute
            // of an input field. Validation rules are defined
            // on the right side
            Mrn: {
                required: true,
                minlength: 6
            },
            FirstName: {
                required: true,
                lettersonly: true
            },
            Middle: "letterswithbasicpunc",
            lastName: {
                required: true,
                lettersonly: true
            },
            aliasFirstName: "lettersonly",
            aliasMiddleName: "lettersonly",
            aliasLastName: "lettersonly",
            MaidenName: "lettersonly",
            MothersMaidenName: "lettersonly",
            Dob: "required",
            Ssn: {
                required: true,
                minlength: 9,
                number: true
            }
            
        },
        // Specify validation error messages
        messages: {
            FirstName: {
                required: "Please provide a first name",
                letters: "First name must be equal to MRn"
            },
            lastName: {
                required: "Please provide a last name",
                lettersonly: "Last name must be all letters"
            },
            Ssn: {
                required: "Please provide a Social Security Number",
                minlength: "Your SSN must be at least 10 digits long",
                number: "SSN should be numeric"
            },
            Middle: "Only one letter allowed",
            aliasFirstName: "Only letters allowed",
            aliasMiddleName: "Only letters allowed",
            aliasLastName: "Only letters allowed",
            MothersMaidenName: "Only letters allowed",
            MaidenName: "Only letters allowed"
        },
        // Make sure the form is submitted to the destination defined
        // in the "action" attribute of the form when valid
        submitHandler: function (form) {
            form.submit();
        }
    });
    
})

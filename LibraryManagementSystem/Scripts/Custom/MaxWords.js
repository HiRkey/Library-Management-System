/// <reference path="jquery.validate.js" />
/// <reference path="jquery.unobtrusive.js" />


//First parameter matches what we put in our code for the name of the validation rule
//second is the name of the single parameter we want to retrieve (since we used add singleval)
$.validator.unobtrusive.adapters.addSingleVal("maxwords", "wordcount");

$.validator.addMethod("maxwords", function (value, element, maxwords) {
    if (value) {
        if (value.split(' ').length > maxwords) {
            return false;
        }
    } return true;
});

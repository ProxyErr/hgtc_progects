"use strict";
/*
	Final Project
    Author:Christopher Baker 
    Date:   8/2/2021

    Filename: java_form.js
   
   validateForm() to make sure all feilds are entered in form.
   prompt repsonse for user. 

*/


function validateForm() {
if (document.forms[0].fmail.value == "" ) {
    alert("Please Enter First Name");
    return false;
} // end if
if (document.forms[0].lmail.value == "") {
    alert("Please Enter last Name");
    return false;
} // end if
if (document.forms[0].email.value == "") {
    alert("Please Enter Email");
    return false;
} // end if
if (document.forms[0].comments.value == "") {
    alert("Please Enter Comments");
    return false;
} // end if
alert("Thank you for Submitting!");
return true;
} // end function validateForm
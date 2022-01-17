"use strict";
/*
	Final Project:
    Author:Christopher Baker 
    Date:   8/2/2021

    Filename: javaSyles.html
   
   runClock() to change date on page to current time.

*/
runClock();
setInterval("runClock()", 1000);

function runClock() {

	var currentDay = new Date();
	

	var dateStr = currentDay.toLocaleDateString();

	var timeStr = currentDay.toLocaleTimeString();


	document.getElementById("dateNow").innerHTML = dateStr + "<br />" + timeStr;
	
	
}
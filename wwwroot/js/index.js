$(document).ready(function () {

    console.log("Hello Pluralsight");

    /* The following  code Use jQuery 
       jQuery.xxx is equivalent to $.xxx
     */

    //var theForm = document.getElementById("theForm");
    var theForm = $("#theForm");  // Using jQuery
    theForm.hide();

    /* find a object by id         */
    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying Item");
    });

    /* find a objects based on a class */
    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You clic on : " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);

    });

});


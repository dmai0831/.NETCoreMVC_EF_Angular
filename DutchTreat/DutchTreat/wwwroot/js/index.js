//ready execute when the browser ready
$(document).ready(function () {
    var x = 0;
    var s = "";
    console.log("Hello World");




    var theForm = $("#theForm");
    theForm.hide();

    //var button = document.getElementById("buyButton");
    //button.addEventListener("click", function () { console.log("Buy Item"); });
    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buy Item");
    });


    //var productInfo = document.getElementsByClassName("product-props");
    //var listItems = productInfo.item[0].children;

    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("you clicked on " + $(this).text());
        });


    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(1000);
    });
});
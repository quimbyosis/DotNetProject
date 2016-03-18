// Write your Javascript code.
var $overlay = $('<div id="overlay"></div>');
var $image = $("<img>");
var $caption = $("<p></p>");

//An image to overlay
$overlay.append($image);

//Add overlay
$("body").append($overlay);

//Capture the click event on a link to an image
$("#gallery a").click(function (event) {
    event.preventDefault();
    var imageLocation = $(this).attr("href");
    //Update the overlay with the image linked in the link
    $image.attr("src", imageLocation)

    //Show the overlay
    $overlay.show();

});

//When overlay is clicked
$overlay.click(function () {
    //Hide the overlay
    $overlay.hide();

});
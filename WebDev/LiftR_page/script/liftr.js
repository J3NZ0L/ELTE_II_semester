//JS for navbar triangle design

window.addEventListener('load', adjustTriangle);

function adjustTriangle() {
    // Calculate the width of the scrollbar
    var scrollbarWidth = window.innerWidth - document.documentElement.clientWidth;

    // Access the triangle elements
    var triangle = document.getElementById('triangle');
    var outerTriangle = document.getElementById('outer-triangle');

    // Check if the triangle elements exist to prevent errors
    if (triangle && outerTriangle) {
        // Adjust the triangle borders
        triangle.style.borderLeft = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`;
        triangle.style.borderRight = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`;
        triangle.style.borderTop = '13vh solid #fff';

        // Adjust the outer triangle borders
        outerTriangle.style.borderLeft = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`;
        outerTriangle.style.borderRight = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`;
        outerTriangle.style.borderTop = '13vh solid #000';
    }
}

//JS for same width figure-figurecaption
function adjustCaptionWidth() {
    var img = document.getElementById('myImage');
    var caption = document.getElementById('myCaption');
    caption.style.width = img.offsetWidth + 'px';
}
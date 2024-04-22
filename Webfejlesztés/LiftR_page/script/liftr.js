window.addEventListener('load', adjustTriangle);
window.addEventListener('resize', adjustTriangle);

function adjustTriangle() {
    // Calculate the width of the scrollbar
    var scrollbarWidth = window.innerWidth - document.documentElement.clientWidth;

    // Access the triangle element
    var triangle = document.getElementById('triangle');

    // Check if the triangle element exists to prevent errors
    if (triangle) {
        // Adjust the triangle borders
        triangle.style.borderLeft = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`;
        triangle.style.borderRight = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`;
        triangle.style.borderTop = '13vh solid #fff';
    }
}

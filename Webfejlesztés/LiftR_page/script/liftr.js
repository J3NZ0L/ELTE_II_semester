window.addEventListener('load', adjustTriangle);
window.addEventListener('resize', adjustTriangle);

function adjustTriangle() {
    var scrollbarWidth = window.innerWidth - document.documentElement.clientWidth;
    var triangle = document.getElementById('triangle');
    triangle.style.borderLeft = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`;
    triangle.style.borderRight = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`;
    triangle.style.borderTop = '100px solid #fff'; /* Change the color and height as per your requirement */
}

window.addEventListener('load', adjustTriangle);
window.addEventListener('resize', adjustTriangle);

function adjustTriangle() {
    var scrollbarWidth = window.innerWidth - document.documentElement.clientWidth;
    var triangle = document.getElementById('triangle');
    triangle.style.borderLeft = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`; //haromszog bal oldala
    triangle.style.borderRight = `calc(50vw - ${scrollbarWidth / 2}px) solid transparent`; //haromszog jobb oldala
    triangle.style.borderTop = '13vh solid #fff'; 
}

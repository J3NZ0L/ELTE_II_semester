const buttonRight = document.getElementById('slideRight');
const buttonLeft = document.getElementById('slideLeft');
const scrollContainer = document.querySelector('.scrollable-container');
const cardWidth = document.querySelector('.scrollable-row .col').offsetWidth;

buttonRight.onclick = function () {
  scrollContainer.scrollTo({
    left: scrollContainer.scrollLeft + cardWidth,
    behavior: 'smooth' // Add smooth scrolling behavior
  });
};

buttonLeft.onclick = function () {
  scrollContainer.scrollTo({
    left: scrollContainer.scrollLeft - cardWidth,
    behavior: 'smooth' // Add smooth scrolling behavior
  });
};

const darkmodeButton = document.getElementById('darkmode-button');
let darkmode = false;

darkmodeButton.onmouseenter = () => changeIcon(!darkmode);
darkmodeButton.onmouseleave = () => changeIcon(darkmode);
darkmodeButton.onclick = () => {
  darkmode = !darkmode;
  document.body.classList.toggle('dark-mode');
  changeIcon(!darkmode);
  darkmodeButton.style.filter = `invert(${darkmode ? 1 : 0})`;
}
function changeIcon(uiMode) {
  uiMode ? darkmodeButton.setAttribute('src', '../media/dark-mode.png') :
    darkmodeButton.setAttribute('src', '../media/bright-mode.png');
}

const video = document.querySelector('.video');
if (video !== null) {
  video.onclick = (e) => {
    if (e.ctrlKey) window.open("../media/Elon_Musk_knocks_the_college_experience.mp4","self");
  }
  document.onkeydown = (e) => {
    if (document.activeElement === video && e.ctrlKey && e.key === 'Enter') window.open("../media/Elon_Musk_knocks_the_college_experience.mp4","self");
  }
}
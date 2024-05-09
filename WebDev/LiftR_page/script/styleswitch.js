// Cross browser addEvent function by John Resig
 
document.addEventListener("DOMContentLoaded", function() { //to fix the issue of JS trying to access properties before dom has loaded
  function addEvent(obj, type, fn) {
    if (obj.attachEvent) {
      obj['e' + type + fn] = fn;
      obj[type + fn] = function() {
        obj['e' + type + fn](window.event);
      }
      obj.attachEvent('on' + type, obj[type + fn]);
    } else obj.addEventListener(type, fn, false);
  }
   
  function switchStyles() {
    var selectedOption = this.options[this.selectedIndex],
      className = selectedOption.value;
   
    document.body.className = className;
  }
   
  var styleSwitcher = document.getElementById("styleSwitcher");
  addEvent(styleSwitcher, "change", switchStyles);
})
document.addEventListener("DOMContentLoaded", function () {
    const text = document.getElementById("welcomeText");
    const letters = text.textContent.trim().split("");
    text.textContent = "";
  
    letters.forEach((letter, index) => {
      const span = document.createElement("span");
      span.textContent = letter;
      span.classList.add("letter");
      text.appendChild(span);
    });
  
    const letterElements = document.querySelectorAll(".letter");
    letterElements.forEach((letter, index) => {
      letter.style.animation = `fadeIn 1s ${index * 0.1}s`;
    });
  
    // After the animation is complete, set the opacity to 1
    setTimeout(() => {
      letterElements.forEach((letter) => {
        letter.style.opacity = 1;
      });
      // Reset the animation duration to 0 to prevent glitches when changing the time between letters
      text.style.animationDuration = "0s";
    }, letters.length * 100); // Wait for the last letter to complete its animation (1 second per letter)
  });
// Get the navbar menu element
let navMenu = document.querySelector("#main-nav");

// Listen for scroll events on the window
window.addEventListener("scroll", () => {
    // Check if the navbar menu is open
    if (navMenu.classList.contains("show")) {
        // Close the navbar menu
        let toggleButton = document.querySelector(".navbar-toggler");
        toggleButton.click(); // Simulate a click on the toggle button to close the menu
    }
});

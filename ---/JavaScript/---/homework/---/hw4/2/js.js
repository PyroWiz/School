document.addEventListener("DOMContentLoaded", () => {
    // Select all buttons
    const buttons = document.querySelectorAll("button");

    // Add a click event listener to each button
    buttons.forEach(button => {
        button.addEventListener("click", () => {
            // Get the button's ID (which corresponds to the color)
            const color = button.id;

            // Set the background color of the page
            document.body.style.backgroundColor = color;
        });
    });
});
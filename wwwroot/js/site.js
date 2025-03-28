// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    console.log("News page loaded.");

    // Example: Highlight the first news item on load
    let firstNewsItem = document.querySelector(".news-item");
    if (firstNewsItem) {
        firstNewsItem.style.border = "2px solid blue";
    }
});

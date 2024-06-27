// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Inside site.js or inline in the HTML
document.addEventListener('DOMContentLoaded', function () {
    var searchInput = document.getElementById('searchInput');
    searchInput.addEventListener('focus', function () {
        // Clear the placeholder text when input is focused
        this.placeholder = '';
    });

    searchInput.addEventListener('blur', function () {
        // Restore the placeholder text if input is blurred and no text has been entered
        if (!this.value.trim()) {
            this.placeholder = 'Search...';
        }
    });
});


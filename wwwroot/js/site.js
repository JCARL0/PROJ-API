// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function zoomCard(card) {
    // Remove zoom class from any currently zoomed card
    document.querySelectorAll('.game-card.zoom').forEach(function (zoomedCard) {
        zoomedCard.classList.remove('zoom');
    });

    // Add zoom class to the clicked card
    card.classList.add('zoom');

    // Show overlay
    document.getElementById('overlay').classList.add('show');
}

function closeZoom() {
    // Remove zoom class from any currently zoomed card
    document.querySelectorAll('.game-card.zoom').forEach(function (zoomedCard) {
        zoomedCard.classList.remove('zoom');
    });

    // Hide overlay
    document.getElementById('overlay').classList.remove('show');
}

function startAnimation() {
    var note = document.getElementById("musicNote");

    note.classList.remove("move");
    void note.offsetWidth;
    note.classList.add("move");
}

function openLightbox(image) {
    var lightbox = document.getElementById("lightbox");
    var lightboxImg = document.getElementById("lightbox-img");

    lightbox.style.display = "flex";
    lightboxImg.src = image.src;
}

function closeLightbox() {
    var lightbox = document.getElementById("lightbox");

    lightbox.style.display = "none";
}

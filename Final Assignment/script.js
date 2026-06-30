function startAnimation() {
    var note = document.getElementById("musicNote");

    note.classList.remove("move");
    void note.offsetWidth;
    note.classList.add("move");
}

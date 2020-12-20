


function miFiltrar() {
    var input, filter, cards, title, i;

    input = document.getElementById("buscaInfoPrincipal");

    filter = input.value.toUpperCase();

    cards = document.getElementsByClassName("div_h4");

    for (i = 0; i < cards.length; i++) {
        title = cards[i].textContent;
        if (title.toUpperCase().indexOf(filter) > -1) {
            cards[i].parentNode.style.display = "";
        } else {
            cards[i].parentNode.style.display = "none";
        }
    }
}


//ON DOCUMENT READY 
$(document).ready(function () {

    document.('#buscaInfoPrincipal').keyup(function () {
        miFiltrar();
    })

    //const inputBuscar = document.querySelector('#buscaInfoPrincipal');
    //inputBuscar.addEventListener('keyup', miFiltrar);



});

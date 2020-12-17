

function vVistaProducto() {

   
    let contenedorProducto = document.querySelector('#contenedorproductos');

    var imagen = {};

    var card_container = document.createElement('div');
    card_container.classList.add('col-4');
    card_container.style.marginTop = "10px";
    card_container.style.cursor = "pointer";

    var div_card = document.createElement('div');

    $(div_card).mouseover(function () {
        this.style.opacity = "0.7"
    })
    $(div_card).mouseout(function () {
        this.style.opacity = "1"
    })
    $(div_card).click(function () { // AQUI SE PUEDE PONER LA FUNCION PARA COMPRAR O CARRITO
        var vProducto = new vVistaClienteUF();
        vComercio.cambiarComercio(data[i]);
    })

    div_card.classList.add('card', 'mr-3');

    var divh3 = document.createElement('h3');
    //divh3.classList.add('card-header');
    //divh3.classList.add('bg-dark');
    //divh3.classList.add('text-white');
    //divh3.classList.add('card-title');
    divh3.innerText = @producto.Nombre;  //  AQUÍ SE LE PONE EL NOMBRE DEL PROD AL CARD


    var img_container = document.createElement('div');
    img_container.classList.add('img-container');

    var imagen = document.createElement('img');
    imagen.classList.add('img-fluid');
    imagen.style.height = "200px";
    imagen.style.width = "100%";
    imagen.id = 'i' + data[i].CedulaProducto; // ARREGLAR AQUI. OCUPO LA LISTA DE IMAGENES
    imagen.src = '';

    var divh5 = document.createElement('h5');
    divh5.id = 'idProducto';
    divh5.style.margin = "auto";
    divh5.innerText = producto.Id;

    contenedorProducto.appendChild(card_container);
    card_container.appendChild(div_card);
    div_card.appendChild(divh3);
    //  img_container.appendChild(imagen);
    //  div_card.appendChild(img_container);
    div_card.appendChild(divh5);
}














$(document).ready(function () {

    var vProducto = new vVistaProductos();
    



});
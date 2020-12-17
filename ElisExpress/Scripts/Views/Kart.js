function actualizarBadge(num) {
    $("#badge")[0].innerHTML = num;
}

function vaciar() {
    $("#productosKart").children().remove();
    actualizarPrecio();
    $("#productosKart")[0].innerHTML = "Sin Productos";
    $("#badge")[0].innerHTML = "";
    sessionStorage.removeItem("ListaProductos");
}

function actualizarBadgepositivo() {
    if ($("#badge")[0].innerHTML == "") {
        $("#badge")[0].innerHTML = 1;
        $("#productosKart")[0].innerHTML = "";
    }
    else {
        $("#badge")[0].innerHTML = Number.parseInt($("#badge")[0].innerHTML) + 1;
    }


}

function asignarRestaurante(nombreRestaurante) {
    $("#RestauranteKart")[0].innerHTML = nombreRestaurante;
}

function actualizarBadgeNegativo() {

    if ($("#badge")[0].innerHTML == "1") {
        $("#badge")[0].innerHTML = "";
        $("#productosKart")[0].innerHTML = "Sin Productos";
    }
    else {
        $("#badge")[0].innerHTML = Number.parseInt($("#badge")[0].innerHTML) - 1;
    }

}



function abrirKart() {
    $("#modalKart").modal("show")
}

function actualizarPrecio() {
    var Total = 0;
    $('[data-precio]').each(function () {
        Total = Number.parseFloat(Total) + (Number.parseFloat(this.innerText)) * Number.parseInt(this.parentElement.children[2].innerText);
    })
    if (Total.toString().lastIndexOf(".") != -1) {
        Total = Total.toString().substr(0, Total.toString().lastIndexOf(".")) + Total.toString().substr(Total.toString().lastIndexOf("."), 3);
    }

    $("#precioFinal")[0].innerText = "$ " + Number.parseFloat(Total);
}

function agregarProduto(IdProducto, producto, cantidad, precio) {

    //var productosList = traerProductosSession();
    var productosList = $("#productosKart").children();
    var existe = false;
    var prod = { "IdProducto": IdProducto, "producto": producto, "cantidad": cantidad, "precio": precio };
    $(productosList).each(function () {

        if (this.id.substr(4) == IdProducto) {
            existe = true;
        }

    })

    if (existe) {
        var filaexistente = $("#fila" + IdProducto).children()[2];
        filaexistente.innerText = Number.parseInt(filaexistente.innerText) + Number.parseInt(cantidad);
        actualizarProductoSession(prod);
    }
    else {
        actualizarBadgepositivo();
        var fila = document.createElement("div");
        fila.classList.add("row");
        fila.classList.add("p-2");
        fila.classList.add("border-bottom");
        fila.classList.add("border-secondary");
        fila.style.alignItems = "center";
        fila.style.background = "aliceblue";
        fila.id = "fila" + IdProducto;

        var eliminar = document.createElement("i");
        eliminar.classList.add("fas");
        eliminar.classList.add("fa-times-circle");
        eliminar.classList.add("col-1");
        eliminar.style.cursor = "pointer";
        eliminar.onclick = function () {

            eliminarProductosSession($(this).parent()[0].id.substr(4));
            console.log($(this).parent().remove());
            actualizarBadgeNegativo()
            actualizarPrecio();
        };

        var nproducto = document.createElement("div");
        nproducto.classList.add("col-7");
        nproducto.innerHTML = producto;


        var ncantidad = document.createElement("div");
        ncantidad.classList.add("col-2");
        ncantidad.classList.add("text-center");
        ncantidad.innerHTML = cantidad;


        var nprecio = document.createElement("div");
        nprecio.classList.add("col-2");
        nprecio.classList.add("text-center");
        nprecio.dataset.precio = "kartPrecio";
        nprecio.innerHTML = precio;

        fila.appendChild(eliminar);
        fila.appendChild(nproducto);
        fila.appendChild(ncantidad);
        fila.appendChild(nprecio);


        $("#productosKart")[0].appendChild(fila);

        guardarProductosSession(prod);
    }





    actualizarPrecio();


}

function enviarMensaje(mensaje) {
    controlA = new ControlActions()
    controlA.ShowMessage("I", "-" + mensaje)
}


function actualizarKart() {
    var productos = traerProductosSession();
    if (productos != undefined) {
        $("#RestauranteKart")[0].innerHTML = traerRestauranteSession();
        $("#productosKart")[0].innerHTML = "";
        $(productos).each(function () {
            agregarProduto(this.IdProducto, this.producto, this.cantidad, this.precio);
        })
        sessionStorage.ListaProductos = JSON.stringify(productos);
    }

}

function traerProductosSession() {
    var productos = [];
    if (sessionStorage.ListaProductos != undefined) {
        return JSON.parse(sessionStorage.ListaProductos);
    }
    else {
        return productos;
    }
}


function eliminarProductosSession(id) {
    var productos = [];
    if (sessionStorage.ListaProductos != undefined) {
        productos = JSON.parse(sessionStorage.ListaProductos);
    }
    var primero = true;
    productos = $.grep(productos, function (e) {

        if (e.IdProducto == id && primero) {
            primero = false;
            return false;

        } else {
            return true;
        }
    });

    sessionStorage.ListaProductos = JSON.stringify(productos);
}


function guardarProductosSession(producto) {
    var lista = [];
    if (sessionStorage.ListaProductos != undefined) {
        lista = JSON.parse(sessionStorage.ListaProductos);

    }
    lista.push(producto);
    sessionStorage.ListaProductos = JSON.stringify(lista);
}

function actualizarProductoSession(producto) {
    var lista = traerProductosSession();
    $(lista).each(function () {
        if (this.IdProducto == producto.IdProducto) {
            this.cantidad = Number.parseInt(this.cantidad) + Number.parseInt(producto.cantidad);
        }
    })

    sessionStorage.ListaProductos = JSON.stringify(lista);
}

function traerRestauranteSession() {
    if (sessionStorage.ComercioActualNombre != undefined) {
        return sessionStorage.ComercioActualNombre;
    } else {
        return "Elija un restaurante";
    }
}

function procesarOrden() {
    if (sessionStorage.Logueado == undefined) {
        controlA = new ControlActions()
        controlA.ShowMessage("W", "-Debe inicar sesion para procesar la orden.");
    }
    else {
        window.location.href = window.location.origin + "/UsuarioFinal/vPagarOrden";
    }

}




$(document).ready(function () {
    actualizarKart();
})

function ControlActions() {

    this.URL_API = "http://localhost:44378/api/";
    this.URL_APP = "http://localhost:44300/";


    this.GetUrlApiService = function (service) {
        return this.URL_API + service;
    }
    this.GetUrlApiServiceId = function (service, Id) {
        return this.URL_API + service + "?" + Id;
    }

    this.GetTableColumsDataName = function (tableId) {
        var val = $('#' + tableId).attr("ColumnsDataName");

        return val;
    }

    this.FillTable = function (service, tableId, refresh) {

        if (!refresh) {
            columns = this.GetTableColumsDataName(tableId).split(',');
            var arrayColumnsData = [];


            $.each(columns, function (index, value) {
                var obj = {};
                obj.data = value;
                arrayColumnsData.push(obj);
            });

            $('#' + tableId).DataTable({
                "processing": true,
                "ajax": {
                    "url": this.GetUrlApiService(service),
                    dataSrc: 'Data'
                },
                "columns": arrayColumnsData
            });
        } else {
            //RECARGA LA TABLA
            $('#' + tableId).DataTable().ajax.reload();
        }

    }

    this.GetSelectedRow = function () {
        var data = sessionStorage.getItem(tableId + '_selected');

        return data;
    };

    this.BindFields = function (formId, data) {
        console.log(data);
        $('#' + formId + ' *').filter(':input').each(function (input) {
            var columnDataName = $(this).attr("ColumnDataName");
            this.value = data[columnDataName];
        });
    }


    // Obtiene los datos de los formularios
    this.GetDataForm = function (formId) {
        var data = {};

        $('#' + formId + ' *').filter(':input').each(function (input) {
            var columnDataName = $(this).attr("columnDataName");
            data[columnDataName] = this.value;
        });

        return data;
    }


    this.ShowMessage = function (type, message) {
        console.log("Mensaje : " + message);
        //Ya que todas las funciones llaman a esta funcion, pero no todas proveen el exception message...
        //Como no tiene '-', da error, y el codigo no continua. Por eso se agrega este if
        if (message.includes("-")) {
            if (type == 'E') {//Error
                $.notify(message.split('-')[1], {
                    style: 'togoStyle',
                    showAnimation: 'slideDown',
                    position: 'bottom right',
                    autoHide: false,
                    className: 'danger'
                });
            } else if (type == 'I') {//Intended
                $.notify(message.split('-')[1], {
                    style: 'togoStyle',
                    showAnimation: 'slideDown',
                    position: 'bottom right',
                    className: 'success'
                });
            } else if (type == 'W') {//Warning
                $.notify(message.split('-')[1], {
                    style: 'togoStyle',
                    showAnimation: 'slideDown',
                    position: 'bottom right',
                    className: 'warning'
                });
            }
        }
    };

    this.PostToAPI = function (service, data) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);

        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };

    this.PostToAPIFun = function (service, data, callbackFunction) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
            callbackFunction(data.Cedula);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };
    this.PostToAPICambiarContrasena = function (service, data, callbackFunction) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
            return callbackFunction();
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };

    this.PostToAPICallbacks = function (service, data, callbackSuccess, callbackFail) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
            return callbackSuccess(response.Data);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                callbackFail(data);
                console.log(data);
            })
        return jqxhr;
    };


    // Post to api Productos
    this.PostToAPIProductos = function (service, data) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);

        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };

    // Post to api fotos
    this.PostToAPIFotos = function (service, data) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);

            $("#txtIDFoto")[0].value = response.Data.IDFoto;


        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };


    // Post to api fotos de productos
    this.PostToAPIFotosProductos = function (service, data) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };


    // Post to api documentos
    this.PostToAPIDocumentos = function (service, data) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);

            $("#txtIdMembresiaComercio")[0].value = response.Data.IdMembresiaComercio;

        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };

    this.PostToAPIDOC = function (service, data) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);


        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };


    this.PostToAPIMT = function (service, data, callbackFunction) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);

            $("#txtIDMembresiaTransportistas")[0].value = response.Data.IDMembresiaTransportistas;

            callbackFunction();
            window.location.href = "http://localhost:44300/";

        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };

    this.PostToAPIADM = function (service, data, callbackFunction) {
        var jqxhr = $.post(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);

            $("#txtCedula")[0].value = response.Data.Cedula;

            callbackFunction();
            window.location.href = "http://localhost:44300/";

        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        return jqxhr;
    };


    // Put to api
    this.PutToAPI = function (service, data) {
        var jqxhr = $.put(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
    };

    this.PutToAPICallbacks = function (service, data, callSuccess, callFail) {
        var jqxhr = $.put(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
            callSuccess(data);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
                callFail(data);
            })
    };

    // Put to api Productos
    this.PutToAPIProductos = function (service, data) {
        var jqxhr = $.put(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log("[data]: " + data);
            })
    };

    // Put to api Ordenes
    this.PutToAPIOrdenes = function (service, data, callback) {
        var jqxhr = $.put(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
            callback();
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log("[data]: " + data);
            })
    };



    // delete to api
    this.DeleteToAPI = function (service, data) {
        var jqxhr = $.delete(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })

    };

    // delete to api ordenes
    this.DeleteToAPIOrdenes = function (service, data, callback) {
        var jqxhr = $.delete(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log("[data]: " + data);
            })
    };


    // Delete to api productos
    this.DeleteToAPIProductos = function (service, data) {
        var jqxhr = $.delete(this.GetUrlApiService(service), data, function (response) {
            var ctrlActions = new ControlActions();
            ctrlActions.ShowMessage('I', response.Message);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
        window.location.reload();
    };


    // Get to api (todos)
    this.GetToApi = function (service, callbackFunction) {
        console.log("[GetToApi] corriendo GET: " + this.GetUrlApiService(service));
        var jqxhr = $.get(this.GetUrlApiService(service), function (response) {
            return callbackFunction(response.Data);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                console.log(data);
            })
    };
    // Get alternativo para hacer funcion especifica si falla
    this.GetToApiCallbackFail = function (service, callbackFunction, callbackFail) {
        console.log("[GetToApi] corriendo GET: " + this.GetUrlApiService(service));
        var jqxhr = $.get(this.GetUrlApiService(service), function (response) {
            return callbackFunction(response.Data);
        })
            .fail(function (response) {
                var data = response.responseJSON;
                var ctrlActions = new ControlActions();
                ctrlActions.ShowMessage('E', data.ExceptionMessage);
                callbackFail();
                console.log(data);
            })
    };

    // Get to api (todos) // productos
    this.GetToApiTP = function (service, callbackFunction) {
        var jqxhr = $.get(this.GetUrlApiService(service), function (response) {
            console.log("Response " + response);

            return callbackFunction(response.Data);
        });
    }


    this.GetToApiIdFun = function (service, Id, callbackFunction) {
        var jqxhr = $.get(this.GetUrlApiServiceId(service, Id), function (response) {
            console.log("Response " + response);

            callbackFunction(response.Data);
        });
    }

    this.GetToApiSave = function (service, nombre) {
        var jqxhr = $.get(this.GetUrlApiService(service), function (response) {
            console.log("Response " + response);
            sessionStorage.setItem(nombre, JSON.stringify(response.Data));
        });
    }

    this.GetToApiSaveFun = function (service, nombre, callbackFunction) {
        var jqxhr = $.get(this.GetUrlApiService(service), function (response) {
            console.log("Response " + response);
            sessionStorage.setItem(nombre, JSON.stringify(response.Data));
            callbackFunction();
        });
    }


    // Get to api (por ID)
    this.GetToApiId = function (service, Id) {
        var jqxhr = $.get(this.GetUrlApiServiceId(service, Id), function (response) {
            console.log("Response " + response);
            //callbackFunction(response.Data);
        });
    }


    this.GetToApiIdContrasenaAdmin = function (service, Id, to, from) {
        var jqxhr = $.get(this.GetUrlApiServiceId(service, Id), function (response) {
            console.log("Response " + response);
            var datos = {};
            datos.contraseña = response.Data;
            datos.User = "evenegass@ucenfotec.ac.cr";
            EnviarCorreoUsuarioAdmin("evenegass@ucenfotec.ac.cr", "ToGoNotificando@info.com", JSON.stringify(datos), 3);

        });
    }



    // Get to api (por ID de foto)
    this.GetToApiIdFoto = function (service, Id, callbackFunction) {
        var jqxhr = $.get(this.GetUrlApiService(service, Id), function (response) {
            console.log("Response " + response.Data);
            // callbackFunction(response.Data);
        });
    }

}

//Custom jquery actions

$.put = function (url, data, callback) {
    if ($.isFunction(data)) {
        type = type || callback,
            callback = data,
            data = {}
    }
    return $.ajax({
        url: url,
        type: 'PUT',
        success: callback,
        data: JSON.stringify(data),
        contentType: 'application/json'
    });
}

$.delete = function (url, data, callback) {
    if ($.isFunction(data)) {
        type = type || callback,
            callback = data,
            data = {}
    }
    return $.ajax({
        url: url,
        type: 'DELETE',
        success: callback,
        data: JSON.stringify(data),
        contentType: 'application/json'
    });
}


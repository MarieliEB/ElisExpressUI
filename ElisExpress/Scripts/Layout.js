$(document).ready(function () {
    $('#sesion').click(function () {
        $('.drop-down').toggleClass('drop-down--active');

    });

    //Codigo de notificacion
    $.notify.addStyle('togoStyle', {
        html: "<div><span data-notify-text/>  <i class=\"fas fa-times\"></i></div>",
        classes: {
            base: {
                "white-space": "nowrap",
                "margin-bottom": "100px",
                "margin-right": "40px",
                "font-size": "18px",
                "border-radius": "0.25rem",
                "padding": "20px"
            },
            danger: {
                "background-color": "#ee9891"
            },
            success: {
                "color": "white",
                "background-color": "#38B44A"
            },
            warning: {
                "background-color": "#fbebc9"
            }
        }
    });
});



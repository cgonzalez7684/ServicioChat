<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"/>
    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <!-- Latest compiled JavaScript -->
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>



   

    <script>
      


        $(document).ready(

        $(function () {
            $('#BtnEnviar').click(function () {
                var f = new Date();
                var cad = f.getHours() + ":" + f.getMinutes() + ":" + f.getSeconds();

                var dato = $('#Mensaje').val();
                $('#Chat').val(cad + ' - Usuario#1: ' + dato + '\n' + $('#Chat').val());
                $('#Mensaje').val('');
            });


            $('#Mensaje').keypress(function (evt) {
                if (event.which == 13) {
                    var dato = $('#Mensaje').val();
                    $('#Chat').val(cad + ' - Usuario#1: ' + dato + '\n' + $('#Chat').val());
                    $('#Mensaje').val('');
                    //event.preventDefault();
                }

            })
        }
        )
        )



        $(function () {
            $('#btnSumar').click(function () {
                var num1 = $('#num1').val(); //Obtenemos el primer número
                var num2 = $('#num2').val(); //Obtenemos el segundo número
                $.ajax({
                    type: "POST",
                    url: "ServicioWeb.aspx/Sumar",
                    data: '{Valor1: ' + num1 + ', Valor2: ' + num2 + '}',
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: resultado,
                    error: errores
                });
            });
        });
        function resultado(msg) {
            //msg.d tiene el resultado devuelto por el método
            $('#num3').val(msg.d);
        }
        function errores(msg) {
            //msg.responseText tiene el mensaje de error enviado por el servidor
            alert('Error: ' + msg.responseText);
        }
    </script>
    <style type="text/css">
    * {margin:0; padding:0;}
    html, body {width:100%; 
    height:100%; 
    overflow:hidden; 
    }
    #contenido {width:100%; 
    height:100%;
    overflow: auto;
    } 
    #fijo { 
    position:absolute;
    width:200px;
    height:200px;
    border:1px solid #000;
    background:#cff;
    left:50%;
    margin-left:-100px;
    top:50%;
    margin-top:-100px;
    } 
    </style>

</head>
<body>

    <br />

    


        <div id="contenido">
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
<p>Texto texto texto texto texto texto texto texto texto texto texto texto texto texto texto</p>
</div>




        <script type="text/javascript" src="Scripts/ventana.js"></script>
</body>
</html>




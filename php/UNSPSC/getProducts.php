<?php
    // LaFactura.co
    // Conexion via API
    //
    // Ejemplo de solicitud de productos de una clase de UNSPSC v.14.0.80 en español
    //
    // Ultima revisión Julio-24-2020


    //Este ejemplo recibe todos los rangos disponibles para documentos

    include_once("../API/api.php");

    $usuario="elusuario"; //coloca en este punto tu usuario
    $contrasena="lacontrasena"; //coloca tu contraseña
    $url="https://playground.lafactura.co/api2.1"; //estea esl la URL de acceso a la api

    //solicita los rangos de documentos
    $solicitud=[
      "UNSPSC"=>[
          "version"=>"v14.0.80",  //version a ser usada
          "getProducts"=>[ //obtener productos
            "lang"=>"es", //en español
            "class"=>"105016" //la clase para obtener los productos
          ]
      ]
    ];
    //convierto a JSON la solicitud
    $solicitud=json_encode($solicitud,JSON_UNESCAPED_UNICODE | JSON_HEX_QUOT);

    $api=new LF_API_v200($url,$usuario,$contrasena);
    $api->send(LF_SERVICE_GENERAL,$solicitud,LF_METHOD_GET); //metodo GET
    echo $api->response; //resulado de la peticion en JSON
?>

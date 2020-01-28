<?php
    //Este ejemplo recibe todos los rangos disponibles para documentos

    include_once("API/api.php");

    $usuario="elusuario"; //coloca en este punto tu usuario
    $contrasena="lacontrasena"; //coloca tu contraseña
    $url="https://playground.lafactura.co/api2.0"; //estea esl la URL de acceso a la api

    //solicita los rangos de documentos
    $solicitud=[
      "getRanges"=>[
          "mode"=>"active", //rangos activos o inactivos
          "type"=>"all" //todos o pueden ser invoice, creditNote, debitNote, all (todos)
      ]
    ];
    //convierto a JSON la solicitud
    $solicitud=json_encode($solicitud,JSON_UNESCAPED_UNICODE | JSON_HEX_QUOT);

    $api=new LF_API_v200($url,$usuario,$contrasena);
    $api->send(LF_SERVICE_GENERAL,$solicitud,LF_METHOD_GET); //metodo GET
    echo $api->response; //resulado de la peticion en JSON

?>

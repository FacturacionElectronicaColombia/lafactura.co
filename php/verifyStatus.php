<?php
  //Este ejemplo verifica el estado de una factura en el sistema

  include_once("API/api.php");

  $usuario="elusuario"; //coloca en este punto tu usuario
  $contrasena="lacontrasena"; //coloca tu contraseña
  $url="https://playground.lafactura.co/api2.0"; //estea esl la direccion de acceso a la api

  //aqui se solicita el estado del documento en cuestion
  $solicitud=[
    "verifyStatus"=>[
        "tascode"=>"fc-54984309jtr0ret90jjrg";
    ];
  ];

  $api=new LF_API_v200($url,$usuario,$contrasena);
  $api->send("invoice",json_encode($solicitud,JSON_UNESCAPED_UNICODE),LF_METHOD_POST);
  echo $api->response; //resulado de la peticion en JSON


?>

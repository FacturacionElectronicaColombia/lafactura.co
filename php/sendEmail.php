<?php
  // LaFactura.co
  // Conexion via API
  //
  // Ejemplo de solicitud de reenvio de documento a un correo electronico
  //
  // Ultima revisión Feb-05-2020

  //Este ejemplo permite reenviar un correo con el documento solicitado

  include_once("API/api.php");

  $usuario="elusuario"; //coloca en este punto tu usuario
  $contrasena="lacontrasena"; //coloca tu contraseña
  $url="https://playground.lafactura.co/api2.1"; //estea esl la URL de acceso a la api

  //solicita envio de correo
  $solicitud=[
    "sendEmail"=>[
        "tascode"=>"fc-54984309jtr0ret90jjrg", //documento en cuestion
        "email"=>"pepito@ejemplo.com" //correo de destino
    ]
  ];
  //convierto a JSON la solicitud
  $solicitud=json_encode($solicitud,JSON_UNESCAPED_UNICODE | JSON_HEX_QUOT);

  $api=new LF_API_v200($url,$usuario,$contrasena);
  $api->send(LF_SERVICE_GENERAL,$solicitud,LF_METHOD_POST); //metodo POST
  echo $api->response; //resulado de la peticion en JSON

?>

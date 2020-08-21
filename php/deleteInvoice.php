<?php
  // LaFactura.co
  // Conexion via API
  //
  // Ejemplo de solicitud de anulacion de factura en el sistema
  
  //Este ejemplo genera una nota credito por el valor total de una factura en el sistema
  include_once("API/api.php");

  $usuario="elusuario"; //coloca en este punto tu usuario
  $contrasena="lacontrasena"; //coloca tu contraseña
  $url="https://playground.lafactura.co/api2.0"; //estea esl la URL de acceso a la api

  date_default_timezone_set('America/Bogota'); //coloco la hora para colombia

  $tascode="fc-54984309jtr0ret90jjrg"; //factura a anular
  $hash=md5($tascode.date("Ymd")); //genero el hash (md5)

  //aqui se prepara la informacion a ser enviada
  $solicitud=[
    "deleteInvoice"=>[
        "tascode"=>$tascode, //factura a anular
        "hash"=>$hash, //hash creado
        "description"=>"El cliente no aceptó el producto" //motivo de anulacion
    ]
  ];
  //convierto a JSON la solicitud
  $solicitud=json_encode($solicitud,JSON_UNESCAPED_UNICODE | JSON_HEX_QUOT);

  $api=new LF_API_v200($url,$usuario,$contrasena);
  $api->send(LF_SERVICE_INVOICE,$solicitud,LF_METHOD_DELETE); //metodo DELETE
  echo $api->response; //resulado de la peticion en JSON


?>

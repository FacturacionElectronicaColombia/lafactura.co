<?php
      //este es un ejemplo del codigo que requieres para recibir nuestras notificaciones
      //ante lños eventos referentes a tus documentos en nuestro sistema.
      //
      //Nuestra plataforma, te puede enviar via https a una URL tuya estas notificacione
      //en tiempo real.
      //
      //Solo debes informarnos la URL a cual deseas que enviemos las notificaciones.

      //leo la informacion que llega a esta url
      $handler=fopen("php://input","r");
      $info=stream_get_contents($handler);
      fclose($handler);

      $arreglo=json_decode($info,true); //convierto de JSON a un arreglo
      //Aqui ya puedes utilizar la informacion de la manera
      //que consideres apropiada.

?>

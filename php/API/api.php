<?php

  define('LF_METHOD_POST',"POST");
  define('LF_METHOD_PUT',"PUT");
  define('LF_METHOD_DELETE',"DELETE");

  function LF_send($url,$send,$usr,$pwd,$method=LF_METHOD_POST){
    try{
       $headers = array(
            "Content-type: application/json",
            "Cache-Control: no-cache",
            "Pragma: no-cache",
            "Content-Length: ".strlen($send),
            "Connection: Keep-Alive",
            "User-Agent: LaFactura.co/4.0",
        );
        $ch = curl_init();
        curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, true);
        curl_setopt($ch, CURLOPT_URL, $url);
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
        curl_setopt($ch, CURLOPT_TIMEOUT, 50); //Espera 50 Secs
        switch($method){
          case LF_METHOD_PUT: curl_setopt($ch, CURLOPT_PUT, true);break;
          case LF_METHOD_POST: curl_setopt($ch, CURLOPT_POST, true);break;
          default: curl_setopt($ch, CURLOPT_CUSTOMREQUEST, $method);
        }
        curl_setopt($ch, CURLOPT_POSTFIELDS, $send);
        curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);
        curl_setopt($ch, CURLOPT_USERPWD, "$usr:$pwd");
        curl_setopt($ch, CURLOPT_CONNECTTIMEOUT, 30); //Timeout
        $response = curl_exec($ch);
        $curl_info= curl_getinfo($ch);
        if(curl_error($ch)){
          return false;
        }
        curl_close($ch);
    } catch(Exception $e){
        return false;
    }
    return $response;
  }


?>

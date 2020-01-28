<?php

  define('LF_METHOD_POST',"POST");
  define('LF_METHOD_PUT',"PUT");
  define('LF_METHOD_GET',"GET");
  define('LF_METHOD_DELETE',"DELETE");

  define('LF_SERVICE_INVOICE',"invoice");
  define('LF_SERVICE_GENERAL',"general");

  class LF_API_v200 {
      public $error=false;
      public $url,$usr,$pwd,$response;

      public function __construct($url,$usr,$pwd){
        $this->url=$url;
        $this->usr=$usr;
        $this->pwd=$pwd;
      }

      public function send($service,$send,$method=LF_METHOD_POST){
        $this->error=false;
        $this->response="";
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
            curl_setopt($ch, CURLOPT_URL, $this->url."/".$service."/");
            curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
            curl_setopt($ch, CURLOPT_TIMEOUT, 50); //Espera 50 Secs
            curl_setopt($ch, CURLOPT_POST, false);
            switch($method){
              case LF_METHOD_GET:   curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "GET");break;
              case LF_METHOD_PUT:   curl_setopt($ch, CURLOPT_PUT, true);break;
              case LF_METHOD_POST:  curl_setopt($ch, CURLOPT_POST, true);break;
              default:              curl_setopt($ch, CURLOPT_CUSTOMREQUEST, $method);
            }
            curl_setopt($ch, CURLOPT_POSTFIELDS, $send);
            curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);
            curl_setopt($ch, CURLOPT_USERPWD, "{$this->usr}:{$this->pwd}");
            curl_setopt($ch, CURLOPT_CONNECTTIMEOUT, 30); //Timeout
            $response = curl_exec($ch);
            $this->response=$response;
            $curl_info= curl_getinfo($ch);
            if(curl_error($ch)){
              $this->error=true;
              return null;
            }
            curl_close($ch);
          } catch(Exception $e){
            $this->error=true;
            return null;
        }
        return $response;
      }
  }


?>

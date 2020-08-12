<?php
  // LaFactura.co
  // Conexion via API
  //
  // Ejemplo de creacion de una Factura
  //
  // Ultima revisión Feb-05-2020

  //Este ejemplo crea una factura nacional
  include_once("API/api.php");

  $usuario="elusuario"; //coloca en este punto tu usuario
  $contrasena="lacontrasena"; //coloca tu contraseña
  $url="https://playground.lafactura.co/api2.0"; //estea esl la URL de acceso a la api

  date_default_timezone_set('America/Bogota'); //coloco la hora para colombia

  //aqui se prepara la informacion a ser enviada
  $solicitud=[
    "invoice"=>[
      "rangeKey"=>"rk-9334924376729cd05d593184087bf5f8",         //llave para el proceso de validacion
      "issueDate"=>"20200201",                                //fecha de la factura
      "issueTime"=>"180600",                                  //hora de la factura
      "dueDate"=>"20200229",                                  //fecha del vencimiento
      "note1"=>"CIEN MIL PESOS MONEDA CORRIENTE",             //Valor en letras
      "customer"=>[
        "additionalAccountID"=>"1",                           //Persona Juridica
        "name"=>"PEPITO PEREZ SAS",                           //Empresa
        "city"=>"Bogota",                                     //Ciudad
        "countryEntity"=>"11",                                //BOGOTA D.C. - Departamento
        "countrySubentity"=>"11001",                          //BOGOTA - Municipio
        "addressLine"=>"Cra 113 No. 8-47 OF 1103",            //Direccion
        "documentNumber"=>"900373044",                        //Documento legal
        "documentType"=>"31",                                 //NIT
        "telephone"=>"311290290",                             //telefono
        "email"=>"pepe@ejemplo.com"                           //correo
      ],//amounts no verificado
      "amounts"=>[
        "totalAmount"=>"150000.00",                           //valor total
        "discountAmount"=>"30000.00",                         //descuentos
        "extraAmount"=>"15000.00",                            //cargos
        "taxAmount"=>"31050.00",                              //total impuestos
        "payAmount"=>"166050.00",                             //total a pagar
      ],
      "items"=>[
        [
          "quantity"=>"15.00",                                //Cantidad
          "unitPrice"=>"10000.00",                            //Precio unitario
          "total"=>"135000.00",                               //Total
          "description"=>"Lentes TAS SPORT 1",                //Descripcion
          "brand"=>"TAS",                                     //Marca
          "model"=>"SPORT 1",                                 //Modelo
          "standard"=>"999",                                  //Standard utilizado
          "agency"=>"991",                                    //Agencia del standard
          "code"=>"1000",                                     //Codigo del producto
          "allowance"=>
          [
            [
              "charge"=>"false",                              //descuento
              "reasonCode"=>"11",                             //Codigo del tipo de descuento (otros)
              "description"=>"a",                             //el motivo del descuento
              "baseAmount"=>"150000.00",                      //base para  el descuento
              "amount"=>"30000.00",                           //monto a descontar
              "percent"=>"20.00"                              //porcentaje de descuento
            ],
            [
              "charge"=>"true",                               //cargo adicional
              "reasonCode"=>"11",                             //no listados por la dian
              "description"=>"b",                             //descripcion del cargo adicional
              "baseAmount"=>"150000.00",                      //base para el cargo
              "amount"=>"15000.00",                           //monto
              "percent"=>"10.00"                              //porcentaje aplicado
            ]
          ],
          "taxes"=>
          [                                                   //Impuestos del item
            [
              "ID"=>"01",                                     //IVA
              "taxAmount"=>"25650.00",                        //impuesto
              "percent"=>"19.00",                             //porcentaje aplicado
            ],
            [
              "ID"=>"04",
              "taxAmount"=>"5400.00",
              "percent"=>"4.00"
            ]
          ]
        ]
      ]
    ]
  ];
  //convierto a JSON la solicitud
  $solicitud=json_encode($solicitud,JSON_UNESCAPED_UNICODE | JSON_HEX_QUOT);

  $api=new LF_API_v200($url,$usuario,$contrasena);
  $api->send(LF_SERVICE_INVOICE,$solicitud,LF_METHOD_POST);
  echo $api->response; //resulado de la peticion en JSON


?>

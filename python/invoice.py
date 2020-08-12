# Envios de facturas

import api

# Datos basicos
USR = "elusuario"
PWD = "lacontrasena"
URL = "https://playground.lafactura.co/api2.0"

# Solicitud
solicitud= {
        "invoice":{
            "rangeKey":"rk-9334924376729cd05d593184087bf5f8",
            "issueDate":"20200812",
            "issueTime":"180600",
            "dueDate":"20200812",
            "note1":"CIEN MIL PESOS MONEDA CORRIENTE",
            "customer":{
                "additionalAccountID":"1",
                "name":"PEPITO PEREZ SAS",
                "city":"Bogota",
                "countryEntity":"11",
                "countrySubentity":"11001",
                "addressLine":"Cra 113 No. 8-47 OF 1103",
                "documentNumber":"900373044",
                "documentType":"31",
                "telephone":"311290290",
                "email":"pepe@ejemplo.com"
            },
            "amounts":{
                "totalAmount":"150000.00",
                "discountAmount":"30000.00",
                "extraAmount":"15000.00",
                "taxAmount":"31050.00",
                "payAmount":"166050.00"
            },
            "items":[
                {
                    "quantity":"15.00",
                    "unitPrice":"10000.00",
                    "total":"135000.00",
                    "description":"Lentes TAS SPORT 1",
                    "brand":"TAS",
                    "model":"SPORT 1",
                    "standard":"999",
                    "agency":"991",
                    "code":"1000",
                    "allowance":[
                        {
                            "charge":"false",
                            "reasonCode":"11",
                            "description":"a",
                            "baseAmount":"150000.00",
                            "amount":"30000.00",
                            "percent":"20.00"
                        },
                        {
                            "charge":"true",
                            "reasonCode":"11",
                            "description":"b",
                            "baseAmount":"150000.00",
                            "amount":"15000.00",
                            "percent":"10.00"
                        }
                    ],
                    "taxes":[
                        {
                            "ID":"01",
                            "taxAmount":"25650.00",
                            "percent":"19.00"
                        },
                        {
                            "ID":"04",
                            "taxAmount":"5400.00",
                            "percent":"4.00"
                        }
                    ]
                }
            ]
        }
    }

# Envio
response  = api.invoice(URL,USR,PWD,solicitud)
# Resultado
print(response.text)

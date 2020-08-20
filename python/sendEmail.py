# Log de eventos de una factura

import api

# Datos basicos
USR = "elusuario"
PWD = "lacontrasena"
URL = "https://playground.lafactura.co/api2.0"

# Solicitud
solicitud= {
              'sendEmail':{
                'tascode':'xxx',
                "email":"ejemplo@ejemplo.com"
              }
            }

# Envio
response  = api.sendEmail(URL,USR,PWD,solicitud)
# Resultado
print(response.text)

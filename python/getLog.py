# Log de eventos de una factura

import api

# Datos basicos
USR = "elusuario"
PWD = "lacontrasena"
URL = "https://playground.lafactura.co/api2.0"

# Solicitud
solicitud= {
              'getLog':{
                'tascode':'xxx'
              }
            }

# Envio
response  = api.getLog(URL,USR,PWD,solicitud)
# Resultado
print(response.text)

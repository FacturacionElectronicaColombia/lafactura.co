#rangos de facturacion de una cuenta

import api

# Datos basicos
USR = "elusuario"
PWD = "lacontrasena"
URL = "https://playground.lafactura.co/api2.0"

# Solicitud
solicitud= {
              'getRanges':{
                'mode':'active',
                'type':'all'
              }
            }

# Envio
response  = api.getRanges(URL,USR,PWD,solicitud)
# Resultado
print(response.text)

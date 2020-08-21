#rangos de facturacion de una cuenta

import api

# Datos basicos
USR = "elusuario"
PWD = "lacontrasena"
URL = "https://playground.lafactura.co/api2.0"

# Solicitud
solicitud= {
    'RUES':{
        'RM':{
            'id':'900900900'
         }
    }

# Envio
response  = api.getRUESRM(URL,USR,PWD,solicitud)
# Resultado
print(response.text)

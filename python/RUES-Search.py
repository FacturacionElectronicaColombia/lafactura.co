#rangos de facturacion de una cuenta

import api

# Datos basicos
USR = "elusuario"
PWD = "lacontrasena"
URL = "https://playground.lafactura.co/api2.0"

# Solicitud
solicitud= {
    'RUES':{
        'search':{
            'name':'ejemplo'
         }
    }

# Envio
response  = api.getRUESSearch(URL,USR,PWD,solicitud)
# Resultado
print(response.text)

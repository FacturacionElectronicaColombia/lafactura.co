#Verificar el estado de un documento

import api

# Datos basicos
USR = "elusuario"
PWD = "lacontrasena"
URL = "https://playground.lafactura.co/api2.0"

# Solicitud
solicitud= {
              'verifyStatus':{
                'tascode':'xxx'
              }
            }

# Envio
response  = api.verifyStatus(URL,USR,PWD,solicitud)
# Resultado
print(response.text)

# Nota credito de factura completa

import api
from datetime import datetime
import hashlib

# Datos basicos
USR = "elusuario"
PWD = "lacontrasena"
URL = "https://playground.lafactura.co/api2.0"

# Solicitud
tascode="fc-54984309jtr0ret90jjrg"
now = datetime.now()
hash = hashlib.md5(tascode+now.strftime("%Y%m%d")).hexdigest()

solicitud= {
              'deleteInvoice':{
                'tascode':tascode,
                'hash':hash,
                'description':'El cliente no acepto el producto'
              }
            }

# Envio
response  = api.deleteInvoice(URL,USR,PWD,solicitud)
# Resultado
print(response.text)
#print(solicitud)

import requests
import json

LF_GENERAL="/general/index.php"
LF_INVOICE="/invoice/index.php"

def getInfo_LF(url, service, method, usr, pwd, info):
  return requests.request(method,url+service,json=info,headers={"content-type": "application/json"},auth=(usr,pwd))

def getRanges(url,usr,pwd,info):
    return getInfo_LF(url,LF_GENERAL,"GET",usr,pwd,info)

def invoice(url,usr,pwd,info):
    return getInfo_LF(url,LF_INVOICE,"POST",usr,pwd,info)

def getLog(url,usr,pwd,info):
    return getInfo_LF(url,LF_INVOICE,"GET",usr,pwd,info)

def verifyStatus(url,usr,pwd,info):
    return getInfo_LF(url,LF_INVOICE,"GET",usr,pwd,info)

def deleteInvoice(url,usr,pwd,info):
    return getInfo_LF(url,LF_INVOICE,"DELETE",usr,pwd,info)


# Comandos cortos de conexion a la API de la Factura.co
# Adicionalmente funcion principal de conexion

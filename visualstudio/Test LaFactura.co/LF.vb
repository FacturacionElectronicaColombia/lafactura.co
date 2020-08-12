Imports System.Net
Imports System.IO
Imports System.Text

Module LF
    'objetos basicos - status
    Public Class status
        Public Property Code As Integer
        Public Property Text As String
    End Class

    ''rangos
    Public Class range
        Public Property RangeKey As String
        Public Property Type As String
        Public Property Prefix As String
        Public Property FromNumber As String
        Public Property ToNumber As String
        Public Property Last As String
    End Class

    'interno de getRanges
    Public Class getRanges_INT
        Public Property Status As status
        Public Property Ranges As range()
    End Class

    'getRanges
    Public Class getRanges
        Public Property generalResult As getRanges_INT
    End Class

    'interno de getRanges
    Public Class generic_INT
        Public Property Status As status
    End Class

    'document
    Public Class document
        Public Property Type As String
        Public Property Mode As String
        Public Property Tascode As String
        Public Property Document As String
        Public Property Cufe As String
        Public Property Cude As String
        Public Property Url As String
        Public Property Check As String
        Public Property Process As Integer
    End Class

    Public Class verifyStatus_INT
        Public Property Status As status
        Public Property Document As document
    End Class

    Public Class getStatus_INT
        Public Property Status As status
        Public Property Documento As document
    End Class

    Public Class Log
        Public Property Fecha As String
        Public Property Proceso As String
    End Class

    Public Class invoiceLog_INT
        Public Property Status As status
        Public Property invoiceLog As Log()
    End Class

    'general result
    Public Class general
        Public Property generalResult As generic_INT
    End Class

    'invoice result
    Public Class invoice
        Public Property invoiceResult As generic_INT
    End Class

    'invoice
    Public Class invoiceStatus
        Public Property invoiceResult As getStatus_INT
    End Class

    Public Class verifyStatus
        Public Property invoiceResult As verifyStatus_INT
    End Class

    Public Class invoiceLog
        Public Property invoiceResult As invoiceLog_INT
    End Class

    '*********************************************
    'Esta funcion envia la informacion via APIRest
    'hace la tarea completa incluyendo verificacion de headers y metodos
    '*********************************************

    Public Function enviarInfo(URL As String, USR As String, PWD As String, METHOD As String, CADENA As String) As String
        Dim response As String
        Dim request As WebRequest
        Dim JSON As Byte() = Encoding.UTF8.GetBytes(CADENA)
        URL = URL + "/index.php"
        If (METHOD = "GET") Then METHOD = "POST"


        Try
            request = WebRequest.Create(URL)
            request.ContentLength = JSON.Length
            request.ContentType = "application/json"
            request.Method = METHOD
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(USR + ":" + PWD)))

            Using requestStream = request.GetRequestStream
                requestStream.Write(JSON, 0, JSON.Length)
                requestStream.Close()

                Using responseStream = request.GetResponse.GetResponseStream
                    Using reader As New StreamReader(responseStream)
                        response = reader.ReadToEnd()
                    End Using
                End Using
            End Using
        Catch ex As WebException
            response = "ERROR: " + ex.Message
        End Try
        Return response
    End Function

End Module

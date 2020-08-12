Imports System.Web.Script.Serialization

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        raw.Text = "" : code.Text = "" : texto.Text = "" : info.Text = ""

        Dim jss As New JavaScriptSerializer()
        Dim llega = LF.enviarInfo(url.Text, usr.Text, pwd.Text, method.Text, json.Text)
        Dim status As LF.status

        raw.Text = llega
        If (llega.Substring(0, 5) = "ERROR") Then Return 'Es un error general de conexion

        'Selecciona la estructura basica para obtener el estado de error
        If test.Text = "getRanges" Then
            Dim res As LF.general = jss.Deserialize(Of LF.general)(llega)
            status = res.generalResult.Status
        Else
            Dim res As LF.invoice = jss.Deserialize(Of LF.invoice)(llega)
            status = res.invoiceResult.Status
        End If

        code.Text = status.Code
        texto.Text = status.Text
        If (status.Code <> 200) Then Return 'Cierra si la respuesta no es la esperada

        Select Case test.Text
            Case "getRanges"
                Dim r As LF.getRanges = jss.Deserialize(Of LF.getRanges)(llega)
                info.Text = "Codigo Estado: " & status.Code & vbCrLf
                info.Text += "Texto Estado: " & status.Text & vbCrLf
                info.Text += "Elementos: " & r.generalResult.Ranges.Count & vbCrLf

                Dim Ranges = r.generalResult.Ranges
                For x As Integer = 0 To Ranges.Count - 1
                    Dim rx = Ranges(x)
                    info.Text += vbCrLf & "-Elemento " & x + 1 & vbCrLf
                    info.Text += "-- RangeKey : " & rx.RangeKey & vbCrLf
                    info.Text += "-- Prefix   : " & rx.Prefix & vbCrLf
                    info.Text += "-- From     : " & rx.FromNumber & vbCrLf
                    info.Text += "-- To       : " & rx.ToNumber & vbCrLf
                    info.Text += "-- Last     : " & rx.Last & vbCrLf
                    info.Text += "-- Type     : " & rx.Type & vbCrLf
                Next
            Case "verifyStatus"
                Dim r As LF.verifyStatus = jss.Deserialize(Of LF.verifyStatus)(llega)
                info.Text = "Codigo Estado: " & status.Code & vbCrLf
                info.Text += "Texto Estado: " & status.Text & vbCrLf
                info.Text += vbCrLf & "-Document " & vbCrLf
                info.Text += "-- type    : " & r.invoiceResult.Document.Type & vbCrLf
                info.Text += "-- mode    : " & r.invoiceResult.Document.Mode & vbCrLf
                info.Text += "-- tascode : " & r.invoiceResult.Document.Tascode & vbCrLf
                info.Text += "-- cufe    : " & r.invoiceResult.Document.Cufe & vbCrLf
                info.Text += "-- cude    : " & r.invoiceResult.Document.Cude & vbCrLf
                info.Text += "-- url     : " & r.invoiceResult.Document.Url & vbCrLf
                info.Text += "-- check   : " & r.invoiceResult.Document.Check & vbCrLf
                info.Text += "-- process : " & r.invoiceResult.Document.Process & vbCrLf
            Case "invoice"
                Dim r As LF.invoiceStatus = jss.Deserialize(Of LF.invoiceStatus)(llega)
                info.Text = "Codigo Estado: " & status.Code & vbCrLf
                info.Text += "Texto Estado: " & status.Text & vbCrLf
                info.Text += vbCrLf & "-Document " & vbCrLf
                info.Text += "-- type    : " & r.invoiceResult.Documento.Type & vbCrLf
                info.Text += "-- mode    : " & r.invoiceResult.Documento.Mode & vbCrLf
                info.Text += "-- tascode : " & r.invoiceResult.Documento.Tascode & vbCrLf
                info.Text += "-- cufe    : " & r.invoiceResult.Documento.Cufe & vbCrLf
                info.Text += "-- cude    : " & r.invoiceResult.Documento.Cude & vbCrLf
                info.Text += "-- url     : " & r.invoiceResult.Documento.Url & vbCrLf
                info.Text += "-- check   : " & r.invoiceResult.Documento.Check & vbCrLf
                info.Text += "-- process : " & r.invoiceResult.Documento.Process & vbCrLf
            Case "getLog"
                Dim r As LF.invoiceLog = jss.Deserialize(Of LF.invoiceLog)(llega)
                info.Text = "Codigo Estado: " & status.Code & vbCrLf
                info.Text += "Texto Estado: " & status.Text & vbCrLf
                info.Text += "Elementos: " & r.invoiceResult.invoiceLog.Count & vbCrLf
                Dim Logs = r.invoiceResult.invoiceLog
                For x As Integer = 0 To Logs.Count - 1
                    Dim lg = Logs(x)
                    info.Text += vbCrLf & "-Log " & x + 1 & vbCrLf
                    info.Text += "-- fecha     : " & lg.Fecha & vbCrLf
                    info.Text += "-- proceso   : " & lg.Proceso & vbCrLf

                Next
        End Select
    End Sub

    Private Sub test_SelectedIndexChanged(sender As Object, e As EventArgs) Handles test.SelectedIndexChanged
        json.Text = "" : raw.Text = "" : code.Text = "" : texto.Text = "" : info.Text = ""

        Select Case test.Text
            Case "getRanges"
                json.Text = "{" & vbCrLf & "    ""getRanges"":{" & vbCrLf & "          ""mode"":""active""," & vbCrLf & "          ""type"":""all""" & vbCrLf & "    }" & vbCrLf & " }"
                method.Text = "GET"
                url.Text = "https://playground.lafactura.co/api2.0/general"
            Case "verifyStatus"
                json.Text = "{" & vbCrLf & "    ""verifyStatus"":{" & vbCrLf & "          ""tascode"":""CODIGO""" & vbCrLf & "    }" & vbCrLf & " }"
                method.Text = "GET"
                url.Text = "https://playground.lafactura.co/api2.0/invoice"
            Case "getLog"
                json.Text = "{" & vbCrLf & "    ""getLog"":{" & vbCrLf & "          ""tascode"":""CODIGO""" & vbCrLf & "    }" & vbCrLf & " }"
                method.Text = "GET"
                url.Text = "https://playground.lafactura.co/api2.0/invoice"
            Case "invoice"
                json.Text = "{
	                ""invoice"": {
		                    ""rangeKey"": ""219832728"",
		                    ""issueDate"": ""20200812"",
		                    ""issueTime"": ""100521"",
		                    ""dueDate"": ""20200912"",
		                    ""paymentType"": ""2"",
		                    ""paymentCode"": ""1"",
		                    ""note1"": ""CIENTO TREINTA Y CUATRO MIL DOSCIENTOS CUARENTA PESOS"",
		                    ""note2"": ""Esta es una nota en la factura"",
		                    ""customer"": {
			                        ""additionalAccountID"": ""1"",
			                        ""name"": ""Pepito Perez y Compania S.A."",
			                        ""countryName"": ""Colombia"",
			                        ""countryCode"": ""CO"",
			                        ""city"": ""Bogotá D.C."",
			                        ""countryEntity"": ""11"",
			                        ""countrySubentity"": ""11001"",
			                        ""addressLine"": ""Av 25 No. 8-47"",
			                        ""documentNumber"": ""900900651"",
			                        ""documentType"": ""31"",
			                        ""telephone"": ""3112196952"",
			                        ""email"": ""este@ejemplo.com""
		                    },
		                    ""amounts"": {
			                        ""totalAmount"": ""120000.00"",
			                        ""discountAmount"": ""4000.00"",
			                        ""extraAmount"": ""0.00"",
			                        ""taxAmount"": ""18240.00"",
			                        ""payAmount"": ""134240.00""
		                    },
		                    ""items"": [{
				                    ""quantity"": ""5.00"",
				                    ""unitPrice"": ""20000.00"",
				                    ""total"": ""96000.00"",
				                    ""description"": ""Horas de soporte remoto"",
				                    ""brand"": ""LF"",
				                    ""model"": ""Soporte"",
				                    ""standard"": ""999"",
				                    ""agency"": ""990"",
				                    ""code"": ""1000"",
				                    ""allowance"": [{
					                    ""charge"": ""false"",
					                    ""reasonCode"": ""11"",
					                    ""description"": ""Es un super descuento por hoy"",
					                    ""baseAmount"": ""100000.00"",
					                    ""amount"": ""4000.00"",
					                    ""percent"": ""4.00""
				                    }],
				                    ""taxes"": [{
					                    ""ID"": ""01"",
					                    ""taxAmount"": ""18240.00"",
					                    ""percent"": ""19.00""
				                    }]
			                    },
			                    {
				                    ""quantity"": ""1.00"",
				                    ""unitPrice"": ""20000.00"",
				                    ""total"": ""20000.00"",
				                    ""description"": ""Servicio sin IVA"",
				                    ""brand"": ""LF"",
				                    ""model"": ""Serv1"",
				                    ""standard"": ""999"",
				                    ""agency"": ""990"",
				                    ""code"": ""1001""
			                    }
		                    ]
	                }
                }"
                method.Text = "POST"
                url.Text = "https://playground.lafactura.co/api2.0/invoice"
        End Select
    End Sub
End Class

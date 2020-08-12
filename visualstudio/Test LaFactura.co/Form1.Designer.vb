<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.method = New System.Windows.Forms.ComboBox()
        Me.url = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.usr = New System.Windows.Forms.TextBox()
        Me.json = New System.Windows.Forms.TextBox()
        Me.test = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.TextBox()
        Me.texto = New System.Windows.Forms.TextBox()
        Me.code = New System.Windows.Forms.TextBox()
        Me.raw = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.method)
        Me.GroupBox1.Controls.Add(Me.url)
        Me.GroupBox1.Controls.Add(Me.pwd)
        Me.GroupBox1.Controls.Add(Me.usr)
        Me.GroupBox1.Controls.Add(Me.json)
        Me.GroupBox1.Controls.Add(Me.test)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 508)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "METHOD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 419)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "URL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PWD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "USR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "JSON"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "TEST"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(439, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'method
        '
        Me.method.FormattingEnabled = True
        Me.method.Items.AddRange(New Object() {"GET", "POST", "DETELETE"})
        Me.method.Location = New System.Drawing.Point(68, 439)
        Me.method.Name = "method"
        Me.method.Size = New System.Drawing.Size(478, 21)
        Me.method.TabIndex = 5
        '
        'url
        '
        Me.url.Location = New System.Drawing.Point(66, 412)
        Me.url.Name = "url"
        Me.url.Size = New System.Drawing.Size(480, 20)
        Me.url.TabIndex = 4
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(65, 384)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(482, 20)
        Me.pwd.TabIndex = 3
        '
        'usr
        '
        Me.usr.Location = New System.Drawing.Point(65, 356)
        Me.usr.Name = "usr"
        Me.usr.Size = New System.Drawing.Size(482, 20)
        Me.usr.TabIndex = 2
        '
        'json
        '
        Me.json.Location = New System.Drawing.Point(66, 50)
        Me.json.Multiline = True
        Me.json.Name = "json"
        Me.json.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.json.Size = New System.Drawing.Size(481, 300)
        Me.json.TabIndex = 1
        Me.json.WordWrap = False
        '
        'test
        '
        Me.test.FormattingEnabled = True
        Me.test.Items.AddRange(New Object() {"getRanges", "verifyStatus", "getLog", "invoice"})
        Me.test.Location = New System.Drawing.Point(65, 24)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(483, 21)
        Me.test.TabIndex = 0
        Me.test.Text = "getRanges"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.info)
        Me.GroupBox2.Controls.Add(Me.texto)
        Me.GroupBox2.Controls.Add(Me.code)
        Me.GroupBox2.Controls.Add(Me.raw)
        Me.GroupBox2.Location = New System.Drawing.Point(597, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(627, 510)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Salida"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "INFO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "TEXT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "CODE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "RAW"
        '
        'info
        '
        Me.info.Location = New System.Drawing.Point(74, 257)
        Me.info.Multiline = True
        Me.info.Name = "info"
        Me.info.ReadOnly = True
        Me.info.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.info.Size = New System.Drawing.Size(536, 239)
        Me.info.TabIndex = 3
        Me.info.WordWrap = False
        '
        'texto
        '
        Me.texto.Location = New System.Drawing.Point(71, 224)
        Me.texto.Name = "texto"
        Me.texto.ReadOnly = True
        Me.texto.Size = New System.Drawing.Size(540, 20)
        Me.texto.TabIndex = 2
        '
        'code
        '
        Me.code.Location = New System.Drawing.Point(72, 196)
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        Me.code.Size = New System.Drawing.Size(539, 20)
        Me.code.TabIndex = 1
        '
        'raw
        '
        Me.raw.Location = New System.Drawing.Point(71, 24)
        Me.raw.Multiline = True
        Me.raw.Name = "raw"
        Me.raw.ReadOnly = True
        Me.raw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.raw.Size = New System.Drawing.Size(541, 163)
        Me.raw.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 523)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Maquina de pruebas LaFactura.co"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents method As ComboBox
    Friend WithEvents url As TextBox
    Friend WithEvents pwd As TextBox
    Friend WithEvents usr As TextBox
    Friend WithEvents json As TextBox
    Friend WithEvents test As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents info As TextBox
    Friend WithEvents texto As TextBox
    Friend WithEvents code As TextBox
    Friend WithEvents raw As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        BtnGuardar = New Button()
        TxtDireccion = New TextBox()
        TxtCorreo = New TextBox()
        TxtTelefono = New TextBox()
        TxtApellidos = New TextBox()
        TxtNombres = New TextBox()
        CBoxPais = New ComboBox()
        CBoxCiudad = New ComboBox()
        CBoxEdad = New ComboBox()
        LbPais = New Label()
        LbCiudad = New Label()
        LbDireccion = New Label()
        LbCorreo = New Label()
        LbTelefono = New Label()
        LbEdad = New Label()
        LbApelldios = New Label()
        LbNombres = New Label()
        RTBInformacion = New RichTextBox()
        BtnSalir = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(BtnGuardar)
        GroupBox1.Controls.Add(TxtDireccion)
        GroupBox1.Controls.Add(TxtCorreo)
        GroupBox1.Controls.Add(TxtTelefono)
        GroupBox1.Controls.Add(TxtApellidos)
        GroupBox1.Controls.Add(TxtNombres)
        GroupBox1.Controls.Add(CBoxPais)
        GroupBox1.Controls.Add(CBoxCiudad)
        GroupBox1.Controls.Add(CBoxEdad)
        GroupBox1.Controls.Add(LbPais)
        GroupBox1.Controls.Add(LbCiudad)
        GroupBox1.Controls.Add(LbDireccion)
        GroupBox1.Controls.Add(LbCorreo)
        GroupBox1.Controls.Add(LbTelefono)
        GroupBox1.Controls.Add(LbEdad)
        GroupBox1.Controls.Add(LbApelldios)
        GroupBox1.Controls.Add(LbNombres)
        GroupBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(512, 478)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Registre sus datos personales"
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.BackColor = SystemColors.MenuHighlight
        BtnGuardar.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnGuardar.ForeColor = Color.Black
        BtnGuardar.Location = New Point(162, 427)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(198, 35)
        BtnGuardar.TabIndex = 16
        BtnGuardar.Text = "Guardar Informacion"
        BtnGuardar.UseVisualStyleBackColor = False
        ' 
        ' TxtDireccion
        ' 
        TxtDireccion.BackColor = SystemColors.MenuHighlight
        TxtDireccion.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TxtDireccion.Location = New Point(162, 278)
        TxtDireccion.Name = "TxtDireccion"
        TxtDireccion.Size = New Size(198, 30)
        TxtDireccion.TabIndex = 15
        ' 
        ' TxtCorreo
        ' 
        TxtCorreo.BackColor = SystemColors.MenuHighlight
        TxtCorreo.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TxtCorreo.Location = New Point(162, 234)
        TxtCorreo.Name = "TxtCorreo"
        TxtCorreo.Size = New Size(198, 30)
        TxtCorreo.TabIndex = 14
        ' 
        ' TxtTelefono
        ' 
        TxtTelefono.BackColor = SystemColors.MenuHighlight
        TxtTelefono.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TxtTelefono.Location = New Point(162, 192)
        TxtTelefono.Name = "TxtTelefono"
        TxtTelefono.Size = New Size(198, 30)
        TxtTelefono.TabIndex = 13
        ' 
        ' TxtApellidos
        ' 
        TxtApellidos.BackColor = SystemColors.MenuHighlight
        TxtApellidos.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TxtApellidos.Location = New Point(162, 103)
        TxtApellidos.Name = "TxtApellidos"
        TxtApellidos.Size = New Size(198, 30)
        TxtApellidos.TabIndex = 12
        ' 
        ' TxtNombres
        ' 
        TxtNombres.BackColor = SystemColors.MenuHighlight
        TxtNombres.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        TxtNombres.Location = New Point(162, 59)
        TxtNombres.Name = "TxtNombres"
        TxtNombres.Size = New Size(198, 30)
        TxtNombres.TabIndex = 11
        ' 
        ' CBoxPais
        ' 
        CBoxPais.BackColor = SystemColors.MenuHighlight
        CBoxPais.FormattingEnabled = True
        CBoxPais.Items.AddRange(New Object() {"Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania (Myanmar)", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Eswatini", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guinea", "Guinea Ecuatorial", "Guinea-Bisáu", "Guyana", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos"})
        CBoxPais.Location = New Point(162, 380)
        CBoxPais.Name = "CBoxPais"
        CBoxPais.Size = New Size(198, 31)
        CBoxPais.TabIndex = 10
        ' 
        ' CBoxCiudad
        ' 
        CBoxCiudad.BackColor = SystemColors.MenuHighlight
        CBoxCiudad.FormattingEnabled = True
        CBoxCiudad.Items.AddRange(New Object() {"Bogotá (Distrito Capital)", "Medellín", "Cali", "Barranquilla", "Cartagena", "Bucaramanga", "Pereira", "Manizales", "Cúcuta", "Santa Marta", "Villavicencio", "Pasto", "Ibagué", "Valledupar", "Neiva", "Popayán", "Montería", "Sincelejo", "Tunja", "Armenia"})
        CBoxCiudad.Location = New Point(162, 329)
        CBoxCiudad.Name = "CBoxCiudad"
        CBoxCiudad.Size = New Size(198, 31)
        CBoxCiudad.TabIndex = 9
        ' 
        ' CBoxEdad
        ' 
        CBoxEdad.BackColor = SystemColors.MenuHighlight
        CBoxEdad.FormattingEnabled = True
        CBoxEdad.Location = New Point(162, 150)
        CBoxEdad.Name = "CBoxEdad"
        CBoxEdad.Size = New Size(198, 31)
        CBoxEdad.TabIndex = 8
        ' 
        ' LbPais
        ' 
        LbPais.AutoSize = True
        LbPais.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbPais.ForeColor = Color.Black
        LbPais.Location = New Point(6, 378)
        LbPais.Name = "LbPais"
        LbPais.Size = New Size(52, 28)
        LbPais.TabIndex = 7
        LbPais.Text = "Pais"
        ' 
        ' LbCiudad
        ' 
        LbCiudad.AutoSize = True
        LbCiudad.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbCiudad.ForeColor = Color.Black
        LbCiudad.Location = New Point(6, 327)
        LbCiudad.Name = "LbCiudad"
        LbCiudad.Size = New Size(81, 28)
        LbCiudad.TabIndex = 6
        LbCiudad.Text = "Ciudad"
        ' 
        ' LbDireccion
        ' 
        LbDireccion.AutoSize = True
        LbDireccion.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbDireccion.ForeColor = Color.Black
        LbDireccion.Location = New Point(6, 276)
        LbDireccion.Name = "LbDireccion"
        LbDireccion.Size = New Size(105, 28)
        LbDireccion.TabIndex = 5
        LbDireccion.Text = "Direccion"
        ' 
        ' LbCorreo
        ' 
        LbCorreo.AutoSize = True
        LbCorreo.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbCorreo.ForeColor = Color.Black
        LbCorreo.Location = New Point(6, 232)
        LbCorreo.Name = "LbCorreo"
        LbCorreo.Size = New Size(80, 28)
        LbCorreo.TabIndex = 4
        LbCorreo.Text = "Correo"
        ' 
        ' LbTelefono
        ' 
        LbTelefono.AutoSize = True
        LbTelefono.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbTelefono.ForeColor = Color.Black
        LbTelefono.Location = New Point(6, 190)
        LbTelefono.Name = "LbTelefono"
        LbTelefono.Size = New Size(101, 28)
        LbTelefono.TabIndex = 3
        LbTelefono.Text = "Telefono"
        ' 
        ' LbEdad
        ' 
        LbEdad.AutoSize = True
        LbEdad.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbEdad.ForeColor = Color.Black
        LbEdad.Location = New Point(6, 148)
        LbEdad.Name = "LbEdad"
        LbEdad.Size = New Size(60, 28)
        LbEdad.TabIndex = 2
        LbEdad.Text = "Edad"
        ' 
        ' LbApelldios
        ' 
        LbApelldios.AutoSize = True
        LbApelldios.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbApelldios.ForeColor = Color.Black
        LbApelldios.Location = New Point(6, 101)
        LbApelldios.Name = "LbApelldios"
        LbApelldios.Size = New Size(105, 28)
        LbApelldios.TabIndex = 1
        LbApelldios.Text = "Apellidos"
        ' 
        ' LbNombres
        ' 
        LbNombres.AutoSize = True
        LbNombres.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LbNombres.ForeColor = Color.Black
        LbNombres.Location = New Point(6, 57)
        LbNombres.Name = "LbNombres"
        LbNombres.Size = New Size(103, 28)
        LbNombres.TabIndex = 0
        LbNombres.Text = "Nombres"
        ' 
        ' RTBInformacion
        ' 
        RTBInformacion.BackColor = SystemColors.MenuHighlight
        RTBInformacion.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        RTBInformacion.Location = New Point(12, 496)
        RTBInformacion.Name = "RTBInformacion"
        RTBInformacion.Size = New Size(512, 219)
        RTBInformacion.TabIndex = 1
        RTBInformacion.Text = ""
        ' 
        ' BtnSalir
        ' 
        BtnSalir.BackColor = SystemColors.MenuHighlight
        BtnSalir.Font = New Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSalir.ForeColor = Color.Black
        BtnSalir.Location = New Point(12, 721)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(198, 35)
        BtnSalir.TabIndex = 17
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(537, 768)
        Controls.Add(BtnSalir)
        Controls.Add(RTBInformacion)
        Controls.Add(GroupBox1)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Formulario De Registro"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LbNombres As Label
    Friend WithEvents LbEdad As Label
    Friend WithEvents LbApelldios As Label
    Friend WithEvents LbDireccion As Label
    Friend WithEvents LbCorreo As Label
    Friend WithEvents LbTelefono As Label
    Friend WithEvents CBoxEdad As ComboBox
    Friend WithEvents LbPais As Label
    Friend WithEvents LbCiudad As Label
    Friend WithEvents CBoxPais As ComboBox
    Friend WithEvents CBoxCiudad As ComboBox
    Friend WithEvents RTBInformacion As RichTextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents BtnSalir As Button
End Class

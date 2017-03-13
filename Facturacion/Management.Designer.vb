<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxUserphone = New System.Windows.Forms.TextBox()
        Me.LabelUserphone = New System.Windows.Forms.Label()
        Me.TextBoxUsermail = New System.Windows.Forms.TextBox()
        Me.LabelUsermail = New System.Windows.Forms.Label()
        Me.TextBoxUsercode = New System.Windows.Forms.TextBox()
        Me.LabelUserCode = New System.Windows.Forms.Label()
        Me.ButtonSaveuser = New System.Windows.Forms.Button()
        Me.Labelbarcodename = New System.Windows.Forms.Label()
        Me.ButtongenerateBarcode = New System.Windows.Forms.Button()
        Me.ButtonCleanUser = New System.Windows.Forms.Button()
        Me.LabelGenerateReceipt = New System.Windows.Forms.Label()
        Me.LabelbyCodeBar = New System.Windows.Forms.Label()
        Me.TextBoxByCodeBar = New System.Windows.Forms.TextBox()
        Me.LabelByUserName = New System.Windows.Forms.Label()
        Me.ButtonGenerateReceipt = New System.Windows.Forms.Button()
        Me.pic_Codebar = New System.Windows.Forms.PictureBox()
        Me.photo_button = New System.Windows.Forms.Button()
        Me.pic_button = New System.Windows.Forms.Button()
        Me.Userimage = New System.Windows.Forms.PictureBox()
        Me.CodeSearch = New System.Windows.Forms.TextBox()
        Me.labelps1 = New System.Windows.Forms.Label()
        Me.labelps2 = New System.Windows.Forms.Label()
        Me.textpas1 = New System.Windows.Forms.TextBox()
        Me.textpas2 = New System.Windows.Forms.TextBox()
        Me.btnps = New System.Windows.Forms.Button()
        Me.textdatabar = New System.Windows.Forms.TextBox()
        Me.Labelvalor = New System.Windows.Forms.Label()
        Me.TextValor = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pic_Codebar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Userimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 665)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(848, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.UsuariosToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(71, 24)
        Me.ToolStripMenuItem1.Text = "Archivo"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.CambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.VerClientesToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'VerClientesToolStripMenuItem
        '
        Me.VerClientesToolStripMenuItem.Name = "VerClientesToolStripMenuItem"
        Me.VerClientesToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.VerClientesToolStripMenuItem.Text = "Ver Clientes"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarFacturaToolStripMenuItem, Me.VerFacturasToolStripMenuItem})
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'GenerarFacturaToolStripMenuItem
        '
        Me.GenerarFacturaToolStripMenuItem.Name = "GenerarFacturaToolStripMenuItem"
        Me.GenerarFacturaToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.GenerarFacturaToolStripMenuItem.Text = "Generar Factura"
        '
        'VerFacturasToolStripMenuItem
        '
        Me.VerFacturasToolStripMenuItem.Name = "VerFacturasToolStripMenuItem"
        Me.VerFacturasToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.VerFacturasToolStripMenuItem.Text = "Ver Facturas"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(73, 95)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(79, 27)
        Me.LabelUsername.TabIndex = 2
        Me.LabelUsername.Text = "Nombre"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(231, 95)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxUsername.TabIndex = 3
        '
        'TextBoxUserphone
        '
        Me.TextBoxUserphone.Location = New System.Drawing.Point(231, 150)
        Me.TextBoxUserphone.Name = "TextBoxUserphone"
        Me.TextBoxUserphone.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxUserphone.TabIndex = 5
        '
        'LabelUserphone
        '
        Me.LabelUserphone.AutoSize = True
        Me.LabelUserphone.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserphone.Location = New System.Drawing.Point(73, 150)
        Me.LabelUserphone.Name = "LabelUserphone"
        Me.LabelUserphone.Size = New System.Drawing.Size(82, 27)
        Me.LabelUserphone.TabIndex = 4
        Me.LabelUserphone.Text = "Telefono"
        '
        'TextBoxUsermail
        '
        Me.TextBoxUsermail.Location = New System.Drawing.Point(231, 208)
        Me.TextBoxUsermail.Name = "TextBoxUsermail"
        Me.TextBoxUsermail.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxUsermail.TabIndex = 7
        '
        'LabelUsermail
        '
        Me.LabelUsermail.AutoSize = True
        Me.LabelUsermail.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsermail.Location = New System.Drawing.Point(73, 208)
        Me.LabelUsermail.Name = "LabelUsermail"
        Me.LabelUsermail.Size = New System.Drawing.Size(68, 27)
        Me.LabelUsermail.TabIndex = 6
        Me.LabelUsermail.Text = "Correo"
        '
        'TextBoxUsercode
        '
        Me.TextBoxUsercode.Location = New System.Drawing.Point(231, 266)
        Me.TextBoxUsercode.Name = "TextBoxUsercode"
        Me.TextBoxUsercode.Size = New System.Drawing.Size(164, 22)
        Me.TextBoxUsercode.TabIndex = 9
        '
        'LabelUserCode
        '
        Me.LabelUserCode.AutoSize = True
        Me.LabelUserCode.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserCode.Location = New System.Drawing.Point(73, 266)
        Me.LabelUserCode.Name = "LabelUserCode"
        Me.LabelUserCode.Size = New System.Drawing.Size(70, 27)
        Me.LabelUserCode.TabIndex = 8
        Me.LabelUserCode.Text = "Cedula"
        '
        'ButtonSaveuser
        '
        Me.ButtonSaveuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveuser.Location = New System.Drawing.Point(593, 428)
        Me.ButtonSaveuser.Name = "ButtonSaveuser"
        Me.ButtonSaveuser.Size = New System.Drawing.Size(214, 58)
        Me.ButtonSaveuser.TabIndex = 11
        Me.ButtonSaveuser.Text = "Guardar"
        Me.ButtonSaveuser.UseVisualStyleBackColor = True
        '
        'Labelbarcodename
        '
        Me.Labelbarcodename.AutoSize = True
        Me.Labelbarcodename.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelbarcodename.Location = New System.Drawing.Point(52, 370)
        Me.Labelbarcodename.Name = "Labelbarcodename"
        Me.Labelbarcodename.Size = New System.Drawing.Size(283, 38)
        Me.Labelbarcodename.TabIndex = 15
        Me.Labelbarcodename.Text = "Codigo de barras"
        '
        'ButtongenerateBarcode
        '
        Me.ButtongenerateBarcode.Location = New System.Drawing.Point(59, 576)
        Me.ButtongenerateBarcode.Name = "ButtongenerateBarcode"
        Me.ButtongenerateBarcode.Size = New System.Drawing.Size(144, 27)
        Me.ButtongenerateBarcode.TabIndex = 17
        Me.ButtongenerateBarcode.Text = "Generar"
        Me.ButtongenerateBarcode.UseVisualStyleBackColor = True
        '
        'ButtonCleanUser
        '
        Me.ButtonCleanUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCleanUser.Location = New System.Drawing.Point(593, 521)
        Me.ButtonCleanUser.Name = "ButtonCleanUser"
        Me.ButtonCleanUser.Size = New System.Drawing.Size(214, 58)
        Me.ButtonCleanUser.TabIndex = 18
        Me.ButtonCleanUser.Text = "Limpiar"
        Me.ButtonCleanUser.UseVisualStyleBackColor = True
        '
        'LabelGenerateReceipt
        '
        Me.LabelGenerateReceipt.AutoSize = True
        Me.LabelGenerateReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGenerateReceipt.Location = New System.Drawing.Point(71, 84)
        Me.LabelGenerateReceipt.Name = "LabelGenerateReceipt"
        Me.LabelGenerateReceipt.Size = New System.Drawing.Size(272, 38)
        Me.LabelGenerateReceipt.TabIndex = 19
        Me.LabelGenerateReceipt.Text = "Generar Factura"
        '
        'LabelbyCodeBar
        '
        Me.LabelbyCodeBar.AutoSize = True
        Me.LabelbyCodeBar.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelbyCodeBar.Location = New System.Drawing.Point(73, 150)
        Me.LabelbyCodeBar.Name = "LabelbyCodeBar"
        Me.LabelbyCodeBar.Size = New System.Drawing.Size(181, 27)
        Me.LabelbyCodeBar.TabIndex = 20
        Me.LabelbyCodeBar.Text = "Por Codigo de barras"
        '
        'TextBoxByCodeBar
        '
        Me.TextBoxByCodeBar.Location = New System.Drawing.Point(307, 154)
        Me.TextBoxByCodeBar.Name = "TextBoxByCodeBar"
        Me.TextBoxByCodeBar.Size = New System.Drawing.Size(225, 22)
        Me.TextBoxByCodeBar.TabIndex = 21
        '
        'LabelByUserName
        '
        Me.LabelByUserName.AutoSize = True
        Me.LabelByUserName.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelByUserName.Location = New System.Drawing.Point(73, 208)
        Me.LabelByUserName.Name = "LabelByUserName"
        Me.LabelByUserName.Size = New System.Drawing.Size(194, 27)
        Me.LabelByUserName.TabIndex = 22
        Me.LabelByUserName.Text = "Por Numero de cedula"
        '
        'ButtonGenerateReceipt
        '
        Me.ButtonGenerateReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerateReceipt.Location = New System.Drawing.Point(60, 309)
        Me.ButtonGenerateReceipt.Name = "ButtonGenerateReceipt"
        Me.ButtonGenerateReceipt.Size = New System.Drawing.Size(214, 58)
        Me.ButtonGenerateReceipt.TabIndex = 24
        Me.ButtonGenerateReceipt.Text = "Generar"
        Me.ButtonGenerateReceipt.UseVisualStyleBackColor = True
        '
        'pic_Codebar
        '
        Me.pic_Codebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pic_Codebar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Codebar.Location = New System.Drawing.Point(59, 428)
        Me.pic_Codebar.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_Codebar.Name = "pic_Codebar"
        Me.pic_Codebar.Size = New System.Drawing.Size(495, 118)
        Me.pic_Codebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Codebar.TabIndex = 16
        Me.pic_Codebar.TabStop = False
        Me.pic_Codebar.UseWaitCursor = True
        '
        'photo_button
        '
        Me.photo_button.BackgroundImage = Global.Facturacion.My.Resources.Resources.picture
        Me.photo_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.photo_button.Location = New System.Drawing.Point(613, 317)
        Me.photo_button.Name = "photo_button"
        Me.photo_button.Size = New System.Drawing.Size(48, 37)
        Me.photo_button.TabIndex = 14
        Me.photo_button.UseVisualStyleBackColor = True
        '
        'pic_button
        '
        Me.pic_button.BackgroundImage = Global.Facturacion.My.Resources.Resources.images
        Me.pic_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_button.Location = New System.Drawing.Point(538, 317)
        Me.pic_button.Name = "pic_button"
        Me.pic_button.Size = New System.Drawing.Size(50, 37)
        Me.pic_button.TabIndex = 13
        Me.pic_button.UseVisualStyleBackColor = True
        '
        'Userimage
        '
        Me.Userimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Userimage.ErrorImage = Global.Facturacion.My.Resources.Resources.No_picture
        Me.Userimage.InitialImage = Global.Facturacion.My.Resources.Resources.No_picture
        Me.Userimage.Location = New System.Drawing.Point(538, 77)
        Me.Userimage.Name = "Userimage"
        Me.Userimage.Size = New System.Drawing.Size(239, 216)
        Me.Userimage.TabIndex = 10
        Me.Userimage.TabStop = False
        '
        'CodeSearch
        '
        Me.CodeSearch.Location = New System.Drawing.Point(307, 208)
        Me.CodeSearch.Name = "CodeSearch"
        Me.CodeSearch.Size = New System.Drawing.Size(225, 22)
        Me.CodeSearch.TabIndex = 25
        '
        'labelps1
        '
        Me.labelps1.AutoSize = True
        Me.labelps1.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelps1.Location = New System.Drawing.Point(73, 149)
        Me.labelps1.Name = "labelps1"
        Me.labelps1.Size = New System.Drawing.Size(173, 27)
        Me.labelps1.TabIndex = 26
        Me.labelps1.Text = "Contraseña anterior"
        '
        'labelps2
        '
        Me.labelps2.AutoSize = True
        Me.labelps2.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelps2.Location = New System.Drawing.Point(73, 203)
        Me.labelps2.Name = "labelps2"
        Me.labelps2.Size = New System.Drawing.Size(158, 27)
        Me.labelps2.TabIndex = 27
        Me.labelps2.Text = "Contraseña nueva"
        '
        'textpas1
        '
        Me.textpas1.Location = New System.Drawing.Point(307, 155)
        Me.textpas1.Name = "textpas1"
        Me.textpas1.Size = New System.Drawing.Size(225, 22)
        Me.textpas1.TabIndex = 28
        '
        'textpas2
        '
        Me.textpas2.Location = New System.Drawing.Point(307, 207)
        Me.textpas2.Name = "textpas2"
        Me.textpas2.Size = New System.Drawing.Size(225, 22)
        Me.textpas2.TabIndex = 29
        '
        'btnps
        '
        Me.btnps.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnps.Location = New System.Drawing.Point(59, 309)
        Me.btnps.Name = "btnps"
        Me.btnps.Size = New System.Drawing.Size(214, 58)
        Me.btnps.TabIndex = 30
        Me.btnps.Text = "Guardar"
        Me.btnps.UseVisualStyleBackColor = True
        '
        'textdatabar
        '
        Me.textdatabar.Location = New System.Drawing.Point(267, 581)
        Me.textdatabar.Name = "textdatabar"
        Me.textdatabar.Size = New System.Drawing.Size(128, 22)
        Me.textdatabar.TabIndex = 31
        '
        'Labelvalor
        '
        Me.Labelvalor.AutoSize = True
        Me.Labelvalor.Font = New System.Drawing.Font("Minion Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelvalor.Location = New System.Drawing.Point(73, 262)
        Me.Labelvalor.Name = "Labelvalor"
        Me.Labelvalor.Size = New System.Drawing.Size(55, 27)
        Me.Labelvalor.TabIndex = 32
        Me.Labelvalor.Text = "Valor"
        '
        'TextValor
        '
        Me.TextValor.Location = New System.Drawing.Point(307, 266)
        Me.TextValor.Name = "TextValor"
        Me.TextValor.Size = New System.Drawing.Size(225, 22)
        Me.TextValor.TabIndex = 33
        '
        'Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(848, 687)
        Me.Controls.Add(Me.TextValor)
        Me.Controls.Add(Me.Labelvalor)
        Me.Controls.Add(Me.textdatabar)
        Me.Controls.Add(Me.btnps)
        Me.Controls.Add(Me.textpas2)
        Me.Controls.Add(Me.textpas1)
        Me.Controls.Add(Me.labelps2)
        Me.Controls.Add(Me.labelps1)
        Me.Controls.Add(Me.CodeSearch)
        Me.Controls.Add(Me.ButtonGenerateReceipt)
        Me.Controls.Add(Me.LabelByUserName)
        Me.Controls.Add(Me.TextBoxByCodeBar)
        Me.Controls.Add(Me.LabelbyCodeBar)
        Me.Controls.Add(Me.LabelGenerateReceipt)
        Me.Controls.Add(Me.ButtonCleanUser)
        Me.Controls.Add(Me.ButtongenerateBarcode)
        Me.Controls.Add(Me.pic_Codebar)
        Me.Controls.Add(Me.Labelbarcodename)
        Me.Controls.Add(Me.photo_button)
        Me.Controls.Add(Me.pic_button)
        Me.Controls.Add(Me.ButtonSaveuser)
        Me.Controls.Add(Me.Userimage)
        Me.Controls.Add(Me.TextBoxUsercode)
        Me.Controls.Add(Me.LabelUserCode)
        Me.Controls.Add(Me.TextBoxUsermail)
        Me.Controls.Add(Me.LabelUsermail)
        Me.Controls.Add(Me.TextBoxUserphone)
        Me.Controls.Add(Me.LabelUserphone)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Management"
        Me.Text = "Sistema Facturación"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pic_Codebar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Userimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents NuevoUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxUserphone As TextBox
    Friend WithEvents LabelUserphone As Label
    Friend WithEvents TextBoxUsermail As TextBox
    Friend WithEvents LabelUsermail As Label
    Friend WithEvents TextBoxUsercode As TextBox
    Friend WithEvents LabelUserCode As Label
    Friend WithEvents Userimage As PictureBox
    Friend WithEvents ButtonSaveuser As Button
    Friend WithEvents pic_button As Button
    Friend WithEvents photo_button As Button
    Friend WithEvents Labelbarcodename As Label
    Friend WithEvents pic_Codebar As PictureBox
    Friend WithEvents ButtongenerateBarcode As Button
    Friend WithEvents ButtonCleanUser As Button
    Friend WithEvents LabelGenerateReceipt As Label
    Friend WithEvents LabelbyCodeBar As Label
    Friend WithEvents TextBoxByCodeBar As TextBox
    Friend WithEvents LabelByUserName As Label
    Friend WithEvents ButtonGenerateReceipt As Button
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CodeSearch As TextBox
    Friend WithEvents VerFacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents labelps1 As Label
    Friend WithEvents labelps2 As Label
    Friend WithEvents textpas1 As TextBox
    Friend WithEvents textpas2 As TextBox
    Friend WithEvents btnps As Button
    Friend WithEvents CambiarContraseñaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents textdatabar As TextBox
    Friend WithEvents Labelvalor As Label
    Friend WithEvents TextValor As TextBox
End Class

Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teacher_Information_Add

    Inherits KryptonForm

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
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.backButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.addTeacherButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.addTeacherGenderComboBox = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.Gender = New System.Windows.Forms.Label()
        Me.addTeacherAddressTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addTeacherEmailTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addTeacherDoBDateTimePicker = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.addTeacherPhoneNumberTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addTeacherNameTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.addTeacherICNumberTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addTeacherIDTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.addTeacherGenderComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPalette1
        '
        Me.KryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.KryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None
        Me.KryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15
        Me.KryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.KryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.KryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, -1, -1, -1)
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(25, 12)
        Me.backButton.Name = "backButton"
        Me.backButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.Size = New System.Drawing.Size(158, 46)
        Me.backButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.backButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.backButton.StateCommon.Border.Rounding = 10
        Me.backButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(5)
        Me.backButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.backButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.backButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backButton.TabIndex = 96
        Me.backButton.Values.Text = "Back"
        '
        'addTeacherButton
        '
        Me.addTeacherButton.Location = New System.Drawing.Point(327, 480)
        Me.addTeacherButton.Name = "addTeacherButton"
        Me.addTeacherButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.Size = New System.Drawing.Size(390, 46)
        Me.addTeacherButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addTeacherButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.addTeacherButton.StateCommon.Border.Rounding = 10
        Me.addTeacherButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(5)
        Me.addTeacherButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.addTeacherButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTeacherButton.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addTeacherButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherButton.TabIndex = 95
        Me.addTeacherButton.Values.Text = "Add Teacher"
        '
        'addTeacherGenderComboBox
        '
        Me.addTeacherGenderComboBox.DropDownWidth = 390
        Me.addTeacherGenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.addTeacherGenderComboBox.Location = New System.Drawing.Point(514, 398)
        Me.addTeacherGenderComboBox.Name = "addTeacherGenderComboBox"
        Me.addTeacherGenderComboBox.Size = New System.Drawing.Size(390, 21)
        Me.addTeacherGenderComboBox.TabIndex = 114
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Gender.Location = New System.Drawing.Point(511, 373)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(53, 16)
        Me.Gender.TabIndex = 111
        Me.Gender.Text = "Gender"
        '
        'addTeacherAddressTextBox
        '
        Me.addTeacherAddressTextBox.Location = New System.Drawing.Point(514, 306)
        Me.addTeacherAddressTextBox.Name = "addTeacherAddressTextBox"
        Me.addTeacherAddressTextBox.Size = New System.Drawing.Size(390, 43)
        Me.addTeacherAddressTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherAddressTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addTeacherAddressTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.addTeacherAddressTextBox.StateCommon.Border.Rounding = 10
        Me.addTeacherAddressTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherAddressTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTeacherAddressTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.addTeacherAddressTextBox.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(519, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Address"
        '
        'addTeacherEmailTextBox
        '
        Me.addTeacherEmailTextBox.Location = New System.Drawing.Point(85, 298)
        Me.addTeacherEmailTextBox.Name = "addTeacherEmailTextBox"
        Me.addTeacherEmailTextBox.Size = New System.Drawing.Size(390, 43)
        Me.addTeacherEmailTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherEmailTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addTeacherEmailTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.addTeacherEmailTextBox.StateCommon.Border.Rounding = 10
        Me.addTeacherEmailTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherEmailTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTeacherEmailTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.addTeacherEmailTextBox.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(90, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Email"
        '
        'addTeacherDoBDateTimePicker
        '
        Me.addTeacherDoBDateTimePicker.CustomFormat = "mm/dd/yyyy"
        Me.addTeacherDoBDateTimePicker.Location = New System.Drawing.Point(85, 392)
        Me.addTeacherDoBDateTimePicker.Name = "addTeacherDoBDateTimePicker"
        Me.addTeacherDoBDateTimePicker.Palette = Me.KryptonPalette1
        Me.addTeacherDoBDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.addTeacherDoBDateTimePicker.Size = New System.Drawing.Size(390, 27)
        Me.addTeacherDoBDateTimePicker.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.addTeacherDoBDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherDoBDateTimePicker.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addTeacherDoBDateTimePicker.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.addTeacherDoBDateTimePicker.StateCommon.Border.Rounding = 10
        Me.addTeacherDoBDateTimePicker.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherDoBDateTimePicker.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.addTeacherDoBDateTimePicker.TabIndex = 106
        '
        'addTeacherPhoneNumberTextBox
        '
        Me.addTeacherPhoneNumberTextBox.Location = New System.Drawing.Point(514, 223)
        Me.addTeacherPhoneNumberTextBox.Name = "addTeacherPhoneNumberTextBox"
        Me.addTeacherPhoneNumberTextBox.Size = New System.Drawing.Size(390, 43)
        Me.addTeacherPhoneNumberTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherPhoneNumberTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addTeacherPhoneNumberTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.addTeacherPhoneNumberTextBox.StateCommon.Border.Rounding = 10
        Me.addTeacherPhoneNumberTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherPhoneNumberTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTeacherPhoneNumberTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.addTeacherPhoneNumberTextBox.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(519, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(90, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Date of Birth"
        '
        'addTeacherNameTextBox
        '
        Me.addTeacherNameTextBox.Location = New System.Drawing.Point(514, 158)
        Me.addTeacherNameTextBox.Name = "addTeacherNameTextBox"
        Me.addTeacherNameTextBox.Size = New System.Drawing.Size(390, 43)
        Me.addTeacherNameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherNameTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addTeacherNameTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.addTeacherNameTextBox.StateCommon.Border.Rounding = 10
        Me.addTeacherNameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherNameTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTeacherNameTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.addTeacherNameTextBox.TabIndex = 101
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(519, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Name"
        '
        'addTeacherICNumberTextBox
        '
        Me.addTeacherICNumberTextBox.Location = New System.Drawing.Point(85, 223)
        Me.addTeacherICNumberTextBox.Name = "addTeacherICNumberTextBox"
        Me.addTeacherICNumberTextBox.Size = New System.Drawing.Size(390, 43)
        Me.addTeacherICNumberTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherICNumberTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addTeacherICNumberTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.addTeacherICNumberTextBox.StateCommon.Border.Rounding = 10
        Me.addTeacherICNumberTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherICNumberTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTeacherICNumberTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.addTeacherICNumberTextBox.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(90, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "IC Number"
        '
        'addTeacherIDTextBox
        '
        Me.addTeacherIDTextBox.Location = New System.Drawing.Point(85, 158)
        Me.addTeacherIDTextBox.Name = "addTeacherIDTextBox"
        Me.addTeacherIDTextBox.Size = New System.Drawing.Size(390, 43)
        Me.addTeacherIDTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherIDTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addTeacherIDTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.addTeacherIDTextBox.StateCommon.Border.Rounding = 10
        Me.addTeacherIDTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.addTeacherIDTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTeacherIDTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.addTeacherIDTextBox.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(90, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Teacher ID"
        '
        'Teacher_Information_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.addTeacherGenderComboBox)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.addTeacherAddressTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addTeacherEmailTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.addTeacherDoBDateTimePicker)
        Me.Controls.Add(Me.addTeacherPhoneNumberTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.addTeacherNameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.addTeacherICNumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.addTeacherIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.addTeacherButton)
        Me.Name = "Teacher_Information_Add"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Information Add"
        CType(Me.addTeacherGenderComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents backButton As KryptonButton
    Friend WithEvents addTeacherButton As KryptonButton
    Friend WithEvents addTeacherGenderComboBox As KryptonComboBox
    Friend WithEvents Gender As Label
    Friend WithEvents addTeacherAddressTextBox As KryptonTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents addTeacherEmailTextBox As KryptonTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents addTeacherDoBDateTimePicker As KryptonDateTimePicker
    Friend WithEvents addTeacherPhoneNumberTextBox As KryptonTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents addTeacherNameTextBox As KryptonTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents addTeacherICNumberTextBox As KryptonTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents addTeacherIDTextBox As KryptonTextBox
    Friend WithEvents Label1 As Label
End Class

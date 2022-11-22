Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teacher_Information_Update
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
        Me.UpdateTeacherButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.updateTeacherGenderComboBox = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.Gender = New System.Windows.Forms.Label()
        Me.updateTeacherAddressTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updateTeacherEmailTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.updateTeacherDoBDateTimePicker = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.updateTeacherPhoneNumberTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.updateTeacherNameTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.updateTeacherICNumberTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updateTeacherIDTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.updateTeacherGenderComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.backButton.Location = New System.Drawing.Point(48, 36)
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
        Me.backButton.TabIndex = 118
        Me.backButton.Values.Text = "Back"
        '
        'UpdateTeacherButton
        '
        Me.UpdateTeacherButton.Location = New System.Drawing.Point(328, 483)
        Me.UpdateTeacherButton.Name = "UpdateTeacherButton"
        Me.UpdateTeacherButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.Size = New System.Drawing.Size(390, 46)
        Me.UpdateTeacherButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.UpdateTeacherButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.UpdateTeacherButton.StateCommon.Border.Rounding = 10
        Me.UpdateTeacherButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(5)
        Me.UpdateTeacherButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.UpdateTeacherButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateTeacherButton.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.UpdateTeacherButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateTeacherButton.TabIndex = 117
        Me.UpdateTeacherButton.Values.Text = "Save Information"
        '
        'updateTeacherGenderComboBox
        '
        Me.updateTeacherGenderComboBox.DropDownWidth = 390
        Me.updateTeacherGenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.updateTeacherGenderComboBox.Location = New System.Drawing.Point(520, 411)
        Me.updateTeacherGenderComboBox.Name = "updateTeacherGenderComboBox"
        Me.updateTeacherGenderComboBox.Size = New System.Drawing.Size(390, 21)
        Me.updateTeacherGenderComboBox.TabIndex = 136
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Gender.Location = New System.Drawing.Point(517, 386)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(53, 16)
        Me.Gender.TabIndex = 133
        Me.Gender.Text = "Gender"
        '
        'updateTeacherAddressTextBox
        '
        Me.updateTeacherAddressTextBox.Location = New System.Drawing.Point(91, 311)
        Me.updateTeacherAddressTextBox.Name = "updateTeacherAddressTextBox"
        Me.updateTeacherAddressTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateTeacherAddressTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherAddressTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateTeacherAddressTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateTeacherAddressTextBox.StateCommon.Border.Rounding = 10
        Me.updateTeacherAddressTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherAddressTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateTeacherAddressTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateTeacherAddressTextBox.TabIndex = 132
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(96, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Address"
        '
        'updateTeacherEmailTextBox
        '
        Me.updateTeacherEmailTextBox.Location = New System.Drawing.Point(91, 236)
        Me.updateTeacherEmailTextBox.Name = "updateTeacherEmailTextBox"
        Me.updateTeacherEmailTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateTeacherEmailTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherEmailTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateTeacherEmailTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateTeacherEmailTextBox.StateCommon.Border.Rounding = 10
        Me.updateTeacherEmailTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherEmailTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateTeacherEmailTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateTeacherEmailTextBox.TabIndex = 130
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(96, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Email"
        '
        'updateTeacherDoBDateTimePicker
        '
        Me.updateTeacherDoBDateTimePicker.CustomFormat = "mm/dd/yyyy"
        Me.updateTeacherDoBDateTimePicker.Location = New System.Drawing.Point(91, 405)
        Me.updateTeacherDoBDateTimePicker.Name = "updateTeacherDoBDateTimePicker"
        Me.updateTeacherDoBDateTimePicker.Palette = Me.KryptonPalette1
        Me.updateTeacherDoBDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.updateTeacherDoBDateTimePicker.Size = New System.Drawing.Size(390, 27)
        Me.updateTeacherDoBDateTimePicker.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.updateTeacherDoBDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherDoBDateTimePicker.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateTeacherDoBDateTimePicker.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateTeacherDoBDateTimePicker.StateCommon.Border.Rounding = 10
        Me.updateTeacherDoBDateTimePicker.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherDoBDateTimePicker.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateTeacherDoBDateTimePicker.TabIndex = 128
        '
        'updateTeacherPhoneNumberTextBox
        '
        Me.updateTeacherPhoneNumberTextBox.Location = New System.Drawing.Point(520, 311)
        Me.updateTeacherPhoneNumberTextBox.Name = "updateTeacherPhoneNumberTextBox"
        Me.updateTeacherPhoneNumberTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateTeacherPhoneNumberTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherPhoneNumberTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateTeacherPhoneNumberTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateTeacherPhoneNumberTextBox.StateCommon.Border.Rounding = 10
        Me.updateTeacherPhoneNumberTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherPhoneNumberTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateTeacherPhoneNumberTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateTeacherPhoneNumberTextBox.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(525, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(96, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Date of Birth"
        '
        'updateTeacherNameTextBox
        '
        Me.updateTeacherNameTextBox.Location = New System.Drawing.Point(91, 158)
        Me.updateTeacherNameTextBox.Name = "updateTeacherNameTextBox"
        Me.updateTeacherNameTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateTeacherNameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherNameTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateTeacherNameTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateTeacherNameTextBox.StateCommon.Border.Rounding = 10
        Me.updateTeacherNameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherNameTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateTeacherNameTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateTeacherNameTextBox.TabIndex = 123
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(96, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Name"
        '
        'updateTeacherICNumberTextBox
        '
        Me.updateTeacherICNumberTextBox.Location = New System.Drawing.Point(520, 236)
        Me.updateTeacherICNumberTextBox.Name = "updateTeacherICNumberTextBox"
        Me.updateTeacherICNumberTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateTeacherICNumberTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherICNumberTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateTeacherICNumberTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateTeacherICNumberTextBox.StateCommon.Border.Rounding = 10
        Me.updateTeacherICNumberTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherICNumberTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateTeacherICNumberTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateTeacherICNumberTextBox.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(525, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "IC Number"
        '
        'updateTeacherIDTextBox
        '
        Me.updateTeacherIDTextBox.Location = New System.Drawing.Point(520, 158)
        Me.updateTeacherIDTextBox.Name = "updateTeacherIDTextBox"
        Me.updateTeacherIDTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateTeacherIDTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherIDTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateTeacherIDTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateTeacherIDTextBox.StateCommon.Border.Rounding = 10
        Me.updateTeacherIDTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateTeacherIDTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateTeacherIDTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateTeacherIDTextBox.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(525, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Teacher ID"
        '
        'Teacher_Information_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.updateTeacherGenderComboBox)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.updateTeacherAddressTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.updateTeacherEmailTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.updateTeacherDoBDateTimePicker)
        Me.Controls.Add(Me.updateTeacherPhoneNumberTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.updateTeacherNameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.updateTeacherICNumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updateTeacherIDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.UpdateTeacherButton)
        Me.Name = "Teacher_Information_Update"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Information Update"
        CType(Me.updateTeacherGenderComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents backButton As KryptonButton
    Friend WithEvents UpdateTeacherButton As KryptonButton
    Friend WithEvents updateTeacherGenderComboBox As KryptonComboBox
    Friend WithEvents Gender As Label
    Friend WithEvents updateTeacherAddressTextBox As KryptonTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents updateTeacherEmailTextBox As KryptonTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents updateTeacherDoBDateTimePicker As KryptonDateTimePicker
    Friend WithEvents updateTeacherPhoneNumberTextBox As KryptonTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents updateTeacherNameTextBox As KryptonTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents updateTeacherICNumberTextBox As KryptonTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents updateTeacherIDTextBox As KryptonTextBox
    Friend WithEvents Label1 As Label
End Class

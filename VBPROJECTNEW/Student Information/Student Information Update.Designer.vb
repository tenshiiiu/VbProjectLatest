Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Information_Update
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
        Me.editStudentButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.updateStudentGenderComboBox = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.Gender = New System.Windows.Forms.Label()
        Me.updateStudentAddressTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updateStudentEmailTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.updateStudentDoBDateTimePicker = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.updateStudentPhoneNumberTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.updateStudentNameTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.updateStudentICNumberTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updateStudentMarticNumberTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.updateStudentGenderComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.backButton.Location = New System.Drawing.Point(56, 24)
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
        'editStudentButton
        '
        Me.editStudentButton.Location = New System.Drawing.Point(318, 498)
        Me.editStudentButton.Name = "editStudentButton"
        Me.editStudentButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.Size = New System.Drawing.Size(390, 46)
        Me.editStudentButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.editStudentButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.editStudentButton.StateCommon.Border.Rounding = 10
        Me.editStudentButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(5)
        Me.editStudentButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.editStudentButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editStudentButton.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.editStudentButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.editStudentButton.TabIndex = 95
        Me.editStudentButton.Values.Text = "Save Information"
        '
        'updateStudentGenderComboBox
        '
        Me.updateStudentGenderComboBox.DropDownWidth = 390
        Me.updateStudentGenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.updateStudentGenderComboBox.Location = New System.Drawing.Point(520, 394)
        Me.updateStudentGenderComboBox.Name = "updateStudentGenderComboBox"
        Me.updateStudentGenderComboBox.Size = New System.Drawing.Size(390, 21)
        Me.updateStudentGenderComboBox.TabIndex = 114
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Gender.Location = New System.Drawing.Point(517, 363)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(53, 16)
        Me.Gender.TabIndex = 111
        Me.Gender.Text = "Gender"
        '
        'updateStudentAddressTextBox
        '
        Me.updateStudentAddressTextBox.Location = New System.Drawing.Point(520, 296)
        Me.updateStudentAddressTextBox.Name = "updateStudentAddressTextBox"
        Me.updateStudentAddressTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateStudentAddressTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentAddressTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateStudentAddressTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateStudentAddressTextBox.StateCommon.Border.Rounding = 10
        Me.updateStudentAddressTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentAddressTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentAddressTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateStudentAddressTextBox.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(525, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Address"
        '
        'updateStudentEmailTextBox
        '
        Me.updateStudentEmailTextBox.Location = New System.Drawing.Point(91, 296)
        Me.updateStudentEmailTextBox.Name = "updateStudentEmailTextBox"
        Me.updateStudentEmailTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateStudentEmailTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentEmailTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateStudentEmailTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateStudentEmailTextBox.StateCommon.Border.Rounding = 10
        Me.updateStudentEmailTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentEmailTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentEmailTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateStudentEmailTextBox.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(96, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Email"
        '
        'updateStudentDoBDateTimePicker
        '
        Me.updateStudentDoBDateTimePicker.CustomFormat = "yyyy/mm/dd"
        Me.updateStudentDoBDateTimePicker.Location = New System.Drawing.Point(99, 388)
        Me.updateStudentDoBDateTimePicker.Name = "updateStudentDoBDateTimePicker"
        Me.updateStudentDoBDateTimePicker.Palette = Me.KryptonPalette1
        Me.updateStudentDoBDateTimePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.updateStudentDoBDateTimePicker.Size = New System.Drawing.Size(390, 27)
        Me.updateStudentDoBDateTimePicker.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.updateStudentDoBDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentDoBDateTimePicker.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateStudentDoBDateTimePicker.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateStudentDoBDateTimePicker.StateCommon.Border.Rounding = 10
        Me.updateStudentDoBDateTimePicker.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentDoBDateTimePicker.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateStudentDoBDateTimePicker.TabIndex = 106
        '
        'updateStudentPhoneNumberTextBox
        '
        Me.updateStudentPhoneNumberTextBox.Location = New System.Drawing.Point(520, 221)
        Me.updateStudentPhoneNumberTextBox.Name = "updateStudentPhoneNumberTextBox"
        Me.updateStudentPhoneNumberTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateStudentPhoneNumberTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentPhoneNumberTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateStudentPhoneNumberTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateStudentPhoneNumberTextBox.StateCommon.Border.Rounding = 10
        Me.updateStudentPhoneNumberTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentPhoneNumberTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentPhoneNumberTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateStudentPhoneNumberTextBox.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(525, 194)
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
        Me.Label5.Location = New System.Drawing.Point(96, 363)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Date of Birth"
        '
        'updateStudentNameTextBox
        '
        Me.updateStudentNameTextBox.Location = New System.Drawing.Point(91, 138)
        Me.updateStudentNameTextBox.Name = "updateStudentNameTextBox"
        Me.updateStudentNameTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateStudentNameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentNameTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateStudentNameTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateStudentNameTextBox.StateCommon.Border.Rounding = 10
        Me.updateStudentNameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentNameTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentNameTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateStudentNameTextBox.TabIndex = 101
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(96, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Name"
        '
        'updateStudentICNumberTextBox
        '
        Me.updateStudentICNumberTextBox.Location = New System.Drawing.Point(520, 138)
        Me.updateStudentICNumberTextBox.Name = "updateStudentICNumberTextBox"
        Me.updateStudentICNumberTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateStudentICNumberTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentICNumberTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateStudentICNumberTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateStudentICNumberTextBox.StateCommon.Border.Rounding = 10
        Me.updateStudentICNumberTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentICNumberTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentICNumberTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateStudentICNumberTextBox.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(525, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "IC Number"
        '
        'updateStudentMarticNumberTextBox
        '
        Me.updateStudentMarticNumberTextBox.Location = New System.Drawing.Point(91, 221)
        Me.updateStudentMarticNumberTextBox.Name = "updateStudentMarticNumberTextBox"
        Me.updateStudentMarticNumberTextBox.Size = New System.Drawing.Size(390, 43)
        Me.updateStudentMarticNumberTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentMarticNumberTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.updateStudentMarticNumberTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.updateStudentMarticNumberTextBox.StateCommon.Border.Rounding = 10
        Me.updateStudentMarticNumberTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.updateStudentMarticNumberTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStudentMarticNumberTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.updateStudentMarticNumberTextBox.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(96, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Matric Number"
        '
        'Student_Information_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.updateStudentGenderComboBox)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.updateStudentAddressTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.updateStudentEmailTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.updateStudentDoBDateTimePicker)
        Me.Controls.Add(Me.updateStudentPhoneNumberTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.updateStudentNameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.updateStudentICNumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updateStudentMarticNumberTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.editStudentButton)
        Me.Name = "Student_Information_Update"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information Update"
        CType(Me.updateStudentGenderComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents backButton As KryptonButton
    Friend WithEvents editStudentButton As KryptonButton
    Friend WithEvents updateStudentGenderComboBox As KryptonComboBox
    Friend WithEvents Gender As Label
    Friend WithEvents updateStudentAddressTextBox As KryptonTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents updateStudentEmailTextBox As KryptonTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents updateStudentDoBDateTimePicker As KryptonDateTimePicker
    Friend WithEvents updateStudentPhoneNumberTextBox As KryptonTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents updateStudentNameTextBox As KryptonTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents updateStudentICNumberTextBox As KryptonTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents updateStudentMarticNumberTextBox As KryptonTextBox
    Friend WithEvents Label1 As Label
End Class

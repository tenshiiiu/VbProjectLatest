Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewStudentForm
    Inherits KryptonForm

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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.searchStudentTextBox = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.studentDataGridView = New System.Windows.Forms.DataGridView()
        Me.RegisterStudentButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.backToHomeButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.viewStudentSubjectButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.studentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'searchStudentTextBox
        '
        Me.searchStudentTextBox.Location = New System.Drawing.Point(33, 110)
        Me.searchStudentTextBox.Name = "searchStudentTextBox"
        Me.searchStudentTextBox.Size = New System.Drawing.Size(689, 33)
        Me.searchStudentTextBox.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.searchStudentTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.searchStudentTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.searchStudentTextBox.StateCommon.Border.Rounding = 15
        Me.searchStudentTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.searchStudentTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchStudentTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.searchStudentTextBox.TabIndex = 43
        '
        'studentDataGridView
        '
        Me.studentDataGridView.AllowUserToAddRows = False
        Me.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.studentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.studentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.studentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.studentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.studentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.studentDataGridView.Location = New System.Drawing.Point(26, 176)
        Me.studentDataGridView.Name = "studentDataGridView"
        Me.studentDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(122, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.studentDataGridView.RowHeadersVisible = False
        Me.studentDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.studentDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.studentDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.studentDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.studentDataGridView.Size = New System.Drawing.Size(673, 348)
        Me.studentDataGridView.TabIndex = 42
        '
        'RegisterStudentButton
        '
        Me.RegisterStudentButton.Location = New System.Drawing.Point(723, 176)
        Me.RegisterStudentButton.Name = "RegisterStudentButton"
        Me.RegisterStudentButton.Size = New System.Drawing.Size(260, 45)
        Me.RegisterStudentButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RegisterStudentButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.RegisterStudentButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.RegisterStudentButton.StateCommon.Border.Rounding = 5
        Me.RegisterStudentButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.RegisterStudentButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterStudentButton.TabIndex = 41
        Me.RegisterStudentButton.Values.Text = "Register Subject"
        '
        'backToHomeButton
        '
        Me.backToHomeButton.Location = New System.Drawing.Point(723, 32)
        Me.backToHomeButton.Name = "backToHomeButton"
        Me.backToHomeButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.Size = New System.Drawing.Size(260, 46)
        Me.backToHomeButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.backToHomeButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.backToHomeButton.StateCommon.Border.Rounding = 10
        Me.backToHomeButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(5)
        Me.backToHomeButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.backToHomeButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backToHomeButton.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.backToHomeButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.backToHomeButton.TabIndex = 38
        Me.backToHomeButton.Values.Text = "Back To Home"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(398, 41)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "STUDENT SUBJECT LIST"
        '
        'viewStudentSubjectButton
        '
        Me.viewStudentSubjectButton.Location = New System.Drawing.Point(723, 248)
        Me.viewStudentSubjectButton.Name = "viewStudentSubjectButton"
        Me.viewStudentSubjectButton.Size = New System.Drawing.Size(260, 45)
        Me.viewStudentSubjectButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.viewStudentSubjectButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.viewStudentSubjectButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.viewStudentSubjectButton.StateCommon.Border.Rounding = 5
        Me.viewStudentSubjectButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.viewStudentSubjectButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewStudentSubjectButton.TabIndex = 39
        Me.viewStudentSubjectButton.Values.Text = "View Student Subject List"
        '
        'ViewStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.searchStudentTextBox)
        Me.Controls.Add(Me.studentDataGridView)
        Me.Controls.Add(Me.RegisterStudentButton)
        Me.Controls.Add(Me.viewStudentSubjectButton)
        Me.Controls.Add(Me.backToHomeButton)
        Me.Controls.Add(Me.Label3)
        Me.Name = "ViewStudentForm"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewStudentForm"
        CType(Me.studentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents searchStudentTextBox As KryptonMaskedTextBox
    Friend WithEvents studentDataGridView As DataGridView
    Friend WithEvents RegisterStudentButton As KryptonButton
    Friend WithEvents backToHomeButton As KryptonButton
    Friend WithEvents Label3 As Label
    Friend WithEvents viewStudentSubjectButton As KryptonButton
End Class

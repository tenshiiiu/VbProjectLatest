Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Subject_Information_Form
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.searchSubjectTextBox = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.subjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddSubjectButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.deleteSubjectButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.UpdateSubjectButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.backToHomeButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.subjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'searchSubjectTextBox
        '
        Me.searchSubjectTextBox.Location = New System.Drawing.Point(12, 95)
        Me.searchSubjectTextBox.Name = "searchSubjectTextBox"
        Me.searchSubjectTextBox.Size = New System.Drawing.Size(696, 33)
        Me.searchSubjectTextBox.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.searchSubjectTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.searchSubjectTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.searchSubjectTextBox.StateCommon.Border.Rounding = 15
        Me.searchSubjectTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.searchSubjectTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchSubjectTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.searchSubjectTextBox.TabIndex = 28
        '
        'subjectDataGridView
        '
        Me.subjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.subjectDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.subjectDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.subjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjectDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.subjectDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subjectDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.subjectDataGridView.Location = New System.Drawing.Point(20, 156)
        Me.subjectDataGridView.Name = "subjectDataGridView"
        Me.subjectDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(122, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.subjectDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.subjectDataGridView.RowHeadersVisible = False
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.subjectDataGridView.Size = New System.Drawing.Size(688, 347)
        Me.subjectDataGridView.TabIndex = 27
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.Location = New System.Drawing.Point(736, 95)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(260, 45)
        Me.AddSubjectButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AddSubjectButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.AddSubjectButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.AddSubjectButton.StateCommon.Border.Rounding = 5
        Me.AddSubjectButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.AddSubjectButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubjectButton.TabIndex = 26
        Me.AddSubjectButton.Values.Text = "Add Subject"
        '
        'deleteSubjectButton
        '
        Me.deleteSubjectButton.Location = New System.Drawing.Point(736, 217)
        Me.deleteSubjectButton.Name = "deleteSubjectButton"
        Me.deleteSubjectButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.deleteSubjectButton.OverrideFocus.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.OverrideFocus.Back.Color2 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.OverrideFocus.Border.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.OverrideFocus.Border.Color2 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.OverrideFocus.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.deleteSubjectButton.Size = New System.Drawing.Size(260, 45)
        Me.deleteSubjectButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.deleteSubjectButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.deleteSubjectButton.StateCommon.Border.Rounding = 5
        Me.deleteSubjectButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.deleteSubjectButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteSubjectButton.StateDisabled.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.StateDisabled.Back.Color2 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.StateNormal.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.StateNormal.Back.Color2 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.StatePressed.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.StatePressed.Back.Color2 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.StateTracking.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.StateTracking.Back.Color2 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.TabIndex = 25
        Me.deleteSubjectButton.Values.Text = "Delete Subject"
        '
        'UpdateSubjectButton
        '
        Me.UpdateSubjectButton.Location = New System.Drawing.Point(736, 156)
        Me.UpdateSubjectButton.Name = "UpdateSubjectButton"
        Me.UpdateSubjectButton.Size = New System.Drawing.Size(260, 45)
        Me.UpdateSubjectButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.UpdateSubjectButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.UpdateSubjectButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.UpdateSubjectButton.StateCommon.Border.Rounding = 5
        Me.UpdateSubjectButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.UpdateSubjectButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateSubjectButton.TabIndex = 24
        Me.UpdateSubjectButton.Values.Text = "Update Subject"
        '
        'backToHomeButton
        '
        Me.backToHomeButton.Location = New System.Drawing.Point(736, 22)
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
        Me.backToHomeButton.TabIndex = 23
        Me.backToHomeButton.Values.Text = "Back To Home"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 41)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "SUBJECT LIST"
        '
        'Subject_Information_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.searchSubjectTextBox)
        Me.Controls.Add(Me.subjectDataGridView)
        Me.Controls.Add(Me.AddSubjectButton)
        Me.Controls.Add(Me.deleteSubjectButton)
        Me.Controls.Add(Me.UpdateSubjectButton)
        Me.Controls.Add(Me.backToHomeButton)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Subject_Information_Form"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject_Information_Form"
        CType(Me.subjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents searchSubjectTextBox As KryptonMaskedTextBox
    Friend WithEvents subjectDataGridView As DataGridView
    Friend WithEvents AddSubjectButton As KryptonButton
    Friend WithEvents deleteSubjectButton As KryptonButton
    Friend WithEvents UpdateSubjectButton As KryptonButton
    Friend WithEvents backToHomeButton As KryptonButton
    Friend WithEvents Label3 As Label
End Class

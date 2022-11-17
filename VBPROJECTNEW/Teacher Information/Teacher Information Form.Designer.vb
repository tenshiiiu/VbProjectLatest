Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teacher_Information_Form
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
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.TeacherDataGridView = New System.Windows.Forms.DataGridView()
        Me.SearchTeacherTextBox = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.AddTeacherButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.deleteTeacherButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.UpdateTeacherButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.backToHomeButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TeacherDataGridView
        '
        Me.TeacherDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TeacherDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TeacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherDataGridView.Location = New System.Drawing.Point(12, 177)
        Me.TeacherDataGridView.Name = "TeacherDataGridView"
        Me.TeacherDataGridView.Size = New System.Drawing.Size(984, 363)
        Me.TeacherDataGridView.TabIndex = 51
        '
        'SearchTeacherTextBox
        '
        Me.SearchTeacherTextBox.Location = New System.Drawing.Point(23, 83)
        Me.SearchTeacherTextBox.Name = "SearchTeacherTextBox"
        Me.SearchTeacherTextBox.Size = New System.Drawing.Size(696, 33)
        Me.SearchTeacherTextBox.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.SearchTeacherTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.SearchTeacherTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.SearchTeacherTextBox.StateCommon.Border.Rounding = 15
        Me.SearchTeacherTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.SearchTeacherTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTeacherTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.SearchTeacherTextBox.TabIndex = 50
        '
        'AddTeacherButton
        '
        Me.AddTeacherButton.Location = New System.Drawing.Point(57, 126)
        Me.AddTeacherButton.Name = "AddTeacherButton"
        Me.AddTeacherButton.Size = New System.Drawing.Size(260, 45)
        Me.AddTeacherButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.AddTeacherButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.AddTeacherButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.AddTeacherButton.StateCommon.Border.Rounding = 5
        Me.AddTeacherButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.AddTeacherButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTeacherButton.TabIndex = 49
        Me.AddTeacherButton.Values.Text = "Add Teacher"
        '
        'deleteTeacherButton
        '
        Me.deleteTeacherButton.Location = New System.Drawing.Point(650, 126)
        Me.deleteTeacherButton.Name = "deleteTeacherButton"
        Me.deleteTeacherButton.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteTeacherButton.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkRed
        Me.deleteTeacherButton.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkRed
        Me.deleteTeacherButton.OverrideDefault.Border.Color2 = System.Drawing.Color.DarkRed
        Me.deleteTeacherButton.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.deleteTeacherButton.OverrideFocus.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteTeacherButton.OverrideFocus.Back.Color2 = System.Drawing.Color.DarkRed
        Me.deleteTeacherButton.OverrideFocus.Border.Color1 = System.Drawing.Color.DarkRed
        Me.deleteTeacherButton.OverrideFocus.Border.Color2 = System.Drawing.Color.DarkRed
        Me.deleteTeacherButton.OverrideFocus.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.deleteTeacherButton.Size = New System.Drawing.Size(260, 45)
        Me.deleteTeacherButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteTeacherButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.deleteTeacherButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.deleteTeacherButton.StateCommon.Border.Rounding = 5
        Me.deleteTeacherButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.deleteTeacherButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteTeacherButton.TabIndex = 48
        Me.deleteTeacherButton.Values.Text = "Delete Teacher"
        '
        'UpdateTeacherButton
        '
        Me.UpdateTeacherButton.Location = New System.Drawing.Point(360, 126)
        Me.UpdateTeacherButton.Name = "UpdateTeacherButton"
        Me.UpdateTeacherButton.Size = New System.Drawing.Size(260, 45)
        Me.UpdateTeacherButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.UpdateTeacherButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.UpdateTeacherButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.UpdateTeacherButton.StateCommon.Border.Rounding = 5
        Me.UpdateTeacherButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.UpdateTeacherButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateTeacherButton.TabIndex = 47
        Me.UpdateTeacherButton.Values.Text = "Update Teacher"
        '
        'backToHomeButton
        '
        Me.backToHomeButton.Location = New System.Drawing.Point(736, 13)
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
        Me.backToHomeButton.TabIndex = 46
        Me.backToHomeButton.Values.Text = "Back To Home"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(379, 41)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "TEACHER INFORMATION"
        '
        'Teacher_Information_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.SearchTeacherTextBox)
        Me.Controls.Add(Me.AddTeacherButton)
        Me.Controls.Add(Me.deleteTeacherButton)
        Me.Controls.Add(Me.UpdateTeacherButton)
        Me.Controls.Add(Me.backToHomeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TeacherDataGridView)
        Me.Name = "Teacher_Information_Form"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Information Form"
        CType(Me.TeacherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents TeacherDataGridView As DataGridView
    Friend WithEvents SearchTeacherTextBox As KryptonMaskedTextBox
    Friend WithEvents AddTeacherButton As KryptonButton
    Friend WithEvents deleteTeacherButton As KryptonButton
    Friend WithEvents UpdateTeacherButton As KryptonButton
    Friend WithEvents backToHomeButton As KryptonButton
    Friend WithEvents Label3 As Label
End Class

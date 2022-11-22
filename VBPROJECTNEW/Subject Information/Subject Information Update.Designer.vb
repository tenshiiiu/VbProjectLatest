Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Subject_Information_Update
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
        Me.UpdateFeeSubjectTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UpdateCreditSubjectTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.backButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.AddClassButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.UpdateSubjectCodeTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UpdateSubjectNameTextBox = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'UpdateFeeSubjectTextBox
        '
        Me.UpdateFeeSubjectTextBox.Location = New System.Drawing.Point(323, 365)
        Me.UpdateFeeSubjectTextBox.Name = "UpdateFeeSubjectTextBox"
        Me.UpdateFeeSubjectTextBox.Size = New System.Drawing.Size(390, 43)
        Me.UpdateFeeSubjectTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateFeeSubjectTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.UpdateFeeSubjectTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.UpdateFeeSubjectTextBox.StateCommon.Border.Rounding = 10
        Me.UpdateFeeSubjectTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateFeeSubjectTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateFeeSubjectTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.UpdateFeeSubjectTextBox.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(328, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Fee :"
        '
        'UpdateCreditSubjectTextBox
        '
        Me.UpdateCreditSubjectTextBox.Location = New System.Drawing.Point(321, 280)
        Me.UpdateCreditSubjectTextBox.Name = "UpdateCreditSubjectTextBox"
        Me.UpdateCreditSubjectTextBox.Size = New System.Drawing.Size(390, 43)
        Me.UpdateCreditSubjectTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateCreditSubjectTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.UpdateCreditSubjectTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.UpdateCreditSubjectTextBox.StateCommon.Border.Rounding = 10
        Me.UpdateCreditSubjectTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateCreditSubjectTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateCreditSubjectTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.UpdateCreditSubjectTextBox.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(326, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Credit :"
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(66, 23)
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
        Me.backButton.TabIndex = 101
        Me.backButton.Values.Text = "Back"
        '
        'AddClassButton
        '
        Me.AddClassButton.Location = New System.Drawing.Point(321, 439)
        Me.AddClassButton.Name = "AddClassButton"
        Me.AddClassButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.Size = New System.Drawing.Size(390, 46)
        Me.AddClassButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.AddClassButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.AddClassButton.StateCommon.Border.Rounding = 10
        Me.AddClassButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(5)
        Me.AddClassButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.AddClassButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddClassButton.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.AddClassButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.AddClassButton.TabIndex = 100
        Me.AddClassButton.Values.Text = "Save Information"
        '
        'UpdateSubjectCodeTextBox
        '
        Me.UpdateSubjectCodeTextBox.Location = New System.Drawing.Point(321, 112)
        Me.UpdateSubjectCodeTextBox.Name = "UpdateSubjectCodeTextBox"
        Me.UpdateSubjectCodeTextBox.Size = New System.Drawing.Size(390, 43)
        Me.UpdateSubjectCodeTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateSubjectCodeTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.UpdateSubjectCodeTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.UpdateSubjectCodeTextBox.StateCommon.Border.Rounding = 10
        Me.UpdateSubjectCodeTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateSubjectCodeTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateSubjectCodeTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.UpdateSubjectCodeTextBox.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(326, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Subject Code :"
        '
        'UpdateSubjectNameTextBox
        '
        Me.UpdateSubjectNameTextBox.Location = New System.Drawing.Point(321, 191)
        Me.UpdateSubjectNameTextBox.Name = "UpdateSubjectNameTextBox"
        Me.UpdateSubjectNameTextBox.Size = New System.Drawing.Size(390, 43)
        Me.UpdateSubjectNameTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateSubjectNameTextBox.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.UpdateSubjectNameTextBox.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.UpdateSubjectNameTextBox.StateCommon.Border.Rounding = 10
        Me.UpdateSubjectNameTextBox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UpdateSubjectNameTextBox.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateSubjectNameTextBox.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10)
        Me.UpdateSubjectNameTextBox.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(326, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Subject Name :"
        '
        'Subject_Information_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.UpdateFeeSubjectTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UpdateCreditSubjectTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.AddClassButton)
        Me.Controls.Add(Me.UpdateSubjectCodeTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UpdateSubjectNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Subject_Information_Update"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Subject Information Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents UpdateFeeSubjectTextBox As KryptonTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents UpdateCreditSubjectTextBox As KryptonTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents backButton As KryptonButton
    Friend WithEvents AddClassButton As KryptonButton
    Friend WithEvents UpdateSubjectCodeTextBox As KryptonTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UpdateSubjectNameTextBox As KryptonTextBox
    Friend WithEvents Label1 As Label
End Class

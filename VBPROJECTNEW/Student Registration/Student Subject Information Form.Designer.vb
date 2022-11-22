Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Subject_Information_Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.matricNumberLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.subjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalCreditLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.feeLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.printSubjectButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.emailSubjectButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
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
        'matricNumberLabel
        '
        Me.matricNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.matricNumberLabel.Location = New System.Drawing.Point(386, 123)
        Me.matricNumberLabel.Name = "matricNumberLabel"
        Me.matricNumberLabel.Size = New System.Drawing.Size(175, 23)
        Me.matricNumberLabel.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(227, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 23)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Matric Number"
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.nameLabel.Location = New System.Drawing.Point(386, 87)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(175, 23)
        Me.nameLabel.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(227, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Name"
        '
        'subjectDataGridView
        '
        Me.subjectDataGridView.AllowUserToAddRows = False
        Me.subjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.subjectDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.subjectDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.subjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjectDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.subjectDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.subjectDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.subjectDataGridView.Location = New System.Drawing.Point(230, 242)
        Me.subjectDataGridView.Name = "subjectDataGridView"
        Me.subjectDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(122, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.subjectDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.subjectDataGridView.RowHeadersVisible = False
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.subjectDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.subjectDataGridView.Size = New System.Drawing.Size(331, 276)
        Me.subjectDataGridView.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(224, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 31)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Student Information"
        '
        'totalCreditLabel
        '
        Me.totalCreditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.totalCreditLabel.Location = New System.Drawing.Point(386, 157)
        Me.totalCreditLabel.Name = "totalCreditLabel"
        Me.totalCreditLabel.Size = New System.Drawing.Size(175, 23)
        Me.totalCreditLabel.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(227, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 23)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Total Credit"
        '
        'feeLabel
        '
        Me.feeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.feeLabel.Location = New System.Drawing.Point(386, 189)
        Me.feeLabel.Name = "feeLabel"
        Me.feeLabel.Size = New System.Drawing.Size(175, 23)
        Me.feeLabel.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(227, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 23)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Fee"
        '
        'printSubjectButton
        '
        Me.printSubjectButton.Location = New System.Drawing.Point(594, 242)
        Me.printSubjectButton.Name = "printSubjectButton"
        Me.printSubjectButton.Size = New System.Drawing.Size(160, 45)
        Me.printSubjectButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.printSubjectButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.printSubjectButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.printSubjectButton.StateCommon.Border.Rounding = 5
        Me.printSubjectButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.printSubjectButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printSubjectButton.TabIndex = 60
        Me.printSubjectButton.Values.Text = "Print "
        '
        'emailSubjectButton
        '
        Me.emailSubjectButton.Location = New System.Drawing.Point(594, 305)
        Me.emailSubjectButton.Name = "emailSubjectButton"
        Me.emailSubjectButton.Size = New System.Drawing.Size(160, 48)
        Me.emailSubjectButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.emailSubjectButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.emailSubjectButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.emailSubjectButton.StateCommon.Border.Rounding = 5
        Me.emailSubjectButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.emailSubjectButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailSubjectButton.TabIndex = 61
        Me.emailSubjectButton.Values.Text = "Email"
        '
        'Student_Subject_Information_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.emailSubjectButton)
        Me.Controls.Add(Me.printSubjectButton)
        Me.Controls.Add(Me.feeLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.totalCreditLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.matricNumberLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.subjectDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Student_Subject_Information_Form"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.Text = "View Student Subject List"
        CType(Me.subjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents matricNumberLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents subjectDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents totalCreditLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents feeLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents printSubjectButton As KryptonButton
    Friend WithEvents emailSubjectButton As KryptonButton
End Class

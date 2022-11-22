Imports ComponentFactory.Krypton.Toolkit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register_Student_Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.addSubjectButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.subjectComboBox = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.matricNumberLabel = New System.Windows.Forms.Label()
        Me.deleteSubjectButton = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.subjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subjectComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(40, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Information"
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
        Me.subjectDataGridView.Location = New System.Drawing.Point(46, 234)
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
        Me.subjectDataGridView.TabIndex = 43
        '
        'addSubjectButton
        '
        Me.addSubjectButton.Location = New System.Drawing.Point(458, 280)
        Me.addSubjectButton.Name = "addSubjectButton"
        Me.addSubjectButton.Size = New System.Drawing.Size(260, 45)
        Me.addSubjectButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.addSubjectButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.addSubjectButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.addSubjectButton.StateCommon.Border.Rounding = 5
        Me.addSubjectButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.addSubjectButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSubjectButton.TabIndex = 44
        Me.addSubjectButton.Values.Text = "Register Subject"
        '
        'subjectComboBox
        '
        Me.subjectComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.subjectComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.subjectComboBox.DropDownWidth = 260
        Me.subjectComboBox.Items.AddRange(New Object() {"Physic", "Bahasa", "Malay"})
        Me.subjectComboBox.Location = New System.Drawing.Point(458, 234)
        Me.subjectComboBox.Name = "subjectComboBox"
        Me.subjectComboBox.Size = New System.Drawing.Size(260, 21)
        Me.subjectComboBox.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(43, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Name"
        '
        'nameLabel
        '
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.nameLabel.Location = New System.Drawing.Point(202, 79)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(175, 23)
        Me.nameLabel.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(43, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 23)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Matric Number"
        '
        'matricNumberLabel
        '
        Me.matricNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.matricNumberLabel.Location = New System.Drawing.Point(202, 115)
        Me.matricNumberLabel.Name = "matricNumberLabel"
        Me.matricNumberLabel.Size = New System.Drawing.Size(175, 23)
        Me.matricNumberLabel.TabIndex = 49
        '
        'deleteSubjectButton
        '
        Me.deleteSubjectButton.Location = New System.Drawing.Point(458, 345)
        Me.deleteSubjectButton.Name = "deleteSubjectButton"
        Me.deleteSubjectButton.Size = New System.Drawing.Size(260, 45)
        Me.deleteSubjectButton.StateCommon.Back.Color1 = System.Drawing.Color.DarkRed
        Me.deleteSubjectButton.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid
        Me.deleteSubjectButton.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.deleteSubjectButton.StateCommon.Border.Rounding = 5
        Me.deleteSubjectButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.deleteSubjectButton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteSubjectButton.TabIndex = 50
        Me.deleteSubjectButton.Values.Text = "Delete Subject"
        '
        'Register_Student_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.deleteSubjectButton)
        Me.Controls.Add(Me.matricNumberLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.subjectComboBox)
        Me.Controls.Add(Me.addSubjectButton)
        Me.Controls.Add(Me.subjectDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register_Student_Form"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register_Student_Form"
        CType(Me.subjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subjectComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents Label1 As Label
    Friend WithEvents subjectDataGridView As DataGridView
    Friend WithEvents addSubjectButton As KryptonButton
    Friend WithEvents subjectComboBox As KryptonComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents matricNumberLabel As Label
    Friend WithEvents deleteSubjectButton As KryptonButton
End Class

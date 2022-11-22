Imports ComponentFactory.Krypton.Toolkit
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PreferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentSubjectListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterStudentSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeacherInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfTeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferenceToolStripMenuItem, Me.RegisterToolStripMenuItem, Me.TeacherInformationToolStripMenuItem, Me.StudentInformationToolStripMenuItem, Me.SubjectInformationToolStripMenuItem, Me.ClassInformationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 534)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PreferenceToolStripMenuItem
        '
        Me.PreferenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.UserManagementToolStripMenuItem})
        Me.PreferenceToolStripMenuItem.Name = "PreferenceToolStripMenuItem"
        Me.PreferenceToolStripMenuItem.Size = New System.Drawing.Size(111, 23)
        Me.PreferenceToolStripMenuItem.Text = "Preference"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentToolStripMenuItem})
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(93, 23)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentSubjectListToolStripMenuItem, Me.RegisterStudentSubjectToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'StudentSubjectListToolStripMenuItem
        '
        Me.StudentSubjectListToolStripMenuItem.Name = "StudentSubjectListToolStripMenuItem"
        Me.StudentSubjectListToolStripMenuItem.Size = New System.Drawing.Size(294, 24)
        Me.StudentSubjectListToolStripMenuItem.Text = "Student Subject List"
        '
        'RegisterStudentSubjectToolStripMenuItem
        '
        Me.RegisterStudentSubjectToolStripMenuItem.Name = "RegisterStudentSubjectToolStripMenuItem"
        Me.RegisterStudentSubjectToolStripMenuItem.Size = New System.Drawing.Size(294, 24)
        Me.RegisterStudentSubjectToolStripMenuItem.Text = "Register Student Subject"
        '
        'TeacherInformationToolStripMenuItem
        '
        Me.TeacherInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfTeacherToolStripMenuItem})
        Me.TeacherInformationToolStripMenuItem.Name = "TeacherInformationToolStripMenuItem"
        Me.TeacherInformationToolStripMenuItem.Size = New System.Drawing.Size(192, 23)
        Me.TeacherInformationToolStripMenuItem.Text = "Teacher Information"
        '
        'ListOfTeacherToolStripMenuItem
        '
        Me.ListOfTeacherToolStripMenuItem.Name = "ListOfTeacherToolStripMenuItem"
        Me.ListOfTeacherToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.ListOfTeacherToolStripMenuItem.Text = "List Of Teacher"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfStudentToolStripMenuItem})
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(192, 23)
        Me.StudentInformationToolStripMenuItem.Text = "Student Information"
        '
        'ListOfStudentToolStripMenuItem
        '
        Me.ListOfStudentToolStripMenuItem.Name = "ListOfStudentToolStripMenuItem"
        Me.ListOfStudentToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.ListOfStudentToolStripMenuItem.Text = "List Of Student"
        '
        'SubjectInformationToolStripMenuItem
        '
        Me.SubjectInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfSubjectToolStripMenuItem})
        Me.SubjectInformationToolStripMenuItem.Name = "SubjectInformationToolStripMenuItem"
        Me.SubjectInformationToolStripMenuItem.Size = New System.Drawing.Size(192, 23)
        Me.SubjectInformationToolStripMenuItem.Text = "Subject Information"
        '
        'ListOfSubjectToolStripMenuItem
        '
        Me.ListOfSubjectToolStripMenuItem.Name = "ListOfSubjectToolStripMenuItem"
        Me.ListOfSubjectToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.ListOfSubjectToolStripMenuItem.Text = "List Of Subject"
        '
        'ClassInformationToolStripMenuItem
        '
        Me.ClassInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LisToolStripMenuItem})
        Me.ClassInformationToolStripMenuItem.Name = "ClassInformationToolStripMenuItem"
        Me.ClassInformationToolStripMenuItem.Size = New System.Drawing.Size(174, 23)
        Me.ClassInformationToolStripMenuItem.Text = "Class Information"
        '
        'LisToolStripMenuItem
        '
        Me.LisToolStripMenuItem.Name = "LisToolStripMenuItem"
        Me.LisToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.LisToolStripMenuItem.Text = "List Of Class"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(491, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 166)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(153, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "School"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(46, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Welcome To Our"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1025, 10)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 432)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1025, 10)
        Me.Panel3.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox1.Image = Global.VBPROJECTNEW.My.Resources.Resources.Knowledge__Isometric
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1008, 529)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenuForm"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PreferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeacherInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfTeacherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListOfSubjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StudentSubjectListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterStudentSubjectToolStripMenuItem As ToolStripMenuItem
End Class

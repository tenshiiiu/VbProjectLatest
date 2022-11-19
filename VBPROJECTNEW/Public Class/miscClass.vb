Imports ComponentFactory.Krypton.Toolkit
Public Class miscClass

    Public Sub numberOnly(sender As Object, e As KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub disableButton(editButton As KryptonButton, deleteButton As KryptonButton)
        'Edit Background Color
        editButton.StateCommon.Back.Color1 = Color.Gray
        deleteButton.StateCommon.Back.Color1 = Color.Gray

        'Disable Button
        editButton.Enabled = False
        deleteButton.Enabled = False

    End Sub

    Public Sub enableButton(editButton As KryptonButton, deleteButton As KryptonButton)
        'Edit Background Color
        editButton.StateCommon.Back.Color1 = ColorTranslator.FromHtml("#3f412c")
        deleteButton.StateCommon.Back.Color1 = Color.Red

        'Disable Button
        editButton.Enabled = True
        deleteButton.Enabled = True

    End Sub


End Class

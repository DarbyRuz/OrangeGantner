Module AutoCompleteCombo

    Public Sub AutoCompleteCombo_KeyUp(ByVal cbo As ComboBox, ByVal e As KeyEventArgs)
        Dim sTypedText As String
        Dim iFoundIndex As Integer
        Dim oFoundItem As Object
        Dim sFoundText As String
        Dim sAppendText As String

        'Allow select keys without Autocompleting
        Select Case e.KeyCode
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, Keys.Delete, Keys.Down
                Return
        End Select

        'Get the Typed Text and Find it in the list
        sTypedText = Trim(cbo.Text)
        iFoundIndex = cbo.FindString(sTypedText)

        'If we found the Typed Text in the list then Autocomplete
        If iFoundIndex >= 0 Then

            'Get the Item from the list (Return Type depends if Datasource was bound 
            ' or List Created)
            oFoundItem = cbo.Items(iFoundIndex)

            'Use the ListControl.GetItemText to resolve the Name in case the Combo 
            ' was Data bound
            sFoundText = Trim(cbo.GetItemText(oFoundItem))

            'Append then found text to the typed text to preserve case
            sAppendText = Trim(sFoundText.Substring(sTypedText.Length))
            cbo.Text = sTypedText & sAppendText

            'Select the Appended Text
            cbo.SelectionStart = Trim(sTypedText.Length)
            cbo.SelectionLength = Trim(sAppendText.Length)

        End If

    End Sub
    Public Sub AutoCompleteCombo_Leave(ByVal cbo As ComboBox)
        Dim iFoundIndex As Integer

        iFoundIndex = cbo.FindStringExact(Trim(cbo.Text))

        cbo.SelectedIndex = iFoundIndex

    End Sub
End Module

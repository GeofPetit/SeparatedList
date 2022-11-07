'******************************************************************************************************************************************
'*                                                                                                                                        *
'*  Description:                                                                                                                          *
'*                                                                                                                                        *
'*  Test harness to demonstrate the cSeparatedList class                                                                                  *
'*                                                                                                                                        *
'*  This form allows the user to enter a single separator character and a corresponding string array of entries.                          *
'*                                                                                                                                        *
'*  The separated list class will return a single string value containing all the entries separated by the specified separator.           *
'*                                                                                                                                        *
'******************************************************************************************************************************************
'*                                                                                                                                        *
'*  Amendment Log:                                                                                                                        *
'*                                                                                                                                        *
'*  Date        By          Reference    Details                                                                                          *
'*  ----------  ----------  ---------    -----------------------------------------------------------------------------------------------  *
'*  ccyy-mm-dd  xxxxxxxxxx  xxxxxxxxx    xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx  *
'*                                                                                                                                        *
'******************************************************************************************************************************************

Public Class frmFromArraySingleSeparator

#Region "Private Variables"
    '*******************************************************************************************************************************
    '* Private variables                                                                                                           *
    '*******************************************************************************************************************************
    Private _cSharp_SeparatedList As cSharp_SeparatedList = Nothing
    Private _insertEntry, _insertString As Boolean
    Private _vb_SeparatedList As vb_SeparatedList.vb_SeparatedList = Nothing
#End Region

#Region "Public Methods"
    '*******************************************************************************************************************************
    '* Public methods                                                                                                              *
    '*******************************************************************************************************************************
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
    End Sub
#End Region

#Region "Private Methods"
    '*******************************************************************************************************************************
    '* Private methods                                                                                                             *
    '*******************************************************************************************************************************
    Private Sub frmFromString_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Initialise the form data
        _Refresh()
        Me.Focus()
    End Sub

    Private Sub btnCancelEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelEntry.Click

        ' Cancel entry
        txtSelectedEntry.Text = String.Empty
        _Refresh(lbxEntries.SelectedIndex)
        lbxEntries.Focus()
    End Sub

    Private Sub btnCancelString_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelString.Click

        ' Cancel entry
        txtSelectedString.Text = String.Empty
        _UpdateSeparatedListControlsStatus(True)
        _UpdateStringListControlsStatus(True)
        _UpdateSelectedStringControlsStatus(False)
        lbxStrings.Focus()
    End Sub

    Private Sub btnConfirmEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmEntry.Click

        ' Add a new or replace the existing entry
        Dim selectedIndex = lbxEntries.SelectedIndex

        If _InsertEntry Then
            If selectedIndex < 0 Then
                If rbtCSharpSeparatedList.Checked Then
                    _cSharp_SeparatedList.Entries.Add(txtSelectedEntry.Text)
                Else
                    _vb_SeparatedList.Entries.Add(txtSelectedEntry.Text)
                End If

                selectedIndex = lbxEntries.Items.Count
            Else
                If rbtCSharpSeparatedList.Checked Then
                    _cSharp_SeparatedList.Entries.Insert(selectedIndex, txtSelectedEntry.Text)
                Else
                    _vb_SeparatedList.Entries.Insert(selectedIndex, txtSelectedEntry.Text)
                End If
            End If
        Else
            If rbtCSharpSeparatedList.Checked Then
                _cSharp_SeparatedList.Entries(selectedIndex) = txtSelectedEntry.Text
            Else
                _vb_SeparatedList.Entries(selectedIndex) = txtSelectedEntry.Text
            End If
        End If

        _Refresh(selectedIndex)
        lbxEntries.Focus()
    End Sub

    Private Sub btnConfirmString_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmString.Click

        ' Add a new or replace the existing entry
        Dim selectedIndex = lbxStrings.SelectedIndex

        If _insertString Then
            If selectedIndex < 0 Then
                selectedIndex = lbxStrings.Items.Add(txtSelectedString.Text)
            Else
                lbxStrings.Items.Insert(selectedIndex, txtSelectedString.Text)
            End If
        Else
            lbxStrings.Items(selectedIndex) = txtSelectedString.Text
        End If

        _UpdateSeparatedListControlsStatus(True)
        _UpdateStringListControlsStatus(True)
        _UpdateSelectedStringControlsStatus(False)
        lbxStrings.Focus()
    End Sub

    Private Sub btnInsertEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertEntry.Click

        ' Change to insert mode
        txtSelectedEntry.Text = String.Empty
        _InsertEntry = True
        _UpdateInputControlsStatus(False)
        _UpdateEntryListControlsStatus(False)
        _UpdateSelectedEntryControlsStatus(True)
        txtSelectedEntry.Focus()
    End Sub

    Private Sub btnInsertString_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertString.Click

        ' Change to insert mode
        txtSelectedString.Text = String.Empty
        _insertString = True
        _UpdateSeparatedListControlsStatus(False)
        _UpdateStringListControlsStatus(False)
        _UpdateSelectedStringControlsStatus(True)
        txtSelectedString.Focus()
    End Sub

    Private Sub btnRemoveEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveEntry.Click

        ' Removed the selected entry
        If rbtCSharpSeparatedList.Checked Then
            _cSharp_SeparatedList.Entries.RemoveAt(lbxEntries.SelectedIndex)
        Else
            _vb_SeparatedList.Entries.RemoveAt(lbxEntries.SelectedIndex)
        End If

        _refresh()
    End Sub

    Private Sub btnRemoveString_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveString.Click

        ' Removed the selected entry
        lbxStrings.Items.RemoveAt(lbxStrings.SelectedIndex)
        _UpdateStringListControlsStatus(True)
        lbxStrings.Focus()
    End Sub

    Private Sub btnReplaceEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnReplaceEntry.Click

        ' Change to replace mode
        _InsertEntry = False
        _UpdateInputControlsStatus(False)
        _UpdateEntryListControlsStatus(False)
        _UpdateSelectedEntryControlsStatus(True)
        txtSelectedEntry.Focus()
    End Sub

    Private Sub btnReplaceString_Click(sender As System.Object, e As System.EventArgs) Handles btnReplaceString.Click

        ' Change to replace mode
        _insertString = False
        _UpdateSeparatedListControlsStatus(False)
        _UpdateStringListControlsStatus(False)
        _UpdateSelectedStringControlsStatus(True)
        txtSelectedString.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click

        ' Create a new separated list for the information entered and refresh the display
        Dim entries As String()
        ReDim entries(lbxStrings.Items.Count - 1)
        lbxStrings.Items.CopyTo(entries, 0)
        Dim chrSeparator As Char = CChar(txtStringSeparator.Text)

        If rbtCSharpSeparatedList.Checked Then
            _cSharp_SeparatedList = New cSharp_SeparatedList(chrSeparator, entries)
        Else
            _vb_SeparatedList = New vb_SeparatedList.vb_SeparatedList(chrSeparator, entries)
        End If

        _refresh()
        lbxEntries.Focus()
    End Sub

    Private Sub lbxEntries_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lbxEntries.DoubleClick

        ' Simulate the replace entry button click
        If btnReplaceEntry.Enabled Then
            btnReplaceEntry_Click(sender, e)
        End If
    End Sub

    Private Sub lbxEntries_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbxEntries.SelectedIndexChanged

        ' Update the selected entry information
        Dim itemIsSelected As Boolean = lbxEntries.SelectedIndex >= 0

        If itemIsSelected Then
            txtSelectedEntry.Text = lbxEntries.SelectedItem.ToString()
        Else
            txtSelectedEntry.Text = String.Empty
        End If

        ' Enable the appropriate form controls
        _UpdateEntryListControlsStatus(True)
        _UpdateSelectedEntryControlsStatus(False)
    End Sub

    Private Sub lbxStrings_DoubleClick(sender As Object, e As System.EventArgs) Handles lbxStrings.DoubleClick

        ' Simulate the replace string button click
        If btnReplaceString.Enabled Then
            btnReplaceString_Click(sender, e)
        End If
    End Sub

    Private Sub lbxStrings_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbxStrings.SelectedIndexChanged

        ' Update the selected entry information
        Dim itemIsSelected As Boolean = lbxStrings.SelectedIndex >= 0

        If itemIsSelected Then
            txtSelectedString.Text = lbxStrings.SelectedItem.ToString()
        Else
            txtSelectedString.Text = String.Empty
        End If

        ' Enable the appropriate form controls
        _UpdateStringListControlsStatus(True)
        _UpdateSelectedStringControlsStatus(False)
    End Sub

    Private Sub rbtCSharpSeparatedList_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtCSharpSeparatedList.CheckedChanged
        _refresh()
    End Sub

    Private Sub rbtVBSeparatedList_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtVBSeparatedList.CheckedChanged
        _refresh()
    End Sub

    Private Sub txtStringSeparator_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStringSeparator.TextChanged

        ' Ensure only 1 separator character can be specified
        If Len(txtStringSeparator.Text) > 1 Then
            txtStringSeparator.Text = txtStringSeparator.Text(txtStringSeparator.Text.Length - 1)
        End If
    End Sub

    Private Sub _refresh(Optional selectedIndex As Int32 = -1)

        ' Reset the form data from the current list
        lbxEntries.Items.Clear()
        Dim enableEntryListControls As Boolean

        If rbtCSharpSeparatedList.Checked Then
            enableEntryListControls = _cSharp_SeparatedList IsNot Nothing
        Else
            enableEntryListControls = _vb_SeparatedList IsNot Nothing
        End If

        If Not enableEntryListControls Then
            txtSeparator.Text = String.Empty
            txtUnusedSeparators.Text = String.Empty
            txtToString.Text = String.Empty
        Else
            If rbtCSharpSeparatedList.Checked Then
                txtSeparator.Text = _cSharp_SeparatedList.Separator
                lbxEntries.Items.AddRange(_cSharp_SeparatedList.Entries.ToArray())
                txtUnusedSeparators.Text = _cSharp_SeparatedList.UnusedSeparators.ToArray()
                txtToString.Text = _cSharp_SeparatedList.ToString
            Else
                txtSeparator.Text = _vb_SeparatedList.Separator
                lbxEntries.Items.AddRange(_vb_SeparatedList.Entries.ToArray())
                txtUnusedSeparators.Text = _vb_SeparatedList.UnusedSeparators.ToArray()
                txtToString.Text = _vb_SeparatedList.ToString
            End If

            lbxEntries.Focus()
        End If

        ' Enable the appropriate form controls
        _UpdateInputControlsStatus(True)
        _UpdateStringListControlsStatus(True)
        _UpdateSelectedStringControlsStatus(False)
        _UpdateSeparatedListControlsStatus(True)
        _UpdateEntryListControlsStatus(enableEntryListControls)
        _UpdateSelectedEntryControlsStatus(False)

        If selectedIndex >= 0 Then
            lbxEntries.SelectedIndex = selectedIndex
        Else
            txtSelectedEntry.Text = String.Empty
        End If
    End Sub

    Private Sub _updateEntryListControlsStatus(enableEntryListControls As Boolean)

        ' Update the status of the entry list controls
        lbxEntries.Enabled = enableEntryListControls
        btnInsertEntry.Enabled = lbxEntries.Enabled
        btnRemoveEntry.Enabled = lbxEntries.Enabled AndAlso lbxEntries.SelectedIndex >= 0
        btnReplaceEntry.Enabled = btnRemoveEntry.Enabled
    End Sub

    Private Sub _updateInputControlsStatus(bolEnable As Boolean)

        ' Update the status of the input controls
        gbxInput.Enabled = bolEnable
    End Sub

    Private Sub _updateSelectedEntryControlsStatus(enableSelectedEntryControls As Boolean)

        ' Update the status of the selected entry controls
        txtSelectedEntry.Enabled = enableSelectedEntryControls
        btnConfirmEntry.Enabled = txtSelectedEntry.Enabled
        btnCancelEntry.Enabled = btnConfirmEntry.Enabled

        ' Update the default accept and cancel buttons for the form
        If enableSelectedEntryControls Then
            Me.AcceptButton = btnConfirmEntry
            Me.CancelButton = btnCancelEntry
        Else
            Me.AcceptButton = btnSubmit
            Me.CancelButton = Nothing
        End If
    End Sub

    Private Sub _updateSelectedStringControlsStatus(enableSelectedStringControls As Boolean)

        ' Update the status of the selected string controls
        txtSelectedString.Enabled = enableSelectedStringControls
        btnConfirmString.Enabled = txtSelectedString.Enabled
        btnCancelString.Enabled = btnConfirmString.Enabled

        ' Update the default accept and cancel buttons for the form
        If enableSelectedStringControls Then
            Me.AcceptButton = btnConfirmString
            Me.CancelButton = btnCancelString
        Else
            Me.AcceptButton = btnSubmit
            Me.CancelButton = Nothing
        End If
    End Sub

    Private Sub _updateSeparatedListControlsStatus(enableSeparatedListControls As Boolean)

        ' Update the status of the separated list controls
        gbxSeparatedList.Enabled = enableSeparatedListControls
    End Sub

    Private Sub _updateStringListControlsStatus(enableStringListControls As Boolean)

        ' Update the status of the string list controls
        lbxStrings.Enabled = enableStringListControls
        btnInsertString.Enabled = lbxStrings.Enabled
        btnRemoveString.Enabled = lbxStrings.Enabled AndAlso lbxStrings.SelectedIndex >= 0
        btnReplaceString.Enabled = btnRemoveString.Enabled
    End Sub
#End Region
End Class

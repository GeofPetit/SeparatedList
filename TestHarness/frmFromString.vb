'******************************************************************************************************************************************
'*                                                                                                                                        *
'*  Description:                                                                                                                          *
'*                                                                                                                                        *
'*  Test harness to demonstrate the cSeparatedList class built from a single string value                                                 *
'*                                                                                                                                        *
'*  This form allows the user to enter a seperated list as a single string value                                                          *
'*                                                                                                                                        *
'*  The separated list class will return the seperator character used and a string array of all entries extracted.                        *
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

Public Class frmFromString

#Region "Private Variables"
    '*******************************************************************************************************************************
    '* Private variables                                                                                                           *
    '*******************************************************************************************************************************
    Private _cSharp_SeparatedList As cSharp_SeparatedList = Nothing
    Private _insertEntry As Boolean
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

    Private Sub btnConfirmEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmEntry.Click

        ' Insert a new or replace the existing entry
        Dim selectedIndex = lbxEntries.SelectedIndex

        If _InsertEntry Then
            If selectedIndex < 0 Then
                If rbtCSharpSeparatedList.Checked Then
                    _cSharp_separatedList.Entries.Add(txtSelectedEntry.Text)
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

    Private Sub btnInsertEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertEntry.Click

        ' Change to insert mode
        txtSelectedEntry.Text = String.Empty
        _InsertEntry = True
        _UpdateInputControlsStatus(False)
        _UpdateEntryListControlsStatus(False)
        _UpdateSelectedEntryControlsStatus(True)
        txtSelectedEntry.Focus()
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

    Private Sub btnReplaceEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnReplaceEntry.Click

        ' Change to replace mode
        _InsertEntry = False
        _UpdateInputControlsStatus(False)
        _UpdateEntryListControlsStatus(False)
        _UpdateSelectedEntryControlsStatus(True)
        txtSelectedEntry.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click

        ' Create a new separated list for the information entered and refresh the display
        If rbtCSharpSeparatedList.Checked Then
            _cSharp_SeparatedList = New cSharp_SeparatedList(txtFromString.Text)
        Else
            _vb_SeparatedList = New vb_SeparatedList.vb_SeparatedList(txtFromString.Text)
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
    End Sub

    Private Sub rbtCSharpSeparatedList_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtCSharpSeparatedList.CheckedChanged
        _refresh()
    End Sub

    Private Sub rbtVBSeparatedList_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtVBSeparatedList.CheckedChanged
        _refresh()
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
        _updateInputControlsStatus(True)
        _updateEntryListControlsStatus(enableEntryListControls)
        _updateSelectedEntryControlsStatus(False)

        ' Selected the required list entry
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

    Private Sub _updateInputControlsStatus(enableInputControls As Boolean)

        ' Update the status of the input controls
        gbxInput.Enabled = enableInputControls
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
#End Region
End Class

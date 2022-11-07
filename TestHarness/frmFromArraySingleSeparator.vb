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
    Private m_bolInsert As Boolean
    'Private m_slsList As vbSeparatedList = Nothing
    Private m_slsList As cSharp_SeparatedList = Nothing
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
        m_Refresh()
        Me.Focus()
    End Sub

    Private Sub btnCancelEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelEntry.Click

        ' Cancel entry
        txtSelectedEntry.Text = String.Empty
        m_Refresh(lbxEntries.SelectedIndex)
        lbxEntries.Focus()
    End Sub

    Private Sub btnCancelString_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelString.Click

        ' Cancel entry
        txtSelectedString.Text = String.Empty
        m_UpdateSeparatedListControlsStatus(True)
        m_UpdateStringListControlsStatus(True)
        m_UpdateSelectedStringControlsStatus(False)
        lbxStrings.Focus()
    End Sub

    Private Sub btnConfirmEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmEntry.Click

        ' Add a new or replace the existing entry
        Dim intSelectedIndex = lbxEntries.SelectedIndex

        If m_bolInsert Then
            If intSelectedIndex < 0 Then
                m_slsList.Entries.Add(txtSelectedEntry.Text)
                intSelectedIndex = lbxEntries.Items.Count
            Else
                m_slsList.Entries.Insert(intSelectedIndex, txtSelectedEntry.Text)
            End If
        Else
            m_slsList.Entries(intSelectedIndex) = txtSelectedEntry.Text
        End If

        m_Refresh(intSelectedIndex)
        lbxEntries.Focus()
    End Sub

    Private Sub btnConfirmString_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmString.Click

        ' Add a new or replace the existing entry
        Dim intSelectedIndex = lbxStrings.SelectedIndex

        If m_bolInsert Then
            If intSelectedIndex < 0 Then
                intSelectedIndex = lbxStrings.Items.Add(txtSelectedString.Text)
            Else
                lbxStrings.Items.Insert(intSelectedIndex, txtSelectedString.Text)
            End If
        Else
            lbxStrings.Items(intSelectedIndex) = txtSelectedString.Text
        End If

        m_UpdateSeparatedListControlsStatus(True)
        m_UpdateStringListControlsStatus(True)
        m_UpdateSelectedStringControlsStatus(False)
        lbxStrings.Focus()
    End Sub

    Private Sub btnInsertEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertEntry.Click

        ' Change to insert mode
        txtSelectedEntry.Text = String.Empty
        m_bolInsert = True
        m_UpdateInputControlsStatus(False)
        m_UpdateEntryListControlsStatus(False)
        m_UpdateSelectedEntryControlsStatus(True)
        txtSelectedEntry.Focus()
    End Sub

    Private Sub btnInsertString_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertString.Click

        ' Change to insert mode
        txtSelectedString.Text = String.Empty
        m_bolInsert = True
        m_UpdateSeparatedListControlsStatus(False)
        m_UpdateStringListControlsStatus(False)
        m_UpdateSelectedStringControlsStatus(True)
        txtSelectedString.Focus()
    End Sub

    Private Sub btnRemoveEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveEntry.Click

        ' Removed the selected entry
        m_slsList.Entries.RemoveAt(lbxEntries.SelectedIndex)
        m_Refresh()
    End Sub

    Private Sub btnRemoveString_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveString.Click

        ' Removed the selected entry
        lbxStrings.Items.RemoveAt(lbxStrings.SelectedIndex)
        m_UpdateStringListControlsStatus(True)
        lbxStrings.Focus()
    End Sub

    Private Sub btnReplaceEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnReplaceEntry.Click

        ' Change to replace mode
        m_bolInsert = False
        m_UpdateInputControlsStatus(False)
        m_UpdateEntryListControlsStatus(False)
        m_UpdateSelectedEntryControlsStatus(True)
        txtSelectedEntry.Focus()
    End Sub

    Private Sub btnReplaceString_Click(sender As System.Object, e As System.EventArgs) Handles btnReplaceString.Click

        ' Change to replace mode
        m_bolInsert = False
        m_UpdateSeparatedListControlsStatus(False)
        m_UpdateStringListControlsStatus(False)
        m_UpdateSelectedStringControlsStatus(True)
        txtSelectedString.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click

        ' Create a new separated list for the information entered and refresh the display
        Dim strEntries As String()
        ReDim strEntries(lbxStrings.Items.Count - 1)
        lbxStrings.Items.CopyTo(strEntries, 0)
        Dim chrSeparator As Char = CChar(txtStringSeparator.Text)
        'm_slsList = New vbSeparatedList(chrSeparator, strEntries)
        m_slsList = New cSharp_SeparatedList(chrSeparator, strEntries)
        m_Refresh()
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
        Dim bolSelectedItem As Boolean = lbxEntries.SelectedIndex >= 0

        If bolSelectedItem Then
            txtSelectedEntry.Text = lbxEntries.SelectedItem.ToString()
        Else
            txtSelectedEntry.Text = String.Empty
        End If

        ' Enable the appropriate form controls
        m_UpdateEntryListControlsStatus(True)
        m_UpdateSelectedEntryControlsStatus(False)
    End Sub

    Private Sub lbxStrings_DoubleClick(sender As Object, e As System.EventArgs) Handles lbxStrings.DoubleClick

        ' Simulate the replace string button click
        If btnReplaceString.Enabled Then
            btnReplaceString_Click(sender, e)
        End If
    End Sub

    Private Sub lbxStrings_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbxStrings.SelectedIndexChanged

        ' Update the selected entry information
        Dim bolSelectedItem As Boolean = lbxStrings.SelectedIndex >= 0

        If bolSelectedItem Then
            txtSelectedString.Text = lbxStrings.SelectedItem.ToString()
        Else
            txtSelectedString.Text = String.Empty
        End If

        ' Enable the appropriate form controls
        m_UpdateStringListControlsStatus(True)
        m_UpdateSelectedStringControlsStatus(False)
    End Sub

    Private Sub m_Refresh(Optional intSelectedIndex As Int32 = -1)

        ' Reset the form data from the current list
        lbxEntries.Items.Clear()
        Dim bolEnable As Boolean = m_slsList IsNot Nothing

        If Not bolEnable Then
            txtStringSeparator.Text = String.Empty
            lbxStrings.Items.Clear()
            txtSeparator.Text = String.Empty
            txtUnusedSeparators.Text = String.Empty
            txtToString.Text = String.Empty
        Else
            txtSeparator.Text = m_slsList.Separator
            lbxEntries.Items.AddRange(m_slsList.Entries.ToArray())
            txtUnusedSeparators.Text = m_slsList.UnusedSeparators.ToArray()
            txtToString.Text = m_slsList.ToString
            lbxEntries.Focus()
        End If

        ' Enable the appropriate form controls
        m_UpdateInputControlsStatus(True)
        m_UpdateStringListControlsStatus(True)
        m_UpdateSelectedStringControlsStatus(False)
        m_UpdateSeparatedListControlsStatus(True)
        m_UpdateEntryListControlsStatus(bolEnable)
        m_UpdateSelectedEntryControlsStatus(False)

        If intSelectedIndex >= 0 Then
            lbxEntries.SelectedIndex = intSelectedIndex
        Else
            txtSelectedEntry.Text = String.Empty
        End If
    End Sub

    Private Sub m_UpdateEntryListControlsStatus(bolEnable As Boolean)

        ' Update the status of the entry list controls
        lbxEntries.Enabled = bolEnable
        btnInsertEntry.Enabled = lbxEntries.Enabled
        btnRemoveEntry.Enabled = lbxEntries.Enabled AndAlso lbxEntries.SelectedIndex >= 0
        btnReplaceEntry.Enabled = btnRemoveEntry.Enabled
    End Sub

    Private Sub m_UpdateInputControlsStatus(bolEnable As Boolean)

        ' Update the status of the input controls
        gbxInput.Enabled = bolEnable
    End Sub

    Private Sub m_UpdateSelectedEntryControlsStatus(bolEnable As Boolean)

        ' Update the status of the selected entry controls
        txtSelectedEntry.Enabled = bolEnable
        btnConfirmEntry.Enabled = txtSelectedEntry.Enabled
        btnCancelEntry.Enabled = btnConfirmEntry.Enabled

        ' Update the default accept and cancel buttons for the form
        If bolEnable Then
            Me.AcceptButton = btnConfirmEntry
            Me.CancelButton = btnCancelEntry
        Else
            Me.AcceptButton = btnSubmit
            Me.CancelButton = Nothing
        End If
    End Sub

    Private Sub m_UpdateSelectedStringControlsStatus(bolEnable As Boolean)

        ' Update the status of the selected string controls
        txtSelectedString.Enabled = bolEnable
        btnConfirmString.Enabled = txtSelectedString.Enabled
        btnCancelString.Enabled = btnConfirmString.Enabled

        ' Update the default accept and cancel buttons for the form
        If bolEnable Then
            Me.AcceptButton = btnConfirmString
            Me.CancelButton = btnCancelString
        Else
            Me.AcceptButton = btnSubmit
            Me.CancelButton = Nothing
        End If
    End Sub

    Private Sub m_UpdateSeparatedListControlsStatus(bolEnable As Boolean)

        ' Update the status of the separated list controls
        gbxSeparatedList.Enabled = bolEnable
    End Sub

    Private Sub m_UpdateStringListControlsStatus(bolEnable As Boolean)

        ' Update the status of the string list controls
        lbxStrings.Enabled = bolEnable
        btnInsertString.Enabled = lbxStrings.Enabled
        btnRemoveString.Enabled = lbxStrings.Enabled AndAlso lbxStrings.SelectedIndex >= 0
        btnReplaceString.Enabled = btnRemoveString.Enabled
    End Sub

    Private Sub txtStringSeparator_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtStringSeparator.TextChanged

        ' Ensure only 1 separator character can be specified
        If Len(txtStringSeparator.Text) > 1 Then
            txtStringSeparator.Text = txtStringSeparator.Text(txtStringSeparator.Text.Length - 1)
        End If
    End Sub
#End Region
End Class

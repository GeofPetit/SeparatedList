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

    Private Sub btnConfirmEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmEntry.Click

        ' Insert a new or replace the existing entry
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

    Private Sub btnInsertEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnInsertEntry.Click

        ' Change to insert mode
        txtSelectedEntry.Text = String.Empty
        m_bolInsert = True
        m_UpdateInputControlsStatus(False)
        m_UpdateEntryListControlsStatus(False)
        m_UpdateSelectedEntryControlsStatus(True)
        txtSelectedEntry.Focus()
    End Sub

    Private Sub btnRemoveEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveEntry.Click

        ' Removed the selected entry
        m_slsList.Entries.RemoveAt(lbxEntries.SelectedIndex)
        m_Refresh()
    End Sub

    Private Sub btnReplaceEntry_Click(sender As System.Object, e As System.EventArgs) Handles btnReplaceEntry.Click

        ' Change to replace mode
        m_bolInsert = False
        m_UpdateInputControlsStatus(False)
        m_UpdateEntryListControlsStatus(False)
        m_UpdateSelectedEntryControlsStatus(True)
        txtSelectedEntry.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click

        ' Create a new separated list for the information entered and refresh the display
        'm_slsList = New vbSeparatedList(txtFromString.Text)
        m_slsList = New cSharp_SeparatedList(txtFromString.Text)
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
    End Sub

    Private Sub m_Refresh(Optional intSelectedIndex As Int32 = -1)

        ' Reset the form data from the current list
        lbxEntries.Items.Clear()
        Dim bolEnable As Boolean = m_slsList IsNot Nothing

        If Not bolEnable Then
            txtFromString.Text = String.Empty
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
        m_UpdateEntryListControlsStatus(bolEnable)
        m_UpdateSelectedEntryControlsStatus(False)

        ' Selected the required list entry
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
#End Region
End Class

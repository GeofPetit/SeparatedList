'******************************************************************************************************************************************
'*                                                                                                                                        *
'*  Description:                                                                                                                          *
'*                                                                                                                                        *
'*  Test harness to demonstrate the SeparatedList class                                                                                   *
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

Public Class frmTestHarness

#Region "Private Variables"
    '*******************************************************************************************************************************
    '* Private variables                                                                                                           *
    '*******************************************************************************************************************************
    Private _frmFromArrayChooseSeparator As frmFromArrayChooseSeparator
    Private _frmFromArraySingleSeparator As frmFromArraySingleSeparator
    Private _frmFromString As frmFromString
#End Region

#Region "Private Methods"
    '*******************************************************************************************************************************
    '* Private methods                                                                                                             *
    '*******************************************************************************************************************************
    Private Sub frmTestHarness_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rbxReadMe.LoadFile("../../../readme.md", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub btnFromString_Click(sender As System.Object, e As System.EventArgs) Handles btnFromString.Click

        ' Create a new instance of the the form if required
        If _frmFromString Is Nothing OrElse _frmFromString.IsDisposed Then
            _frmFromString = New frmFromString()
        End If

        ' Display the form
        _showForm(_frmFromString)
    End Sub

    Private Sub btnFromArraySingleSeparator_Click(sender As System.Object, e As System.EventArgs) Handles btnFromArraySingleSeparator.Click

        ' Create a new instance of the the form if required
        If _frmFromArraySingleSeparator Is Nothing OrElse _frmFromArraySingleSeparator.IsDisposed Then
            _frmFromArraySingleSeparator = New frmFromArraySingleSeparator()
        End If

        ' Display the form
        _showForm(_frmFromArraySingleSeparator)
    End Sub

    Private Sub btnFromArrayChooseSeparator_Click(sender As System.Object, e As System.EventArgs) Handles btnFromArrayChooseSeparator.Click

        ' Create a new instance of the the form if required
        If _frmFromArrayChooseSeparator Is Nothing OrElse _frmFromArrayChooseSeparator.IsDisposed Then
            _frmFromArrayChooseSeparator = New frmFromArrayChooseSeparator()
        End If

        ' Display the form
        _showForm(_frmFromArrayChooseSeparator)
    End Sub

    Private Sub _showForm(frmForm As Form)

        ' Ensure the form is visible
        If Not frmForm.Visible Then
            frmForm.Show(Me)
        End If

        ' Give focus to the required form
        frmForm.Focus()
    End Sub
#End Region
End Class
'******************************************************************************************************************************************
'*                                                                                                                                        *
'*  Description:                                                                                                                          *
'*                                                                                                                                        *
'*  Test harness to demonstrate the cSeparatedList class                                                                                  *
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
    Private m_frmFromArrayChooseSeparator As frmFromArrayChooseSeparator
    Private m_frmFromArraySingleSeparator As frmFromArraySingleSeparator
    Private m_frmFromString As frmFromString
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
        If m_frmFromString Is Nothing OrElse m_frmFromString.IsDisposed Then
            m_frmFromString = New frmFromString()
        End If

        ' Display the form
        m_ShowForm(m_frmFromString)
    End Sub

    Private Sub btnFromArraySingleSeparator_Click(sender As System.Object, e As System.EventArgs) Handles btnFromArraySingleSeparator.Click

        ' Create a new instance of the the form if required
        If m_frmFromArraySingleSeparator Is Nothing OrElse m_frmFromArraySingleSeparator.IsDisposed Then
            m_frmFromArraySingleSeparator = New frmFromArraySingleSeparator()
        End If

        ' Display the form
        m_ShowForm(m_frmFromArraySingleSeparator)
    End Sub

    Private Sub btnFromArrayChooseSeparator_Click(sender As System.Object, e As System.EventArgs) Handles btnFromArrayChooseSeparator.Click

        ' Create a new instance of the the form if required
        If m_frmFromArrayChooseSeparator Is Nothing OrElse m_frmFromArrayChooseSeparator.IsDisposed Then
            m_frmFromArrayChooseSeparator = New frmFromArrayChooseSeparator()
        End If

        ' Display the form
        m_ShowForm(m_frmFromArrayChooseSeparator)
    End Sub

    Private Sub m_ShowForm(frmForm As Form)

        ' Ensure the form is visible
        If Not frmForm.Visible Then
            frmForm.Show(Me)
        End If

        ' Give focus to the required form
        frmForm.Focus()
    End Sub

#End Region
End Class
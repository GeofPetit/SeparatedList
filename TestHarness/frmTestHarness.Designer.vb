<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestHarness
    Inherits System.Windows.Forms.Form

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
        Me.btnFromString = New System.Windows.Forms.Button()
        Me.btnFromArrayChooseSeparator = New System.Windows.Forms.Button()
        Me.btnFromArraySingleSeparator = New System.Windows.Forms.Button()
        Me.tlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.rbxReadMe = New System.Windows.Forms.RichTextBox()
        Me.tlpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnFromString
        '
        Me.btnFromString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFromString.Location = New System.Drawing.Point(3, 3)
        Me.btnFromString.Name = "btnFromString"
        Me.btnFromString.Size = New System.Drawing.Size(1102, 23)
        Me.btnFromString.TabIndex = 0
        Me.btnFromString.Text = "From String"
        Me.btnFromString.UseVisualStyleBackColor = True
        '
        'btnFromArrayChooseSeparator
        '
        Me.btnFromArrayChooseSeparator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFromArrayChooseSeparator.Location = New System.Drawing.Point(3, 61)
        Me.btnFromArrayChooseSeparator.Name = "btnFromArrayChooseSeparator"
        Me.btnFromArrayChooseSeparator.Size = New System.Drawing.Size(1102, 23)
        Me.btnFromArrayChooseSeparator.TabIndex = 1
        Me.btnFromArrayChooseSeparator.Text = "From Array Choose Separator"
        Me.btnFromArrayChooseSeparator.UseVisualStyleBackColor = True
        '
        'btnFromArraySingleSeparator
        '
        Me.btnFromArraySingleSeparator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnFromArraySingleSeparator.Location = New System.Drawing.Point(3, 32)
        Me.btnFromArraySingleSeparator.Name = "btnFromArraySingleSeparator"
        Me.btnFromArraySingleSeparator.Size = New System.Drawing.Size(1102, 23)
        Me.btnFromArraySingleSeparator.TabIndex = 2
        Me.btnFromArraySingleSeparator.Text = "From Array Single Separator"
        Me.btnFromArraySingleSeparator.UseVisualStyleBackColor = True
        '
        'tlpMenu
        '
        Me.tlpMenu.AutoSize = True
        Me.tlpMenu.ColumnCount = 1
        Me.tlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMenu.Controls.Add(Me.rbxReadMe, 0, 3)
        Me.tlpMenu.Controls.Add(Me.btnFromString, 0, 0)
        Me.tlpMenu.Controls.Add(Me.btnFromArraySingleSeparator, 0, 1)
        Me.tlpMenu.Controls.Add(Me.btnFromArrayChooseSeparator, 0, 2)
        Me.tlpMenu.Location = New System.Drawing.Point(12, 12)
        Me.tlpMenu.Name = "tlpMenu"
        Me.tlpMenu.RowCount = 4
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMenu.Size = New System.Drawing.Size(1108, 898)
        Me.tlpMenu.TabIndex = 3
        '
        'rbxReadMe
        '
        Me.rbxReadMe.Location = New System.Drawing.Point(3, 90)
        Me.rbxReadMe.Name = "rbxReadMe"
        Me.rbxReadMe.ReadOnly = True
        Me.rbxReadMe.Size = New System.Drawing.Size(1102, 805)
        Me.rbxReadMe.TabIndex = 5
        Me.rbxReadMe.Text = ""
        '
        'frmTestHarness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 919)
        Me.Controls.Add(Me.tlpMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTestHarness"
        Me.Text = "frmTestHarness"
        Me.tlpMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFromString As System.Windows.Forms.Button
    Friend WithEvents btnFromArrayChooseSeparator As System.Windows.Forms.Button
    Friend WithEvents btnFromArraySingleSeparator As System.Windows.Forms.Button
    Friend WithEvents tlpMenu As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rbxReadMe As System.Windows.Forms.RichTextBox
End Class

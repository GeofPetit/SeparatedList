<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFromArraySingleSeparator
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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gbxInput = New System.Windows.Forms.GroupBox()
        Me.tlpInput = New System.Windows.Forms.TableLayoutPanel()
        Me.flpClass = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbtCSharpSeparatedList = New System.Windows.Forms.RadioButton()
        Me.rbtVBSeparatedList = New System.Windows.Forms.RadioButton()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.txtStringSeparator = New System.Windows.Forms.TextBox()
        Me.flpStringActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnConfirmString = New System.Windows.Forms.Button()
        Me.btnCancelString = New System.Windows.Forms.Button()
        Me.flpStringListActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnInsertString = New System.Windows.Forms.Button()
        Me.btnRemoveString = New System.Windows.Forms.Button()
        Me.btnReplaceString = New System.Windows.Forms.Button()
        Me.txtSelectedString = New System.Windows.Forms.TextBox()
        Me.lbxStrings = New System.Windows.Forms.ListBox()
        Me.lblSelectedString = New System.Windows.Forms.Label()
        Me.flpSubmit = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblStringSeparator = New System.Windows.Forms.Label()
        Me.lblStrings = New System.Windows.Forms.Label()
        Me.gbxSeparatedList = New System.Windows.Forms.GroupBox()
        Me.tlpSeparatedList = New System.Windows.Forms.TableLayoutPanel()
        Me.txtUnusedSeparators = New System.Windows.Forms.TextBox()
        Me.lblUnusedSeparators = New System.Windows.Forms.Label()
        Me.lbxEntries = New System.Windows.Forms.ListBox()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblSelectedEntry = New System.Windows.Forms.Label()
        Me.txtSelectedEntry = New System.Windows.Forms.TextBox()
        Me.lblEntries = New System.Windows.Forms.Label()
        Me.flpEntryActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnConfirmEntry = New System.Windows.Forms.Button()
        Me.btnCancelEntry = New System.Windows.Forms.Button()
        Me.flpEntryListActions = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnInsertEntry = New System.Windows.Forms.Button()
        Me.btnRemoveEntry = New System.Windows.Forms.Button()
        Me.btnReplaceEntry = New System.Windows.Forms.Button()
        Me.txtSeparator = New System.Windows.Forms.TextBox()
        Me.gbxOutput = New System.Windows.Forms.GroupBox()
        Me.tlpOutput = New System.Windows.Forms.TableLayoutPanel()
        Me.lblToString = New System.Windows.Forms.Label()
        Me.txtToString = New System.Windows.Forms.TextBox()
        Me.tlpMain.SuspendLayout()
        Me.gbxInput.SuspendLayout()
        Me.tlpInput.SuspendLayout()
        Me.flpClass.SuspendLayout()
        Me.flpStringActions.SuspendLayout()
        Me.flpStringListActions.SuspendLayout()
        Me.flpSubmit.SuspendLayout()
        Me.gbxSeparatedList.SuspendLayout()
        Me.tlpSeparatedList.SuspendLayout()
        Me.flpEntryActions.SuspendLayout()
        Me.flpEntryListActions.SuspendLayout()
        Me.gbxOutput.SuspendLayout()
        Me.tlpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.AutoSize = True
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.Controls.Add(Me.gbxInput, 0, 0)
        Me.tlpMain.Controls.Add(Me.gbxSeparatedList, 0, 1)
        Me.tlpMain.Controls.Add(Me.gbxOutput, 0, 2)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.Size = New System.Drawing.Size(601, 669)
        Me.tlpMain.TabIndex = 0
        '
        'gbxInput
        '
        Me.gbxInput.AutoSize = True
        Me.gbxInput.Controls.Add(Me.tlpInput)
        Me.gbxInput.Location = New System.Drawing.Point(3, 3)
        Me.gbxInput.Name = "gbxInput"
        Me.gbxInput.Size = New System.Drawing.Size(594, 265)
        Me.gbxInput.TabIndex = 0
        Me.gbxInput.TabStop = False
        Me.gbxInput.Text = "Input"
        '
        'tlpInput
        '
        Me.tlpInput.AutoSize = True
        Me.tlpInput.ColumnCount = 3
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tlpInput.Controls.Add(Me.flpClass, 1, 0)
        Me.tlpInput.Controls.Add(Me.lblClass, 0, 0)
        Me.tlpInput.Controls.Add(Me.txtStringSeparator, 1, 1)
        Me.tlpInput.Controls.Add(Me.flpStringActions, 2, 3)
        Me.tlpInput.Controls.Add(Me.flpStringListActions, 2, 2)
        Me.tlpInput.Controls.Add(Me.txtSelectedString, 1, 3)
        Me.tlpInput.Controls.Add(Me.lbxStrings, 1, 2)
        Me.tlpInput.Controls.Add(Me.lblSelectedString, 0, 3)
        Me.tlpInput.Controls.Add(Me.flpSubmit, 2, 0)
        Me.tlpInput.Controls.Add(Me.lblStringSeparator, 0, 1)
        Me.tlpInput.Controls.Add(Me.lblStrings, 0, 2)
        Me.tlpInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInput.Location = New System.Drawing.Point(3, 16)
        Me.tlpInput.Name = "tlpInput"
        Me.tlpInput.RowCount = 4
        Me.tlpInput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpInput.Size = New System.Drawing.Size(588, 246)
        Me.tlpInput.TabIndex = 0
        '
        'flpClass
        '
        Me.flpClass.AutoSize = True
        Me.flpClass.Controls.Add(Me.rbtCSharpSeparatedList)
        Me.flpClass.Controls.Add(Me.rbtVBSeparatedList)
        Me.flpClass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpClass.Location = New System.Drawing.Point(88, 3)
        Me.flpClass.Name = "flpClass"
        Me.flpClass.Size = New System.Drawing.Size(412, 29)
        Me.flpClass.TabIndex = 1
        '
        'rbtCSharpSeparatedList
        '
        Me.rbtCSharpSeparatedList.AutoSize = True
        Me.rbtCSharpSeparatedList.Checked = True
        Me.rbtCSharpSeparatedList.Location = New System.Drawing.Point(3, 3)
        Me.rbtCSharpSeparatedList.Name = "rbtCSharpSeparatedList"
        Me.rbtCSharpSeparatedList.Size = New System.Drawing.Size(130, 17)
        Me.rbtCSharpSeparatedList.TabIndex = 0
        Me.rbtCSharpSeparatedList.TabStop = True
        Me.rbtCSharpSeparatedList.Text = "cSharp_SeparatedList"
        Me.rbtCSharpSeparatedList.UseVisualStyleBackColor = True
        '
        'rbtVBSeparatedList
        '
        Me.rbtVBSeparatedList.AutoSize = True
        Me.rbtVBSeparatedList.Location = New System.Drawing.Point(139, 3)
        Me.rbtVBSeparatedList.Name = "rbtVBSeparatedList"
        Me.rbtVBSeparatedList.Size = New System.Drawing.Size(108, 17)
        Me.rbtVBSeparatedList.TabIndex = 1
        Me.rbtVBSeparatedList.Text = "vb_SeparatedList"
        Me.rbtVBSeparatedList.UseVisualStyleBackColor = True
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(3, 0)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(38, 13)
        Me.lblClass.TabIndex = 0
        Me.lblClass.Text = "Class :"
        '
        'txtStringSeparator
        '
        Me.txtStringSeparator.Location = New System.Drawing.Point(88, 38)
        Me.txtStringSeparator.Name = "txtStringSeparator"
        Me.txtStringSeparator.Size = New System.Drawing.Size(21, 20)
        Me.txtStringSeparator.TabIndex = 4
        '
        'flpStringActions
        '
        Me.flpStringActions.AutoSize = True
        Me.flpStringActions.Controls.Add(Me.btnConfirmString)
        Me.flpStringActions.Controls.Add(Me.btnCancelString)
        Me.flpStringActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpStringActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpStringActions.Location = New System.Drawing.Point(506, 185)
        Me.flpStringActions.Name = "flpStringActions"
        Me.flpStringActions.Size = New System.Drawing.Size(79, 58)
        Me.flpStringActions.TabIndex = 10
        '
        'btnConfirmString
        '
        Me.btnConfirmString.Enabled = False
        Me.btnConfirmString.Location = New System.Drawing.Point(3, 3)
        Me.btnConfirmString.Name = "btnConfirmString"
        Me.btnConfirmString.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmString.TabIndex = 6
        Me.btnConfirmString.Text = "Confirm"
        Me.btnConfirmString.UseVisualStyleBackColor = True
        '
        'btnCancelString
        '
        Me.btnCancelString.Enabled = False
        Me.btnCancelString.Location = New System.Drawing.Point(3, 32)
        Me.btnCancelString.Name = "btnCancelString"
        Me.btnCancelString.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelString.TabIndex = 7
        Me.btnCancelString.Text = "Cancel"
        Me.btnCancelString.UseVisualStyleBackColor = True
        '
        'flpStringListActions
        '
        Me.flpStringListActions.AutoSize = True
        Me.flpStringListActions.Controls.Add(Me.btnInsertString)
        Me.flpStringListActions.Controls.Add(Me.btnRemoveString)
        Me.flpStringListActions.Controls.Add(Me.btnReplaceString)
        Me.flpStringListActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpStringListActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpStringListActions.Location = New System.Drawing.Point(506, 64)
        Me.flpStringListActions.Name = "flpStringListActions"
        Me.flpStringListActions.Size = New System.Drawing.Size(79, 115)
        Me.flpStringListActions.TabIndex = 7
        '
        'btnInsertString
        '
        Me.btnInsertString.Location = New System.Drawing.Point(3, 3)
        Me.btnInsertString.Name = "btnInsertString"
        Me.btnInsertString.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertString.TabIndex = 1
        Me.btnInsertString.Text = "Insert"
        Me.btnInsertString.UseVisualStyleBackColor = True
        '
        'btnRemoveString
        '
        Me.btnRemoveString.Enabled = False
        Me.btnRemoveString.Location = New System.Drawing.Point(3, 32)
        Me.btnRemoveString.Name = "btnRemoveString"
        Me.btnRemoveString.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveString.TabIndex = 2
        Me.btnRemoveString.Text = "Remove"
        Me.btnRemoveString.UseVisualStyleBackColor = True
        '
        'btnReplaceString
        '
        Me.btnReplaceString.Enabled = False
        Me.btnReplaceString.Location = New System.Drawing.Point(3, 61)
        Me.btnReplaceString.Name = "btnReplaceString"
        Me.btnReplaceString.Size = New System.Drawing.Size(75, 23)
        Me.btnReplaceString.TabIndex = 3
        Me.btnReplaceString.Text = "Replace"
        Me.btnReplaceString.UseVisualStyleBackColor = True
        '
        'txtSelectedString
        '
        Me.txtSelectedString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSelectedString.Enabled = False
        Me.txtSelectedString.Location = New System.Drawing.Point(88, 185)
        Me.txtSelectedString.Multiline = True
        Me.txtSelectedString.Name = "txtSelectedString"
        Me.txtSelectedString.Size = New System.Drawing.Size(412, 58)
        Me.txtSelectedString.TabIndex = 9
        '
        'lbxStrings
        '
        Me.lbxStrings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxStrings.FormattingEnabled = True
        Me.lbxStrings.Location = New System.Drawing.Point(88, 64)
        Me.lbxStrings.Name = "lbxStrings"
        Me.lbxStrings.Size = New System.Drawing.Size(412, 115)
        Me.lbxStrings.TabIndex = 6
        '
        'lblSelectedString
        '
        Me.lblSelectedString.AutoSize = True
        Me.lblSelectedString.Location = New System.Drawing.Point(3, 182)
        Me.lblSelectedString.Name = "lblSelectedString"
        Me.lblSelectedString.Size = New System.Drawing.Size(55, 13)
        Me.lblSelectedString.TabIndex = 8
        Me.lblSelectedString.Text = "Selected :"
        '
        'flpSubmit
        '
        Me.flpSubmit.AutoSize = True
        Me.flpSubmit.Controls.Add(Me.btnSubmit)
        Me.flpSubmit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpSubmit.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpSubmit.Location = New System.Drawing.Point(506, 3)
        Me.flpSubmit.Name = "flpSubmit"
        Me.flpSubmit.Size = New System.Drawing.Size(79, 29)
        Me.flpSubmit.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(3, 3)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblStringSeparator
        '
        Me.lblStringSeparator.AutoSize = True
        Me.lblStringSeparator.Location = New System.Drawing.Point(3, 35)
        Me.lblStringSeparator.Name = "lblStringSeparator"
        Me.lblStringSeparator.Size = New System.Drawing.Size(59, 13)
        Me.lblStringSeparator.TabIndex = 3
        Me.lblStringSeparator.Text = "Separator :"
        '
        'lblStrings
        '
        Me.lblStrings.AutoSize = True
        Me.lblStrings.Location = New System.Drawing.Point(3, 61)
        Me.lblStrings.Name = "lblStrings"
        Me.lblStrings.Size = New System.Drawing.Size(45, 13)
        Me.lblStrings.TabIndex = 5
        Me.lblStrings.Text = "Strings :"
        '
        'gbxSeparatedList
        '
        Me.gbxSeparatedList.AutoSize = True
        Me.gbxSeparatedList.Controls.Add(Me.tlpSeparatedList)
        Me.gbxSeparatedList.Location = New System.Drawing.Point(3, 274)
        Me.gbxSeparatedList.Name = "gbxSeparatedList"
        Me.gbxSeparatedList.Size = New System.Drawing.Size(594, 257)
        Me.gbxSeparatedList.TabIndex = 1
        Me.gbxSeparatedList.TabStop = False
        Me.gbxSeparatedList.Text = "Separated List"
        '
        'tlpSeparatedList
        '
        Me.tlpSeparatedList.AutoSize = True
        Me.tlpSeparatedList.ColumnCount = 3
        Me.tlpSeparatedList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tlpSeparatedList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSeparatedList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tlpSeparatedList.Controls.Add(Me.txtUnusedSeparators, 1, 3)
        Me.tlpSeparatedList.Controls.Add(Me.lblUnusedSeparators, 0, 3)
        Me.tlpSeparatedList.Controls.Add(Me.lbxEntries, 1, 1)
        Me.tlpSeparatedList.Controls.Add(Me.lblSeparator, 0, 0)
        Me.tlpSeparatedList.Controls.Add(Me.lblSelectedEntry, 0, 2)
        Me.tlpSeparatedList.Controls.Add(Me.txtSelectedEntry, 1, 2)
        Me.tlpSeparatedList.Controls.Add(Me.lblEntries, 0, 1)
        Me.tlpSeparatedList.Controls.Add(Me.flpEntryActions, 2, 2)
        Me.tlpSeparatedList.Controls.Add(Me.flpEntryListActions, 2, 1)
        Me.tlpSeparatedList.Controls.Add(Me.txtSeparator, 1, 0)
        Me.tlpSeparatedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSeparatedList.Location = New System.Drawing.Point(3, 16)
        Me.tlpSeparatedList.Name = "tlpSeparatedList"
        Me.tlpSeparatedList.RowCount = 4
        Me.tlpSeparatedList.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSeparatedList.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSeparatedList.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSeparatedList.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSeparatedList.Size = New System.Drawing.Size(588, 238)
        Me.tlpSeparatedList.TabIndex = 0
        '
        'txtUnusedSeparators
        '
        Me.txtUnusedSeparators.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUnusedSeparators.Enabled = False
        Me.txtUnusedSeparators.Location = New System.Drawing.Point(88, 215)
        Me.txtUnusedSeparators.Name = "txtUnusedSeparators"
        Me.txtUnusedSeparators.ReadOnly = True
        Me.txtUnusedSeparators.Size = New System.Drawing.Size(412, 20)
        Me.txtUnusedSeparators.TabIndex = 10
        '
        'lblUnusedSeparators
        '
        Me.lblUnusedSeparators.AutoSize = True
        Me.lblUnusedSeparators.Location = New System.Drawing.Point(3, 212)
        Me.lblUnusedSeparators.Name = "lblUnusedSeparators"
        Me.lblUnusedSeparators.Size = New System.Drawing.Size(50, 13)
        Me.lblUnusedSeparators.TabIndex = 9
        Me.lblUnusedSeparators.Text = "Unused :"
        '
        'lbxEntries
        '
        Me.lbxEntries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxEntries.Enabled = False
        Me.lbxEntries.FormattingEnabled = True
        Me.lbxEntries.Location = New System.Drawing.Point(88, 29)
        Me.lbxEntries.Name = "lbxEntries"
        Me.lbxEntries.Size = New System.Drawing.Size(412, 116)
        Me.lbxEntries.TabIndex = 3
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(3, 0)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(59, 13)
        Me.lblSeparator.TabIndex = 0
        Me.lblSeparator.Text = "Separator :"
        '
        'lblSelectedEntry
        '
        Me.lblSelectedEntry.AutoSize = True
        Me.lblSelectedEntry.Location = New System.Drawing.Point(3, 148)
        Me.lblSelectedEntry.Name = "lblSelectedEntry"
        Me.lblSelectedEntry.Size = New System.Drawing.Size(55, 13)
        Me.lblSelectedEntry.TabIndex = 5
        Me.lblSelectedEntry.Text = "Selected :"
        '
        'txtSelectedEntry
        '
        Me.txtSelectedEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSelectedEntry.Enabled = False
        Me.txtSelectedEntry.Location = New System.Drawing.Point(88, 151)
        Me.txtSelectedEntry.Multiline = True
        Me.txtSelectedEntry.Name = "txtSelectedEntry"
        Me.txtSelectedEntry.Size = New System.Drawing.Size(412, 58)
        Me.txtSelectedEntry.TabIndex = 6
        '
        'lblEntries
        '
        Me.lblEntries.AutoSize = True
        Me.lblEntries.Location = New System.Drawing.Point(3, 26)
        Me.lblEntries.Name = "lblEntries"
        Me.lblEntries.Size = New System.Drawing.Size(45, 13)
        Me.lblEntries.TabIndex = 2
        Me.lblEntries.Text = "Entries :"
        '
        'flpEntryActions
        '
        Me.flpEntryActions.AutoSize = True
        Me.flpEntryActions.Controls.Add(Me.btnConfirmEntry)
        Me.flpEntryActions.Controls.Add(Me.btnCancelEntry)
        Me.flpEntryActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpEntryActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpEntryActions.Location = New System.Drawing.Point(506, 151)
        Me.flpEntryActions.Name = "flpEntryActions"
        Me.flpEntryActions.Size = New System.Drawing.Size(79, 58)
        Me.flpEntryActions.TabIndex = 7
        '
        'btnConfirmEntry
        '
        Me.btnConfirmEntry.Enabled = False
        Me.btnConfirmEntry.Location = New System.Drawing.Point(3, 3)
        Me.btnConfirmEntry.Name = "btnConfirmEntry"
        Me.btnConfirmEntry.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmEntry.TabIndex = 6
        Me.btnConfirmEntry.Text = "Confirm"
        Me.btnConfirmEntry.UseVisualStyleBackColor = True
        '
        'btnCancelEntry
        '
        Me.btnCancelEntry.Enabled = False
        Me.btnCancelEntry.Location = New System.Drawing.Point(3, 32)
        Me.btnCancelEntry.Name = "btnCancelEntry"
        Me.btnCancelEntry.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelEntry.TabIndex = 7
        Me.btnCancelEntry.Text = "Cancel"
        Me.btnCancelEntry.UseVisualStyleBackColor = True
        '
        'flpEntryListActions
        '
        Me.flpEntryListActions.AutoSize = True
        Me.flpEntryListActions.Controls.Add(Me.btnInsertEntry)
        Me.flpEntryListActions.Controls.Add(Me.btnRemoveEntry)
        Me.flpEntryListActions.Controls.Add(Me.btnReplaceEntry)
        Me.flpEntryListActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpEntryListActions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpEntryListActions.Location = New System.Drawing.Point(506, 29)
        Me.flpEntryListActions.Name = "flpEntryListActions"
        Me.flpEntryListActions.Size = New System.Drawing.Size(79, 116)
        Me.flpEntryListActions.TabIndex = 4
        '
        'btnInsertEntry
        '
        Me.btnInsertEntry.Enabled = False
        Me.btnInsertEntry.Location = New System.Drawing.Point(3, 3)
        Me.btnInsertEntry.Name = "btnInsertEntry"
        Me.btnInsertEntry.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertEntry.TabIndex = 1
        Me.btnInsertEntry.Text = "Insert"
        Me.btnInsertEntry.UseVisualStyleBackColor = True
        '
        'btnRemoveEntry
        '
        Me.btnRemoveEntry.Enabled = False
        Me.btnRemoveEntry.Location = New System.Drawing.Point(3, 32)
        Me.btnRemoveEntry.Name = "btnRemoveEntry"
        Me.btnRemoveEntry.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveEntry.TabIndex = 2
        Me.btnRemoveEntry.Text = "Remove"
        Me.btnRemoveEntry.UseVisualStyleBackColor = True
        '
        'btnReplaceEntry
        '
        Me.btnReplaceEntry.Enabled = False
        Me.btnReplaceEntry.Location = New System.Drawing.Point(3, 61)
        Me.btnReplaceEntry.Name = "btnReplaceEntry"
        Me.btnReplaceEntry.Size = New System.Drawing.Size(75, 23)
        Me.btnReplaceEntry.TabIndex = 3
        Me.btnReplaceEntry.Text = "Replace"
        Me.btnReplaceEntry.UseVisualStyleBackColor = True
        '
        'txtSeparator
        '
        Me.txtSeparator.Enabled = False
        Me.txtSeparator.Location = New System.Drawing.Point(88, 3)
        Me.txtSeparator.Name = "txtSeparator"
        Me.txtSeparator.Size = New System.Drawing.Size(52, 20)
        Me.txtSeparator.TabIndex = 1
        '
        'gbxOutput
        '
        Me.gbxOutput.AutoSize = True
        Me.gbxOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbxOutput.Controls.Add(Me.tlpOutput)
        Me.gbxOutput.Location = New System.Drawing.Point(3, 537)
        Me.gbxOutput.Name = "gbxOutput"
        Me.gbxOutput.Size = New System.Drawing.Size(594, 128)
        Me.gbxOutput.TabIndex = 2
        Me.gbxOutput.TabStop = False
        Me.gbxOutput.Text = "Output"
        '
        'tlpOutput
        '
        Me.tlpOutput.AutoSize = True
        Me.tlpOutput.ColumnCount = 3
        Me.tlpOutput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tlpOutput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpOutput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tlpOutput.Controls.Add(Me.lblToString, 0, 0)
        Me.tlpOutput.Controls.Add(Me.txtToString, 1, 0)
        Me.tlpOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOutput.Location = New System.Drawing.Point(3, 16)
        Me.tlpOutput.Name = "tlpOutput"
        Me.tlpOutput.RowCount = 1
        Me.tlpOutput.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpOutput.Size = New System.Drawing.Size(588, 109)
        Me.tlpOutput.TabIndex = 1
        '
        'lblToString
        '
        Me.lblToString.AutoSize = True
        Me.lblToString.Location = New System.Drawing.Point(3, 0)
        Me.lblToString.Name = "lblToString"
        Me.lblToString.Size = New System.Drawing.Size(56, 13)
        Me.lblToString.TabIndex = 0
        Me.lblToString.Text = "To String :"
        '
        'txtToString
        '
        Me.txtToString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtToString.Enabled = False
        Me.txtToString.Location = New System.Drawing.Point(88, 3)
        Me.txtToString.Multiline = True
        Me.txtToString.Name = "txtToString"
        Me.txtToString.Size = New System.Drawing.Size(412, 103)
        Me.txtToString.TabIndex = 1
        '
        'frmFromArraySingleSeparator
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 669)
        Me.Controls.Add(Me.tlpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFromArraySingleSeparator"
        Me.Text = "From Array Single Separator"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.gbxInput.ResumeLayout(False)
        Me.gbxInput.PerformLayout()
        Me.tlpInput.ResumeLayout(False)
        Me.tlpInput.PerformLayout()
        Me.flpClass.ResumeLayout(False)
        Me.flpClass.PerformLayout()
        Me.flpStringActions.ResumeLayout(False)
        Me.flpStringListActions.ResumeLayout(False)
        Me.flpSubmit.ResumeLayout(False)
        Me.gbxSeparatedList.ResumeLayout(False)
        Me.gbxSeparatedList.PerformLayout()
        Me.tlpSeparatedList.ResumeLayout(False)
        Me.tlpSeparatedList.PerformLayout()
        Me.flpEntryActions.ResumeLayout(False)
        Me.flpEntryListActions.ResumeLayout(False)
        Me.gbxOutput.ResumeLayout(False)
        Me.gbxOutput.PerformLayout()
        Me.tlpOutput.ResumeLayout(False)
        Me.tlpOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbxInput As System.Windows.Forms.GroupBox
    Friend WithEvents tlpInput As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents gbxSeparatedList As System.Windows.Forms.GroupBox
    Friend WithEvents gbxOutput As System.Windows.Forms.GroupBox
    Friend WithEvents tlpOutput As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblToString As System.Windows.Forms.Label
    Friend WithEvents txtToString As System.Windows.Forms.TextBox
    Friend WithEvents tlpSeparatedList As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents lbxEntries As System.Windows.Forms.ListBox
    Friend WithEvents lblSelectedEntry As System.Windows.Forms.Label
    Friend WithEvents txtSelectedEntry As System.Windows.Forms.TextBox
    Friend WithEvents flpEntryActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnConfirmEntry As System.Windows.Forms.Button
    Friend WithEvents btnCancelEntry As System.Windows.Forms.Button
    Friend WithEvents btnInsertEntry As System.Windows.Forms.Button
    Friend WithEvents btnRemoveEntry As System.Windows.Forms.Button
    Friend WithEvents btnReplaceEntry As System.Windows.Forms.Button
    Friend WithEvents lblEntries As System.Windows.Forms.Label
    Friend WithEvents flpEntryListActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtSeparator As System.Windows.Forms.TextBox
    Friend WithEvents flpSubmit As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents flpStringActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnConfirmString As System.Windows.Forms.Button
    Friend WithEvents btnCancelString As System.Windows.Forms.Button
    Friend WithEvents flpStringListActions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnInsertString As System.Windows.Forms.Button
    Friend WithEvents btnRemoveString As System.Windows.Forms.Button
    Friend WithEvents btnReplaceString As System.Windows.Forms.Button
    Friend WithEvents txtSelectedString As System.Windows.Forms.TextBox
    Friend WithEvents lbxStrings As System.Windows.Forms.ListBox
    Friend WithEvents lblSelectedString As System.Windows.Forms.Label
    Friend WithEvents lblStringSeparator As System.Windows.Forms.Label
    Friend WithEvents lblStrings As System.Windows.Forms.Label
    Friend WithEvents txtStringSeparator As System.Windows.Forms.TextBox
    Friend WithEvents lblUnusedSeparators As System.Windows.Forms.Label
    Friend WithEvents txtUnusedSeparators As System.Windows.Forms.TextBox
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents flpClass As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents rbtCSharpSeparatedList As System.Windows.Forms.RadioButton
    Friend WithEvents rbtVBSeparatedList As System.Windows.Forms.RadioButton

End Class

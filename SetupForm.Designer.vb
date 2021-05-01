<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupForm))
        Me.NameListBox = New System.Windows.Forms.ListBox()
        Me.HourlyRateListBox = New System.Windows.Forms.ListBox()
        Me.FICARateListBox = New System.Windows.Forms.ListBox()
        Me.FederalRateListBox = New System.Windows.Forms.ListBox()
        Me.StateRateListBox = New System.Windows.Forms.ListBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.HourlyRateTextBox = New System.Windows.Forms.TextBox()
        Me.FICARateTextBox = New System.Windows.Forms.TextBox()
        Me.FederalRateTextBox = New System.Windows.Forms.TextBox()
        Me.StateRateTextBox = New System.Windows.Forms.TextBox()
        Me.DeleteEmployeeBtn = New System.Windows.Forms.Button()
        Me.ApplyChangesBtn = New System.Windows.Forms.Button()
        Me.AddNewEmployeeBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.CancelReturnBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.SaveReturnBtn = New System.Windows.Forms.Button()
        Me.ClearInputsBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameListBox
        '
        Me.NameListBox.FormattingEnabled = True
        Me.NameListBox.ItemHeight = 16
        Me.NameListBox.Location = New System.Drawing.Point(13, 13)
        Me.NameListBox.Name = "NameListBox"
        Me.NameListBox.Size = New System.Drawing.Size(150, 308)
        Me.NameListBox.TabIndex = 0
        '
        'HourlyRateListBox
        '
        Me.HourlyRateListBox.Enabled = False
        Me.HourlyRateListBox.FormattingEnabled = True
        Me.HourlyRateListBox.ItemHeight = 16
        Me.HourlyRateListBox.Location = New System.Drawing.Point(170, 12)
        Me.HourlyRateListBox.Name = "HourlyRateListBox"
        Me.HourlyRateListBox.Size = New System.Drawing.Size(150, 308)
        Me.HourlyRateListBox.TabIndex = 1
        '
        'FICARateListBox
        '
        Me.FICARateListBox.Enabled = False
        Me.FICARateListBox.FormattingEnabled = True
        Me.FICARateListBox.ItemHeight = 16
        Me.FICARateListBox.Location = New System.Drawing.Point(326, 12)
        Me.FICARateListBox.Name = "FICARateListBox"
        Me.FICARateListBox.Size = New System.Drawing.Size(150, 308)
        Me.FICARateListBox.TabIndex = 2
        '
        'FederalRateListBox
        '
        Me.FederalRateListBox.Enabled = False
        Me.FederalRateListBox.FormattingEnabled = True
        Me.FederalRateListBox.ItemHeight = 16
        Me.FederalRateListBox.Location = New System.Drawing.Point(482, 12)
        Me.FederalRateListBox.Name = "FederalRateListBox"
        Me.FederalRateListBox.Size = New System.Drawing.Size(150, 308)
        Me.FederalRateListBox.TabIndex = 3
        '
        'StateRateListBox
        '
        Me.StateRateListBox.Enabled = False
        Me.StateRateListBox.FormattingEnabled = True
        Me.StateRateListBox.ItemHeight = 16
        Me.StateRateListBox.Location = New System.Drawing.Point(638, 12)
        Me.StateRateListBox.Name = "StateRateListBox"
        Me.StateRateListBox.Size = New System.Drawing.Size(150, 308)
        Me.StateRateListBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(13, 357)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(150, 22)
        Me.NameTextBox.TabIndex = 5
        '
        'HourlyRateTextBox
        '
        Me.HourlyRateTextBox.Location = New System.Drawing.Point(170, 357)
        Me.HourlyRateTextBox.Name = "HourlyRateTextBox"
        Me.HourlyRateTextBox.Size = New System.Drawing.Size(150, 22)
        Me.HourlyRateTextBox.TabIndex = 6
        '
        'FICARateTextBox
        '
        Me.FICARateTextBox.Location = New System.Drawing.Point(326, 357)
        Me.FICARateTextBox.Name = "FICARateTextBox"
        Me.FICARateTextBox.Size = New System.Drawing.Size(150, 22)
        Me.FICARateTextBox.TabIndex = 7
        '
        'FederalRateTextBox
        '
        Me.FederalRateTextBox.Location = New System.Drawing.Point(482, 357)
        Me.FederalRateTextBox.Name = "FederalRateTextBox"
        Me.FederalRateTextBox.Size = New System.Drawing.Size(150, 22)
        Me.FederalRateTextBox.TabIndex = 8
        '
        'StateRateTextBox
        '
        Me.StateRateTextBox.Location = New System.Drawing.Point(638, 357)
        Me.StateRateTextBox.Name = "StateRateTextBox"
        Me.StateRateTextBox.Size = New System.Drawing.Size(150, 22)
        Me.StateRateTextBox.TabIndex = 9
        '
        'DeleteEmployeeBtn
        '
        Me.DeleteEmployeeBtn.Location = New System.Drawing.Point(794, 219)
        Me.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn"
        Me.DeleteEmployeeBtn.Size = New System.Drawing.Size(163, 46)
        Me.DeleteEmployeeBtn.TabIndex = 10
        Me.DeleteEmployeeBtn.Text = "Delete Selected Employee"
        Me.DeleteEmployeeBtn.UseVisualStyleBackColor = True
        '
        'ApplyChangesBtn
        '
        Me.ApplyChangesBtn.Enabled = False
        Me.ApplyChangesBtn.Location = New System.Drawing.Point(417, 385)
        Me.ApplyChangesBtn.Name = "ApplyChangesBtn"
        Me.ApplyChangesBtn.Size = New System.Drawing.Size(265, 30)
        Me.ApplyChangesBtn.TabIndex = 11
        Me.ApplyChangesBtn.Text = "Apply Changes To Selected Employee"
        Me.ApplyChangesBtn.UseVisualStyleBackColor = True
        '
        'AddNewEmployeeBtn
        '
        Me.AddNewEmployeeBtn.Enabled = False
        Me.AddNewEmployeeBtn.Location = New System.Drawing.Point(170, 385)
        Me.AddNewEmployeeBtn.Name = "AddNewEmployeeBtn"
        Me.AddNewEmployeeBtn.Size = New System.Drawing.Size(213, 30)
        Me.AddNewEmployeeBtn.TabIndex = 12
        Me.AddNewEmployeeBtn.Text = "Add Above As New Employee"
        Me.AddNewEmployeeBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(794, 13)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(163, 38)
        Me.CancelBtn.TabIndex = 13
        Me.CancelBtn.Text = "Cancel Changes"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'CancelReturnBtn
        '
        Me.CancelReturnBtn.Location = New System.Drawing.Point(794, 73)
        Me.CancelReturnBtn.Name = "CancelReturnBtn"
        Me.CancelReturnBtn.Size = New System.Drawing.Size(163, 38)
        Me.CancelReturnBtn.TabIndex = 14
        Me.CancelReturnBtn.Text = "Cancel and Return"
        Me.CancelReturnBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(794, 450)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(163, 38)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Save Changes"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'SaveReturnBtn
        '
        Me.SaveReturnBtn.Location = New System.Drawing.Point(625, 450)
        Me.SaveReturnBtn.Name = "SaveReturnBtn"
        Me.SaveReturnBtn.Size = New System.Drawing.Size(163, 38)
        Me.SaveReturnBtn.TabIndex = 16
        Me.SaveReturnBtn.Text = "Save and Return"
        Me.SaveReturnBtn.UseVisualStyleBackColor = True
        '
        'ClearInputsBtn
        '
        Me.ClearInputsBtn.Location = New System.Drawing.Point(794, 353)
        Me.ClearInputsBtn.Name = "ClearInputsBtn"
        Me.ClearInputsBtn.Size = New System.Drawing.Size(162, 31)
        Me.ClearInputsBtn.TabIndex = 17
        Me.ClearInputsBtn.Text = "Clear Inputs"
        Me.ClearInputsBtn.UseVisualStyleBackColor = True
        '
        'SetupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(969, 500)
        Me.Controls.Add(Me.ClearInputsBtn)
        Me.Controls.Add(Me.SaveReturnBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.CancelReturnBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.AddNewEmployeeBtn)
        Me.Controls.Add(Me.ApplyChangesBtn)
        Me.Controls.Add(Me.DeleteEmployeeBtn)
        Me.Controls.Add(Me.StateRateTextBox)
        Me.Controls.Add(Me.FederalRateTextBox)
        Me.Controls.Add(Me.FICARateTextBox)
        Me.Controls.Add(Me.HourlyRateTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.StateRateListBox)
        Me.Controls.Add(Me.FederalRateListBox)
        Me.Controls.Add(Me.FICARateListBox)
        Me.Controls.Add(Me.HourlyRateListBox)
        Me.Controls.Add(Me.NameListBox)
        Me.Name = "SetupForm"
        Me.Text = "SetupForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameListBox As ListBox
    Friend WithEvents HourlyRateListBox As ListBox
    Friend WithEvents FICARateListBox As ListBox
    Friend WithEvents FederalRateListBox As ListBox
    Friend WithEvents StateRateListBox As ListBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents HourlyRateTextBox As TextBox
    Friend WithEvents FICARateTextBox As TextBox
    Friend WithEvents FederalRateTextBox As TextBox
    Friend WithEvents StateRateTextBox As TextBox
    Friend WithEvents DeleteEmployeeBtn As Button
    Friend WithEvents ApplyChangesBtn As Button
    Friend WithEvents AddNewEmployeeBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents CancelReturnBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents SaveReturnBtn As Button
    Friend WithEvents ClearInputsBtn As Button
End Class

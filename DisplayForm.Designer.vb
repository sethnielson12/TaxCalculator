<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DisplayForm))
        Me.SetupBtn = New System.Windows.Forms.Button()
        Me.TaxCalculatorLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameListBox = New System.Windows.Forms.ListBox()
        Me.HourlyRateListBox = New System.Windows.Forms.ListBox()
        Me.FICARateListBox = New System.Windows.Forms.ListBox()
        Me.FederalRateListBox = New System.Windows.Forms.ListBox()
        Me.StateRateListBox = New System.Windows.Forms.ListBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.HourlyRateLabel = New System.Windows.Forms.Label()
        Me.TotalHoursLabel = New System.Windows.Forms.Label()
        Me.EmployeeNameHolder = New System.Windows.Forms.Label()
        Me.PayRateHolder = New System.Windows.Forms.Label()
        Me.TotalHoursHolder = New System.Windows.Forms.TextBox()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FICARateHolder = New System.Windows.Forms.Label()
        Me.FederalRateHolder = New System.Windows.Forms.Label()
        Me.StateRateHolder = New System.Windows.Forms.Label()
        Me.GrossPayValueHolder = New System.Windows.Forms.TextBox()
        Me.FICAValueHolder = New System.Windows.Forms.TextBox()
        Me.FederalValueHolder = New System.Windows.Forms.TextBox()
        Me.StateValueHolder = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalWitholdingsHolder = New System.Windows.Forms.TextBox()
        Me.NetPayHolder = New System.Windows.Forms.TextBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SetupBtn
        '
        Me.SetupBtn.Location = New System.Drawing.Point(914, 12)
        Me.SetupBtn.Name = "SetupBtn"
        Me.SetupBtn.Size = New System.Drawing.Size(75, 25)
        Me.SetupBtn.TabIndex = 0
        Me.SetupBtn.Text = "Setup"
        Me.SetupBtn.UseVisualStyleBackColor = True
        '
        'TaxCalculatorLabel
        '
        Me.TaxCalculatorLabel.AutoSize = True
        Me.TaxCalculatorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.TaxCalculatorLabel.Location = New System.Drawing.Point(12, 9)
        Me.TaxCalculatorLabel.Name = "TaxCalculatorLabel"
        Me.TaxCalculatorLabel.Size = New System.Drawing.Size(279, 46)
        Me.TaxCalculatorLabel.TabIndex = 1
        Me.TaxCalculatorLabel.Text = "Tax Calculator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "By Seth Nielson"
        '
        'NameListBox
        '
        Me.NameListBox.FormattingEnabled = True
        Me.NameListBox.ItemHeight = 16
        Me.NameListBox.Location = New System.Drawing.Point(20, 97)
        Me.NameListBox.Name = "NameListBox"
        Me.NameListBox.Size = New System.Drawing.Size(175, 356)
        Me.NameListBox.TabIndex = 3
        '
        'HourlyRateListBox
        '
        Me.HourlyRateListBox.FormattingEnabled = True
        Me.HourlyRateListBox.ItemHeight = 16
        Me.HourlyRateListBox.Location = New System.Drawing.Point(201, 426)
        Me.HourlyRateListBox.Name = "HourlyRateListBox"
        Me.HourlyRateListBox.Size = New System.Drawing.Size(120, 84)
        Me.HourlyRateListBox.TabIndex = 4
        Me.HourlyRateListBox.Visible = False
        '
        'FICARateListBox
        '
        Me.FICARateListBox.FormattingEnabled = True
        Me.FICARateListBox.ItemHeight = 16
        Me.FICARateListBox.Location = New System.Drawing.Point(327, 426)
        Me.FICARateListBox.Name = "FICARateListBox"
        Me.FICARateListBox.Size = New System.Drawing.Size(120, 84)
        Me.FICARateListBox.TabIndex = 5
        Me.FICARateListBox.Visible = False
        '
        'FederalRateListBox
        '
        Me.FederalRateListBox.FormattingEnabled = True
        Me.FederalRateListBox.ItemHeight = 16
        Me.FederalRateListBox.Location = New System.Drawing.Point(453, 426)
        Me.FederalRateListBox.Name = "FederalRateListBox"
        Me.FederalRateListBox.Size = New System.Drawing.Size(120, 84)
        Me.FederalRateListBox.TabIndex = 6
        Me.FederalRateListBox.Visible = False
        '
        'StateRateListBox
        '
        Me.StateRateListBox.FormattingEnabled = True
        Me.StateRateListBox.ItemHeight = 16
        Me.StateRateListBox.Location = New System.Drawing.Point(579, 426)
        Me.StateRateListBox.Name = "StateRateListBox"
        Me.StateRateListBox.Size = New System.Drawing.Size(120, 84)
        Me.StateRateListBox.TabIndex = 7
        Me.StateRateListBox.Visible = False
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(239, 97)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(115, 17)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Employee Name:"
        '
        'HourlyRateLabel
        '
        Me.HourlyRateLabel.AutoSize = True
        Me.HourlyRateLabel.Location = New System.Drawing.Point(239, 144)
        Me.HourlyRateLabel.Name = "HourlyRateLabel"
        Me.HourlyRateLabel.Size = New System.Drawing.Size(115, 17)
        Me.HourlyRateLabel.TabIndex = 9
        Me.HourlyRateLabel.Text = "Hourly Pay Rate:"
        '
        'TotalHoursLabel
        '
        Me.TotalHoursLabel.AutoSize = True
        Me.TotalHoursLabel.Location = New System.Drawing.Point(239, 191)
        Me.TotalHoursLabel.Name = "TotalHoursLabel"
        Me.TotalHoursLabel.Size = New System.Drawing.Size(139, 17)
        Me.TotalHoursLabel.TabIndex = 10
        Me.TotalHoursLabel.Text = "Total Hours Worked:"
        '
        'EmployeeNameHolder
        '
        Me.EmployeeNameHolder.AutoSize = True
        Me.EmployeeNameHolder.ForeColor = System.Drawing.Color.DarkRed
        Me.EmployeeNameHolder.Location = New System.Drawing.Point(435, 97)
        Me.EmployeeNameHolder.Name = "EmployeeNameHolder"
        Me.EmployeeNameHolder.Size = New System.Drawing.Size(53, 17)
        Me.EmployeeNameHolder.TabIndex = 11
        Me.EmployeeNameHolder.Text = "(name)"
        '
        'PayRateHolder
        '
        Me.PayRateHolder.AutoSize = True
        Me.PayRateHolder.ForeColor = System.Drawing.Color.DarkRed
        Me.PayRateHolder.Location = New System.Drawing.Point(435, 144)
        Me.PayRateHolder.Name = "PayRateHolder"
        Me.PayRateHolder.Size = New System.Drawing.Size(70, 17)
        Me.PayRateHolder.TabIndex = 12
        Me.PayRateHolder.Text = "(pay rate)"
        '
        'TotalHoursHolder
        '
        Me.TotalHoursHolder.Location = New System.Drawing.Point(438, 191)
        Me.TotalHoursHolder.Name = "TotalHoursHolder"
        Me.TotalHoursHolder.Size = New System.Drawing.Size(100, 22)
        Me.TotalHoursHolder.TabIndex = 13
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(423, 236)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(132, 30)
        Me.CalculateBtn.TabIndex = 14
        Me.CalculateBtn.Text = "Calculate Taxes"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(576, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Gross Pay:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(576, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "FICA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(576, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Federal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(576, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(576, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Total Witholdings:"
        '
        'FICARateHolder
        '
        Me.FICARateHolder.AutoSize = True
        Me.FICARateHolder.ForeColor = System.Drawing.Color.DarkRed
        Me.FICARateHolder.Location = New System.Drawing.Point(662, 144)
        Me.FICARateHolder.Name = "FICARateHolder"
        Me.FICARateHolder.Size = New System.Drawing.Size(20, 17)
        Me.FICARateHolder.TabIndex = 20
        Me.FICARateHolder.Text = "%"
        '
        'FederalRateHolder
        '
        Me.FederalRateHolder.AutoSize = True
        Me.FederalRateHolder.ForeColor = System.Drawing.Color.DarkRed
        Me.FederalRateHolder.Location = New System.Drawing.Point(662, 191)
        Me.FederalRateHolder.Name = "FederalRateHolder"
        Me.FederalRateHolder.Size = New System.Drawing.Size(20, 17)
        Me.FederalRateHolder.TabIndex = 21
        Me.FederalRateHolder.Text = "%"
        '
        'StateRateHolder
        '
        Me.StateRateHolder.AutoSize = True
        Me.StateRateHolder.ForeColor = System.Drawing.Color.DarkRed
        Me.StateRateHolder.Location = New System.Drawing.Point(662, 236)
        Me.StateRateHolder.Name = "StateRateHolder"
        Me.StateRateHolder.Size = New System.Drawing.Size(20, 17)
        Me.StateRateHolder.TabIndex = 22
        Me.StateRateHolder.Text = "%"
        '
        'GrossPayValueHolder
        '
        Me.GrossPayValueHolder.Enabled = False
        Me.GrossPayValueHolder.Location = New System.Drawing.Point(765, 92)
        Me.GrossPayValueHolder.Name = "GrossPayValueHolder"
        Me.GrossPayValueHolder.Size = New System.Drawing.Size(100, 22)
        Me.GrossPayValueHolder.TabIndex = 23
        '
        'FICAValueHolder
        '
        Me.FICAValueHolder.Enabled = False
        Me.FICAValueHolder.Location = New System.Drawing.Point(765, 139)
        Me.FICAValueHolder.Name = "FICAValueHolder"
        Me.FICAValueHolder.Size = New System.Drawing.Size(100, 22)
        Me.FICAValueHolder.TabIndex = 24
        '
        'FederalValueHolder
        '
        Me.FederalValueHolder.Enabled = False
        Me.FederalValueHolder.Location = New System.Drawing.Point(765, 185)
        Me.FederalValueHolder.Name = "FederalValueHolder"
        Me.FederalValueHolder.Size = New System.Drawing.Size(100, 22)
        Me.FederalValueHolder.TabIndex = 25
        '
        'StateValueHolder
        '
        Me.StateValueHolder.Enabled = False
        Me.StateValueHolder.Location = New System.Drawing.Point(765, 231)
        Me.StateValueHolder.Name = "StateValueHolder"
        Me.StateValueHolder.Size = New System.Drawing.Size(100, 22)
        Me.StateValueHolder.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(576, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Net Pay:"
        '
        'TotalWitholdingsHolder
        '
        Me.TotalWitholdingsHolder.Enabled = False
        Me.TotalWitholdingsHolder.Location = New System.Drawing.Point(765, 284)
        Me.TotalWitholdingsHolder.Name = "TotalWitholdingsHolder"
        Me.TotalWitholdingsHolder.Size = New System.Drawing.Size(100, 22)
        Me.TotalWitholdingsHolder.TabIndex = 27
        '
        'NetPayHolder
        '
        Me.NetPayHolder.Enabled = False
        Me.NetPayHolder.Location = New System.Drawing.Point(765, 345)
        Me.NetPayHolder.Name = "NetPayHolder"
        Me.NetPayHolder.Size = New System.Drawing.Size(117, 22)
        Me.NetPayHolder.TabIndex = 29
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(914, 437)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 23)
        Me.ExitBtn.TabIndex = 30
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'DisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1001, 472)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.NetPayHolder)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TotalWitholdingsHolder)
        Me.Controls.Add(Me.StateValueHolder)
        Me.Controls.Add(Me.FederalValueHolder)
        Me.Controls.Add(Me.FICAValueHolder)
        Me.Controls.Add(Me.GrossPayValueHolder)
        Me.Controls.Add(Me.StateRateHolder)
        Me.Controls.Add(Me.FederalRateHolder)
        Me.Controls.Add(Me.FICARateHolder)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.TotalHoursHolder)
        Me.Controls.Add(Me.PayRateHolder)
        Me.Controls.Add(Me.EmployeeNameHolder)
        Me.Controls.Add(Me.TotalHoursLabel)
        Me.Controls.Add(Me.HourlyRateLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.StateRateListBox)
        Me.Controls.Add(Me.FederalRateListBox)
        Me.Controls.Add(Me.FICARateListBox)
        Me.Controls.Add(Me.HourlyRateListBox)
        Me.Controls.Add(Me.NameListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TaxCalculatorLabel)
        Me.Controls.Add(Me.SetupBtn)
        Me.Name = "DisplayForm"
        Me.Text = "Tax Calulator 2020"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SetupBtn As Button
    Friend WithEvents TaxCalculatorLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NameListBox As ListBox
    Friend WithEvents HourlyRateListBox As ListBox
    Friend WithEvents FICARateListBox As ListBox
    Friend WithEvents FederalRateListBox As ListBox
    Friend WithEvents StateRateListBox As ListBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents HourlyRateLabel As Label
    Friend WithEvents TotalHoursLabel As Label
    Friend WithEvents EmployeeNameHolder As Label
    Friend WithEvents PayRateHolder As Label
    Friend WithEvents TotalHoursHolder As TextBox
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FICARateHolder As Label
    Friend WithEvents FederalRateHolder As Label
    Friend WithEvents StateRateHolder As Label
    Friend WithEvents GrossPayValueHolder As TextBox
    Friend WithEvents FICAValueHolder As TextBox
    Friend WithEvents FederalValueHolder As TextBox
    Friend WithEvents StateValueHolder As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TotalWitholdingsHolder As TextBox
    Friend WithEvents NetPayHolder As TextBox
    Friend WithEvents ExitBtn As Button
End Class

Imports System
Imports System.IO

Public Class DisplayForm
    Inherits System.Windows.Forms.Form

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub

    Private Sub SetupBtn_Click(sender As Object, e As EventArgs) Handles SetupBtn.Click
        Dim setup As New SetupForm
        setup.ShowDialog()

        LoadData()
        'EnableAndDisable()
    End Sub

    Private Sub LoadData()
        'erase old data
        NameListBox.Items.Clear()
        HourlyRateListBox.Items.Clear()
        FICARateListBox.Items.Clear()
        FederalRateListBox.Items.Clear()
        StateRateListBox.Items.Clear()

        Dim sFileName As String = "employees.txt"
        If (File.Exists(sFileName)) Then
            Dim fStreamReader As StreamReader = File.OpenText(sFileName)
            Dim count As Integer
            Dim i As Integer
            Dim name As String
            Dim salary As String
            Dim fica As Decimal
            Dim federal As Decimal
            Dim state As Decimal

            count = fStreamReader.ReadLine
            For i = 1 To count
                name = fStreamReader.ReadLine
                salary = fStreamReader.ReadLine
                fica = fStreamReader.ReadLine
                federal = fStreamReader.ReadLine
                state = fStreamReader.ReadLine

                NameListBox.Items.Add(name)
                HourlyRateListBox.Items.Add(salary)
                FICARateListBox.Items.Add(fica)
                FederalRateListBox.Items.Add(federal)
                StateRateListBox.Items.Add(state)
            Next

            fStreamReader.Close()
        End If

        'UpdateLabelsAndClearBoxes()
    End Sub

    Private Sub DisplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        'EnableAndDisable()
    End Sub

    Private Sub NameListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameListBox.SelectedIndexChanged
        UpdateLabelsAndClearBoxes()
    End Sub

    Private Sub UpdateLabelsAndClearBoxes()
        Dim index As Integer
        index = NameListBox.SelectedIndex()
        If (index >= 0) Then
            EmployeeNameHolder.Text = NameListBox.Items.Item(index)
            PayRateHolder.Text = HourlyRateListBox.Items.Item(index)
            FICARateHolder.Text = FICARateListBox.Items.Item(index)
            FederalRateHolder.Text = FederalRateListBox.Items.Item(index)
            StateRateHolder.Text = StateRateListBox.Items.Item(index)
        Else
            EmployeeNameHolder.Text = ""
            PayRateHolder.Text = ""
            FICARateHolder.Text = ""
            FederalRateHolder.Text = ""
            StateRateHolder.Text = ""
        End If
        TotalHoursHolder.Text = ""
        GrossPayValueHolder.Text = ""
        FICAValueHolder.Text = ""
        FederalValueHolder.Text = ""
        StateValueHolder.Text = ""
        TotalWitholdingsHolder.Text = ""
        NetPayHolder.Text = ""




    End Sub

    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        Dim index As Integer
        index = NameListBox.SelectedIndex()
        If (index >= 0 And TotalHoursHolder.Text IsNot "") Then


            Dim totalHours As Double
            Dim hourlyRate As Double
            Dim grossPay As Double
            Dim ficaRate As Double
            Dim federalRate As Double
            Dim stateRate As Double
            Dim ficaRemoved As Double
            Dim federalRemoved As Double
            Dim stateRemoved As Double
            Dim totalRemoved As Double

            If Double.TryParse(TotalHoursHolder.Text, totalHours) Then
                totalHours = CDbl(TotalHoursHolder.Text)
                hourlyRate = CDbl(PayRateHolder.Text)
                grossPay = totalHours * hourlyRate
                ficaRate = CDbl(FICARateHolder.Text)
                federalRate = CDbl(FederalRateHolder.Text)
                stateRate = CDbl(StateRateHolder.Text)
                ficaRemoved = grossPay * ficaRate
                federalRemoved = grossPay * federalRate
                stateRemoved = grossPay * stateRate
                totalRemoved = ficaRemoved + federalRemoved + stateRemoved

                GrossPayValueHolder.Text = CStr(grossPay)
                FICAValueHolder.Text = CStr(ficaRemoved)
                FederalValueHolder.Text = CStr(federalRemoved)
                StateValueHolder.Text = CStr(stateRemoved)
                TotalWitholdingsHolder.Text = CStr(totalRemoved)
                NetPayHolder.Text = CStr(grossPay - totalRemoved)

            End If
        End If


    End Sub
End Class

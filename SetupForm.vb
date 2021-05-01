Imports System
Imports System.IO

Public Class SetupForm
    Dim dataChanged As Boolean
    Dim changingValues As Boolean
    Dim doneSaving As Boolean
    Dim allInputsFilled As Boolean



    Private Sub SaveData()
        Dim sFileName As String = "employees.txt"
        Dim fStreamWriter As StreamWriter = File.CreateText(sFileName)
        Dim count, i As Integer

        count = NameListBox.Items.Count
        fStreamWriter.WriteLine(count)
        For i = 0 To count - 1
            fStreamWriter.WriteLine(NameListBox.Items(i))
            fStreamWriter.WriteLine(HourlyRateListBox.Items(i))
            fStreamWriter.WriteLine(FICARateListBox.Items(i))
            fStreamWriter.WriteLine(FederalRateListBox.Items(i))
            fStreamWriter.WriteLine(StateRateListBox.Items(i))
        Next
        fStreamWriter.Flush()
        fStreamWriter.Close()

        'dataChanged = False
        'EnableAndDisable()
        doneSaving = True

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SaveData()
    End Sub

    Private Sub SaveReturnBtn_Click(sender As Object, e As EventArgs) Handles SaveReturnBtn.Click
        doneSaving = False
        SaveData()
        If doneSaving Then
            Me.Close()
        End If

    End Sub

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        allInputsFilled = False
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
            System.Console.WriteLine("employees.txt exists")
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

    Private Sub NameListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameListBox.SelectedIndexChanged
        Dim index As Integer
        index = NameListBox.SelectedIndex()
        If (index >= 0) Then
            HourlyRateListBox.SelectedIndex = index
            FICARateListBox.SelectedIndex = index
            FederalRateListBox.SelectedIndex = index
            StateRateListBox.SelectedIndex = index
            If (Not changingValues) Then
                NameTextBox.Text() = NameListBox.Items(NameListBox.SelectedIndex)
                HourlyRateTextBox.Text() = HourlyRateListBox.Items(HourlyRateListBox.SelectedIndex)
                FICARateTextBox.Text() = FICARateListBox.Items(FICARateListBox.SelectedIndex)
                FederalRateTextBox.Text() = FederalRateListBox.Items(FederalRateListBox.SelectedIndex)
                StateRateTextBox.Text = StateRateListBox.Items(StateRateListBox.SelectedIndex)
            End If
        End If

    End Sub

    Private Sub CancelReturnBtn_Click(sender As Object, e As EventArgs) Handles CancelReturnBtn.Click
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        LoadData()
    End Sub

    Private Sub AddNewEmployeeBtn_Click(sender As Object, e As EventArgs) Handles AddNewEmployeeBtn.Click
        NameListBox.Items.Add(NameTextBox.Text())
        HourlyRateListBox.Items.Add(HourlyRateTextBox.Text())
        FICARateListBox.Items.Add(FICARateTextBox.Text())
        FederalRateListBox.Items.Add(FederalRateTextBox.Text())
        StateRateListBox.Items.Add(StateRateTextBox.Text())


    End Sub

    Private Sub ApplyChangesBtn_Click(sender As Object, e As EventArgs) Handles ApplyChangesBtn.Click
        Dim index As Integer
        index = NameListBox.SelectedIndex()
        If (index >= 0) Then
            changingValues = True

            NameListBox.Items(NameListBox.SelectedIndex()) = NameTextBox.Text()
            HourlyRateListBox.Items(HourlyRateListBox.SelectedIndex) = HourlyRateTextBox.Text()
            FICARateListBox.Items(FICARateListBox.SelectedIndex()) = FICARateTextBox.Text()
            FederalRateListBox.Items(FederalRateListBox.SelectedIndex) = FederalRateTextBox.Text()
            StateRateListBox.Items(StateRateListBox.SelectedIndex) = StateRateTextBox.Text()

            changingValues = False

        End If
    End Sub

    Private Sub DeleteEmployeeBtn_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        Dim index As Integer
        index = NameListBox.SelectedIndex()
        If (index >= 0) Then
            NameListBox.Items.RemoveAt(NameListBox.SelectedIndex)
            HourlyRateListBox.Items.RemoveAt(HourlyRateListBox.SelectedIndex)
            FICARateListBox.Items.RemoveAt(FICARateListBox.SelectedIndex)
            FederalRateListBox.Items.RemoveAt(FederalRateListBox.SelectedIndex)
            StateRateListBox.Items.RemoveAt(StateRateListBox.SelectedIndex)
        End If
    End Sub

    Private Sub ClearInputsBtn_Click(sender As Object, e As EventArgs) Handles ClearInputsBtn.Click
        NameTextBox.Text = ""
        HourlyRateTextBox.Text = ""
        FICARateTextBox.Text = ""
        FederalRateTextBox.Text = ""
        StateRateTextBox.Text() = ""
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        InputsChanged()
    End Sub

    Private Sub InputsChanged()
        If NameTextBox.Text = "" Or HourlyRateTextBox.Text = "" Or FICARateTextBox.Text = "" Or FederalRateTextBox.Text = "" Or StateRateTextBox.Text = "" Then
            allInputsFilled = False
        Else
            allInputsFilled = True
        End If
        If Not allInputsFilled Then
            ApplyChangesBtn.Enabled = False
            AddNewEmployeeBtn.Enabled = False
        Else
            ApplyChangesBtn.Enabled = True
            AddNewEmployeeBtn.Enabled = True
        End If
    End Sub

    Private Sub HourlyRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles HourlyRateTextBox.TextChanged
        InputsChanged()
    End Sub

    Private Sub FICARateTextBox_TextChanged(sender As Object, e As EventArgs) Handles FICARateTextBox.TextChanged
        InputsChanged()
    End Sub

    Private Sub FederalRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles FederalRateTextBox.TextChanged
        InputsChanged()
    End Sub

    Private Sub StateRateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateRateTextBox.TextChanged
        InputsChanged()
    End Sub
End Class
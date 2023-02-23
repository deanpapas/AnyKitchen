Imports System.IO
Public Class Calendar

    'Navigation Menu
#Region "Navigation Menu"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Close()
    End Sub
    Private Sub Button2_Click() Handles Minimizebtn.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click() Handles Button3.Click
        RecipeBook.Show()
        Close()
    End Sub
    Private Sub Button4_Click() Handles Button4.Click
        WhiteGoods.Show()
        Close()
    End Sub
    Private Sub Button5_Click() Handles Button5.Click
        ShoppingList.Show()
        Close()
    End Sub
    Private Sub Button6_Click() Handles Button6.Click
        WishList.Show()
        Close()
    End Sub
    ' Private Sub Button7_Click() Handles Button7.Click
    '    Calendar.Show()
    '   Close()
    'End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RecipeMaker.Show()
        Close()
    End Sub
    Private Sub Button9_Click() Handles Button9.Click
        WhiteGoodProvider.Show()
        Close()
    End Sub
#End Region

    'Show Date Info
#Region "Show Date Info"
    Public SelectedDate As String
    Dim objStreamWriter As StreamWriter
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles DateSelect.DateChanged
        DayViewer.Text = "" 'Resets DayViewer textbox
        SelectedDate = DateSelect.SelectionStart
        SelectedDate = SelectedDate.Replace("/", "") 'removes "/" from filename and saves it into a string

        If My.Computer.FileSystem.FileExists("\AnyKitchenFiles\Calendar\" + SelectedDate + ".text") Then 'Checks if a file for the selected date exists
            DayViewer.Text = File.ReadAllText("\AnyKitchenFiles\Calendar\" + SelectedDate + ".text") 'Sets the DayViewer test for the corresponding selected date
        End If

    End Sub
#End Region

    'Save Day Button
#Region "Save Day Button"
    Private Sub SaveDaybtn_Click(sender As Object, e As EventArgs) Handles SaveDaybtn.Click

        SelectedDate = DateSelect.SelectionStart
        SelectedDate = SelectedDate.Replace("/", "") 'removes "/" from filename and saves it into a string

        If My.Computer.FileSystem.FileExists("\AnyKitchenFiles\Calendar\" + SelectedDate + ".text") Then 'Checks if a file for the selected date exists
            objStreamWriter = New StreamWriter("\AnyKitchenFiles\Calendar\" + SelectedDate + ".text") 'Opens previously created file
            objStreamWriter.WriteLine(DayViewer.Text)
            objStreamWriter.Close()
        Else
            File.Create("\AnyKitchenFiles\Calendar\" + SelectedDate + ".text").Dispose() 'Creates file 
            objStreamWriter = New StreamWriter("\AnyKitchenFiles\Calendar\" + SelectedDate + ".text") 'Opens previously created file
            objStreamWriter.WriteLine(DayViewer.Text)
            objStreamWriter.Close()
        End If

        MessageBox.Show("Date Saved!") 'Indicates to user that the date was saved
    End Sub
#End Region

    'Toggle Edit Button
#Region "Toggle Edit Button"
    'Toggles the ReadOnly control of the DayViewer textbox
    Private Sub EditDaybtn_Click(sender As Object, e As EventArgs) Handles EditDaybtn.Click
        If DayViewer.ReadOnly = True Then
            DayViewer.ReadOnly = False
            DayViewer.BackColor = Color.LightGray
        ElseIf DayViewer.ReadOnly = False Then
            DayViewer.ReadOnly = True
            DayViewer.BackColor = Color.White
        End If
    End Sub
#End Region

    'Calendar Form Load
#Region "Calendar Form Load"
    Private Sub Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DayViewer.ReadOnly = True 'Sets DayViewer textbox control
    End Sub
#End Region

    'Open Schedule Form
#Region "Open Schedule Form"
    Private Sub Schedulebtn_Click(sender As Object, e As EventArgs) Handles Schedulebtn.Click
        RecipeSchedule.Show()
    End Sub
#End Region

End Class
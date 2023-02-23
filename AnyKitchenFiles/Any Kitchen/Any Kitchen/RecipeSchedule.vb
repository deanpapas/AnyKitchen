Imports System.IO
Public Class RecipeSchedule

    'Navigation Buttons
#Region "Navigation Buttons"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

    'RecipeSchedule Form Load
#Region "RecipeSchedule Form Load"
    Dim Recipes(RecipeDisplayCounter) As String
    Private Sub RecipeSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Takes File Name and makes title for recipe card
        Recipes = Directory.GetFiles("\AnyKitchenFiles\Recipes")
        Array.Sort(Recipes)


        For i = 1 To RecipeDisplayCounter
            Dim EditStep1 As String = Recipes(i - 1).ToString()
            Dim EditStep2 As String = EditStep1.Remove(0, 9)
            Dim EditStep3 As String = EditStep2.Remove(EditStep2.Length - 5)
            Controls.Find("Recipebtn" & i, True)(0).Text = EditStep3
        Next
        'Hides unused cards 
        For i = RecipeDisplayCounter + 1 To 10
            Controls.Find("Recipebtn" & i, True)(0).Visible = False

        Next
    End Sub
#End Region

    'Recipe Button Functions
#Region "Recipe Button Functions"
    'Add recipe text from corresponding file to CalendarDayViewer textbox
    'Indicate to the user that the recipe was added to the corresponding day
    Private Sub Recipebtn1_Click(sender As Object, e As EventArgs) Handles Recipebtn1.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(0)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub

    Private Sub Recipebtn2_Click(sender As Object, e As EventArgs) Handles Recipebtn2.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(1)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub

    Private Sub Recipebtn3_Click(sender As Object, e As EventArgs) Handles Recipebtn3.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(2)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub

    Private Sub Recipebtn4_Click(sender As Object, e As EventArgs) Handles Recipebtn4.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(3)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub

    Private Sub Recipebtn5_Click(sender As Object, e As EventArgs) Handles Recipebtn5.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(4)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub

    Private Sub Recipebtn6_Click(sender As Object, e As EventArgs) Handles Recipebtn6.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(5)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub

    Private Sub Recipebtn7_Click(sender As Object, e As EventArgs) Handles Recipebtn7.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(6)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub

    Private Sub Recipebtn8_Click(sender As Object, e As EventArgs) Handles Recipebtn8.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(7)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub

    Private Sub Recipebtn9_Click(sender As Object, e As EventArgs) Handles Recipebtn9.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(8)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub

    Private Sub Recipebtn10_Click(sender As Object, e As EventArgs) Handles Recipebtn10.Click
        Calendar.DayViewer.Text = Calendar.DayViewer.Text + File.ReadAllText(Recipes(9)) + "======================================"
        MessageBox.Show("Recipe Added!")
    End Sub
#End Region

End Class
Imports System.IO
Public Class RecipeBook

    'Navigation Menu
#Region "Navigation Menu"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Close()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Minimizebtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    'RecipeBook.Show()
    'Me.Close()
    'End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WhiteGoods.Show()
        Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ShoppingList.Show()
        Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Wishlist.Show()
        Close()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Calendar.Show()
        Close()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RecipeMaker.Show()
        Close()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        WhiteGoodProvider.Show()
        Close()
    End Sub
#End Region

    'Edits/Updates Recipe Cards
#Region "Edit/Update Recipe Cards"
    Dim Recipes(RecipeDisplayCounter) As String
    Private Sub RecipeOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens Recipe Folder And Puts Recipe Files Into Array
        Recipes = Directory.GetFiles("\AnyKitchenFiles\Recipes")
        Array.Sort(Recipes) 'Sprt Array Into Alphabetical Order

        For i = 1 To RecipeDisplayCounter 'Cycles Through Every Recipe In Array
            Dim EditStep1 As String = Recipes(i - 1).ToString() 'Converts File Name Into A String
            Dim EditStep2 As String = EditStep1.Remove(0, 25) 'Removes Text Before Recipe Name
            Dim EditStep3 As String = EditStep2.Remove(EditStep2.Length - 5) 'Removes Text After Recipe Name
            Controls.Find("Recipebtn" & i, True)(0).Text = EditStep3 'Names The Appropriate Button
        Next
        'Hides unused cards 
        For i = RecipeDisplayCounter + 1 To 10
            Controls.Find("Recipebtn" & i, True)(0).Visible = False
        Next


    End Sub
#End Region

    'Recipe Button Functions
#Region "Recipe Button Functions"
    'Changes Recipe Viewer Variable To The Selected Recipe
    'Opens RecipeOpen Form For User To View Variable
    Private Sub Recipebtn1_Click(sender As Object, e As EventArgs) Handles Recipebtn1.Click
        RecipeViewerVariable = Recipes(0)
        RecipeOpen.Show()
    End Sub
    Private Sub Recipebtn2_Click(sender As Object, e As EventArgs) Handles Recipebtn2.Click
        RecipeViewerVariable = Recipes(1)
        RecipeOpen.Show()
    End Sub
    Private Sub Recipebtn3_Click(sender As Object, e As EventArgs) Handles Recipebtn3.Click
        RecipeViewerVariable = Recipes(2)
        RecipeOpen.Show()
    End Sub
    Private Sub Recipebtn4_Click(sender As Object, e As EventArgs) Handles Recipebtn4.Click
        RecipeViewerVariable = Recipes(3)
        RecipeOpen.Show()
    End Sub
    Private Sub Recipebtn5_Click(sender As Object, e As EventArgs) Handles Recipebtn5.Click
        RecipeViewerVariable = Recipes(4)
        RecipeOpen.Show()
    End Sub
    Private Sub Recipebtn6_Click(sender As Object, e As EventArgs) Handles Recipebtn6.Click
        RecipeViewerVariable = Recipes(5)
        RecipeOpen.Show()
    End Sub
    Private Sub Recipebtn7_Click(sender As Object, e As EventArgs) Handles Recipebtn7.Click
        RecipeViewerVariable = Recipes(6)
        RecipeOpen.Show()
    End Sub
    Private Sub Recipebtn8_Click(sender As Object, e As EventArgs) Handles Recipebtn8.Click
        RecipeViewerVariable = Recipes(7)
        RecipeOpen.Show()
    End Sub
    Private Sub Recipebtn9_Click(sender As Object, e As EventArgs) Handles Recipebtn9.Click
        RecipeViewerVariable = Recipes(8)
        RecipeOpen.Show()
    End Sub
    Private Sub Recipebtn10_Click(sender As Object, e As EventArgs) Handles Recipebtn10.Click
        RecipeViewerVariable = Recipes(9)
        RecipeOpen.Show()
    End Sub
#End Region

End Class

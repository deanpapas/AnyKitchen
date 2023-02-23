Imports System.IO
Public Class RecipeMaker

    'Navigation Menu
#Region "Navigation Menu"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
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
    Private Sub Button7_Click() Handles Button7.Click
        Calendar.Show()
        Close()
    End Sub
    'Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button7.Click
    'RecipeMaker.Show()
    'Close()
    'End Sub
    Private Sub Button9_Click() Handles Button9.Click
        WhiteGoodProvider.Show()
        Close()
    End Sub
#End Region

    'Publish Button
#Region "Publish Button"
    Private Sub btnPublish_Click() Handles btnPublish.Click

        'Ingredient Variables
        Dim objStreamWriter As StreamWriter
        Dim Ingredient(9) As String
        Dim Amount(9) As String
        Dim Unit(9) As String

        If RecipeName.Text = "" Or Method.Text = "" Then
            MessageBox.Show("Please Fill all Areas") 'Validation that recipe name and method are not blank
        ElseIf RecipeDisplayCounter = 10 Then
            MessageBox.Show("Recipe Book Full! Please Delete a Recipe") 'Warning message for user telling them that their recipe book is full when amount exceeds 10
        Else
            File.Create("\AnyKitchenFiles\Recipes\" + RecipeName.Text + ".text").Dispose() 'Creates file using the title of the recipe
            objStreamWriter = New StreamWriter("\AnyKitchenFiles\Recipes\" + RecipeName.Text + ".text") 'Opens previously creted file

            'Writes Recipe Name into file
            objStreamWriter.WriteLine(RecipeName.Text)
            objStreamWriter.WriteLine()

            'Writes Ingredients into file
            objStreamWriter.WriteLine("Ingredients")
            Dim e As Integer = 0
            For i = 0 To 9
                Ingredient(i) = Controls.Find("Ingredient" & i, True)(0).Text
                Amount(i) = Controls.Find("Amount" & i, True)(0).Text
                Unit(i) = Controls.Find("Unit" & i, True)(0).Text

                If Ingredient(i) = "" Then 'Makes sure to only write ingredients that were entered by the user

                Else
                    e = e + 1
                    objStreamWriter.WriteLine((e) & "." + Ingredient(i) & "-" + Amount(i) + Unit(i))
                End If
            Next
            objStreamWriter.WriteLine()

            'Writes Method into file
            objStreamWriter.WriteLine("Method")
            objStreamWriter.WriteLine(Method.Text)

            'Closes File
            objStreamWriter.Close()

            MessageBox.Show("Recipe Saved!") 'Indicates to user that the recipe was saved

            RecipeDisplayCounter = RecipeDisplayCounter + 1 'Inrcrements user recipe count to keep track of the number of recipes
            objStreamWriter = New StreamWriter("\AnyKitchenFiles\DisplayRecipeNumber\DisplayNum.txt")
            objStreamWriter.WriteLine(RecipeDisplayCounter)
            objStreamWriter.Close()
        End If

    End Sub
#End Region

End Class


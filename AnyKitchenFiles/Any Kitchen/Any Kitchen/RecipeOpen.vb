Imports System.IO

Public Class RecipeOpen

    'Navigation Buttons
#Region "Navigation Buttons"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

    'RecipeOpen Form Load
#Region "RecipeOpen Form Load"
    Private Sub RecipeOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecipeViewer.Text = File.ReadAllText(RecipeViewerVariable) 'Reads text from the selected recipes file and puts it into textbox
        RecipeViewer.ReadOnly = True 'Sets the Recipe Viewer to read only when the form is loaded
    End Sub
#End Region

    'Save Recipe Button
#Region "Save Recipe Button"
    Private Sub SaveEditRecipebtn_Click(sender As Object, e As EventArgs) Handles SaveEditRecipebtn.Click

        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter(RecipeViewerVariable) 'Opens the current recipe's file


        objStreamWriter.WriteLine(RecipeViewer.Text) 'Overwrites file with the new version of the recipe
        objStreamWriter.WriteLine()
        objStreamWriter.Close()
        MessageBox.Show("Recipe Saved!") 'Indicates that the recipe has been saved

    End Sub
#End Region

    'Edit Recipe Button
#Region "Edit Recipe Button"
    'Toggles the RecipeViewer textbox readonly control
    Private Sub EditRecipebtn_Click_1(sender As Object, e As EventArgs) Handles EditRecipebtn.Click
        If RecipeViewer.ReadOnly = True Then
            RecipeViewer.ReadOnly = False
            RecipeViewer.BackColor = Color.LightGray
        ElseIf RecipeViewer.ReadOnly = False Then
            RecipeViewer.ReadOnly = True
            RecipeViewer.BackColor = Color.White

        End If
    End Sub
#End Region

    'Add To List Button
#Region "Add To List Button"
    Private Sub AddToListbtn_Click(sender As Object, e As EventArgs) Handles AddToListbtn.Click

        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter("\AnyKitchenFiles\ShoppingLists\ShoppingList.txt", True) 'Opens ShoppingList File

        'Recipe Name
        objStreamWriter.WriteLine(File.ReadAllText(RecipeViewerVariable)) 'Writes Recipe into Shopping List
        objStreamWriter.WriteLine("==========================================================================")
        objStreamWriter.Close()
        MessageBox.Show("Recipe Added to List!") 'Indicates to user that the recipe was written into shopping list

    End Sub
#End Region

    'Delete Recipe Button
#Region "Delete Recipe Button"
    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click

        My.Computer.FileSystem.DeleteFile(RecipeViewerVariable) 'Deletes coresponding recipe file
        RecipeDisplayCounter = RecipeDisplayCounter - 1 'Updates current amount of recipes
        MessageBox.Show("Recipe Deleted") 'Indicates that the recipe was deleted
        Dim objStreamWriter As StreamWriter
        'Saves current amount of recipes into file
        objStreamWriter = New StreamWriter("\AnyKitchenFiles\DisplayRecipeNumber\DisplayNum.txt")
        objStreamWriter.WriteLine(RecipeDisplayCounter)
        objStreamWriter.Close()
        RecipeBook.Close()
        RecipeBook.Show()
        Close()
    End Sub
#End Region

End Class

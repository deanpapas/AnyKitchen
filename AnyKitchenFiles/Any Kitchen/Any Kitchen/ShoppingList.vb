Imports System.IO
Public Class ShoppingList

    'Navigation Menu
#Region "Navigation Menu"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click_1() Handles Button2.Click
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

    'Private Sub Button5_Click() Handles Button5.Click
    'ShoppingList.Show()
    'Close()
    'End Sub

    Private Sub Button6_Click() Handles Button6.Click
        WishList.Show()
        Close()
    End Sub

    Private Sub Button7_Click() Handles Button7.Click
        Calendar.Show()
        Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RecipeMaker.Show()
        Close()
    End Sub

    Private Sub Button9_Click() Handles Button9.Click
        WhiteGoodProvider.Show()
        Close()
    End Sub
#End Region

    'Load Shopping List
#Region "Load Shopping List"
    Private Sub ShoppingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShoppingListViewer.Text = System.IO.File.ReadAllText("\AnyKitchenFiles\ShoppingLists\ShoppingList.txt") 'Opens ShoppingList file and sers ShoppingListViewer textbox to the text inside the file
        ShoppingListViewer.ReadOnly = True 'Sets the ShoppingListViewer Readonly control when form is loaded
    End Sub
#End Region

    'Save Changes Button
#Region "Save Changes Button"
    Private Sub SaveEditListbtn_Click(sender As Object, e As EventArgs) Handles SaveEditListbtn.Click
        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter("\AnyKitchenFiles\ShoppingLists\ShoppingList.txt") 'Opens ShoppingList file

        'Saves changes to ShoppingList
        objStreamWriter.WriteLine(ShoppingListViewer.Text)
        objStreamWriter.WriteLine()
        objStreamWriter.Close()
        MessageBox.Show("Shoppinglist Saved!") 'Indicates to the user that the Shopping List was saved
    End Sub
#End Region

    'Toggle Edit Button
#Region "Toggle Edit Button"
    'Toggles the ReadOnly control of the ShoppingListViewer textbox
    Private Sub EditListbtn_Click(sender As Object, e As EventArgs) Handles EditListbtn.Click
        If ShoppingListViewer.ReadOnly = True Then
            ShoppingListViewer.ReadOnly = False
            ShoppingListViewer.BackColor = Color.LightGray
        ElseIf ShoppingListViewer.ReadOnly = False Then
            ShoppingListViewer.ReadOnly = True
            ShoppingListViewer.BackColor = Color.White

        End If
    End Sub
#End Region

End Class
Imports System.IO
Public Class WishList

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
    Private Sub Button5_Click() Handles Button5.Click
        ShoppingList.Show()
        Close()
    End Sub
    'Private Sub Button6_Click() Handles Button6.Click
    '   WishList.Show()
    '  Close()
    'End Sub
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

    'Load Wishlist
#Region "Load WishList"
    Private Sub ShoppingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WishListViewer.Text = System.IO.File.ReadAllText("\AnyKitchenFiles\Wishlists\Wishlist.txt") 'Loads Wishlist file and reads text into textbox
        WishListViewer.ReadOnly = True 'Sets WishList viewer textbox control
    End Sub
#End Region

    'Save Wishlist
#Region "Save Shopping List"
    Private Sub SaveEditListbtn_Click(sender As Object, e As EventArgs) Handles SaveEditListbtn.Click
        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter("\AnyKitchenFiles\Wishlists\Wishlist.txt") 'Opens Wishlist file

        'Overwrites Wishlist File with the new version
        objStreamWriter.WriteLine(WishListViewer.Text)
        objStreamWriter.WriteLine()
        objStreamWriter.Close()
        MessageBox.Show("Wishlist Saved!") 'Indicates that the wishlist has been saved
    End Sub
#End Region

    'Toggle WishList Viewer
#Region "Toggle WishList Viewer"
    'Toggles the ReadOnly control of the WishlistListViewer textbox
    Private Sub EditListbtn_Click(sender As Object, e As EventArgs) Handles EditListbtn.Click
        If WishListViewer.ReadOnly = True Then
            WishListViewer.ReadOnly = False
            WishListViewer.BackColor = Color.LightGray
        ElseIf WishListViewer.ReadOnly = False Then
            WishListViewer.ReadOnly = True
            WishListViewer.BackColor = Color.White

        End If
    End Sub
#End Region

End Class
Imports System.IO

Public Class GoodOpen

    'Navigation Buttons
#Region "Navigation Button"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

    'GoodOpen Form Load
#Region "GoodOpen Form Load"
    Private Sub GoodOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GoodViewer.Text = File.ReadAllText(GoodsViewerVariable) 'Reads text from the selected goods file and puts it into textbox
        GoodViewer.ReadOnly = True 'Sets the GoodViewer to read only when the form is loaded
    End Sub
#End Region

    'Add Product To WishList
#Region "Add Prodcut To WishList"
    Private Sub AddToListbtn_Click(sender As Object, e As EventArgs) Handles AddToWishListbtn.Click

        Dim objStreamWriter As StreamWriter
        objStreamWriter = New StreamWriter("\AnyKitchenFiles\Wishlists\Wishlist.txt", True) 'Opens wishlsit file

        'Writes Product Details into wishlsit
        objStreamWriter.WriteLine(File.ReadAllText(GoodsViewerVariable))
        objStreamWriter.WriteLine("==========================================================================")
        objStreamWriter.Close()
        MessageBox.Show("Product Added to Wishlist!") 'Idicates to user that the product was added

    End Sub
#End Region

    'Delete Product
#Region "Delete Product"
    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        My.Computer.FileSystem.DeleteFile(GoodsViewerVariable) 'Deletes coresponding recipe file
        GoodsDisplayCounter = GoodsDisplayCounter - 1 'Updates current amount of recipes
        MessageBox.Show("Product Deleted") 'Indicates that the recipe was deleted
        Dim objStreamWriter As StreamWriter
        'Saves current amount of recipes into file
        objStreamWriter = New StreamWriter("\AnyKitchenFiles\DisplayGoodsNumber\DisplayNumGoods.txt")
        objStreamWriter.WriteLine(GoodsDisplayCounter)
        objStreamWriter.Close()
        WhiteGoods.Close()
        WhiteGoods.Show()
        Close()
    End Sub
#End Region

End Class

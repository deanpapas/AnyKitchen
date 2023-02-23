Imports System.IO
Public Class WhiteGoods

    'Navigation Menu
#Region "Navigation Menu"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RecipeBook.Show()
        Me.Close()
    End Sub
    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '   WhiteGoods.Show()
    '  Close()
    'End Sub
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

    'Update WhiteGood Cards
#Region "Update WhiteGood Cards"
    Dim WhiteGoods(GoodsDisplayCounter) As String
    Private Sub GoodOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Takes File Name and makes title for Goods Card
        WhiteGoods = Directory.GetFiles("\AnyKitchenFiles\WhiteGoods")
        Array.Sort(WhiteGoods)


        For i = 1 To GoodsDisplayCounter 'Cycles Through Every WhiteGood In Array
            Dim EditStep1 As String = WhiteGoods(i - 1).ToString() 'Converts File Name Into A String
            Dim EditStep2 As String = EditStep1.Remove(0, 28) 'Removes Text Before WhiteGood Name
            Dim EditStep3 As String = EditStep2.Remove(EditStep2.Length - 5) 'Removes Text After WhiteGood Name
            Controls.Find("Goodbtn" & i, True)(0).Text = EditStep3 'Names The Appropriate Button
        Next

        'Hides unused cards 
        For i = GoodsDisplayCounter + 1 To 10
            Controls.Find("Goodbtn" & i, True)(0).Visible = False

        Next


    End Sub
#End Region

    'Controls For Good Buttons
#Region "Controls For Good Buttons"
    'Changes Good Viewer Variable To The Selected Recipe
    'Opes GoodOpen Form For User To View Variable
    Private Sub Goodbtn1_Click(sender As Object, e As EventArgs) Handles Goodbtn1.Click
        GoodsViewerVariable = WhiteGoods(0)
        GoodOpen.Show()
    End Sub

    Private Sub Goodbtn2_Click(sender As Object, e As EventArgs) Handles Goodbtn2.Click
        GoodsViewerVariable = WhiteGoods(1)
        GoodOpen.Show()
    End Sub

    Private Sub Goodbtn3_Click(sender As Object, e As EventArgs) Handles Goodbtn3.Click
        GoodsViewerVariable = WhiteGoods(2)
        GoodOpen.Show()
    End Sub

    Private Sub Goodbtn4_Click(sender As Object, e As EventArgs) Handles Goodbtn4.Click
        GoodsViewerVariable = WhiteGoods(3)
        GoodOpen.Show()
    End Sub

    Private Sub Goodbtn5_Click(sender As Object, e As EventArgs) Handles Goodbtn5.Click
        GoodsViewerVariable = WhiteGoods(4)
        GoodOpen.Show()
    End Sub

    Private Sub Goodbtn6_Click(sender As Object, e As EventArgs) Handles Goodbtn6.Click
        GoodsViewerVariable = WhiteGoods(5)
        GoodOpen.Show()
    End Sub

    Private Sub Goodbtn7_Click(sender As Object, e As EventArgs) Handles Goodbtn7.Click
        GoodsViewerVariable = WhiteGoods(6)
        GoodOpen.Show()
    End Sub

    Private Sub Goodbtn8_Click(sender As Object, e As EventArgs) Handles Goodbtn8.Click
        GoodsViewerVariable = WhiteGoods(7)
        GoodOpen.Show()
    End Sub

    Private Sub Goodbtn9_Click(sender As Object, e As EventArgs) Handles Goodbtn9.Click
        GoodsViewerVariable = WhiteGoods(8)
        GoodOpen.Show()
    End Sub

    Private Sub Goodbtn10_Click(sender As Object, e As EventArgs) Handles Goodbtn10.Click
        GoodsViewerVariable = WhiteGoods(9)
        GoodOpen.Show()
    End Sub
#End Region

End Class

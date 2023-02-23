Imports System.IO
Public Class WhiteGoodProvider

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
    Private Sub Button7_Click() Handles Button7.Click
        Calendar.Show()
        Close()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RecipeMaker.Show()
        Close()
    End Sub
    'Private Sub Button9_Click() Handles Button9.Click
    '   WhiteGoodProvider.Show()
    '  Close()
    'End Sub

    'Publish Button (Saves Recipe)
#End Region

    'Publish Button
#Region "Publish Button"
    Private Sub btnPublish_Click() Handles btnPublish.Click
        Dim objStreamWriter As StreamWriter
        Dim input As String = Price.Text
        If ProductName.Text = "" Or ProductDetails.Text = "" Or Price.Text = "" Then
            MessageBox.Show("Please Fill all Areas") 'Validation that product name, details and price are not blank
        ElseIf typeCheckInt(input) Then
            MessageBox.Show("Please Make Sure Price Value is an Integer")
        ElseIf RecipeDisplayCounter = 10 Then
            MessageBox.Show("Product page full, Please delete a product") 'Warning message for user telling them that their product page is full when amount exceeds 10
        Else
            File.Create("\AnyKitchenFiles\WhiteGoods\" + ProductName.Text + ".text").Dispose() 'Creates file using the title of the product
            objStreamWriter = New StreamWriter("\AnyKitchenFiles\WhiteGoods\" + ProductName.Text + ".text") 'Opens previously created file

            'Writes Product Name into file
            objStreamWriter.WriteLine(ProductName.Text)
            objStreamWriter.WriteLine()

            'Writes Product Details into file
            objStreamWriter.WriteLine(ProductDetails.Text)
            objStreamWriter.WriteLine()

            'Writes Price into file
            objStreamWriter.WriteLine("$" + Price.Text)
            objStreamWriter.Close()

            MessageBox.Show("Product Published!") 'Indicates to user that the product was published

            GoodsDisplayCounter = GoodsDisplayCounter + 1 'Inrcrements good count to keep track of the number of WhiteGoods
            objStreamWriter = New StreamWriter("\AnyKitchenFiles\DisplayGoodsNumber\DisplayNumGoods.txt")
            objStreamWriter.WriteLine(GoodsDisplayCounter)
            objStreamWriter.Close()
        End If
    End Sub
#End Region

    'Check for Integer Value Function
#Region "Check for Integer Value Function"
    Function typeCheckInt(ByVal input As String) As Boolean
        Try
            Convert.ToInt32(input)
            Return False
        Catch ex As Exception
            Return True
        End Try
    End Function
#End Region

End Class
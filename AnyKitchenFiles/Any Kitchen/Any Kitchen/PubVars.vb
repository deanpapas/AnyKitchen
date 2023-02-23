'Storage of variables used throughout multiple modules
Module PubVars
    Public RecipeDisplayCounter As Integer = IO.File.ReadAllText("\AnyKitchenFiles\DisplayRecipeNumber\DisplayNum.txt") 'Stores the amount of recipes
    Public RecipeViewerVariable As String 'Temporarily stores recipe name
    Public GoodsDisplayCounter As Integer = IO.File.ReadAllText("\AnyKitchenFiles\DisplayGoodsNumber\DisplayNumGoods.txt") 'Stores the amount of products
    Public GoodsViewerVariable As String 'Temporarily stores product name
    Public SelectedDate As String 'Temporarily stores the currently selected date
End Module

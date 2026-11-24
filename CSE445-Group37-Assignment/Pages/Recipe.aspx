<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recipe.aspx.cs" Inherits="CSE445_Group37_Assignment.Pages.Recipe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recipe</title>
    <link rel="stylesheet" href="CSS/Recipe.css"/>
</head>
<body>
    <form id="formRecipe" runat="server">
        <div>
            <h1>Recipe title</h1>
            <p><a href="./LoginPage.aspx">Go back to list (FIX THIS LATER!!!)</a></p>

            <hr />

            <p> My Rating: <asp:Label ID="LabelRating" runat="server">5/5</asp:Label> </p>
            
            <h3> Ingredients </h3>
            <p>
                <asp:Table ID="TableIngredients" runat="server" CellPadding="6" GridLines="Both" CssClass="table">
                    <asp:TableRow>
                        <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Amount</asp:TableHeaderCell>
                        <asp:TableHeaderCell></asp:TableHeaderCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:TextBox ID="tbl_name1" runat="server" Width="300px">ingredient name here</asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="tbl_amount1" runat="server" Width="100px">amount</asp:TextBox>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Button ID="tbl_delete1" runat="server" Text="delete"/>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </p>
            <p>
                <asp:Button ID="buttonAddRow"  runat="server" Text="Add row"/>
            </p>


            <h3> Instructions </h3>
            <p>
                <asp:TextBox ID="TextBoxInstructions" runat="server" Height="400px" Width="80%" TextMode="MultiLine"></asp:TextBox>
            </p>
        </div>
    </form>
</body>
</html>

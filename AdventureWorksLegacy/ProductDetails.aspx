<%@ Page Language="C#" AutoEventWireup="true" Codebehind="ProductDetails.aspx.cs"
    Inherits="AdventureWorksLegacy.ProductDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Details</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 369px;
        }
    </style>
     <link href="static/css/flora.all.css" rel="stylesheet" type="text/css" />
    <link href="style/style.css" rel="stylesheet" type="text/css" />

    <script src="static/js/jquery-1.2.4b.js" type="text/javascript"></script>

    <script src="static/js/ui.core.js" type="text/javascript"></script>
    <style type="text/css">
        .km-button{           
            padding:10px 20px;           
        }
        .km-content{
            text-align:center;
        }
        .product-content{
             margin-left:auto; 
            margin-right:auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="km-content">
            <table class="product-content">
                <tr>
                    <td class="style2">
                        <asp:Image ID="ImgLargePhoto" runat="server" Height="361px" Width="369px" />
                    </td>
                    <td>
                        <table class="style1">
<%--                            <tr>
                                <td style="color: #0000FF; font-weight: 700">
                                    <span style="color: Black; font-weight: bold;">Model:</span><br />
                                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                </td>
                            </tr>
--%>                            <tr>
                                <td style="font-weight: 700; color: #009933">
                                    <span style="color: Black; font-weight: bold;">ProductDetails:</span><br />
                                    <asp:Literal ID="LitDescription" runat="server"></asp:Literal>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: 700; color: #FF0000">
                                    <span style="color: Black; font-weight: bold;">Price:</span><br />
                                    <asp:Literal ID="LitListPrice" runat="server"></asp:Literal>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnBack" class="km-button" runat="server" Text="Back" OnClick="btnBack_Click"/>
        </div>
        
    </form>
</body>
</html>

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
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="style1">
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
        </div>
    </form>
</body>
</html>

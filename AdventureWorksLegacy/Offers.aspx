<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Offers.aspx.cs" Inherits="AdventureWorksLegacy.Offers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Offers</title>
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
    <div id="header" style="float: right">
        <div>
            <br />
            <p>
                OFFERS
            </p>
            <br />
        </div>
    </div>

    <form id="form1" runat="server">
        <div id="all-content">
            <div>
                <asp:DataList ID="DlProducts" runat="server" RepeatColumns="4">
                    <ItemTemplate>
                        <asp:Panel ID="Panel1" runat="server" Height="180px" Width="270px">
                            <div class="km-thumbnail">
                                <div>
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ThumbnailPhotoUrl") %>'></asp:Image>
                                </div>
                                <div class="km-bike-name">
                                    <asp:Label ID="lbl" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                                </div>
                                <div>
                                    <span style="color: Black; font-weight: bold;">Price:</span>
                                    <br />
                                    <asp:Label ID="lbl3" runat="server" Text='<%#Eval("ListPrice") %>'></asp:Label>
                                </div>
                                <div>
                                    <%--<asp:LinkButton ID="LinkButton1" runat="server" Font-Underline="False" Style="font-weight: 700;
                                            color: Black" CommandName="ViewDetails" CommandArgument='<%#Eval("ProductID") %>'
                                            BackColor="#FF9933">ViewDetails</asp:LinkButton>--%>
                                </div>
                            </div>
                        </asp:Panel>
                    </ItemTemplate>
                </asp:DataList>
                 <asp:Button ID="btnBack" class="km-button" runat="server" Text="Back" OnClick="btnBack_Click"/>
            </div>
        </div>
    </form>
</body>
</html>

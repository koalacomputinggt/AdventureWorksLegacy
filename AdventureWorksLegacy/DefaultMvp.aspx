<%@ Page Language="C#" AutoEventWireup="true" Codebehind="DefaultMvp.aspx.cs" Inherits="AdventureWorksLegacy.DefaultMvp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default MVP</title>
    <link href="static/css/flora.all.css" rel="stylesheet" type="text/css" />
    <link href="style/style.css" rel="stylesheet" type="text/css" />

    <script src="static/js/jquery-1.2.4b.js" type="text/javascript"></script>

    <script src="static/js/ui.core.js" type="text/javascript"></script>

    <script src="static/js/ui.tabs.js" type="text/javascript"></script>

    <script src="static/js/ui.accordion.js" type="text/javascript"></script>

    <script type="text/javascript">
        var tabsDataRaw='<%=CategoryListTabData %>';
        var currentCategoryIndex = '<%=CurrentCategoryIndex %>';
        var currentSubCategoryIndex = '<%=CurrentSubCategoryIndex %>';
        var subCategoriesData='<%=SubCategoryListAccordionData %>';
    </script>

    
    <style type="text/css">
        #container-login{
            padding-bottom:10px;
            float:right;
            margin:10px 50px;
        }
        
        .km-button{
            padding: 10px 20px;
            text-decoration: none;
        }
        
       
    </style>
</head>
<body>
    <div id="header" style="float: right">
        <div>
            <br />
            <p>
                
            </p>
            <br />
        </div>
    </div>

    <script type="html" id="tab-content">
        <div id="fragment-{{value}}" data-tab-id="{{value}}">
            <h1>{{text}}</h1>
            <ul id="accordion-{{value}}">		        
	        </ul>
        </div>
    </script>

    <form id="frmMVP" method="post" runat="server">
    
        <div id="container-login">
            <div runat="server" id="divAnonymous">
                <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                <asp:TextBox ID="TxtPwd" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Button ID="BtnSignIn" class="km-button" runat="server" OnClick="BtnSignIn_Click" Text="Sign In" />
            </div>
            <div runat="server" id="divLogged" visible="false">
                <asp:Label ID="LblLoggedUser" runat="server">Welcome user</asp:Label>
                <asp:Button ID="BtnSignOut" class="km-button" runat="Server" OnClick="BtnSignOut_Click" Text="Sign Out" />
                <asp:HyperLink ID="LnkOffers" class="km-button" runat="server" NavigateUrl="~/Offers.aspx">Offers</asp:HyperLink>
                <asp:HyperLink ID="LnkRequestForFinancing" class="km-button" runat="server" NavigateUrl="~/RequestForFinancing.aspx">Request for Financing</asp:HyperLink>
            </div>
        </div>
        <div id="container-1">
            <ul class="tabssection">
            </ul>
        </div>
        <asp:HiddenField ID="hdnIsUserAuthenticated" runat="server" />
        <div id="all-content">
            <div>
                <asp:DataList ID="DlProducts" runat="server" RepeatColumns="3" onitemcommand="DlProducts_ItemCommand">
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
                                <input type="button" class="km-detail-action-link km-button" data-product-id='<%#Eval("ProductID") %>' value="View details"/>
                                    <%--<asp:LinkButton ID="LnkViewDetails" runat="server" Font-Underline="False" Style="font-weight: 700;
                                            color: Black" CommandName="ViewDetails" CommandArgument='<%#Eval("ProductID") %>'
                                            BackColor="#FF9933">ViewDetails</asp:LinkButton>--%>
                                </div>
                            </div>
                        </asp:Panel>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </form>
    <script src="script/DefaultMvp.js" type="text/javascript"></script>
</body>
</html>

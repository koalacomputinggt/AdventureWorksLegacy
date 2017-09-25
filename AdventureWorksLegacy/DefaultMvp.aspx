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

    <script src="script/DefaultMvp.js" type="text/javascript"></script>

</head>
<body>
    <div id="header" style="float: right">
        <div>
            <br />
            <p>
                HEADER
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

    <form id="form1" runat="server">
        <div id="container-login">
            <div runat="server" id="divAnonymous">
                <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
                <asp:TextBox ID="TxtPwd" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Button ID="BtnSignIn" runat="server" OnClick="BtnSignIn_Click" Text="Sign In"/>
            </div>
            <div runat="server" id="divLogged" visible="false">
                <asp:Label ID="LblLoggedUser" runat="server">Welcome user</asp:Label>
                <asp:Button ID="BtnSignOut" runat="Server" OnClick="BtnSignOut_Click" Text="Sign Out"/>
            </div>
        </div>
        <div id="container-1">
            <ul class="tabssection">
            </ul>
        </div>
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
            </div>
        </div>
    </form>
</body>
</html>

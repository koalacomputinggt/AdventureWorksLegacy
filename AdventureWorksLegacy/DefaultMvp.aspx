<%@ Page Language="C#" AutoEventWireup="true" Codebehind="DefaultMvp.aspx.cs" Inherits="AdventureWorksLegacy.DefaultMvp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default MVP</title>
    <link href="static/css/flora.all.css" rel="stylesheet" type="text/css" />
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
    <script type="html" id="tab-content">
        <div id="fragment-{{value}}" data-tab-id="{{value}}">
            <h1>{{text}}</h1>
            <ul id="accordion-{{value}}">		        
	        </ul>
        </div>
    </script>
    <form id="form1" runat="server">
    
        <div id="container-1">
                <ul class="tabssection">
                    
                </ul>
                
            </div>

        <div id="all-content">
          
            <div>
                <asp:DataList ID="DlProducts" runat="server" RepeatColumns="4">
                    <ItemTemplate>
                        <asp:Panel ID="Panel1" runat="server" BorderColor="#FF9933" BorderWidth="3px" Height="180px"
                            Width="270px">
                            <table height="150">
                                <tr>
                                    <td width="75%" style="color: #FF0000; font-weight: bold" align="center">
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ThumbnailPhotoUrl") %>'></asp:Image>
                                    </td>
                                </tr>
                                <tr>
                                    <td width="75%" style="color: #0000FF; font-weight: bold">
                                        <asp:Label ID="lbl" runat="server" Text='<%# Eval("Name") %>'></asp:Label></td>
                                </tr>
<%--                                <tr>
                                    <td width="50%" style="color: #009900; font-weight: bold">
                                        <span style="color: Black; font-weight: bold;">Model:</span><br />
                                        <asp:Label ID="lbl2" runat="server" Text='<%#Eval("Model") %>'></asp:Label>
                                    </td>
                                </tr>--%>
                                <tr>
                                    <td width="75%" style="color: #FF0000; font-weight: bold">
                                        <span style="color: Black; font-weight: bold;">Price:</span>
                                        <br />
                                        <asp:Label ID="lbl3" runat="server" Text='<%#Eval("ListPrice") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="Right">
                                        <asp:LinkButton ID="LinkButton1" runat="server" Font-Underline="False" Style="font-weight: 700;
                                            color: Black" CommandName="ViewDetails" CommandArgument='<%#Eval("ProductID") %>'
                                            BackColor="#FF9933">ViewDetails</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </div>
    </form>
</body>
</html>

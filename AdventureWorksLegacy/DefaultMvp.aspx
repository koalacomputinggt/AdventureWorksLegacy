<%@ Page Language="C#" AutoEventWireup="true" Codebehind="DefaultMvp.aspx.cs" Inherits="AdventureWorksLegacy.DefaultMvp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default MVP</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DdlCategories" runat="server" OnSelectedIndexChanged="DdlCategories_SelectedIndexChanged"
                AutoPostBack="True"  AppendDataBoundItems = "True" >
                <asp:ListItem Selected = "True" Text = "--Select--" Value = "0"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:DropDownList ID="DdlSubcategories" runat="server" OnSelectedIndexChanged="DdlSubcategories_SelectedIndexChanged" 
                AutoPostBack="True" AppendDataBoundItems = "True" >
                <asp:ListItem Selected = "True" Text = "--Select--" Value = "0"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
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

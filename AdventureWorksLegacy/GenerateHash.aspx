<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateHash.aspx.cs" Inherits="AdventureWorksLegacy.GenerateHash" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblPwd" runat="Server" >Pwd:</asp:Label>
        <asp:TextBox ID="TxtPwd" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="Server" >Hash:</asp:Label>
        <asp:Label ID="TxtHash" runat="Server"></asp:Label>
        <%--<asp:TextBox ID="TxtHash" runat="server"></asp:TextBox>--%>
        <br />
        <asp:Button ID="BtnGenerateHash" runat="Server" Text="Generate Hash" OnClick="BtnGenerateHash_Click"/>
        <asp:Button ID="BtnSignIn" runat="server" Text="Sign In" OnClick="BtnSignIn_Click" />
        <asp:Label ID="LblResult" runat="server"></asp:Label>
        
    </div>
    </form>
</body>
</html>

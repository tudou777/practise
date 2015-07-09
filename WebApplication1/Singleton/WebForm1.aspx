<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Singleton.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="设置并读取" />
    
    </div>
    </form>
</body>
</html>

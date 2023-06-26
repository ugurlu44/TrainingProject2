<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyMainpageFirstField.aspx.cs" Inherits="TrainingProject2.Admin.ModifyMainpageFirstField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Anasayfa Mesajı"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtMainpageMessage" runat="server" Height="59px" Width="212px"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click" Text="Güncelle" />
    </form>
</body>
</html>

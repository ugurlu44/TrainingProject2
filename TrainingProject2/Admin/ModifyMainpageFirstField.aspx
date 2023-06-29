<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyMainpageFirstField.aspx.cs" Inherits="TrainingProject2.Admin.ModifyMainpageFirstField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server" Text="Anasayfa İlk Satır Mesajı"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtFirstLinieMessage" runat="server" Height="137px" TextMode="MultiLine" Width="317px"></asp:TextBox>
        <br />
        <asp:Button ID="btn_updateFirstLinie" runat="server" OnClick="btn_updateFirstLinie_Click" Text="Güncelle" />
        <br />
        <br />
        <br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Anasayfa İkinci Satır Mesajı"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtSecondLinieMessage" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="btn_updateSecondLinie" runat="server" OnClick="btn_updateSecondLinie_Click" Text="Güncelle" />
        <br />
    </form>
</body>
</html>

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
        <asp:TextBox ID="txtFirstLinieMessage" runat="server" Height="137px" TextMode="MultiLine" Width="317px"></asp:TextBox>
        <br />
        <br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Anasayfa İkinci Satır Mesajı"></asp:Label>
            <br />
            <asp:TextBox ID="txtSecondLinieMessage" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Anasayfa Başlarken Mesajı"></asp:Label>
            <br />
            <asp:TextBox ID="txtGettingStartedMessage" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Anasayfa Daha Fazla Bilgi Mesajı"></asp:Label>
            <br />
            <asp:TextBox ID="txtGetLibraries" TextMode="MultiLine" runat="server" Height="137px" Width="314px" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Anasayfa WebHosting Mesajı"></asp:Label>
            <br />
            <asp:TextBox ID="txtWebHosting" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Güncelle" />
        <br />
    </form>
</body>
</html>

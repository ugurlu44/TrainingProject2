<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyMainpageFirstField.aspx.cs" Inherits="TrainingProject2.Admin.ModifyMainpageFirstField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 343px;
            position: absolute;
            left: 420px;
            top: 15px;
        }
        .auto-style2 {
            width: 348px;
        }
        .auto-style3 {
            width: 345px;
        }
        .auto-style4 {
            width: 341px;
        }
        .auto-style5 {
            width: 343px;
            position: absolute;
            left: 418px;
            top: 201px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <div class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Anasayfa İlk Satır Mesajı"></asp:Label>
            <br />
            <asp:TextBox ID="txtFirstLinieMessage" runat="server" Height="137px" TextMode="MultiLine" Width="317px"></asp:TextBox>
            <br />
            <br />
                </div>
                <div class="auto-style3">
            <asp:Label ID="Label1" runat="server" Text="Anasayfa İkinci Satır Mesajı"></asp:Label>
            <br />
            <asp:TextBox ID="txtSecondLinieMessage" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
            <br />
            <br />
                </div>
                <div class="auto-style4">
            <asp:Label ID="Label3" runat="server" Text="Anasayfa Başlarken Mesajı"></asp:Label>
            <br />
            <asp:TextBox ID="txtGettingStartedMessage" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
            <br />
            <br />
                </div>
                <div class="auto-style1">
            <asp:Label ID="Label4" runat="server" Text="Anasayfa Daha Fazla Bilgi Mesajı"></asp:Label>
            <br />
            <asp:TextBox ID="txtGetLibraries" TextMode="MultiLine" runat="server" Height="137px" Width="314px" ></asp:TextBox>
            <br />
            <br />
                 </div>
                <div class="auto-style5">
                <asp:Label ID="Label5" runat="server" Text="Anasayfa WebHosting Mesajı"></asp:Label>
                <br />
                <asp:TextBox ID="txtWebHosting" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
                <br />
                <br />
                </div>
            
            <asp:Label ID="Label6" runat="server" Text="Başlangıç"></asp:Label>
                <br />
                <asp:TextBox ID="txtStarter" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
                <br />
                <br />

        
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Güncelle" />
        <br />
        </div>
    </form>
</body>
</html>

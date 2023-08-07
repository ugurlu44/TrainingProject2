<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyMainpageFirstField.aspx.cs" Inherits="TrainingProject2.Admin.ModifyMainpageFirstField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ugur KORKMAZ</title>

</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Anasayfa İlk Satır Mesajı"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtFirstLinieMessage" runat="server" Height="137px" TextMode="MultiLine" Width="317px"></asp:TextBox>
                            </td>
                            <td>Açıklama :<asp:TextBox ID="txtFirstLinieMessageDescription" runat="server"   Width="150"></asp:TextBox>
                                <br /><br />
                                <asp:CheckBox ID="chcFirstLine" runat="server" Text="Aktif/Pasif" />
                               <br /> <br />
                                Bilgi :<asp:TextBox ID="txtFirstLineInfo" runat="server"   Width="150"></asp:TextBox>
                            </td>

                        </tr>
                    </table>
                </td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Anasayfa İkinci Satır Mesajı"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtSecondLinieMessage" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
                            </td>

                            <td>Açıklama :<asp:TextBox ID="txtSecondLinieMessageDescription" runat="server"   Width="150"></asp:TextBox>
                                <br /><br />
                                <asp:CheckBox ID="chcSeconndLine" runat="server" Text="Aktif/Pasif" />
                                <br /> <br />
                                Bilgi :<asp:TextBox ID="txtSecondLineInfo" runat="server"   Width="150"></asp:TextBox>
                            </td>
                        </tr>
                    </table>

                </td>
            </tr>



            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Anasayfa Başlarken Mesajı"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtGettingStartedMessage" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
                            </td>

                            <td>Açıklama :<asp:TextBox ID="txtStartedMessageDescription" runat="server"   Width="150"></asp:TextBox>
                                <br /><br />
                                <asp:CheckBox ID="chcGettingStartedMessage" runat="server" Text="Aktif/Pasif" />
                                <br /> <br />
                                Bilgi :<asp:TextBox ID="txtGettingStartedInfo" runat="server"   Width="150"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Anasayfa Daha Fazla Bilgi Mesajı"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtGetLibraries" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
                            </td>
                            <td>Açıklama :<asp:TextBox ID="txtGetLibrariesDescription" runat="server"   Width="150"></asp:TextBox>
                                <br /><br />
                                <asp:CheckBox ID="chcGetLibraries" runat="server" Text="Aktif/Pasif" />
                                <br /> <br />
                                Bilgi :<asp:TextBox ID="txtGetLibrariesInfo" runat="server"   Width="150"></asp:TextBox>
                            </td>
                        </tr>
                    </table>

                </td>
            </tr>


            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Anasayfa WebHosting Mesajı"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtWebHosting" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
                            </td>

                            <td>Açıklama :<asp:TextBox ID="txtWebhostingDescription" runat="server"   Width="150"></asp:TextBox>
                                <br /><br />
                                <asp:CheckBox ID="chcWebHosting" runat="server" Text="Aktif/Pasif" />
                                <br /> <br />
                                Bilgi :<asp:TextBox ID="txtWebhostingInfo" runat="server"   Width="150"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Başlangıç"></asp:Label>
                                <br />
                                <asp:TextBox ID="txtStarter" TextMode="MultiLine" runat="server" Height="137px" Width="314px"></asp:TextBox>
                            </td>
                            <td>Açıklama :<asp:TextBox ID="txtStarterDescription" runat="server"   Width="150"></asp:TextBox>
                                <br /><br />
                                <asp:CheckBox ID="chcStarter" runat="server" Text="Aktif/Pasif" />
                                <br /> <br />
                                Bilgi :<asp:TextBox ID="txtStarterInfo" runat="server"   Width="150"></asp:TextBox>
                            </td>
                        </tr>
                    </table>

                </td>
            </tr>

        </table>

        <br />

        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Güncelle" />
        <br />
    </form>
</body>
</html>

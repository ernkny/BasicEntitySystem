<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proje.WebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Getir" OnClick="Button1_Click" />
        </div>
        <div>
        <table >
              <tr>
                <th>Modal</th>
                <th>Particular</th>
                <th>Total</th>
              </tr>
              <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label></td>
                <td><asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label></td>
                <td><asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label></td>
              </tr>
             
            </table>
        </div>
        <div>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Id"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" placeholder="Modal"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" placeholder="Particular"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" placeholder="Total"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Güncelle" OnClick="Button2_Click" /><asp:Label style="margin-left:20px;" ID="Label6" runat="server" Text="Label"></asp:Label>
        </div>

        <div>
             <asp:TextBox ID="TextBox6" runat="server" placeholder="Id"></asp:TextBox>
        </div>
        <div>
             <asp:Button ID="Button3" runat="server" Text="Sil" OnClick="Button3_Click" />
            <asp:Label style="margin-left:20px;" ID="Label7" runat="server" Text=""></asp:Label>
        </div>
        <div>
             <asp:TextBox ID="TextBox7" runat="server" placeholder="Model"></asp:TextBox>
             <asp:TextBox ID="TextBox8" runat="server" placeholder="Particular"></asp:TextBox>
             <asp:TextBox ID="TextBox9" runat="server" placeholder="Total"></asp:TextBox>
             
        </div>
        <div>
            <asp:Button ID="Button4" runat="server" Text="Ekle" OnClick="Button4_Click" />
            <asp:Label style="margin-left:20px;" ID="Label5" runat="server" Text=""></asp:Label>
        </div>
        <div style="margin-top:30px">
            <asp:Button ID="Button5" runat="server" Text="Ürünler Getir" OnClick="Button5_Click" />
        </div>
        <div>
             <asp:Label style="margin-left:20px;" ID="Label8" runat="server" Visible="False"></asp:Label>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>

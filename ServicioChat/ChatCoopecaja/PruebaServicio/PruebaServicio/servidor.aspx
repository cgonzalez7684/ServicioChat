<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="servidor.aspx.cs" Inherits="PruebaServicio.servidor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Interval="3000" OnTick="Timer1_Tick">
        </asp:Timer>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
            <ContentTemplate>
                <asp:ListBox ID="ListBox1" runat="server" Height="137px"  Width="407px"></asp:ListBox>
                <br />
                <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="394px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
         <br />
         <br />
        <br />
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Id_interno"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nombre Usuario Interno"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ingreso de usuario" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Salida de usuario" OnClick="Button3_Click" Width="87px" />
        <br />
        <br />
        id_chat<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button4" runat="server" Text="unirse a chat" OnClick="Button4_Click" />
    </form>
</body>
</html>

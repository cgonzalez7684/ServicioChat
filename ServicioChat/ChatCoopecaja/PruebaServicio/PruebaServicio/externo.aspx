<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="externo.aspx.cs" Inherits="PruebaServicio.externo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   


</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
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
                <asp:ListBox ID="ListBox1" runat="server" Height="398px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="603px"></asp:ListBox>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="591px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>

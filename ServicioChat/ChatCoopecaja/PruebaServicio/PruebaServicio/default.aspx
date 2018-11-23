<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PruebaServicio._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
        window.$zopim || (function (d, s) {
            var z = $zopim = function (c) { z._.push(c) }, $ = z.s =
            d.createElement(s), e = d.getElementsByTagName(s)[0]; z.set = function (o) {
                z.set.
                _.push(o)
            }; z._ = []; z.set._ = []; $.async = !0; $.setAttribute("charset", "utf-8");
            $.src = "//v2.zopim.com/?3g6kv7xnK1k8RYaMlpYWrc5KYaoLyMcT"; z.t = +new Date; $.
            type = "text/javascript"; e.parentNode.insertBefore($, e)
        })(document, "script");
</script>
<!--End of Zopim Live Chat Script-->

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Escoja que tipo de usuario es<br />
        <br />
    
    </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/externo.aspx">CLIENTE</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/servidor.aspx">USUARIO INTERNO</asp:HyperLink>
    </form>
</body>
</html>

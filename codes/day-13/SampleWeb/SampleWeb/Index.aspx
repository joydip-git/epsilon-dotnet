<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SampleWeb.Index" %>
<!-- Active Server Pages Extended (ASPX) -->

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <script>
       function call() {
           var inputValue = document.getElementById('txtSample').value;
           window.alert(`Input Value:${inputValue}`);
       }
   </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            HTML:&nbsp;<input type="text" id="txtSample" />
            <br />
            Server:&nbsp;<asp:TextBox ID="txtValue" runat="server" />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="ServerButtonClicked"/>
            <br />
            <input type="button" value="Click" id="btnInput" onclick="call()"/>
        </div>
    </form>
</body>
</html>

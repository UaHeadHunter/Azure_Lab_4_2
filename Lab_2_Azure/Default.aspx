<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_2_Azure.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="calc-container">
        <h1>CALCULATOR</h1>
        <div>
            <asp:TextBox ID="CalcField" runat="server">0</asp:TextBox>
        </div>
        <div class="bottom-section">
            <div class="numbers-section">
                <asp:Button ID="btn7" runat="server" Text="7" OnClick="btnNumb7_Click" />
                <asp:Button ID="btn8" runat="server" Text="8" OnClick="btnNumb8_Click" />
                <asp:Button ID="btn9" runat="server" Text="9" OnClick="btnNumb9_Click" />
                <asp:Button ID="btnAdd" runat="server" Text="+" OnClick="btnAdd_Click" />
                <asp:Button ID="btn4" runat="server" Text="4" OnClick="btnNumb4_Click" />
                <asp:Button ID="btn5" runat="server" Text="5" OnClick="btnNumb5_Click" />
                <asp:Button ID="btn6" runat="server" Text="6" OnClick="btnNumb6_Click" />
                <asp:Button ID="btnSubtract" runat="server" Text="-"  OnClick="btnSubtract_Click"/>
                <asp:Button ID="btn1" runat="server" Text="1" OnClick="btnNumb1_Click" />
                <asp:Button ID="btn2" runat="server" Text="2" OnClick="btnNumb2_Click" />
                <asp:Button ID="btn3" runat="server" Text="3" OnClick="btnNumb3_Click" />
                <asp:Button ID="btnMultiply" runat="server" Text="*"  OnClick="btnMultiply_Click"/>  
                <asp:Button ID="btn0" runat="server" Text="0" OnClick="btnNumb0_Click" />
                <asp:Button ID="btnClear" runat="server" Text="C" OnClick="btnClear_Click" />
                <asp:Button ID="btnCalculate" runat="server" Text="=" OnClick="btnCalculate_Click"/> 
                <asp:Button ID="btnDivide" runat="server" Text="/" OnClick="btnDivide_Click"/>  
            </div>  
        </div>
    </div>
    </form>
</body>

 <script type="text/javascript" src="scripts/jquery-3.1.1.js"></script>
</html>

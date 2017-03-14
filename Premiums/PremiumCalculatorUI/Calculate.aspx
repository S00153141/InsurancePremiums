<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculate.aspx.cs" Inherits="PremiumCalculatorUI.Calculate" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <section>
        <div class="col-md-6 col-md-offset-3">
            <h3>Calculate your Premium!</h3>
            <div>
                <h4>Gender:</h4>
                <input type="text" class="form-control" id="tbxGender" runat="server" />
            </div>
            
            <div>
                <h4>Age:</h4>
                <input type="text" class="form-control" id="tbxAge" runat="server"/>
            </div>
            
            <div>
                <asp:Button Text="Calculate" runat="server" ID="btnCalculate" OnClick="CalculatePremium" />
            </div>
            
            <div>
                <h4>Outcome:</h4>
                <p id="pOutcome" runat="server"></p>
            </div>
            
        </div>
    </section>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Carpool.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>List of available rides<br />
        <br />
        <asp:GridView ID="RideView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="EmpName" HeaderText="Employee Name" />
                <asp:BoundField DataField="Source" HeaderText="Source" />
                <asp:BoundField DataField="Destination" HeaderText="Destination" />
                <asp:BoundField DataField="Ride_Time" HeaderText="Time" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone No" />
            </Columns>
        </asp:GridView>
        </div>
        
    </form>
</body>
</html>

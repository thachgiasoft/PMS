<%@ Control Language="C#" ClassName="HeSoNhomMonFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomMon" runat="server" Text="Ma Nhom Mon:" AssociatedControlID="dataMaNhomMon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomMon" Text='<%# Bind("MaNhomMon") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaNhomMon" runat="server" Display="Dynamic" ControlToValidate="dataMaNhomMon" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMaNhomMon" runat="server" Display="Dynamic" ControlToValidate="dataMaNhomMon" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSo" runat="server" Text="Si So:" AssociatedControlID="dataSiSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSo" Text='<%# Bind("SiSo") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataSiSo" runat="server" Display="Dynamic" ControlToValidate="dataSiSo" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataSiSo" runat="server" Display="Dynamic" ControlToValidate="dataSiSo" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



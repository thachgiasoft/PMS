<%@ Control Language="C#" ClassName="HeSoTroCapTheoKhoaFields" %>

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
        <td class="literal"><asp:Label ID="lbldataTenKhoa" runat="server" Text="Ten Khoa:" AssociatedControlID="dataTenKhoa" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenKhoa" Text='<%# Bind("TenKhoa") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaKhoa" runat="server" Text="Ma Khoa:" AssociatedControlID="dataMaKhoa" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaKhoa" Text='<%# Bind("MaKhoa") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaKhoa" runat="server" Display="Dynamic" ControlToValidate="dataMaKhoa" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



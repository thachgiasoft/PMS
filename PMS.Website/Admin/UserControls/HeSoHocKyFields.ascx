<%@ Control Language="C#" ClassName="HeSoHocKyFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHocKy" runat="server" Text="Ten Hoc Ky:" AssociatedControlID="dataTenHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHocKy" Text='<%# Bind("TenHocKy") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuTu" runat="server" Text="Thu Tu:" AssociatedControlID="dataThuTu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuTu" Text='<%# Bind("ThuTu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuTu" runat="server" Display="Dynamic" ControlToValidate="dataThuTu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



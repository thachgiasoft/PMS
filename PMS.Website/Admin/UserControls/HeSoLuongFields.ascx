<%@ Control Language="C#" ClassName="HeSoLuongFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataDenKhoan" runat="server" Text="Den Khoan:" AssociatedControlID="dataDenKhoan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDenKhoan" Text='<%# Bind("DenKhoan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDenKhoan" runat="server" Display="Dynamic" ControlToValidate="dataDenKhoan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuKhoan" runat="server" Text="Tu Khoan:" AssociatedControlID="dataTuKhoan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuKhoan" Text='<%# Bind("TuKhoan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTuKhoan" runat="server" Display="Dynamic" ControlToValidate="dataTuKhoan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



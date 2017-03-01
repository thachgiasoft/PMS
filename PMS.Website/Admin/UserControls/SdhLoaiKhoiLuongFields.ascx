<%@ Control Language="C#" ClassName="SdhLoaiKhoiLuongFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNghiaVu" runat="server" Text="Nghia Vu:" AssociatedControlID="dataNghiaVu" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataNghiaVu" SelectedValue='<%# Bind("NghiaVu") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLoaiKhoiLuong" runat="server" Text="Ten Loai Khoi Luong:" AssociatedControlID="dataTenLoaiKhoiLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLoaiKhoiLuong" Text='<%# Bind("TenLoaiKhoiLuong") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiKhoiLuong" runat="server" Text="Ma Loai Khoi Luong:" AssociatedControlID="dataMaLoaiKhoiLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiKhoiLuong" Text='<%# Bind("MaLoaiKhoiLuong") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLoaiKhoiLuong" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiKhoiLuong" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhom" runat="server" Text="Ma Nhom:" AssociatedControlID="dataMaNhom" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhom" Text='<%# Bind("MaNhom") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaNhom" runat="server" Display="Dynamic" ControlToValidate="dataMaNhom" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



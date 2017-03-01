<%@ Control Language="C#" ClassName="HeSoNgayFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaQuanLy" runat="server" Display="Dynamic" ControlToValidate="dataMaQuanLy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHeSo" runat="server" Text="Ten He So:" AssociatedControlID="dataTenHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHeSo" Text='<%# Bind("TenHeSo") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSo" runat="server" Text="He So:" AssociatedControlID="dataHeSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSo" Text='<%# Bind("HeSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietBatDau" runat="server" Text="Tiet Bat Dau:" AssociatedControlID="dataTietBatDau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietBatDau" Text='<%# Bind("TietBatDau") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietBatDau" runat="server" Display="Dynamic" ControlToValidate="dataTietBatDau" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietKetThuc" runat="server" Text="Tiet Ket Thuc:" AssociatedControlID="dataTietKetThuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietKetThuc" Text='<%# Bind("TietKetThuc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietKetThuc" runat="server" Display="Dynamic" ControlToValidate="dataTietKetThuc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietNghiaVu" runat="server" Text="Tiet Nghia Vu:" AssociatedControlID="dataTietNghiaVu" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTietNghiaVu" SelectedValue='<%# Bind("TietNghiaVu") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTrongGio" runat="server" Text="Trong Gio:" AssociatedControlID="dataTrongGio" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTrongGio" SelectedValue='<%# Bind("TrongGio") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBuoi" runat="server" Text="Ma Buoi:" AssociatedControlID="dataMaBuoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBuoi" Text='<%# Bind("MaBuoi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenBuoi" runat="server" Text="Ten Buoi:" AssociatedControlID="dataTenBuoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenBuoi" Text='<%# Bind("TenBuoi") %>' MaxLength="200"></asp:TextBox>
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



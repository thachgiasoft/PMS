<%@ Control Language="C#" ClassName="HocHamFields" %>

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
        <td class="literal"><asp:Label ID="lbldataTenHocHam" runat="server" Text="Ten Hoc Ham:" AssociatedControlID="dataTenHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHocHam" Text='<%# Bind("TenHocHam") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThucLanh" runat="server" Text="Thuc Lanh:" AssociatedControlID="dataThucLanh" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataThucLanh" SelectedValue='<%# Bind("ThucLanh") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuTu" runat="server" Text="Thu Tu:" AssociatedControlID="dataThuTu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuTu" Text='<%# Bind("ThuTu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThuTu" runat="server" Display="Dynamic" ControlToValidate="dataThuTu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHrmid" runat="server" Text="Hrmid:" AssociatedControlID="dataHrmid" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataHrmid" Value='<%# Bind("Hrmid") %>'></asp:HiddenField>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



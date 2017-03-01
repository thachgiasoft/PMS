<%@ Control Language="C#" ClassName="PhanQuyenControlTrenFormFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataKhongDuocPhepCapNhat" runat="server" Text="Khong Duoc Phep Cap Nhat:" AssociatedControlID="dataKhongDuocPhepCapNhat" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataKhongDuocPhepCapNhat" SelectedValue='<%# Bind("KhongDuocPhepCapNhat") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenForm" runat="server" Text="Ten Form:" AssociatedControlID="dataTenForm" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenForm" Text='<%# Bind("TenForm") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaTaiKhoan" runat="server" Text="Ma Tai Khoan:" AssociatedControlID="dataMaTaiKhoan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaTaiKhoan" Text='<%# Bind("MaTaiKhoan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaTaiKhoan" runat="server" Display="Dynamic" ControlToValidate="dataMaTaiKhoan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



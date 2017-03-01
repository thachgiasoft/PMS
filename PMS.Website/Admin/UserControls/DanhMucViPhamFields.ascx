<%@ Control Language="C#" ClassName="DanhMucViPhamFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataCoXepLoai" runat="server" Text="Co Xep Loai:" AssociatedControlID="dataCoXepLoai" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataCoXepLoai" SelectedValue='<%# Bind("CoXepLoai") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaViPham" runat="server" Text="Ma Vi Pham:" AssociatedControlID="dataMaViPham" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaViPham" Text='<%# Bind("MaViPham") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaViPham" runat="server" Display="Dynamic" ControlToValidate="dataMaViPham" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDungViPham" runat="server" Text="Noi Dung Vi Pham:" AssociatedControlID="dataNoiDungViPham" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDungViPham" Text='<%# Bind("NoiDungViPham") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



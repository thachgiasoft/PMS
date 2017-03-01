<%@ Control Language="C#" ClassName="NgonNguGiangDayFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenNgonNgu" runat="server" Text="Ten Ngon Ngu:" AssociatedControlID="dataTenNgonNgu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenNgonNgu" Text='<%# Bind("TenNgonNgu") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNgonNgu" runat="server" Text="Ma Ngon Ngu:" AssociatedControlID="dataMaNgonNgu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNgonNgu" Text='<%# Bind("MaNgonNgu") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaNgonNgu" runat="server" Display="Dynamic" ControlToValidate="dataMaNgonNgu" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



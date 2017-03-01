<%@ Control Language="C#" ClassName="LyDoTamNghiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTinhGiamTruGioChuan" runat="server" Text="Tinh Giam Tru Gio Chuan:" AssociatedControlID="dataTinhGiamTruGioChuan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTinhGiamTruGioChuan" SelectedValue='<%# Bind("TinhGiamTruGioChuan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenLyDoTamNghi" runat="server" Text="Ten Ly Do Tam Nghi:" AssociatedControlID="dataTenLyDoTamNghi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenLyDoTamNghi" Text='<%# Bind("TenLyDoTamNghi") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



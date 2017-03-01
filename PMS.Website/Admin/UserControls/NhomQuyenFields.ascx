<%@ Control Language="C#" ClassName="NhomQuyenFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataQlNhomQuyen" runat="server" Text="Ql Nhom Quyen:" AssociatedControlID="dataQlNhomQuyen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataQlNhomQuyen" Text='<%# Bind("QlNhomQuyen") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenNhomQuyen" runat="server" Text="Ten Nhom Quyen:" AssociatedControlID="dataTenNhomQuyen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenNhomQuyen" Text='<%# Bind("TenNhomQuyen") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



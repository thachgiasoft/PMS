<%@ Control Language="C#" ClassName="DanhMucQuyMoFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenQuyMo" runat="server" Text="Ten Quy Mo:" AssociatedControlID="dataTenQuyMo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenQuyMo" Text='<%# Bind("TenQuyMo") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuyMo" runat="server" Text="Ma Quy Mo:" AssociatedControlID="dataMaQuyMo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuyMo" Text='<%# Bind("MaQuyMo") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



<%@ Control Language="C#" ClassName="BacLuongFields" %>

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
        <td class="literal"><asp:Label ID="lbldataTenBacLuong" runat="server" Text="Ten Bac Luong:" AssociatedControlID="dataTenBacLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenBacLuong" Text='<%# Bind("TenBacLuong") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBacLuong" runat="server" Text="Ma Bac Luong:" AssociatedControlID="dataMaBacLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBacLuong" Text='<%# Bind("MaBacLuong") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaBacLuong" runat="server" Display="Dynamic" ControlToValidate="dataMaBacLuong" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



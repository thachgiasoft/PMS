<%@ Control Language="C#" ClassName="QuocTichFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHrmid" runat="server" Text="Hrmid:" AssociatedControlID="dataHrmid" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataHrmid" Value='<%# Bind("Hrmid") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenQuocTich" runat="server" Text="Ten Quoc Tich:" AssociatedControlID="dataTenQuocTich" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenQuocTich" Text='<%# Bind("TenQuocTich") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuocTich" runat="server" Text="Ma Quoc Tich:" AssociatedControlID="dataMaQuocTich" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuocTich" Text='<%# Bind("MaQuocTich") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



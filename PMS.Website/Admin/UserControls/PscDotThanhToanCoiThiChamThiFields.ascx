<%@ Control Language="C#" ClassName="PscDotThanhToanCoiThiChamThiFields" %>

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
        <td class="literal"><asp:Label ID="lbldataTenDot" runat="server" Text="Ten Dot:" AssociatedControlID="dataTenDot" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenDot" Text='<%# Bind("TenDot") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDot" runat="server" Text="Ma Dot:" AssociatedControlID="dataMaDot" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDot" Text='<%# Bind("MaDot") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaDot" runat="server" Display="Dynamic" ControlToValidate="dataMaDot" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



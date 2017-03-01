<%@ Control Language="C#" ClassName="TienCongTacPhiFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTien" runat="server" Text="So Tien:" AssociatedControlID="dataSoTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTien" Text='<%# Bind("SoTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTien" runat="server" Display="Dynamic" ControlToValidate="dataSoTien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaCoSo" runat="server" Text="Ma Co So:" AssociatedControlID="dataMaCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaCoSo" Text='<%# Bind("MaCoSo") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaCoSo" runat="server" Display="Dynamic" ControlToValidate="dataMaCoSo" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenCoSo" runat="server" Text="Ten Co So:" AssociatedControlID="dataTenCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenCoSo" Text='<%# Bind("TenCoSo") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



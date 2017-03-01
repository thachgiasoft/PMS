<%@ Control Language="C#" ClassName="KhoanChiKhacFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucChi" runat="server" Text="Muc Chi:" AssociatedControlID="dataMucChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMucChi" Text='<%# Bind("MucChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMucChi" runat="server" Display="Dynamic" ControlToValidate="dataMucChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDung" runat="server" Text="Noi Dung:" AssociatedControlID="dataNoiDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDung" Text='<%# Bind("NoiDung") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



<%@ Control Language="C#" ClassName="VaiTroFields" %>

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
        <td class="literal"><asp:Label ID="lbldataChia" runat="server" Text="Chia:" AssociatedControlID="dataChia" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataChia" SelectedValue='<%# Bind("Chia") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucHuong" runat="server" Text="Muc Huong:" AssociatedControlID="dataMucHuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMucHuong" Text='<%# Bind("MucHuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMucHuong" runat="server" Display="Dynamic" ControlToValidate="dataMucHuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaVaiTro" runat="server" Text="Ma Vai Tro:" AssociatedControlID="dataMaVaiTro" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaVaiTro" Text='<%# Bind("MaVaiTro") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenVaiTro" runat="server" Text="Ten Vai Tro:" AssociatedControlID="dataTenVaiTro" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenVaiTro" Text='<%# Bind("TenVaiTro") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



<%@ Control Language="C#" ClassName="HinhThucDaoTaoFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNhanDonGia" runat="server" Text="He So Nhan Don Gia:" AssociatedControlID="dataHeSoNhanDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNhanDonGia" Text='<%# Bind("HeSoNhanDonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNhanDonGia" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNhanDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTinhGioChuan" runat="server" Text="Tinh Gio Chuan:" AssociatedControlID="dataTinhGioChuan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataTinhGioChuan" SelectedValue='<%# Bind("TinhGioChuan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHinhThucDaoTao" runat="server" Text="Ma Hinh Thuc Dao Tao:" AssociatedControlID="dataMaHinhThucDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHinhThucDaoTao" Text='<%# Bind("MaHinhThucDaoTao") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaHinhThucDaoTao" runat="server" Display="Dynamic" ControlToValidate="dataMaHinhThucDaoTao" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHinhThucDaoTao" runat="server" Text="Ten Hinh Thuc Dao Tao:" AssociatedControlID="dataTenHinhThucDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHinhThucDaoTao" Text='<%# Bind("TenHinhThucDaoTao") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



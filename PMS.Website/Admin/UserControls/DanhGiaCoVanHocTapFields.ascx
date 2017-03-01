<%@ Control Language="C#" ClassName="DanhGiaCoVanHocTapFields" %>

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
        <td class="literal"><asp:Label ID="lbldataPhanTramHuongThu" runat="server" Text="Phan Tram Huong Thu:" AssociatedControlID="dataPhanTramHuongThu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanTramHuongThu" Text='<%# Bind("PhanTramHuongThu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanTramHuongThu" runat="server" Display="Dynamic" ControlToValidate="dataPhanTramHuongThu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDungDanhGia" runat="server" Text="Noi Dung Danh Gia:" AssociatedControlID="dataNoiDungDanhGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDungDanhGia" Text='<%# Bind("NoiDungDanhGia") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



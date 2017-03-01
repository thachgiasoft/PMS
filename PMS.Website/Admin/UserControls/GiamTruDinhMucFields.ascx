<%@ Control Language="C#" ClassName="GiamTruDinhMucFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonVi" runat="server" Text="Don Vi:" AssociatedControlID="dataDonVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonVi" Text='<%# Bind("DonVi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucGiamNckh" runat="server" Text="Muc Giam Nckh:" AssociatedControlID="dataMucGiamNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMucGiamNckh" Text='<%# Bind("MucGiamNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMucGiamNckh" runat="server" Display="Dynamic" ControlToValidate="dataMucGiamNckh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanTramGiamTru" runat="server" Text="Phan Tram Giam Tru:" AssociatedControlID="dataPhanTramGiamTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanTramGiamTru" Text='<%# Bind("PhanTramGiamTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanTramGiamTru" runat="server" Display="Dynamic" ControlToValidate="dataPhanTramGiamTru" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDungGiamTru" runat="server" Text="Noi Dung Giam Tru:" AssociatedControlID="dataNoiDungGiamTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDungGiamTru" Text='<%# Bind("NoiDungGiamTru") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucGiam" runat="server" Text="Muc Giam:" AssociatedControlID="dataMucGiam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMucGiam" Text='<%# Bind("MucGiam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMucGiam" runat="server" Display="Dynamic" ControlToValidate="dataMucGiam" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



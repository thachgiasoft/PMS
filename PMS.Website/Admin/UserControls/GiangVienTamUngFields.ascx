<%@ Control Language="C#" ClassName="GiangVienTamUngFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioNghiaVuGiangDay" runat="server" Text="Gio Nghia Vu Giang Day:" AssociatedControlID="dataGioNghiaVuGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioNghiaVuGiangDay" Text='<%# Bind("GioNghiaVuGiangDay") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioNghiaVuGiangDay" runat="server" Display="Dynamic" ControlToValidate="dataGioNghiaVuGiangDay" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioNghiaVuNckh" runat="server" Text="Gio Nghia Vu Nckh:" AssociatedControlID="dataGioNghiaVuNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioNghiaVuNckh" Text='<%# Bind("GioNghiaVuNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioNghiaVuNckh" runat="server" Display="Dynamic" ControlToValidate="dataGioNghiaVuNckh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotThanhToan" runat="server" Text="Dot Thanh Toan:" AssociatedControlID="dataDotThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotThanhToan" Text='<%# Bind("DotThanhToan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDotThanhToan" runat="server" Display="Dynamic" ControlToValidate="dataDotThanhToan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioGiangDayQuyDoi" runat="server" Text="Gio Giang Day Quy Doi:" AssociatedControlID="dataGioGiangDayQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioGiangDayQuyDoi" Text='<%# Bind("GioGiangDayQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioGiangDayQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataGioGiangDayQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoGioQuyDoi" runat="server" Text="So Gio Quy Doi:" AssociatedControlID="dataSoGioQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoGioQuyDoi" Text='<%# Bind("SoGioQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoGioQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataSoGioQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoGioQuyDoiKhoiLuongCongThem" runat="server" Text="So Gio Quy Doi Khoi Luong Cong Them:" AssociatedControlID="dataSoGioQuyDoiKhoiLuongCongThem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoGioQuyDoiKhoiLuongCongThem" Text='<%# Bind("SoGioQuyDoiKhoiLuongCongThem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoGioQuyDoiKhoiLuongCongThem" runat="server" Display="Dynamic" ControlToValidate="dataSoGioQuyDoiKhoiLuongCongThem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioNckh" runat="server" Text="Gio Nckh:" AssociatedControlID="dataGioNckh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGioNckh" Text='<%# Bind("GioNckh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGioNckh" runat="server" Display="Dynamic" ControlToValidate="dataGioNckh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTien" runat="server" Text="So Tien:" AssociatedControlID="dataSoTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTien" Text='<%# Bind("SoTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTien" runat="server" Display="Dynamic" ControlToValidate="dataSoTien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayTamUng" runat="server" Text="Ngay Tam Ung:" AssociatedControlID="dataNgayTamUng" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayTamUng" Text='<%# Bind("NgayTamUng", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayTamUng" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHoTen" runat="server" Text="Ho Ten:" AssociatedControlID="dataHoTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHoTen" Text='<%# Bind("HoTen") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
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



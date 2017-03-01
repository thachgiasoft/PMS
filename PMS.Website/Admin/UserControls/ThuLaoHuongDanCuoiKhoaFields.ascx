<%@ Control Language="C#" ClassName="ThuLaoHuongDanCuoiKhoaFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTienNoGioChuan" runat="server" Text="Thanh Tien No Gio Chuan:" AssociatedControlID="dataThanhTienNoGioChuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTienNoGioChuan" Text='<%# Bind("ThanhTienNoGioChuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTienNoGioChuan" runat="server" Display="Dynamic" ControlToValidate="dataThanhTienNoGioChuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThue" runat="server" Text="Thue:" AssociatedControlID="dataThue" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThue" Text='<%# Bind("Thue") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThue" runat="server" Display="Dynamic" ControlToValidate="dataThue" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietNoGioChuan" runat="server" Text="So Tiet No Gio Chuan:" AssociatedControlID="dataSoTietNoGioChuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietNoGioChuan" Text='<%# Bind("SoTietNoGioChuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietNoGioChuan" runat="server" Display="Dynamic" ControlToValidate="dataSoTietNoGioChuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoLuongThamGiaHoiDongTotNghiep" runat="server" Text="So Luong Tham Gia Hoi Dong Tot Nghiep:" AssociatedControlID="dataSoLuongThamGiaHoiDongTotNghiep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLuongThamGiaHoiDongTotNghiep" Text='<%# Bind("SoLuongThamGiaHoiDongTotNghiep") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLuongThamGiaHoiDongTotNghiep" runat="server" Display="Dynamic" ControlToValidate="dataSoLuongThamGiaHoiDongTotNghiep" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTienThamGiaHoiDongTotNghiep" runat="server" Text="Thanh Tien Tham Gia Hoi Dong Tot Nghiep:" AssociatedControlID="dataThanhTienThamGiaHoiDongTotNghiep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTienThamGiaHoiDongTotNghiep" Text='<%# Bind("ThanhTienThamGiaHoiDongTotNghiep") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTienThamGiaHoiDongTotNghiep" runat="server" Display="Dynamic" ControlToValidate="dataThanhTienThamGiaHoiDongTotNghiep" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChotKhoiLuong" runat="server" Text="Chot Khoi Luong:" AssociatedControlID="dataChotKhoiLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChotKhoiLuong" Text='<%# Bind("ChotKhoiLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataChotKhoiLuong" runat="server" Display="Dynamic" ControlToValidate="dataChotKhoiLuong" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThucLanh" runat="server" Text="Thuc Lanh:" AssociatedControlID="dataThucLanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThucLanh" Text='<%# Bind("ThucLanh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThucLanh" runat="server" Display="Dynamic" ControlToValidate="dataThucLanh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiDung" runat="server" Text="Noi Dung:" AssociatedControlID="dataNoiDung" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiDung" Text='<%# Bind("NoiDung") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTienKhoaLuanChuyenDeTotNghiep" runat="server" Text="Thanh Tien Khoa Luan Chuyen De Tot Nghiep:" AssociatedControlID="dataThanhTienKhoaLuanChuyenDeTotNghiep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTienKhoaLuanChuyenDeTotNghiep" Text='<%# Bind("ThanhTienKhoaLuanChuyenDeTotNghiep") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTienKhoaLuanChuyenDeTotNghiep" runat="server" Display="Dynamic" ControlToValidate="dataThanhTienKhoaLuanChuyenDeTotNghiep" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotChiTra" runat="server" Text="Dot Chi Tra:" AssociatedControlID="dataDotChiTra" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotChiTra" Text='<%# Bind("DotChiTra") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHuongDanVietBaoCaoTotNghiep" runat="server" Text="Huong Dan Viet Bao Cao Tot Nghiep:" AssociatedControlID="dataHuongDanVietBaoCaoTotNghiep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHuongDanVietBaoCaoTotNghiep" Text='<%# Bind("HuongDanVietBaoCaoTotNghiep") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHuongDanVietBaoCaoTotNghiep" runat="server" Display="Dynamic" ControlToValidate="dataHuongDanVietBaoCaoTotNghiep" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVienQuanLy" runat="server" Text="Ma Giang Vien Quan Ly:" AssociatedControlID="dataMaGiangVienQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVienQuanLy" Text='<%# Bind("MaGiangVienQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietQuyDoi" runat="server" Text="So Tiet Quy Doi:" AssociatedControlID="dataSoTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietQuyDoi" Text='<%# Bind("SoTietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataSoTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanBienKhoaLuanTotNghiep" runat="server" Text="Phan Bien Khoa Luan Tot Nghiep:" AssociatedControlID="dataPhanBienKhoaLuanTotNghiep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanBienKhoaLuanTotNghiep" Text='<%# Bind("PhanBienKhoaLuanTotNghiep") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataPhanBienKhoaLuanTotNghiep" runat="server" Display="Dynamic" ControlToValidate="dataPhanBienKhoaLuanTotNghiep" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHuongDanChuyenDeThucTapTotNghiep" runat="server" Text="Huong Dan Chuyen De Thuc Tap Tot Nghiep:" AssociatedControlID="dataHuongDanChuyenDeThucTapTotNghiep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHuongDanChuyenDeThucTapTotNghiep" Text='<%# Bind("HuongDanChuyenDeThucTapTotNghiep") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHuongDanChuyenDeThucTapTotNghiep" runat="server" Display="Dynamic" ControlToValidate="dataHuongDanChuyenDeThucTapTotNghiep" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHuongDanKhoaLuanTotNghiep" runat="server" Text="Huong Dan Khoa Luan Tot Nghiep:" AssociatedControlID="dataHuongDanKhoaLuanTotNghiep" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHuongDanKhoaLuanTotNghiep" Text='<%# Bind("HuongDanKhoaLuanTotNghiep") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHuongDanKhoaLuanTotNghiep" runat="server" Display="Dynamic" ControlToValidate="dataHuongDanKhoaLuanTotNghiep" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



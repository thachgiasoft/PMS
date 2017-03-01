<%@ Control Language="C#" ClassName="DanhSachHopDongThinhGiangFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLopDong" runat="server" Text="He So Lop Dong:" AssociatedControlID="dataHeSoLopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLopDong" Text='<%# Bind("HeSoLopDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLopDong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLopDong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongSoTietTrenTuan" runat="server" Text="Tong So Tiet Tren Tuan:" AssociatedControlID="dataTongSoTietTrenTuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongSoTietTrenTuan" Text='<%# Bind("TongSoTietTrenTuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongSoTietTrenTuan" runat="server" Display="Dynamic" ControlToValidate="dataTongSoTietTrenTuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTrangThaiHoSo" runat="server" Text="Trang Thai Ho So:" AssociatedControlID="dataTrangThaiHoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTrangThaiHoSo" Text='<%# Bind("TrangThaiHoSo") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSo" runat="server" Text="Si So:" AssociatedControlID="dataSiSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSo" Text='<%# Bind("SiSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSo" runat="server" Display="Dynamic" ControlToValidate="dataSiSo" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietThucHanhTrenTuan" runat="server" Text="So Tiet Thuc Hanh Tren Tuan:" AssociatedControlID="dataSoTietThucHanhTrenTuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietThucHanhTrenTuan" Text='<%# Bind("SoTietThucHanhTrenTuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietThucHanhTrenTuan" runat="server" Display="Dynamic" ControlToValidate="dataSoTietThucHanhTrenTuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoNhomThucHanh" runat="server" Text="So Nhom Thuc Hanh:" AssociatedControlID="dataSoNhomThucHanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoNhomThucHanh" Text='<%# Bind("SoNhomThucHanh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoNhomThucHanh" runat="server" Display="Dynamic" ControlToValidate="dataSoNhomThucHanh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoiThucHanh" runat="server" Text="He So Quy Doi Thuc Hanh:" AssociatedControlID="dataHeSoQuyDoiThucHanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoiThucHanh" Text='<%# Bind("HeSoQuyDoiThucHanh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoiThucHanh" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoiThucHanh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietLyThuyetTrenTuan" runat="server" Text="So Tiet Ly Thuyet Tren Tuan:" AssociatedControlID="dataSoTietLyThuyetTrenTuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietLyThuyetTrenTuan" Text='<%# Bind("SoTietLyThuyetTrenTuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietLyThuyetTrenTuan" runat="server" Display="Dynamic" ControlToValidate="dataSoTietLyThuyetTrenTuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongSoTiet" runat="server" Text="Tong So Tiet:" AssociatedControlID="dataTongSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongSoTiet" Text='<%# Bind("TongSoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataTongSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataIsLock" runat="server" Text="Is Lock:" AssociatedControlID="dataIsLock" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataIsLock" SelectedValue='<%# Bind("IsLock") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaXacNhan" runat="server" Text="Da Xac Nhan:" AssociatedControlID="dataDaXacNhan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDaXacNhan" SelectedValue='<%# Bind("DaXacNhan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTongGiaTriHopDong" runat="server" Text="Tong Gia Tri Hop Dong:" AssociatedControlID="dataTongGiaTriHopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTongGiaTriHopDong" Text='<%# Bind("TongGiaTriHopDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTongGiaTriHopDong" runat="server" Display="Dynamic" ControlToValidate="dataTongGiaTriHopDong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonViTienTe" runat="server" Text="Don Vi Tien Te:" AssociatedControlID="dataDonViTienTe" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonViTienTe" Text='<%# Bind("DonViTienTe") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThue" runat="server" Text="Thue:" AssociatedControlID="dataThue" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThue" Text='<%# Bind("Thue") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThue" runat="server" Display="Dynamic" ControlToValidate="dataThue" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGiaTriHopDongConLai" runat="server" Text="Gia Tri Hop Dong Con Lai:" AssociatedControlID="dataGiaTriHopDongConLai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGiaTriHopDongConLai" Text='<%# Bind("GiaTriHopDongConLai") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGiaTriHopDongConLai" runat="server" Display="Dynamic" ControlToValidate="dataGiaTriHopDongConLai" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietThucHanh" runat="server" Text="So Tiet Thuc Hanh:" AssociatedControlID="dataSoTietThucHanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietThucHanh" Text='<%# Bind("SoTietThucHanh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietThucHanh" runat="server" Display="Dynamic" ControlToValidate="dataSoTietThucHanh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoCmnd" runat="server" Text="So Cmnd:" AssociatedControlID="dataSoCmnd" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoCmnd" Text='<%# Bind("SoCmnd") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChuyenNganh" runat="server" Text="Chuyen Nganh:" AssociatedControlID="dataChuyenNganh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChuyenNganh" Text='<%# Bind("ChuyenNganh") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgaySinh" runat="server" Text="Ngay Sinh:" AssociatedControlID="dataNgaySinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgaySinh" Text='<%# Bind("NgaySinh") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHoTen" runat="server" Text="Ho Ten:" AssociatedControlID="dataHoTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHoTen" Text='<%# Bind("HoTen") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaSoThue" runat="server" Text="Ma So Thue:" AssociatedControlID="dataMaSoThue" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaSoThue" Text='<%# Bind("MaSoThue") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayBatDau" runat="server" Text="Ngay Bat Dau:" AssociatedControlID="dataNgayBatDau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayBatDau" Text='<%# Bind("NgayBatDau", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayBatDau" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDonVi" runat="server" Text="Ma Don Vi:" AssociatedControlID="dataMaDonVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDonVi" Text='<%# Bind("MaDonVi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietLyThuyet" runat="server" Text="So Tiet Ly Thuyet:" AssociatedControlID="dataSoTietLyThuyet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietLyThuyet" Text='<%# Bind("SoTietLyThuyet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietLyThuyet" runat="server" Display="Dynamic" ControlToValidate="dataSoTietLyThuyet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayKetThuc" runat="server" Text="Ngay Ket Thuc:" AssociatedControlID="dataNgayKetThuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayKetThuc" Text='<%# Bind("NgayKetThuc", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayKetThuc" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoHopDong" runat="server" Text="So Hop Dong:" AssociatedControlID="dataSoHopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoHopDong" Text='<%# Bind("SoHopDong") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCoQuanCongTac" runat="server" Text="Co Quan Cong Tac:" AssociatedControlID="dataCoQuanCongTac" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCoQuanCongTac" Text='<%# Bind("CoQuanCongTac") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



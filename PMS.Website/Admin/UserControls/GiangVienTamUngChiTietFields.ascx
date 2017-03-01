<%@ Control Language="C#" ClassName="GiangVienTamUngChiTietFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoi" runat="server" Text="Tiet Quy Doi:" AssociatedControlID="dataTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoi" Text='<%# Bind("TietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietThucTeQuyDoi" runat="server" Text="So Tiet Thuc Te Quy Doi:" AssociatedControlID="dataSoTietThucTeQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietThucTeQuyDoi" Text='<%# Bind("SoTietThucTeQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietThucTeQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataSoTietThucTeQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNienCheTinChi" runat="server" Text="He So Nien Che Tin Chi:" AssociatedControlID="dataHeSoNienCheTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNienCheTinChi" Text='<%# Bind("HeSoNienCheTinChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNienCheTinChi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNienCheTinChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiLop" runat="server" Text="Loai Lop:" AssociatedControlID="dataLoaiLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiLop" Text='<%# Bind("LoaiLop") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNgoaiGio" runat="server" Text="He So Ngoai Gio:" AssociatedControlID="dataHeSoNgoaiGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNgoaiGio" Text='<%# Bind("HeSoNgoaiGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNgoaiGio" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNgoaiGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoiThucHanhSangLyThuyet" runat="server" Text="He So Quy Doi Thuc Hanh Sang Ly Thuyet:" AssociatedControlID="dataHeSoQuyDoiThucHanhSangLyThuyet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoiThucHanhSangLyThuyet" Text='<%# Bind("HeSoQuyDoiThucHanhSangLyThuyet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoiThucHanhSangLyThuyet" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoiThucHanhSangLyThuyet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNgonNgu" runat="server" Text="He So Ngon Ngu:" AssociatedControlID="dataHeSoNgonNgu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNgonNgu" Text='<%# Bind("HeSoNgonNgu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNgonNgu" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNgonNgu" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoBacDaoTao" runat="server" Text="He So Bac Dao Tao:" AssociatedControlID="dataHeSoBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoBacDaoTao" Text='<%# Bind("HeSoBacDaoTao") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoBacDaoTao" runat="server" Display="Dynamic" ControlToValidate="dataHeSoBacDaoTao" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoCongViec" runat="server" Text="He So Cong Viec:" AssociatedControlID="dataHeSoCongViec" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoCongViec" Text='<%# Bind("HeSoCongViec") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoCongViec" runat="server" Display="Dynamic" ControlToValidate="dataHeSoCongViec" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoCoSo" runat="server" Text="He So Co So:" AssociatedControlID="dataHeSoCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoCoSo" Text='<%# Bind("HeSoCoSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoCoSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSoCoSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLopDong" runat="server" Text="He So Lop Dong:" AssociatedControlID="dataHeSoLopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLopDong" Text='<%# Bind("HeSoLopDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLopDong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLopDong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoChucDanhChuyenMon" runat="server" Text="He So Chuc Danh Chuyen Mon:" AssociatedControlID="dataHeSoChucDanhChuyenMon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoChucDanhChuyenMon" Text='<%# Bind("HeSoChucDanhChuyenMon") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoChucDanhChuyenMon" runat="server" Display="Dynamic" ControlToValidate="dataHeSoChucDanhChuyenMon" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThanhTien" runat="server" Text="Thanh Tien:" AssociatedControlID="dataThanhTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThanhTien" Text='<%# Bind("ThanhTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataThanhTien" runat="server" Display="Dynamic" ControlToValidate="dataThanhTien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotTamUng" runat="server" Text="Dot Tam Ung:" AssociatedControlID="dataDotTamUng" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotTamUng" Text='<%# Bind("DotTamUng") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayTamUng" runat="server" Text="Ngay Tam Ung:" AssociatedControlID="dataNgayTamUng" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayTamUng" Text='<%# Bind("NgayTamUng", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayTamUng" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucThanhToan" runat="server" Text="Muc Thanh Toan:" AssociatedControlID="dataMucThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMucThanhToan" Text='<%# Bind("MucThanhToan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMucThanhToan" runat="server" Display="Dynamic" ControlToValidate="dataMucThanhToan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgonNguGiangDay" runat="server" Text="Ngon Ngu Giang Day:" AssociatedControlID="dataNgonNguGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgonNguGiangDay" Text='<%# Bind("NgonNguGiangDay") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoThinhGiangMonChuyenNganh" runat="server" Text="He So Thinh Giang Mon Chuyen Nganh:" AssociatedControlID="dataHeSoThinhGiangMonChuyenNganh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoThinhGiangMonChuyenNganh" Text='<%# Bind("HeSoThinhGiangMonChuyenNganh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoThinhGiangMonChuyenNganh" runat="server" Display="Dynamic" ControlToValidate="dataHeSoThinhGiangMonChuyenNganh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoClcCntn" runat="server" Text="He So Clc Cntn:" AssociatedControlID="dataHeSoClcCntn" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoClcCntn" Text='<%# Bind("HeSoClcCntn") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoClcCntn" runat="server" Display="Dynamic" ControlToValidate="dataHeSoClcCntn" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoMonMoi" runat="server" Text="He So Mon Moi:" AssociatedControlID="dataHeSoMonMoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoMonMoi" Text='<%# Bind("HeSoMonMoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoMonMoi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoMonMoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLuong" runat="server" Text="He So Luong:" AssociatedControlID="dataHeSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLuong" Text='<%# Bind("HeSoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoTroCap" runat="server" Text="He So Tro Cap:" AssociatedControlID="dataHeSoTroCap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoTroCap" Text='<%# Bind("HeSoTroCap") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoTroCap" runat="server" Display="Dynamic" ControlToValidate="dataHeSoTroCap" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSo" runat="server" Text="Si So:" AssociatedControlID="dataSiSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSo" Text='<%# Bind("SiSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSo" runat="server" Display="Dynamic" ControlToValidate="dataSiSo" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTinChi" runat="server" Text="So Tin Chi:" AssociatedControlID="dataSoTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTinChi" Text='<%# Bind("SoTinChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataSoTinChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNhom" runat="server" Text="Nhom:" AssociatedControlID="dataNhom" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNhom" Text='<%# Bind("Nhom") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiHocPhan" runat="server" Text="Loai Hoc Phan:" AssociatedControlID="dataLoaiHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiHocPhan" Text='<%# Bind("LoaiHocPhan") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiHocPhan" runat="server" Text="Ma Loai Hoc Phan:" AssociatedControlID="dataMaLoaiHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiHocPhan" Text='<%# Bind("MaLoaiHocPhan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaLoaiHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiHocPhan" ErrorMessage="Invalid value" MaximumValue="255" MinimumValue="0" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMonHoc" runat="server" Text="Ten Mon Hoc:" AssociatedControlID="dataTenMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMonHoc" Text='<%# Bind("TenMonHoc") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaChucVu" runat="server" Text="Ma Chuc Vu:" AssociatedControlID="dataMaChucVu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaChucVu" Text='<%# Bind("MaChucVu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaChucVu" runat="server" Display="Dynamic" ControlToValidate="dataMaChucVu" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLoaiGiangVien" Text='<%# Bind("MaLoaiGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaLoaiGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaoTaoTinChi" runat="server" Text="Dao Tao Tin Chi:" AssociatedControlID="dataDaoTaoTinChi" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDaoTaoTinChi" SelectedValue='<%# Bind("DaoTaoTinChi") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLopHocPhanChuyenNganh" runat="server" Text="Lop Hoc Phan Chuyen Nganh:" AssociatedControlID="dataLopHocPhanChuyenNganh" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataLopHocPhanChuyenNganh" SelectedValue='<%# Bind("LopHocPhanChuyenNganh") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHinhThucDaoTao" runat="server" Text="Ma Hinh Thuc Dao Tao:" AssociatedControlID="dataMaHinhThucDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHinhThucDaoTao" Text='<%# Bind("MaHinhThucDaoTao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaKhoa" runat="server" Text="Ma Khoa:" AssociatedControlID="dataMaKhoa" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaKhoa" Text='<%# Bind("MaKhoa") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBacDaoTao" runat="server" Text="Ma Bac Dao Tao:" AssociatedControlID="dataMaBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBacDaoTao" Text='<%# Bind("MaBacDaoTao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTietThucDay" runat="server" Text="So Tiet Thuc Day:" AssociatedControlID="dataSoTietThucDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTietThucDay" Text='<%# Bind("SoTietThucDay") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTietThucDay" runat="server" Display="Dynamic" ControlToValidate="dataSoTietThucDay" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaKhoaHoc" runat="server" Text="Ma Khoa Hoc:" AssociatedControlID="dataMaKhoaHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaKhoaHoc" Text='<%# Bind("MaKhoaHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomMonHoc" runat="server" Text="Ma Nhom Mon Hoc:" AssociatedControlID="dataMaNhomMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomMonHoc" Text='<%# Bind("MaNhomMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



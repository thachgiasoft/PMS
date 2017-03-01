<%@ Control Language="C#" ClassName="KcqKhoiLuongGiangDayChiTietFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataCompensate" runat="server" Text="Compensate:" AssociatedControlID="dataCompensate" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCompensate" Text='<%# Bind("Compensate") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCompensate" runat="server" Display="Dynamic" ControlToValidate="dataCompensate" ErrorMessage="Invalid value" MaximumValue="255" MinimumValue="0" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayDay" runat="server" Text="Ngay Day:" AssociatedControlID="dataNgayDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayDay" Text='<%# Bind("NgayDay", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayDay" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTinhTrang" runat="server" Text="Tinh Trang:" AssociatedControlID="dataTinhTrang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTinhTrang" Text='<%# Bind("TinhTrang") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataTinhTrang" runat="server" Display="Dynamic" ControlToValidate="dataTinhTrang" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataTinhTrang" runat="server" Display="Dynamic" ControlToValidate="dataTinhTrang" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomMonHoc" runat="server" Text="Ma Nhom Mon Hoc:" AssociatedControlID="dataMaNhomMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomMonHoc" Text='<%# Bind("MaNhomMonHoc") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataTietBatDau" runat="server" Text="Tiet Bat Dau:" AssociatedControlID="dataTietBatDau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietBatDau" Text='<%# Bind("TietBatDau") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietBatDau" runat="server" Display="Dynamic" ControlToValidate="dataTietBatDau" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBuoiHoc" runat="server" Text="Ma Buoi Hoc:" AssociatedControlID="dataMaBuoiHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBuoiHoc" Text='<%# Bind("MaBuoiHoc") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaBuoiHoc" runat="server" Display="Dynamic" ControlToValidate="dataMaBuoiHoc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoHocKy" runat="server" Text="He So Hoc Ky:" AssociatedControlID="dataHeSoHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoHocKy" Text='<%# Bind("HeSoHocKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoHocKy" runat="server" Display="Dynamic" ControlToValidate="dataHeSoHocKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiHocKy" runat="server" Text="Loai Hoc Ky:" AssociatedControlID="dataLoaiHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiHocKy" Text='<%# Bind("LoaiHocKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataLoaiHocKy" runat="server" Display="Dynamic" ControlToValidate="dataLoaiHocKy" ErrorMessage="Invalid value" MaximumValue="255" MinimumValue="0" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaPhongHoc" runat="server" Text="Ma Phong Hoc:" AssociatedControlID="dataMaPhongHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaPhongHoc" Text='<%# Bind("MaPhongHoc") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataMaHinhThucDaoTao" runat="server" Text="Ma Hinh Thuc Dao Tao:" AssociatedControlID="dataMaHinhThucDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHinhThucDaoTao" Text='<%# Bind("MaHinhThucDaoTao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaoTaoTinChi" runat="server" Text="Dao Tao Tin Chi:" AssociatedControlID="dataDaoTaoTinChi" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDaoTaoTinChi" SelectedValue='<%# Bind("DaoTaoTinChi") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDotImport" runat="server" Text="Dot Import:" AssociatedControlID="dataDotImport" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDotImport" Text='<%# Bind("DotImport") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLopHocPhanChuyenNganh" runat="server" Text="Lop Hoc Phan Chuyen Nganh:" AssociatedControlID="dataLopHocPhanChuyenNganh" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataLopHocPhanChuyenNganh" SelectedValue='<%# Bind("LopHocPhanChuyenNganh") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamThu" runat="server" Text="Nam Thu:" AssociatedControlID="dataNamThu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamThu" Text='<%# Bind("NamThu") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaKhoaHoc" runat="server" Text="Ma Khoa Hoc:" AssociatedControlID="dataMaKhoaHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaKhoaHoc" Text='<%# Bind("MaKhoaHoc") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataDonViTinh" runat="server" Text="Don Vi Tinh:" AssociatedControlID="dataDonViTinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonViTinh" Text='<%# Bind("DonViTinh") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNhom" runat="server" Text="Nhom:" AssociatedControlID="dataNhom" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNhom" Text='<%# Bind("Nhom") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMonHoc" runat="server" Text="Ten Mon Hoc:" AssociatedControlID="dataTenMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMonHoc" Text='<%# Bind("TenMonHoc") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataTenMonHoc" runat="server" Display="Dynamic" ControlToValidate="dataTenMonHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaMonHoc" runat="server" Display="Dynamic" ControlToValidate="dataMaMonHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThucHanh" runat="server" Text="Thuc Hanh:" AssociatedControlID="dataThucHanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThucHanh" Text='<%# Bind("ThucHanh") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataThucHanh" runat="server" Display="Dynamic" ControlToValidate="dataThucHanh" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataThucHanh" runat="server" Display="Dynamic" ControlToValidate="dataThucHanh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLyThuyet" runat="server" Text="Ly Thuyet:" AssociatedControlID="dataLyThuyet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLyThuyet" Text='<%# Bind("LyThuyet") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataLyThuyet" runat="server" Display="Dynamic" ControlToValidate="dataLyThuyet" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataLyThuyet" runat="server" Display="Dynamic" ControlToValidate="dataLyThuyet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTinChi" runat="server" Text="So Tin Chi:" AssociatedControlID="dataSoTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTinChi" Text='<%# Bind("SoTinChi") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataSoTinChi" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataSoTinChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
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
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLichHoc" runat="server" Text="Ma Lich Hoc:" AssociatedControlID="dataMaLichHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLichHoc" Text='<%# Bind("MaLichHoc") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLichHoc" runat="server" Display="Dynamic" ControlToValidate="dataMaLichHoc" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMaLichHoc" runat="server" Display="Dynamic" ControlToValidate="dataMaLichHoc" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDot" runat="server" Text="Ma Dot:" AssociatedControlID="dataMaDot" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDot" Text='<%# Bind("MaDot") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaDot" runat="server" Display="Dynamic" ControlToValidate="dataMaDot" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataHocKy" runat="server" Display="Dynamic" ControlToValidate="dataHocKy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataNamHoc" runat="server" Display="Dynamic" ControlToValidate="dataNamHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBaiTap" runat="server" Text="Bai Tap:" AssociatedControlID="dataBaiTap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataBaiTap" Text='<%# Bind("BaiTap") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataBaiTap" runat="server" Display="Dynamic" ControlToValidate="dataBaiTap" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataBaiTap" runat="server" Display="Dynamic" ControlToValidate="dataBaiTap" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanLoai" runat="server" Text="Phan Loai:" AssociatedControlID="dataPhanLoai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanLoai" Text='<%# Bind("PhanLoai") %>' MaxLength="20"></asp:TextBox>
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
					<asp:TextBox runat="server" ID="dataMaLoaiHocPhan" Text='<%# Bind("MaLoaiHocPhan") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLoaiHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiHocPhan" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMaLoaiHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLoaiHocPhan" ErrorMessage="Invalid value" MaximumValue="255" MinimumValue="0" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTuan" runat="server" Text="Tuan:" AssociatedControlID="dataTuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTuan" Text='<%# Bind("Tuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTuan" runat="server" Display="Dynamic" ControlToValidate="dataTuan" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNam" runat="server" Text="Nam:" AssociatedControlID="dataNam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNam" Text='<%# Bind("Nam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataNam" runat="server" Display="Dynamic" ControlToValidate="dataNam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoThanhPhan" runat="server" Text="He So Thanh Phan:" AssociatedControlID="dataHeSoThanhPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoThanhPhan" Text='<%# Bind("HeSoThanhPhan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoThanhPhan" runat="server" Display="Dynamic" ControlToValidate="dataHeSoThanhPhan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLuanAn" runat="server" Text="Luan An:" AssociatedControlID="dataLuanAn" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLuanAn" Text='<%# Bind("LuanAn") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataLuanAn" runat="server" Display="Dynamic" ControlToValidate="dataLuanAn" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataLuanAn" runat="server" Display="Dynamic" ControlToValidate="dataLuanAn" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDoAn" runat="server" Text="Do An:" AssociatedControlID="dataDoAn" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDoAn" Text='<%# Bind("DoAn") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataDoAn" runat="server" Display="Dynamic" ControlToValidate="dataDoAn" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataDoAn" runat="server" Display="Dynamic" ControlToValidate="dataDoAn" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBaiTapLon" runat="server" Text="Bai Tap Lon:" AssociatedControlID="dataBaiTapLon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataBaiTapLon" Text='<%# Bind("BaiTapLon") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataBaiTapLon" runat="server" Display="Dynamic" ControlToValidate="dataBaiTapLon" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataBaiTapLon" runat="server" Display="Dynamic" ControlToValidate="dataBaiTapLon" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoLuong" runat="server" Text="So Luong:" AssociatedControlID="dataSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLuong" Text='<%# Bind("SoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataSoLuong" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThucTap" runat="server" Text="Thuc Tap:" AssociatedControlID="dataThucTap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThucTap" Text='<%# Bind("ThucTap") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataThucTap" runat="server" Display="Dynamic" ControlToValidate="dataThucTap" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataThucTap" runat="server" Display="Dynamic" ControlToValidate="dataThucTap" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTieuLuan" runat="server" Text="Tieu Luan:" AssociatedControlID="dataTieuLuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTieuLuan" Text='<%# Bind("TieuLuan") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataTieuLuan" runat="server" Display="Dynamic" ControlToValidate="dataTieuLuan" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataTieuLuan" runat="server" Display="Dynamic" ControlToValidate="dataTieuLuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



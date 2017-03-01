<%@ Control Language="C#" ClassName="KcqKetQuaThanhToanThuLaoFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNhomMonHoc" runat="server" Text="Ma Nhom Mon Hoc:" AssociatedControlID="dataMaNhomMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaNhomMonHoc" Text='<%# Bind("MaNhomMonHoc") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataMalopHocPhan" runat="server" Text="Malop Hoc Phan:" AssociatedControlID="dataMalopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMalopHocPhan" Text='<%# Bind("MalopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaBacDaoTao" runat="server" Text="Ma Bac Dao Tao:" AssociatedControlID="dataMaBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaBacDaoTao" Text='<%# Bind("MaBacDaoTao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiLop" runat="server" Text="Loai Lop:" AssociatedControlID="dataLoaiLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiLop" Text='<%# Bind("LoaiLop") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoChucDanhChuyenMon" runat="server" Text="He So Chuc Danh Chuyen Mon:" AssociatedControlID="dataHeSoChucDanhChuyenMon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoChucDanhChuyenMon" Text='<%# Bind("HeSoChucDanhChuyenMon") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoChucDanhChuyenMon" runat="server" Display="Dynamic" ControlToValidate="dataHeSoChucDanhChuyenMon" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoiThucHanhSangLyThuyet" runat="server" Text="He So Quy Doi Thuc Hanh Sang Ly Thuyet:" AssociatedControlID="dataHeSoQuyDoiThucHanhSangLyThuyet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoiThucHanhSangLyThuyet" Text='<%# Bind("HeSoQuyDoiThucHanhSangLyThuyet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoiThucHanhSangLyThuyet" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoiThucHanhSangLyThuyet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenCoSo" runat="server" Text="Ten Co So:" AssociatedControlID="dataTenCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenCoSo" Text='<%# Bind("TenCoSo") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaNgoaiChuan" runat="server" Text="Don Gia Ngoai Chuan:" AssociatedControlID="dataDonGiaNgoaiChuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaNgoaiChuan" Text='<%# Bind("DonGiaNgoaiChuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaNgoaiChuan" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaNgoaiChuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoGioChuanTinhThem" runat="server" Text="So Gio Chuan Tinh Them:" AssociatedControlID="dataSoGioChuanTinhThem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoGioChuanTinhThem" Text='<%# Bind("SoGioChuanTinhThem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoGioChuanTinhThem" runat="server" Display="Dynamic" ControlToValidate="dataSoGioChuanTinhThem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoGioThucGiangTrenLop" runat="server" Text="So Gio Thuc Giang Tren Lop:" AssociatedControlID="dataSoGioThucGiangTrenLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoGioThucGiangTrenLop" Text='<%# Bind("SoGioThucGiangTrenLop") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoGioThucGiangTrenLop" runat="server" Display="Dynamic" ControlToValidate="dataSoGioThucGiangTrenLop" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoCoSo" runat="server" Text="He So Co So:" AssociatedControlID="dataHeSoCoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoCoSo" Text='<%# Bind("HeSoCoSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoCoSo" runat="server" Display="Dynamic" ControlToValidate="dataHeSoCoSo" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaKhoaHoc" runat="server" Text="Ma Khoa Hoc:" AssociatedControlID="dataMaKhoaHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaKhoaHoc" Text='<%# Bind("MaKhoaHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaDiaDiem" runat="server" Text="Don Gia Dia Diem:" AssociatedControlID="dataDonGiaDiaDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaDiaDiem" Text='<%# Bind("DonGiaDiaDiem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaDiaDiem" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaDiaDiem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenDiaDiem" runat="server" Text="Ten Dia Diem:" AssociatedControlID="dataTenDiaDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenDiaDiem" Text='<%# Bind("TenDiaDiem") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDiaDiem" runat="server" Text="Ma Dia Diem:" AssociatedControlID="dataMaDiaDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDiaDiem" Text='<%# Bind("MaDiaDiem") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTinChi" runat="server" Text="So Tin Chi:" AssociatedControlID="dataSoTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTinChi" Text='<%# Bind("SoTinChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTinChi" runat="server" Display="Dynamic" ControlToValidate="dataSoTinChi" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoDiaDiem" runat="server" Text="He So Dia Diem:" AssociatedControlID="dataHeSoDiaDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoDiaDiem" Text='<%# Bind("HeSoDiaDiem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoDiaDiem" runat="server" Display="Dynamic" ControlToValidate="dataHeSoDiaDiem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTienXeDiaDiem" runat="server" Text="Tien Xe Dia Diem:" AssociatedControlID="dataTienXeDiaDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTienXeDiaDiem" Text='<%# Bind("TienXeDiaDiem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTienXeDiaDiem" runat="server" Display="Dynamic" ControlToValidate="dataTienXeDiaDiem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoBacDaoTao" runat="server" Text="He So Bac Dao Tao:" AssociatedControlID="dataHeSoBacDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoBacDaoTao" Text='<%# Bind("HeSoBacDaoTao") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoBacDaoTao" runat="server" Display="Dynamic" ControlToValidate="dataHeSoBacDaoTao" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLuong" runat="server" Text="He So Luong:" AssociatedControlID="dataHeSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLuong" Text='<%# Bind("HeSoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNgoaiGio" runat="server" Text="He So Ngoai Gio:" AssociatedControlID="dataHeSoNgoaiGio" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNgoaiGio" Text='<%# Bind("HeSoNgoaiGio") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNgoaiGio" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNgoaiGio" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoTroCap" runat="server" Text="He So Tro Cap:" AssociatedControlID="dataHeSoTroCap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoTroCap" Text='<%# Bind("HeSoTroCap") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoTroCap" runat="server" Display="Dynamic" ControlToValidate="dataHeSoTroCap" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNgonNgu" runat="server" Text="He So Ngon Ngu:" AssociatedControlID="dataHeSoNgonNgu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNgonNgu" Text='<%# Bind("HeSoNgonNgu") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNgonNgu" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNgonNgu" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoNienCheTinChi" runat="server" Text="He So Nien Che Tin Chi:" AssociatedControlID="dataHeSoNienCheTinChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoNienCheTinChi" Text='<%# Bind("HeSoNienCheTinChi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoNienCheTinChi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoNienCheTinChi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoMonMoi" runat="server" Text="He So Mon Moi:" AssociatedControlID="dataHeSoMonMoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoMonMoi" Text='<%# Bind("HeSoMonMoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoMonMoi" runat="server" Display="Dynamic" ControlToValidate="dataHeSoMonMoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaMonHoc" runat="server" Text="Ma Mon Hoc:" AssociatedControlID="dataMaMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaMonHoc" Text='<%# Bind("MaMonHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPhanLoai" runat="server" Text="Phan Loai:" AssociatedControlID="dataPhanLoai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPhanLoai" Text='<%# Bind("PhanLoai") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoai" runat="server" Text="Loai:" AssociatedControlID="dataLoai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoai" Text='<%# Bind("Loai") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNhom" runat="server" Text="Nhom:" AssociatedControlID="dataNhom" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNhom" Text='<%# Bind("Nhom") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLoaiHocPhan" runat="server" Text="Loai Hoc Phan:" AssociatedControlID="dataLoaiHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLoaiHocPhan" Text='<%# Bind("LoaiHocPhan") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenMonHoc" runat="server" Text="Ten Mon Hoc:" AssociatedControlID="dataTenMonHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenMonHoc" Text='<%# Bind("TenMonHoc") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDonVi" runat="server" Text="Ma Don Vi:" AssociatedControlID="dataMaDonVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDonVi" Text='<%# Bind("MaDonVi") %>' MaxLength="20"></asp:TextBox>
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
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
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
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLop" runat="server" Text="Ma Lop:" AssociatedControlID="dataMaLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLop" Text='<%# Bind("MaLop") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLanChot" runat="server" Text="Lan Chot:" AssociatedControlID="dataLanChot" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLanChot" Text='<%# Bind("LanChot") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataLanChot" runat="server" Display="Dynamic" ControlToValidate="dataLanChot" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
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
        <td class="literal"><asp:Label ID="lbldataDonGiaTrongChuan" runat="server" Text="Don Gia Trong Chuan:" AssociatedControlID="dataDonGiaTrongChuan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaTrongChuan" Text='<%# Bind("DonGiaTrongChuan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaTrongChuan" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaTrongChuan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHinhThucDaoTao" runat="server" Text="Ma Hinh Thuc Dao Tao:" AssociatedControlID="dataMaHinhThucDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHinhThucDaoTao" Text='<%# Bind("MaHinhThucDaoTao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietQuyDoi" runat="server" Text="Tiet Quy Doi:" AssociatedControlID="dataTietQuyDoi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietQuyDoi" Text='<%# Bind("TietQuyDoi") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietQuyDoi" runat="server" Display="Dynamic" ControlToValidate="dataTietQuyDoi" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietThucDay" runat="server" Text="Tiet Thuc Day:" AssociatedControlID="dataTietThucDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietThucDay" Text='<%# Bind("TietThucDay") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietThucDay" runat="server" Display="Dynamic" ControlToValidate="dataTietThucDay" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSo" runat="server" Text="Si So:" AssociatedControlID="dataSiSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSo" Text='<%# Bind("SiSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSo" runat="server" Display="Dynamic" ControlToValidate="dataSiSo" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLopClc" runat="server" Text="Lop Clc:" AssociatedControlID="dataLopClc" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataLopClc" SelectedValue='<%# Bind("LopClc") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoLopDong" runat="server" Text="He So Lop Dong:" AssociatedControlID="dataHeSoLopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoLopDong" Text='<%# Bind("HeSoLopDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoLopDong" runat="server" Display="Dynamic" ControlToValidate="dataHeSoLopDong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoHocKy" runat="server" Text="He So Hoc Ky:" AssociatedControlID="dataHeSoHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoHocKy" Text='<%# Bind("HeSoHocKy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoHocKy" runat="server" Display="Dynamic" ControlToValidate="dataHeSoHocKy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTietChuNhat" runat="server" Text="Tiet Chu Nhat:" AssociatedControlID="dataTietChuNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTietChuNhat" Text='<%# Bind("TietChuNhat") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTietChuNhat" runat="server" Display="Dynamic" ControlToValidate="dataTietChuNhat" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



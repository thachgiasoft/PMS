<%@ Control Language="C#" ClassName="GiangVienFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaTrinhDoChinhTri" runat="server" Text="Ma Trinh Do Chinh Tri:" AssociatedControlID="dataMaTrinhDoChinhTri" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaTrinhDoChinhTri" DataSourceID="MaTrinhDoChinhTriTrinhDoChinhTriDataSource" DataTextField="MaQuanLy" DataValueField="MaTrinhDoChinhTri" SelectedValue='<%# Bind("MaTrinhDoChinhTri") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:TrinhDoChinhTriDataSource ID="MaTrinhDoChinhTriTrinhDoChinhTriDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNgachCongChuc" runat="server" Text="Ma Ngach Cong Chuc:" AssociatedControlID="dataMaNgachCongChuc" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaNgachCongChuc" DataSourceID="MaNgachCongChucNgachCongChucDataSource" DataTextField="MaQuanLy" DataValueField="MaNgachCongChuc" SelectedValue='<%# Bind("MaNgachCongChuc") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:NgachCongChucDataSource ID="MaNgachCongChucNgachCongChucDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaTrinhDoNgoaiNgu" runat="server" Text="Ma Trinh Do Ngoai Ngu:" AssociatedControlID="dataMaTrinhDoNgoaiNgu" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaTrinhDoNgoaiNgu" DataSourceID="MaTrinhDoNgoaiNguTrinhDoNgoaiNguDataSource" DataTextField="MaQuanLy" DataValueField="MaTrinhDoNgoaiNgu" SelectedValue='<%# Bind("MaTrinhDoNgoaiNgu") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:TrinhDoNgoaiNguDataSource ID="MaTrinhDoNgoaiNguTrinhDoNgoaiNguDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaTrinhDoSuPham" runat="server" Text="Ma Trinh Do Su Pham:" AssociatedControlID="dataMaTrinhDoSuPham" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaTrinhDoSuPham" DataSourceID="MaTrinhDoSuPhamTrinhDoSuPhamDataSource" DataTextField="MaQuanLy" DataValueField="MaTrinhDoSuPham" SelectedValue='<%# Bind("MaTrinhDoSuPham") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:TrinhDoSuPhamDataSource ID="MaTrinhDoSuPhamTrinhDoSuPhamDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiNhanVien" runat="server" Text="Ma Loai Nhan Vien:" AssociatedControlID="dataMaLoaiNhanVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaLoaiNhanVien" DataSourceID="MaLoaiNhanVienLoaiNhanVienDataSource" DataTextField="MaQuanLy" DataValueField="MaLoaiNhanVien" SelectedValue='<%# Bind("MaLoaiNhanVien") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:LoaiNhanVienDataSource ID="MaLoaiNhanVienLoaiNhanVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoHieuCongChuc" runat="server" Text="So Hieu Cong Chuc:" AssociatedControlID="dataSoHieuCongChuc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoHieuCongChuc" Text='<%# Bind("SoHieuCongChuc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgach" runat="server" Text="Ngach:" AssociatedControlID="dataNgach" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgach" Text='<%# Bind("Ngach") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKhoaTaiKhoan" runat="server" Text="Khoa Tai Khoan:" AssociatedControlID="dataKhoaTaiKhoan" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataKhoaTaiKhoan" SelectedValue='<%# Bind("KhoaTaiKhoan") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiCapBang" runat="server" Text="Noi Cap Bang:" AssociatedControlID="dataNoiCapBang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiCapBang" Text='<%# Bind("NoiCapBang") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaTrinhDoTinHoc" runat="server" Text="Ma Trinh Do Tin Hoc:" AssociatedControlID="dataMaTrinhDoTinHoc" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaTrinhDoTinHoc" DataSourceID="MaTrinhDoTinHocTrinhDoTinHocDataSource" DataTextField="MaQuanLy" DataValueField="MaTrinhDoTinHoc" SelectedValue='<%# Bind("MaTrinhDoTinHoc") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:TrinhDoTinHocDataSource ID="MaTrinhDoTinHocTrinhDoTinHocDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataIdHoSo" runat="server" Text="Id Ho So:" AssociatedControlID="dataIdHoSo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataIdHoSo" Text='<%# Bind("IdHoSo") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataIdHoSo" runat="server" Display="Dynamic" ControlToValidate="dataIdHoSo" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonViGiangDay" runat="server" Text="Don Vi Giang Day:" AssociatedControlID="dataDonViGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonViGiangDay" Text='<%# Bind("DonViGiangDay") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDaXoaHrm" runat="server" Text="Da Xoa Hrm:" AssociatedControlID="dataDaXoaHrm" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDaXoaHrm" SelectedValue='<%# Bind("DaXoaHrm") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuocTich" runat="server" Text="Ma Quoc Tich:" AssociatedControlID="dataMaQuocTich" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuocTich" Text='<%# Bind("MaQuocTich") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaQuocTich" runat="server" Display="Dynamic" ControlToValidate="dataMaQuocTich" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNganhDaoTao" runat="server" Text="Nganh Dao Tao:" AssociatedControlID="dataNganhDaoTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNganhDaoTao" Text='<%# Bind("NganhDaoTao") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNguoiCapNhat" runat="server" Text="Nguoi Cap Nhat:" AssociatedControlID="dataNguoiCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNguoiCapNhat" Text='<%# Bind("NguoiCapNhat") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaTrinhDoQuanLyNhaNuoc" runat="server" Text="Ma Trinh Do Quan Ly Nha Nuoc:" AssociatedControlID="dataMaTrinhDoQuanLyNhaNuoc" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaTrinhDoQuanLyNhaNuoc" DataSourceID="MaTrinhDoQuanLyNhaNuocTrinhDoQuanLyNhaNuocDataSource" DataTextField="MaQuanLy" DataValueField="MaTrinhDoQuanLyNhaNuoc" SelectedValue='<%# Bind("MaTrinhDoQuanLyNhaNuoc") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:TrinhDoQuanLyNhaNuocDataSource ID="MaTrinhDoQuanLyNhaNuocTrinhDoQuanLyNhaNuocDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataKhoiKienThucGiangDay" runat="server" Text="Khoi Kien Thuc Giang Day:" AssociatedControlID="dataKhoiKienThucGiangDay" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataKhoiKienThucGiangDay" Text='<%# Bind("KhoiKienThucGiangDay") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCapNhat" runat="server" Text="Ngay Cap Nhat:" AssociatedControlID="dataNgayCapNhat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCapNhat" Text='<%# Bind("NgayCapNhat", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayCapNhat" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDanToc" runat="server" Text="Ma Dan Toc:" AssociatedControlID="dataMaDanToc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDanToc" Text='<%# Bind("MaDanToc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaTonGiao" runat="server" Text="Ma Ton Giao:" AssociatedControlID="dataMaTonGiao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaTonGiao" Text='<%# Bind("MaTonGiao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaDonVi" runat="server" Text="Ma Don Vi:" AssociatedControlID="dataMaDonVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaDonVi" Text='<%# Bind("MaDonVi") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHocHam" DataSourceID="MaHocHamHocHamDataSource" DataTextField="MaQuanLy" DataValueField="MaHocHam" SelectedValue='<%# Bind("MaHocHam") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:HocHamDataSource ID="MaHocHamHocHamDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHocVi" DataSourceID="MaHocViHocViDataSource" DataTextField="MaQuanLy" DataValueField="MaHocVi" SelectedValue='<%# Bind("MaHocVi") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:HocViDataSource ID="MaHocViHocViDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLoaiGiangVien" runat="server" Text="Ma Loai Giang Vien:" AssociatedControlID="dataMaLoaiGiangVien" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaLoaiGiangVien" DataSourceID="MaLoaiGiangVienLoaiGiangVienDataSource" DataTextField="MaQuanLy" DataValueField="MaLoaiGiangVien" SelectedValue='<%# Bind("MaLoaiGiangVien") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:LoaiGiangVienDataSource ID="MaLoaiGiangVienLoaiGiangVienDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaNguoiLap" runat="server" Text="Ma Nguoi Lap:" AssociatedControlID="dataMaNguoiLap" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaNguoiLap" DataSourceID="MaNguoiLapTaiKhoanDataSource" DataTextField="TenDangNhap" DataValueField="MaTaiKhoan" SelectedValue='<%# Bind("MaNguoiLap") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:TaiKhoanDataSource ID="MaNguoiLapTaiKhoanDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMatKhau" runat="server" Text="Mat Khau:" AssociatedControlID="dataMatKhau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMatKhau" Text='<%# Bind("MatKhau") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaTinhTrang" runat="server" Text="Ma Tinh Trang:" AssociatedControlID="dataMaTinhTrang" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaTinhTrang" DataSourceID="MaTinhTrangTinhTrangDataSource" DataTextField="MaQuanLy" DataValueField="MaTinhTrang" SelectedValue='<%# Bind("MaTinhTrang") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:TinhTrangDataSource ID="MaTinhTrangTinhTrangDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaQuanLy" runat="server" Display="Dynamic" ControlToValidate="dataMaQuanLy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHo" runat="server" Text="Ho:" AssociatedControlID="dataHo" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHo" Text='<%# Bind("Ho") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenDem" runat="server" Text="Ten Dem:" AssociatedControlID="dataTenDem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenDem" Text='<%# Bind("TenDem") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTen" runat="server" Text="Ten:" AssociatedControlID="dataTen" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTen" Text='<%# Bind("Ten") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgaySinh" runat="server" Text="Ngay Sinh:" AssociatedControlID="dataNgaySinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgaySinh" Text='<%# Bind("NgaySinh") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGioiTinh" runat="server" Text="Gioi Tinh:" AssociatedControlID="dataGioiTinh" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataGioiTinh" SelectedValue='<%# Bind("GioiTinh") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiSinh" runat="server" Text="Noi Sinh:" AssociatedControlID="dataNoiSinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiSinh" Text='<%# Bind("NoiSinh") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCmnd" runat="server" Text="Cmnd:" AssociatedControlID="dataCmnd" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCmnd" Text='<%# Bind("Cmnd") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayCap" runat="server" Text="Ngay Cap:" AssociatedControlID="dataNgayCap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayCap" Text='<%# Bind("NgayCap") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiCap" runat="server" Text="Noi Cap:" AssociatedControlID="dataNoiCap" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiCap" Text='<%# Bind("NoiCap") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDoanDang" runat="server" Text="Doan Dang:" AssociatedControlID="dataDoanDang" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataDoanDang" SelectedValue='<%# Bind("DoanDang") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayVaoDoanDang" runat="server" Text="Ngay Vao Doan Dang:" AssociatedControlID="dataNgayVaoDoanDang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayVaoDoanDang" Text='<%# Bind("NgayVaoDoanDang") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayKyHopDong" runat="server" Text="Ngay Ky Hop Dong:" AssociatedControlID="dataNgayKyHopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayKyHopDong" Text='<%# Bind("NgayKyHopDong", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayKyHopDong" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayKetThucHopDong" runat="server" Text="Ngay Ket Thuc Hop Dong:" AssociatedControlID="dataNgayKetThucHopDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayKetThucHopDong" Text='<%# Bind("NgayKetThucHopDong", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayKetThucHopDong" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHinhAnh" runat="server" Text="Hinh Anh:" AssociatedControlID="dataHinhAnh" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataHinhAnh" Value='<%# Bind("HinhAnh") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDiaChi" runat="server" Text="Dia Chi:" AssociatedControlID="dataDiaChi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDiaChi" Text='<%# Bind("DiaChi") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThuongTru" runat="server" Text="Thuong Tru:" AssociatedControlID="dataThuongTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThuongTru" Text='<%# Bind("ThuongTru") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNoiLamViec" runat="server" Text="Noi Lam Viec:" AssociatedControlID="dataNoiLamViec" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNoiLamViec" Text='<%# Bind("NoiLamViec") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataEmail" runat="server" Text="Email:" AssociatedControlID="dataEmail" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataEmail" Text='<%# Bind("Email") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDienThoai" runat="server" Text="Dien Thoai:" AssociatedControlID="dataDienThoai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDienThoai" Text='<%# Bind("DienThoai") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoDiDong" runat="server" Text="So Di Dong:" AssociatedControlID="dataSoDiDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoDiDong" Text='<%# Bind("SoDiDong") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTaiKhoan" runat="server" Text="So Tai Khoan:" AssociatedControlID="dataSoTaiKhoan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTaiKhoan" Text='<%# Bind("SoTaiKhoan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenNganHang" runat="server" Text="Ten Ngan Hang:" AssociatedControlID="dataTenNganHang" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenNganHang" Text='<%# Bind("TenNganHang") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaSoThue" runat="server" Text="Ma So Thue:" AssociatedControlID="dataMaSoThue" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaSoThue" Text='<%# Bind("MaSoThue") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChiNhanh" runat="server" Text="Chi Nhanh:" AssociatedControlID="dataChiNhanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChiNhanh" Text='<%# Bind("ChiNhanh") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoSoBaoHiem" runat="server" Text="So So Bao Hiem:" AssociatedControlID="dataSoSoBaoHiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoSoBaoHiem" Text='<%# Bind("SoSoBaoHiem") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataThoiGianBatDau" runat="server" Text="Thoi Gian Bat Dau:" AssociatedControlID="dataThoiGianBatDau" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataThoiGianBatDau" Text='<%# Bind("ThoiGianBatDau") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataBacLuong" runat="server" Text="Bac Luong:" AssociatedControlID="dataBacLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataBacLuong" Text='<%# Bind("BacLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataBacLuong" runat="server" Display="Dynamic" ControlToValidate="dataBacLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayHuongLuong" runat="server" Text="Ngay Huong Luong:" AssociatedControlID="dataNgayHuongLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayHuongLuong" Text='<%# Bind("NgayHuongLuong") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamLamViec" runat="server" Text="Nam Lam Viec:" AssociatedControlID="dataNamLamViec" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamLamViec" Text='<%# Bind("NamLamViec") %>' MaxLength="10"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChuyenNganh" runat="server" Text="Chuyen Nganh:" AssociatedControlID="dataChuyenNganh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChuyenNganh" Text='<%# Bind("ChuyenNganh") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHeSoThuLao" runat="server" Text="Ma He So Thu Lao:" AssociatedControlID="dataMaHeSoThuLao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHeSoThuLao" Text='<%# Bind("MaHeSoThuLao") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHrmid" runat="server" Text="Hrmid:" AssociatedControlID="dataHrmid" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataHrmid" Value='<%# Bind("Hrmid") %>'></asp:HiddenField>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



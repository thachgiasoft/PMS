<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="LoaiGiangVienEdit.aspx.cs" Inherits="LoaiGiangVienEdit" Title="LoaiGiangVien Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Loai Giang Vien - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaLoaiGiangVien" runat="server" DataSourceID="LoaiGiangVienDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiGiangVienFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/LoaiGiangVienFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>LoaiGiangVien not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:LoaiGiangVienDataSource ID="LoaiGiangVienDataSource" runat="server"
			SelectMethod="GetByMaLoaiGiangVien"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaLoaiGiangVien" QueryStringField="MaLoaiGiangVien" Type="String" />

			</Parameters>
		</data:LoaiGiangVienDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewQuyDinhTienCanTren1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewQuyDinhTienCanTren1_SelectedIndexChanged"			 			 
			DataSourceID="QuyDinhTienCanTrenDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_QuyDinhTienCanTren.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="Stt" HeaderText="Stt" SortExpression="[STT]" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Hoc Ham" DataNavigateUrlFormatString="HocHamEdit.aspx?MaHocHam={0}" DataNavigateUrlFields="MaHocHam" DataContainer="MaHocHamSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Vi" DataNavigateUrlFormatString="HocViEdit.aspx?MaHocVi={0}" DataNavigateUrlFields="MaHocVi" DataContainer="MaHocViSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Loai Nhan Vien" DataNavigateUrlFormatString="LoaiNhanVienEdit.aspx?MaLoaiNhanVien={0}" DataNavigateUrlFields="MaLoaiNhanVien" DataContainer="MaLoaiNhanVienSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Loai Giang Vien" DataNavigateUrlFormatString="LoaiGiangVienEdit.aspx?MaLoaiGiangVien={0}" DataNavigateUrlFields="MaLoaiGiangVien" DataContainer="MaLoaiGiangVienSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="TienCanTren" HeaderText="Tien Can Tren" SortExpression="[TienCanTren]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Quy Dinh Tien Can Tren Found! </b>
				<asp:HyperLink runat="server" ID="hypQuyDinhTienCanTren" NavigateUrl="~/admin/QuyDinhTienCanTrenEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:QuyDinhTienCanTrenDataSource ID="QuyDinhTienCanTrenDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:QuyDinhTienCanTrenProperty Name="HocHam"/> 
					<data:QuyDinhTienCanTrenProperty Name="HocVi"/> 
					<data:QuyDinhTienCanTrenProperty Name="LoaiGiangVien"/> 
					<data:QuyDinhTienCanTrenProperty Name="LoaiNhanVien"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:QuyDinhTienCanTrenFilter  Column="MaLoaiGiangVien" QueryStringField="MaLoaiGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:QuyDinhTienCanTrenDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewDonGia2" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewDonGia2_SelectedIndexChanged"			 			 
			DataSourceID="DonGiaDataSource2"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_DonGia.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]" />				
				<data:HyperLinkField HeaderText="Ma Loai Giang Vien" DataNavigateUrlFormatString="LoaiGiangVienEdit.aspx?MaLoaiGiangVien={0}" DataNavigateUrlFields="MaLoaiGiangVien" DataContainer="MaLoaiGiangVienSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Ham" DataNavigateUrlFormatString="HocHamEdit.aspx?MaHocHam={0}" DataNavigateUrlFields="MaHocHam" DataContainer="MaHocHamSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Vi" DataNavigateUrlFormatString="HocViEdit.aspx?MaHocVi={0}" DataNavigateUrlFields="MaHocVi" DataContainer="MaHocViSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="DonGiaClc" HeaderText="Don Gia Clc" SortExpression="[DonGiaClc]" />				
				<asp:BoundField DataField="HeSoQuyDoiChatLuong" HeaderText="He So Quy Doi Chat Luong" SortExpression="[HeSoQuyDoiChatLuong]" />				
				<asp:BoundField DataField="DonGiaTrongChuan" HeaderText="Don Gia Trong Chuan" SortExpression="[DonGiaTrongChuan]" />				
				<asp:BoundField DataField="DonGiaNgoaiChuan" HeaderText="Don Gia Ngoai Chuan" SortExpression="[DonGiaNgoaiChuan]" />				
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]" />				
				<asp:BoundField DataField="BacDaoTao" HeaderText="Bac Dao Tao" SortExpression="[BacDaoTao]" />				
				<data:HyperLinkField HeaderText="Ngon Ngu Giang Day" DataNavigateUrlFormatString="NgonNguGiangDayEdit.aspx?MaNgonNgu={0}" DataNavigateUrlFields="MaNgonNgu" DataContainer="NgonNguGiangDaySource" DataTextField="TenNgonNgu" />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" />				
				<data:HyperLinkField HeaderText="Ma Nhom Mon" DataNavigateUrlFormatString="NhomMonHocEdit.aspx?MaNhomMon={0}" DataNavigateUrlFields="MaNhomMon" DataContainer="MaNhomMonSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NhomMonHoc" HeaderText="Nhom Mon Hoc" SortExpression="[NhomMonHoc]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Don Gia Found! </b>
				<asp:HyperLink runat="server" ID="hypDonGia" NavigateUrl="~/admin/DonGiaEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:DonGiaDataSource ID="DonGiaDataSource2" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:DonGiaProperty Name="NhomMonHoc"/> 
					<data:DonGiaProperty Name="HocHam"/> 
					<data:DonGiaProperty Name="HocVi"/> 
					<data:DonGiaProperty Name="LoaiGiangVien"/> 
					<data:DonGiaProperty Name="NgonNguGiangDay"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:DonGiaFilter  Column="MaLoaiGiangVien" QueryStringField="MaLoaiGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:DonGiaDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewGiangVien3" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewGiangVien3_SelectedIndexChanged"			 			 
			DataSourceID="GiangVienDataSource3"
			DataKeyNames="MaGiangVien"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_GiangVien.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MaDanToc" HeaderText="Ma Dan Toc" SortExpression="[MaDanToc]" />				
				<asp:BoundField DataField="MaTonGiao" HeaderText="Ma Ton Giao" SortExpression="[MaTonGiao]" />				
				<asp:BoundField DataField="MaDonVi" HeaderText="Ma Don Vi" SortExpression="[MaDonVi]" />				
				<data:HyperLinkField HeaderText="Ma Hoc Ham" DataNavigateUrlFormatString="HocHamEdit.aspx?MaHocHam={0}" DataNavigateUrlFields="MaHocHam" DataContainer="MaHocHamSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Vi" DataNavigateUrlFormatString="HocViEdit.aspx?MaHocVi={0}" DataNavigateUrlFields="MaHocVi" DataContainer="MaHocViSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Loai Giang Vien" DataNavigateUrlFormatString="LoaiGiangVienEdit.aspx?MaLoaiGiangVien={0}" DataNavigateUrlFields="MaLoaiGiangVien" DataContainer="MaLoaiGiangVienSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Nguoi Lap" DataNavigateUrlFormatString="TaiKhoanEdit.aspx?MaTaiKhoan={0}" DataNavigateUrlFields="MaTaiKhoan" DataContainer="MaNguoiLapSource" DataTextField="TenDangNhap" />
				<asp:BoundField DataField="MatKhau" HeaderText="Mat Khau" SortExpression="[MatKhau]" />				
				<data:HyperLinkField HeaderText="Ma Tinh Trang" DataNavigateUrlFormatString="TinhTrangEdit.aspx?MaTinhTrang={0}" DataNavigateUrlFields="MaTinhTrang" DataContainer="MaTinhTrangSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]" />				
				<asp:BoundField DataField="Ho" HeaderText="Ho" SortExpression="[Ho]" />				
				<asp:BoundField DataField="TenDem" HeaderText="Ten Dem" SortExpression="[TenDem]" />				
				<asp:BoundField DataField="Ten" HeaderText="Ten" SortExpression="[Ten]" />				
				<asp:BoundField DataField="NgaySinh" HeaderText="Ngay Sinh" SortExpression="[NgaySinh]" />				
				<asp:BoundField DataField="GioiTinh" HeaderText="Gioi Tinh" SortExpression="[GioiTinh]" />				
				<asp:BoundField DataField="NoiSinh" HeaderText="Noi Sinh" SortExpression="[NoiSinh]" />				
				<asp:BoundField DataField="Cmnd" HeaderText="Cmnd" SortExpression="[Cmnd]" />				
				<asp:BoundField DataField="NgayCap" HeaderText="Ngay Cap" SortExpression="[NgayCap]" />				
				<asp:BoundField DataField="NoiCap" HeaderText="Noi Cap" SortExpression="[NoiCap]" />				
				<asp:BoundField DataField="DoanDang" HeaderText="Doan Dang" SortExpression="[DoanDang]" />				
				<asp:BoundField DataField="NgayVaoDoanDang" HeaderText="Ngay Vao Doan Dang" SortExpression="[NgayVaoDoanDang]" />				
				<asp:BoundField DataField="NgayKyHopDong" HeaderText="Ngay Ky Hop Dong" SortExpression="[NgayKyHopDong]" />				
				<asp:BoundField DataField="NgayKetThucHopDong" HeaderText="Ngay Ket Thuc Hop Dong" SortExpression="[NgayKetThucHopDong]" />				
				<asp:BoundField DataField="HinhAnh" HeaderText="Hinh Anh" SortExpression="[HinhAnh]" />				
				<asp:BoundField DataField="DiaChi" HeaderText="Dia Chi" SortExpression="[DiaChi]" />				
				<asp:BoundField DataField="ThuongTru" HeaderText="Thuong Tru" SortExpression="[ThuongTru]" />				
				<asp:BoundField DataField="NoiLamViec" HeaderText="Noi Lam Viec" SortExpression="[NoiLamViec]" />				
				<asp:BoundField DataField="Email" HeaderText="Email" SortExpression="[Email]" />				
				<asp:BoundField DataField="DienThoai" HeaderText="Dien Thoai" SortExpression="[DienThoai]" />				
				<asp:BoundField DataField="SoDiDong" HeaderText="So Di Dong" SortExpression="[SoDiDong]" />				
				<asp:BoundField DataField="SoTaiKhoan" HeaderText="So Tai Khoan" SortExpression="[SoTaiKhoan]" />				
				<asp:BoundField DataField="TenNganHang" HeaderText="Ten Ngan Hang" SortExpression="[TenNganHang]" />				
				<asp:BoundField DataField="MaSoThue" HeaderText="Ma So Thue" SortExpression="[MaSoThue]" />				
				<asp:BoundField DataField="ChiNhanh" HeaderText="Chi Nhanh" SortExpression="[ChiNhanh]" />				
				<asp:BoundField DataField="SoSoBaoHiem" HeaderText="So So Bao Hiem" SortExpression="[SoSoBaoHiem]" />				
				<asp:BoundField DataField="ThoiGianBatDau" HeaderText="Thoi Gian Bat Dau" SortExpression="[ThoiGianBatDau]" />				
				<asp:BoundField DataField="BacLuong" HeaderText="Bac Luong" SortExpression="[BacLuong]" />				
				<asp:BoundField DataField="NgayHuongLuong" HeaderText="Ngay Huong Luong" SortExpression="[NgayHuongLuong]" />				
				<asp:BoundField DataField="NamLamViec" HeaderText="Nam Lam Viec" SortExpression="[NamLamViec]" />				
				<asp:BoundField DataField="ChuyenNganh" HeaderText="Chuyen Nganh" SortExpression="[ChuyenNganh]" />				
				<asp:BoundField DataField="MaHeSoThuLao" HeaderText="Ma He So Thu Lao" SortExpression="[MaHeSoThuLao]" />				
				<asp:BoundField DataField="Ngach" HeaderText="Ngach" SortExpression="[Ngach]" />				
				<asp:BoundField DataField="SoHieuCongChuc" HeaderText="So Hieu Cong Chuc" SortExpression="[SoHieuCongChuc]" />				
				<asp:BoundField DataField="Hrmid" HeaderText="Hrmid" SortExpression="[HRMID]" />				
				<asp:BoundField DataField="NoiCapBang" HeaderText="Noi Cap Bang" SortExpression="[NoiCapBang]" />				
				<asp:BoundField DataField="KhoaTaiKhoan" HeaderText="Khoa Tai Khoan" SortExpression="[KhoaTaiKhoan]" />				
				<data:HyperLinkField HeaderText="Ma Loai Nhan Vien" DataNavigateUrlFormatString="LoaiNhanVienEdit.aspx?MaLoaiNhanVien={0}" DataNavigateUrlFields="MaLoaiNhanVien" DataContainer="MaLoaiNhanVienSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Ngach Cong Chuc" DataNavigateUrlFormatString="NgachCongChucEdit.aspx?MaNgachCongChuc={0}" DataNavigateUrlFields="MaNgachCongChuc" DataContainer="MaNgachCongChucSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Trinh Do Chinh Tri" DataNavigateUrlFormatString="TrinhDoChinhTriEdit.aspx?MaTrinhDoChinhTri={0}" DataNavigateUrlFields="MaTrinhDoChinhTri" DataContainer="MaTrinhDoChinhTriSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Trinh Do Su Pham" DataNavigateUrlFormatString="TrinhDoSuPhamEdit.aspx?MaTrinhDoSuPham={0}" DataNavigateUrlFields="MaTrinhDoSuPham" DataContainer="MaTrinhDoSuPhamSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Trinh Do Ngoai Ngu" DataNavigateUrlFormatString="TrinhDoNgoaiNguEdit.aspx?MaTrinhDoNgoaiNgu={0}" DataNavigateUrlFields="MaTrinhDoNgoaiNgu" DataContainer="MaTrinhDoNgoaiNguSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Trinh Do Tin Hoc" DataNavigateUrlFormatString="TrinhDoTinHocEdit.aspx?MaTrinhDoTinHoc={0}" DataNavigateUrlFields="MaTrinhDoTinHoc" DataContainer="MaTrinhDoTinHocSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Trinh Do Quan Ly Nha Nuoc" DataNavigateUrlFormatString="TrinhDoQuanLyNhaNuocEdit.aspx?MaTrinhDoQuanLyNhaNuoc={0}" DataNavigateUrlFields="MaTrinhDoQuanLyNhaNuoc" DataContainer="MaTrinhDoQuanLyNhaNuocSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="KhoiKienThucGiangDay" HeaderText="Khoi Kien Thuc Giang Day" SortExpression="[KhoiKienThucGiangDay]" />				
				<asp:BoundField DataField="NganhDaoTao" HeaderText="Nganh Dao Tao" SortExpression="[NganhDaoTao]" />				
				<asp:BoundField DataField="DonViGiangDay" HeaderText="Don Vi Giang Day" SortExpression="[DonViGiangDay]" />				
				<asp:BoundField DataField="IdHoSo" HeaderText="Id Ho So" SortExpression="[IdHoSo]" />				
				<asp:BoundField DataField="MaQuocTich" HeaderText="Ma Quoc Tich" SortExpression="[MaQuocTich]" />				
				<asp:BoundField DataField="DaXoaHrm" HeaderText="Da Xoa Hrm" SortExpression="[DaXoaHRM]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Giang Vien Found! </b>
				<asp:HyperLink runat="server" ID="hypGiangVien" NavigateUrl="~/admin/GiangVienEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:GiangVienDataSource ID="GiangVienDataSource3" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienProperty Name="HocHam"/> 
					<data:GiangVienProperty Name="HocVi"/> 
					<data:GiangVienProperty Name="LoaiGiangVien"/> 
					<data:GiangVienProperty Name="LoaiNhanVien"/> 
					<data:GiangVienProperty Name="NgachCongChuc"/> 
					<data:GiangVienProperty Name="TaiKhoan"/> 
					<data:GiangVienProperty Name="TinhTrang"/> 
					<data:GiangVienProperty Name="TrinhDoChinhTri"/> 
					<data:GiangVienProperty Name="TrinhDoNgoaiNgu"/> 
					<data:GiangVienProperty Name="TrinhDoQuanLyNhaNuoc"/> 
					<data:GiangVienProperty Name="TrinhDoSuPham"/> 
					<data:GiangVienProperty Name="TrinhDoTinHoc"/> 
					<%--<data:GiangVienProperty Name="TietNoKyTruocCollection" />--%>
					<%--<data:GiangVienProperty Name="KcqKhoiLuongKhacCollection" />--%>
					<%--<data:GiangVienProperty Name="ThuLaoThoaThuanCollection" />--%>
					<%--<data:GiangVienProperty Name="GiangVienCamKetKhongTruThueCollection" />--%>
					<%--<data:GiangVienProperty Name="ThamDinhLuanVanThacSyCollection" />--%>
					<%--<data:GiangVienProperty Name="GiangVienHoSoCollection" />--%>
					<%--<data:GiangVienProperty Name="ThoiGianLamViecCuaNhanVienCollection" />--%>
					<%--<data:GiangVienProperty Name="GiangVienHoatDongQuanLyCollection" />--%>
					<%--<data:GiangVienProperty Name="KhoiLuongKhacCollection" />--%>
					<%--<data:GiangVienProperty Name="CoVanHocTapCollection" />--%>
					<%--<data:GiangVienProperty Name="GiangVienNghienCuuKhCollection" />--%>
					<%--<data:GiangVienProperty Name="GiangVienChucVuCollection" />--%>
					<%--<data:GiangVienProperty Name="XetDuyetDeCuongLuanVanCaoHocCollection" />--%>
					<%--<data:GiangVienProperty Name="KetQuaTinhCollection" />--%>
					<%--<data:GiangVienProperty Name="ThoiGianNghiTamThoiCuaGiangVienCollection" />--%>
					<%--<data:GiangVienProperty Name="GiangVienTinhLuongThinhGiangCollection" />--%>
					<%--<data:GiangVienProperty Name="GiangVienChuyenMonCollection" />--%>
					<%--<data:GiangVienProperty Name="BangPhuTroiNamHocCollection" />--%>
					<%--<data:GiangVienProperty Name="TietNghiaVuCollection" />--%>
					<%--<data:GiangVienProperty Name="GiangVienMocTangLuongCollection" />--%>
					<%--<data:GiangVienProperty Name="GiangVienGiamTruDinhMucCollection" />--%>
					<%--<data:GiangVienProperty Name="MaHoSoHoSoCollection_From_GiangVienHoSo" />--%>
					<%--<data:GiangVienProperty Name="GiangVienHoatDongNgoaiGiangDayCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:GiangVienFilter  Column="MaLoaiGiangVien" QueryStringField="MaLoaiGiangVien" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:GiangVienDataSource>		
		
		<br />
		

</asp:Content>


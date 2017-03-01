<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVien.aspx.cs" Inherits="GiangVien" Title="GiangVien List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienDataSource"
				DataKeyNames="MaGiangVien"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVien.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:HyperLinkField HeaderText="Ma Trinh Do Chinh Tri" DataNavigateUrlFormatString="TrinhDoChinhTriEdit.aspx?MaTrinhDoChinhTri={0}" DataNavigateUrlFields="MaTrinhDoChinhTri" DataContainer="MaTrinhDoChinhTriSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Ngach Cong Chuc" DataNavigateUrlFormatString="NgachCongChucEdit.aspx?MaNgachCongChuc={0}" DataNavigateUrlFields="MaNgachCongChuc" DataContainer="MaNgachCongChucSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Trinh Do Ngoai Ngu" DataNavigateUrlFormatString="TrinhDoNgoaiNguEdit.aspx?MaTrinhDoNgoaiNgu={0}" DataNavigateUrlFields="MaTrinhDoNgoaiNgu" DataContainer="MaTrinhDoNgoaiNguSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Trinh Do Su Pham" DataNavigateUrlFormatString="TrinhDoSuPhamEdit.aspx?MaTrinhDoSuPham={0}" DataNavigateUrlFields="MaTrinhDoSuPham" DataContainer="MaTrinhDoSuPhamSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Loai Nhan Vien" DataNavigateUrlFormatString="LoaiNhanVienEdit.aspx?MaLoaiNhanVien={0}" DataNavigateUrlFields="MaLoaiNhanVien" DataContainer="MaLoaiNhanVienSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="SoHieuCongChuc" HeaderText="So Hieu Cong Chuc" SortExpression="[SoHieuCongChuc]"  />
				<asp:BoundField DataField="Ngach" HeaderText="Ngach" SortExpression="[Ngach]"  />
				<data:BoundRadioButtonField DataField="KhoaTaiKhoan" HeaderText="Khoa Tai Khoan" SortExpression="[KhoaTaiKhoan]"  />
				<asp:BoundField DataField="NoiCapBang" HeaderText="Noi Cap Bang" SortExpression="[NoiCapBang]"  />
				<data:HyperLinkField HeaderText="Ma Trinh Do Tin Hoc" DataNavigateUrlFormatString="TrinhDoTinHocEdit.aspx?MaTrinhDoTinHoc={0}" DataNavigateUrlFields="MaTrinhDoTinHoc" DataContainer="MaTrinhDoTinHocSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="IdHoSo" HeaderText="Id Ho So" SortExpression="[IdHoSo]"  />
				<asp:BoundField DataField="DonViGiangDay" HeaderText="Don Vi Giang Day" SortExpression="[DonViGiangDay]"  />
				<data:BoundRadioButtonField DataField="DaXoaHrm" HeaderText="Da Xoa Hrm" SortExpression="[DaXoaHRM]"  />
				<asp:BoundField DataField="MaQuocTich" HeaderText="Ma Quoc Tich" SortExpression="[MaQuocTich]"  />
				<asp:BoundField DataField="NganhDaoTao" HeaderText="Nganh Dao Tao" SortExpression="[NganhDaoTao]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<data:HyperLinkField HeaderText="Ma Trinh Do Quan Ly Nha Nuoc" DataNavigateUrlFormatString="TrinhDoQuanLyNhaNuocEdit.aspx?MaTrinhDoQuanLyNhaNuoc={0}" DataNavigateUrlFields="MaTrinhDoQuanLyNhaNuoc" DataContainer="MaTrinhDoQuanLyNhaNuocSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="KhoiKienThucGiangDay" HeaderText="Khoi Kien Thuc Giang Day" SortExpression="[KhoiKienThucGiangDay]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="MaDanToc" HeaderText="Ma Dan Toc" SortExpression="[MaDanToc]"  />
				<asp:BoundField DataField="MaTonGiao" HeaderText="Ma Ton Giao" SortExpression="[MaTonGiao]"  />
				<asp:BoundField DataField="MaDonVi" HeaderText="Ma Don Vi" SortExpression="[MaDonVi]"  />
				<data:HyperLinkField HeaderText="Ma Hoc Ham" DataNavigateUrlFormatString="HocHamEdit.aspx?MaHocHam={0}" DataNavigateUrlFields="MaHocHam" DataContainer="MaHocHamSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Vi" DataNavigateUrlFormatString="HocViEdit.aspx?MaHocVi={0}" DataNavigateUrlFields="MaHocVi" DataContainer="MaHocViSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Loai Giang Vien" DataNavigateUrlFormatString="LoaiGiangVienEdit.aspx?MaLoaiGiangVien={0}" DataNavigateUrlFields="MaLoaiGiangVien" DataContainer="MaLoaiGiangVienSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Nguoi Lap" DataNavigateUrlFormatString="TaiKhoanEdit.aspx?MaTaiKhoan={0}" DataNavigateUrlFields="MaTaiKhoan" DataContainer="MaNguoiLapSource" DataTextField="TenDangNhap" />
				<asp:BoundField DataField="MatKhau" HeaderText="Mat Khau" SortExpression="[MatKhau]"  />
				<data:HyperLinkField HeaderText="Ma Tinh Trang" DataNavigateUrlFormatString="TinhTrangEdit.aspx?MaTinhTrang={0}" DataNavigateUrlFields="MaTinhTrang" DataContainer="MaTinhTrangSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="Ho" HeaderText="Ho" SortExpression="[Ho]"  />
				<asp:BoundField DataField="TenDem" HeaderText="Ten Dem" SortExpression="[TenDem]"  />
				<asp:BoundField DataField="Ten" HeaderText="Ten" SortExpression="[Ten]"  />
				<asp:BoundField DataField="NgaySinh" HeaderText="Ngay Sinh" SortExpression="[NgaySinh]"  />
				<data:BoundRadioButtonField DataField="GioiTinh" HeaderText="Gioi Tinh" SortExpression="[GioiTinh]"  />
				<asp:BoundField DataField="NoiSinh" HeaderText="Noi Sinh" SortExpression="[NoiSinh]"  />
				<asp:BoundField DataField="Cmnd" HeaderText="Cmnd" SortExpression="[Cmnd]"  />
				<asp:BoundField DataField="NgayCap" HeaderText="Ngay Cap" SortExpression="[NgayCap]"  />
				<asp:BoundField DataField="NoiCap" HeaderText="Noi Cap" SortExpression="[NoiCap]"  />
				<data:BoundRadioButtonField DataField="DoanDang" HeaderText="Doan Dang" SortExpression="[DoanDang]"  />
				<asp:BoundField DataField="NgayVaoDoanDang" HeaderText="Ngay Vao Doan Dang" SortExpression="[NgayVaoDoanDang]"  />
				<asp:BoundField DataField="NgayKyHopDong" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Ky Hop Dong" SortExpression="[NgayKyHopDong]"  />
				<asp:BoundField DataField="NgayKetThucHopDong" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Ket Thuc Hop Dong" SortExpression="[NgayKetThucHopDong]"  />
				<asp:BoundField DataField="HinhAnh" HeaderText="Hinh Anh" SortExpression="[HinhAnh]"  />
				<asp:BoundField DataField="DiaChi" HeaderText="Dia Chi" SortExpression="[DiaChi]"  />
				<asp:BoundField DataField="ThuongTru" HeaderText="Thuong Tru" SortExpression="[ThuongTru]"  />
				<asp:BoundField DataField="NoiLamViec" HeaderText="Noi Lam Viec" SortExpression="[NoiLamViec]"  />
				<asp:BoundField DataField="Email" HeaderText="Email" SortExpression="[Email]"  />
				<asp:BoundField DataField="DienThoai" HeaderText="Dien Thoai" SortExpression="[DienThoai]"  />
				<asp:BoundField DataField="SoDiDong" HeaderText="So Di Dong" SortExpression="[SoDiDong]"  />
				<asp:BoundField DataField="SoTaiKhoan" HeaderText="So Tai Khoan" SortExpression="[SoTaiKhoan]"  />
				<asp:BoundField DataField="TenNganHang" HeaderText="Ten Ngan Hang" SortExpression="[TenNganHang]"  />
				<asp:BoundField DataField="MaSoThue" HeaderText="Ma So Thue" SortExpression="[MaSoThue]"  />
				<asp:BoundField DataField="ChiNhanh" HeaderText="Chi Nhanh" SortExpression="[ChiNhanh]"  />
				<asp:BoundField DataField="SoSoBaoHiem" HeaderText="So So Bao Hiem" SortExpression="[SoSoBaoHiem]"  />
				<asp:BoundField DataField="ThoiGianBatDau" HeaderText="Thoi Gian Bat Dau" SortExpression="[ThoiGianBatDau]"  />
				<asp:BoundField DataField="BacLuong" HeaderText="Bac Luong" SortExpression="[BacLuong]"  />
				<asp:BoundField DataField="NgayHuongLuong" HeaderText="Ngay Huong Luong" SortExpression="[NgayHuongLuong]"  />
				<asp:BoundField DataField="NamLamViec" HeaderText="Nam Lam Viec" SortExpression="[NamLamViec]"  />
				<asp:BoundField DataField="ChuyenNganh" HeaderText="Chuyen Nganh" SortExpression="[ChuyenNganh]"  />
				<asp:BoundField DataField="MaHeSoThuLao" HeaderText="Ma He So Thu Lao" SortExpression="[MaHeSoThuLao]"  />
				<asp:BoundField DataField="Hrmid" HeaderText="Hrmid" SortExpression="[HRMID]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVien Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVien" OnClientClick="javascript:location.href='GiangVienEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienDataSource ID="GiangVienDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
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
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:GiangVienDataSource>
	    		
</asp:Content>




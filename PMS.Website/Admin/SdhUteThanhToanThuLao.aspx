<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="SdhUteThanhToanThuLao.aspx.cs" Inherits="SdhUteThanhToanThuLao" Title="SdhUteThanhToanThuLao List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Sdh Ute Thanh Toan Thu Lao List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="SdhUteThanhToanThuLaoDataSource"
				DataKeyNames="IdKhoiLuongQuyDoi"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_SdhUteThanhToanThuLao.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaDonVi" HeaderText="Ma Don Vi" SortExpression="[MaDonVi]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<asp:BoundField DataField="Ten" HeaderText="Ten" SortExpression="[Ten]"  />
				<asp:BoundField DataField="Ho" HeaderText="Ho" SortExpression="[Ho]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]"  />
				<asp:BoundField DataField="SoGioThucGiangTrenLop" HeaderText="So Gio Thuc Giang Tren Lop" SortExpression="[SoGioThucGiangTrenLop]"  />
				<asp:BoundField DataField="HeSoHocKy" HeaderText="He So Hoc Ky" SortExpression="[HeSoHocKy]"  />
				<asp:BoundField DataField="MaDiaDiem" HeaderText="Ma Dia Diem" SortExpression="[MaDiaDiem]"  />
				<asp:BoundField DataField="SoGioChuanTinhThem" HeaderText="So Gio Chuan Tinh Them" SortExpression="[SoGioChuanTinhThem]"  />
				<data:BoundRadioButtonField DataField="DaChot" HeaderText="Da Chot" SortExpression="[DaChot]"  />
				<asp:BoundField DataField="ThanhTien" HeaderText="Thanh Tien" SortExpression="[ThanhTien]"  />
				<asp:BoundField DataField="ThanhTienDayChuNhat" HeaderText="Thanh Tien Day Chu Nhat" SortExpression="[ThanhTienDayChuNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="TongThanhTien" HeaderText="Tong Thanh Tien" SortExpression="[TongThanhTien]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="Nhom" HeaderText="Nhom" SortExpression="[Nhom]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<data:HyperLinkField HeaderText="Id Khoi Luong Quy Doi" DataNavigateUrlFormatString="SdhUteKhoiLuongQuyDoiEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="IdKhoiLuongQuyDoiSource" DataTextField="HeSoLopDongLyThuyet" />
				<asp:BoundField DataField="NhomMonHoc" HeaderText="Nhom Mon Hoc" SortExpression="[NhomMonHoc]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="HeSoLopDongLyThuyet" HeaderText="He So Lop Dong Ly Thuyet" SortExpression="[HeSoLopDongLyThuyet]"  />
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="HeSoLopDongThTnTt" HeaderText="He So Lop Dong Th Tn Tt" SortExpression="[HeSoLopDongThTnTt]"  />
				<asp:BoundField DataField="SoTietDayChuNhat" HeaderText="So Tiet Day Chu Nhat" SortExpression="[SoTietDayChuNhat]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]"  />
				<data:BoundRadioButtonField DataField="LopClc" HeaderText="Lop Clc" SortExpression="[LopClc]"  />
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No SdhUteThanhToanThuLao Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnSdhUteThanhToanThuLao" OnClientClick="javascript:location.href='SdhUteThanhToanThuLaoEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:SdhUteThanhToanThuLaoDataSource ID="SdhUteThanhToanThuLaoDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:SdhUteThanhToanThuLaoProperty Name="SdhUteKhoiLuongQuyDoi"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:SdhUteThanhToanThuLaoDataSource>
	    		
</asp:Content>




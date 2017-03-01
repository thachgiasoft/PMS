<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoCoiThiChamBaiImport.aspx.cs" Inherits="ThuLaoCoiThiChamBaiImport" Title="ThuLaoCoiThiChamBaiImport List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Coi Thi Cham Bai Import List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoCoiThiChamBaiImportDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoCoiThiChamBaiImport.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="BacDaoTao" HeaderText="Bac Dao Tao" SortExpression="[BacDaoTao]"  />
				<asp:BoundField DataField="DonGiaCuoiKy" HeaderText="Don Gia Cuoi Ky" SortExpression="[DonGiaCuoiKy]"  />
				<asp:BoundField DataField="ThanhTien" HeaderText="Thanh Tien" SortExpression="[ThanhTien]"  />
				<asp:BoundField DataField="SoTienCoiThi" HeaderText="So Tien Coi Thi" SortExpression="[SoTienCoiThi]"  />
				<asp:BoundField DataField="GioCoiThi" HeaderText="Gio Coi Thi" SortExpression="[GioCoiThi]"  />
				<asp:BoundField DataField="GioNhapDiem" HeaderText="Gio Nhap Diem" SortExpression="[GioNhapDiem]"  />
				<asp:BoundField DataField="TongCong" HeaderText="Tong Cong" SortExpression="[TongCong]"  />
				<asp:BoundField DataField="LoaiHinHdaoTao" HeaderText="Loai Hin Hdao Tao" SortExpression="[LoaiHinHDaoTao]"  />
				<asp:BoundField DataField="GioChamThi" HeaderText="Gio Cham Thi" SortExpression="[GioChamThi]"  />
				<asp:BoundField DataField="GioRaDe" HeaderText="Gio Ra De" SortExpression="[GioRaDe]"  />
				<asp:BoundField DataField="GioToChucThi" HeaderText="Gio To Chuc Thi" SortExpression="[GioToChucThi]"  />
				<asp:BoundField DataField="DonGiaGiuaKy" HeaderText="Don Gia Giua Ky" SortExpression="[DonGiaGiuaKy]"  />
				<asp:BoundField DataField="MaGiangVienQuanLy" HeaderText="Ma Giang Vien Quan Ly" SortExpression="[MaGiangVienQuanLy]"  />
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]"  />
				<asp:BoundField DataField="NoiDungChi" HeaderText="Noi Dung Chi" SortExpression="[NoiDungChi]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="DotChiTra" HeaderText="Dot Chi Tra" SortExpression="[DotChiTra]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="SoBaiGiuaKy" HeaderText="So Bai Giua Ky" SortExpression="[SoBaiGiuaKy]"  />
				<asp:BoundField DataField="SoBaiCuoiKy" HeaderText="So Bai Cuoi Ky" SortExpression="[SoBaiCuoiKy]"  />
				<asp:BoundField DataField="DonGiaQuaTrinh" HeaderText="Don Gia Qua Trinh" SortExpression="[DonGiaQuaTrinh]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="SoBaiQuaTrinh" HeaderText="So Bai Qua Trinh" SortExpression="[SoBaiQuaTrinh]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoCoiThiChamBaiImport Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoCoiThiChamBaiImport" OnClientClick="javascript:location.href='ThuLaoCoiThiChamBaiImportEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoCoiThiChamBaiImportDataSource ID="ThuLaoCoiThiChamBaiImportDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
		>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:ThuLaoCoiThiChamBaiImportDataSource>
	    		
</asp:Content>




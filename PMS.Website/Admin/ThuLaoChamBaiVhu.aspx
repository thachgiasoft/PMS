<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoChamBaiVhu.aspx.cs" Inherits="ThuLaoChamBaiVhu" Title="ThuLaoChamBaiVhu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Cham Bai Vhu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoChamBaiVhuDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoChamBaiVhu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TongCong" HeaderText="Tong Cong" SortExpression="[TongCong]"  />
				<asp:BoundField DataField="ThanhTienLan2" HeaderText="Thanh Tien Lan2" SortExpression="[ThanhTienLan2]"  />
				<asp:BoundField DataField="HeSoQuyDoi" HeaderText="He So Quy Doi" SortExpression="[HeSoQuyDoi]"  />
				<asp:BoundField DataField="HinhThucThi" HeaderText="Hinh Thuc Thi" SortExpression="[HinhThucThi]"  />
				<asp:BoundField DataField="DinhMucChamCuoiKy" HeaderText="Dinh Muc Cham Cuoi Ky" SortExpression="[DinhMucChamCuoiKy]"  />
				<asp:BoundField DataField="ThuLaoChamGiuaKy" HeaderText="Thu Lao Cham Giua Ky" SortExpression="[ThuLaoChamGiuaKy]"  />
				<asp:BoundField DataField="ThanhTienLan1" HeaderText="Thanh Tien Lan1" SortExpression="[ThanhTienLan1]"  />
				<asp:BoundField DataField="ThuLaoChamCuoiKy" HeaderText="Thu Lao Cham Cuoi Ky" SortExpression="[ThuLaoChamCuoiKy]"  />
				<asp:BoundField DataField="MaHocVi" HeaderText="Ma Hoc Vi" SortExpression="[MaHocVi]"  />
				<asp:BoundField DataField="MaHocHam" HeaderText="Ma Hoc Ham" SortExpression="[MaHocHam]"  />
				<asp:BoundField DataField="SoBaiLan2" HeaderText="So Bai Lan2" SortExpression="[SoBaiLan2]"  />
				<asp:BoundField DataField="MaLoaiGiangVien" HeaderText="Ma Loai Giang Vien" SortExpression="[MaLoaiGiangVien]"  />
				<data:BoundRadioButtonField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]"  />
				<asp:BoundField DataField="SoTietQuyDoi" HeaderText="So Tiet Quy Doi" SortExpression="[SoTietQuyDoi]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="KhoaNganh" HeaderText="Khoa Nganh" SortExpression="[KhoaNganh]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="MaHocPhan" HeaderText="Ma Hoc Phan" SortExpression="[MaHocPhan]"  />
				<asp:BoundField DataField="Nganh" HeaderText="Nganh" SortExpression="[Nganh]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="LanThi" HeaderText="Lan Thi" SortExpression="[LanThi]"  />
				<asp:BoundField DataField="KyThi" HeaderText="Ky Thi" SortExpression="[KyThi]"  />
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]"  />
				<asp:BoundField DataField="LopSinhVien" HeaderText="Lop Sinh Vien" SortExpression="[LopSinhVien]"  />
				<asp:BoundField DataField="DinhMucChamGiuaKy" HeaderText="Dinh Muc Cham Giua Ky" SortExpression="[DinhMucChamGiuaKy]"  />
				<asp:BoundField DataField="ThoiGianThi" HeaderText="Thoi Gian Thi" SortExpression="[ThoiGianThi]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="TenHocPhan" HeaderText="Ten Hoc Phan" SortExpression="[TenHocPhan]"  />
				<asp:BoundField DataField="BacDaoTao" HeaderText="Bac Dao Tao" SortExpression="[BacDaoTao]"  />
				<asp:BoundField DataField="SoTinChi" HeaderText="So Tin Chi" SortExpression="[SoTinChi]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoChamBaiVhu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoChamBaiVhu" OnClientClick="javascript:location.href='ThuLaoChamBaiVhuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoChamBaiVhuDataSource ID="ThuLaoChamBaiVhuDataSource" runat="server"
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
		</data:ThuLaoChamBaiVhuDataSource>
	    		
</asp:Content>




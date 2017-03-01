<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoChamBai.aspx.cs" Inherits="ThuLaoChamBai" Title="ThuLaoChamBai List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Cham Bai List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoChamBaiDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoChamBai.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="ThucLanh" HeaderText="Thuc Lanh" SortExpression="[ThucLanh]"  />
				<asp:BoundField DataField="TienCuoiKy" HeaderText="Tien Cuoi Ky" SortExpression="[TienCuoiKy]"  />
				<asp:BoundField DataField="TongCong" HeaderText="Tong Cong" SortExpression="[TongCong]"  />
				<asp:BoundField DataField="Thue" HeaderText="Thue" SortExpression="[Thue]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="MucChi" HeaderText="Muc Chi" SortExpression="[MucChi]"  />
				<asp:BoundField DataField="MaHinhThucThi" HeaderText="Ma Hinh Thuc Thi" SortExpression="[MaHinhThucThi]"  />
				<data:BoundRadioButtonField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="DotChiTra" HeaderText="Dot Chi Tra" SortExpression="[DotChiTra]"  />
				<data:BoundRadioButtonField DataField="IsSync" HeaderText="Is Sync" SortExpression="[IsSync]"  />
				<asp:BoundField DataField="MaLop" HeaderText="Ma Lop" SortExpression="[MaLop]"  />
				<asp:BoundField DataField="LanThi" HeaderText="Lan Thi" SortExpression="[LanThi]"  />
				<asp:BoundField DataField="KyThi" HeaderText="Ky Thi" SortExpression="[KyThi]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="MaGiangVienQuanLy" HeaderText="Ma Giang Vien Quan Ly" SortExpression="[MaGiangVienQuanLy]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="MaHocPhan" HeaderText="Ma Hoc Phan" SortExpression="[MaHocPhan]"  />
				<asp:BoundField DataField="SoBaiGiuaKy" HeaderText="So Bai Giua Ky" SortExpression="[SoBaiGiuaKy]"  />
				<asp:BoundField DataField="DonGiaCuoiKy" HeaderText="Don Gia Cuoi Ky" SortExpression="[DonGiaCuoiKy]"  />
				<asp:BoundField DataField="TienGiuaKy" HeaderText="Tien Giua Ky" SortExpression="[TienGiuaKy]"  />
				<asp:BoundField DataField="TienQuaTrinh" HeaderText="Tien Qua Trinh" SortExpression="[TienQuaTrinh]"  />
				<asp:BoundField DataField="DonGiaQuaTrinh" HeaderText="Don Gia Qua Trinh" SortExpression="[DonGiaQuaTrinh]"  />
				<asp:BoundField DataField="SoBaiQuaTrinh" HeaderText="So Bai Qua Trinh" SortExpression="[SoBaiQuaTrinh]"  />
				<asp:BoundField DataField="SoBaiCuoiKy" HeaderText="So Bai Cuoi Ky" SortExpression="[SoBaiCuoiKy]"  />
				<asp:BoundField DataField="DonGiaGiuaKy" HeaderText="Don Gia Giua Ky" SortExpression="[DonGiaGiuaKy]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoChamBai Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoChamBai" OnClientClick="javascript:location.href='ThuLaoChamBaiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoChamBaiDataSource ID="ThuLaoChamBaiDataSource" runat="server"
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
		</data:ThuLaoChamBaiDataSource>
	    		
</asp:Content>




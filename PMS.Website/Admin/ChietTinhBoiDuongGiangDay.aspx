<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ChietTinhBoiDuongGiangDay.aspx.cs" Inherits="ChietTinhBoiDuongGiangDay" Title="ChietTinhBoiDuongGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Chiet Tinh Boi Duong Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ChietTinhBoiDuongGiangDayDataSource"
				DataKeyNames="MaQuanLy, MaLopHocPhan, MaLopSinhVien"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ChietTinhBoiDuongGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="MaLopSinhVien" HeaderText="Ma Lop Sinh Vien" SortExpression="[MaLopSinhVien]" ReadOnly="True" />
				<asp:BoundField DataField="TongCong" HeaderText="Tong Cong" SortExpression="[TongCong]"  />
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]"  />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="TienThem" HeaderText="Tien Them" SortExpression="[TienThem]"  />
				<asp:BoundField DataField="ChiPhiLuuTru" HeaderText="Chi Phi Luu Tru" SortExpression="[ChiPhiLuuTru]"  />
				<asp:BoundField DataField="ChiPhiDiLai" HeaderText="Chi Phi Di Lai" SortExpression="[ChiPhiDiLai]"  />
				<asp:BoundField DataField="SoDeThiDapAn" HeaderText="So De Thi Dap An" SortExpression="[SoDeThiDapAn]"  />
				<asp:BoundField DataField="SoNgayLuuTru" HeaderText="So Ngay Luu Tru" SortExpression="[SoNgayLuuTru]"  />
				<asp:BoundField DataField="TenLopSinhVien" HeaderText="Ten Lop Sinh Vien" SortExpression="[TenLopSinhVien]"  />
				<data:BoundRadioButtonField DataField="HoanTat" HeaderText="Hoan Tat" SortExpression="[HoanTat]"  />
				<asp:BoundField DataField="SoLanDiLai" HeaderText="So Lan Di Lai" SortExpression="[SoLanDiLai]"  />
				<asp:BoundField DataField="MaPhong" HeaderText="Ma Phong" SortExpression="[MaPhong]"  />
				<asp:BoundField DataField="TenPhong" HeaderText="Ten Phong" SortExpression="[TenPhong]"  />
				<asp:BoundField DataField="MaCoSo" HeaderText="Ma Co So" SortExpression="[MaCoSo]"  />
				<asp:BoundField DataField="TenLopHocPhan" HeaderText="Ten Lop Hoc Phan" SortExpression="[TenLopHocPhan]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]" ReadOnly="True" />
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" ReadOnly="True" />
				<asp:BoundField DataField="SiSoLop" HeaderText="Si So Lop" SortExpression="[SiSoLop]"  />
				<asp:BoundField DataField="HeSoLd" HeaderText="He So Ld" SortExpression="[HeSoLD]"  />
				<asp:BoundField DataField="HeSoTinChi" HeaderText="He So Tin Chi" SortExpression="[HeSoTinChi]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="TenCoSo" HeaderText="Ten Co So" SortExpression="[TenCoSo]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ChietTinhBoiDuongGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnChietTinhBoiDuongGiangDay" OnClientClick="javascript:location.href='ChietTinhBoiDuongGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ChietTinhBoiDuongGiangDayDataSource ID="ChietTinhBoiDuongGiangDayDataSource" runat="server"
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
		</data:ChietTinhBoiDuongGiangDayDataSource>
	    		
</asp:Content>




<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThanhTraTheoThoiKhoaBieu.aspx.cs" Inherits="ThanhTraTheoThoiKhoaBieu" Title="ThanhTraTheoThoiKhoaBieu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thanh Tra Theo Thoi Khoa Bieu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThanhTraTheoThoiKhoaBieuDataSource"
				DataKeyNames="MaLichHoc, MaCanBoGiangDay"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThanhTraTheoThoiKhoaBieu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="TietBatDau" HeaderText="Tiet Bat Dau" SortExpression="[TietBatDau]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="Ngay" HeaderText="Ngay" SortExpression="[Ngay]"  />
				<asp:BoundField DataField="SoTietGhiNhan" HeaderText="So Tiet Ghi Nhan" SortExpression="[SoTietGhiNhan]"  />
				<asp:BoundField DataField="MaCanBoGiangDay" HeaderText="Ma Can Bo Giang Day" SortExpression="[MaCanBoGiangDay]" ReadOnly="True" />
				<data:BoundRadioButtonField DataField="DaXacNhan" HeaderText="Da Xac Nhan" SortExpression="[DaXacNhan]"  />
				<asp:BoundField DataField="ThanhLy" HeaderText="Thanh Ly" SortExpression="[ThanhLy]"  />
				<asp:BoundField DataField="SoTietQuyDoi" HeaderText="So Tiet Quy Doi" SortExpression="[SoTietQuyDoi]"  />
				<asp:BoundField DataField="Phong" HeaderText="Phong" SortExpression="[Phong]"  />
				<data:BoundRadioButtonField DataField="XacNhan" HeaderText="Xac Nhan" SortExpression="[XacNhan]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="SiSo" HeaderText="Si So" SortExpression="[SiSo]"  />
				<asp:BoundField DataField="ThoiDiemGhiNhan" HeaderText="Thoi Diem Ghi Nhan" SortExpression="[ThoiDiemGhiNhan]"  />
				<asp:BoundField DataField="MaHinhThucViPhamHrm" HeaderText="Ma Hinh Thuc Vi Pham Hrm" SortExpression="[MaHinhThucViPhamHrm]"  />
				<asp:BoundField DataField="MaLichHoc" HeaderText="Ma Lich Hoc" SortExpression="[MaLichHoc]" ReadOnly="True" />
				<asp:BoundField DataField="MaViPham" HeaderText="Ma Vi Pham" SortExpression="[MaViPham]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="LyDo" HeaderText="Ly Do" SortExpression="[LyDo]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThanhTraTheoThoiKhoaBieu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThanhTraTheoThoiKhoaBieu" OnClientClick="javascript:location.href='ThanhTraTheoThoiKhoaBieuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThanhTraTheoThoiKhoaBieuDataSource ID="ThanhTraTheoThoiKhoaBieuDataSource" runat="server"
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
		</data:ThanhTraTheoThoiKhoaBieuDataSource>
	    		
</asp:Content>




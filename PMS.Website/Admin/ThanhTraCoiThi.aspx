<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThanhTraCoiThi.aspx.cs" Inherits="ThanhTraCoiThi" Title="ThanhTraCoiThi List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thanh Tra Coi Thi List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThanhTraCoiThiDataSource"
				DataKeyNames="Examination, MaCanBoCoiThi"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThanhTraCoiThi.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ThoiDiemGhiNhan" HeaderText="Thoi Diem Ghi Nhan" SortExpression="[ThoiDiemGhiNhan]"  />
				<asp:BoundField DataField="LyDo" HeaderText="Ly Do" SortExpression="[LyDo]"  />
				<asp:BoundField DataField="SiSoThanhTra" HeaderText="Si So Thanh Tra" SortExpression="[SiSoThanhTra]"  />
				<asp:BoundField DataField="MaViPham" HeaderText="Ma Vi Pham" SortExpression="[MaViPham]"  />
				<asp:BoundField DataField="MaHinhThucViPhamHrm" HeaderText="Ma Hinh Thuc Vi Pham Hrm" SortExpression="[MaHinhThucViPhamHrm]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaLoaiHocPhan" HeaderText="Ma Loai Hoc Phan" SortExpression="[MaLoaiHocPhan]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<data:BoundRadioButtonField DataField="XacNhan" HeaderText="Xac Nhan" SortExpression="[XacNhan]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="SoLuongSinhVien" HeaderText="So Luong Sinh Vien" SortExpression="[SoLuongSinhVien]"  />
				<asp:BoundField DataField="ThoiGianBatDau" HeaderText="Thoi Gian Bat Dau" SortExpression="[ThoiGianBatDau]"  />
				<asp:BoundField DataField="MaPhong" HeaderText="Ma Phong" SortExpression="[MaPhong]"  />
				<asp:BoundField DataField="NgayThi" HeaderText="Ngay Thi" SortExpression="[NgayThi]"  />
				<asp:BoundField DataField="Examination" HeaderText="Examination" SortExpression="[Examination]" ReadOnly="True" />
				<asp:BoundField DataField="MaCanBoCoiThi" HeaderText="Ma Can Bo Coi Thi" SortExpression="[MaCanBoCoiThi]" ReadOnly="True" />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="TietBatDau" HeaderText="Tiet Bat Dau" SortExpression="[TietBatDau]"  />
				<asp:BoundField DataField="MaLopSinhVien" HeaderText="Ma Lop Sinh Vien" SortExpression="[MaLopSinhVien]"  />
				<asp:BoundField DataField="ThoiGianLamBai" HeaderText="Thoi Gian Lam Bai" SortExpression="[ThoiGianLamBai]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="TenMonHoc" HeaderText="Ten Mon Hoc" SortExpression="[TenMonHoc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThanhTraCoiThi Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThanhTraCoiThi" OnClientClick="javascript:location.href='ThanhTraCoiThiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThanhTraCoiThiDataSource ID="ThanhTraCoiThiDataSource" runat="server"
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
		</data:ThanhTraCoiThiDataSource>
	    		
</asp:Content>




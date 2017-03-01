<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoCoiThi.aspx.cs" Inherits="ThuLaoCoiThi" Title="ThuLaoCoiThi List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Coi Thi List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoCoiThiDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoCoiThi.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="DotChiTra" HeaderText="Dot Chi Tra" SortExpression="[DotChiTra]"  />
				<asp:BoundField DataField="MaCoSo" HeaderText="Ma Co So" SortExpression="[MaCoSo]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="TietbatDau" HeaderText="Tietbat Dau" SortExpression="[TietbatDau]"  />
				<data:BoundRadioButtonField DataField="IsSync" HeaderText="Is Sync" SortExpression="[IsSync]"  />
				<data:BoundRadioButtonField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]"  />
				<asp:BoundField DataField="SoLuongSinhVien" HeaderText="So Luong Sinh Vien" SortExpression="[SoLuongSinhVien]"  />
				<asp:BoundField DataField="ThoiGianLamBai" HeaderText="Thoi Gian Lam Bai" SortExpression="[ThoiGianLamBai]"  />
				<asp:BoundField DataField="GioCoiThi" HeaderText="Gio Coi Thi" SortExpression="[GioCoiThi]"  />
				<asp:BoundField DataField="MaHocPhan" HeaderText="Ma Hoc Phan" SortExpression="[MaHocPhan]"  />
				<asp:BoundField DataField="Ngay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay" SortExpression="[Ngay]"  />
				<asp:BoundField DataField="Ca" HeaderText="Ca" SortExpression="[Ca]"  />
				<asp:BoundField DataField="LanThi" HeaderText="Lan Thi" SortExpression="[LanThi]"  />
				<asp:BoundField DataField="MaGiangVienQuanLy" HeaderText="Ma Giang Vien Quan Ly" SortExpression="[MaGiangVienQuanLy]"  />
				<asp:BoundField DataField="KyThi" HeaderText="Ky Thi" SortExpression="[KyThi]"  />
				<asp:BoundField DataField="Phong" HeaderText="Phong" SortExpression="[Phong]"  />
				<asp:BoundField DataField="NoiDung" HeaderText="Noi Dung" SortExpression="[NoiDung]"  />
				<asp:BoundField DataField="MaMonHoc" HeaderText="Ma Mon Hoc" SortExpression="[MaMonHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="SoTien" HeaderText="So Tien" SortExpression="[SoTien]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoCoiThi Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoCoiThi" OnClientClick="javascript:location.href='ThuLaoCoiThiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoCoiThiDataSource ID="ThuLaoCoiThiDataSource" runat="server"
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
		</data:ThuLaoCoiThiDataSource>
	    		
</asp:Content>




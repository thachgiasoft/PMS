<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="SdhHeSoLopDong.aspx.cs" Inherits="SdhHeSoLopDong" Title="SdhHeSoLopDong List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Sdh He So Lop Dong List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="SdhHeSoLopDongDataSource"
				DataKeyNames="MaHeSo"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_SdhHeSoLopDong.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HocKyApDung" HeaderText="Hoc Ky Ap Dung" SortExpression="[HocKyApDung]"  />
				<asp:BoundField DataField="MaLoaiKhoiLuong" HeaderText="Ma Loai Khoi Luong" SortExpression="[MaLoaiKhoiLuong]"  />
				<asp:BoundField DataField="NgayKtApDung" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Kt Ap Dung" SortExpression="[NgayKTApDung]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NgayBdApDung" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Bd Ap Dung" SortExpression="[NgayBDApDung]"  />
				<asp:BoundField DataField="MaBacDaoTao" HeaderText="Ma Bac Dao Tao" SortExpression="[MaBacDaoTao]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="Stt" HeaderText="Stt" SortExpression="[STT]"  />
				<asp:BoundField DataField="MaNhomMonHoc" HeaderText="Ma Nhom Mon Hoc" SortExpression="[MaNhomMonHoc]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="DenKhoan" HeaderText="Den Khoan" SortExpression="[DenKhoan]"  />
				<asp:BoundField DataField="TuKhoan" HeaderText="Tu Khoan" SortExpression="[TuKhoan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No SdhHeSoLopDong Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnSdhHeSoLopDong" OnClientClick="javascript:location.href='SdhHeSoLopDongEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:SdhHeSoLopDongDataSource ID="SdhHeSoLopDongDataSource" runat="server"
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
		</data:SdhHeSoLopDongDataSource>
	    		
</asp:Content>




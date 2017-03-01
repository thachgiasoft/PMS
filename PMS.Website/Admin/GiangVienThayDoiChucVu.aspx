<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienThayDoiChucVu.aspx.cs" Inherits="GiangVienThayDoiChucVu" Title="GiangVienThayDoiChucVu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Thay Doi Chuc Vu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienThayDoiChucVuDataSource"
				DataKeyNames="MaQuanLy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienThayDoiChucVu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayHetHieuLuc" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Het Hieu Luc" SortExpression="[NgayHetHieuLuc]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="User" HeaderText="User" SortExpression="[User]"  />
				<asp:BoundField DataField="NgayHieuLuc" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Hieu Luc" SortExpression="[NgayHieuLuc]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="MaChucVuCu" HeaderText="Ma Chuc Vu Cu" SortExpression="[MaChucVuCu]"  />
				<asp:BoundField DataField="MaChucVu" HeaderText="Ma Chuc Vu" SortExpression="[MaChucVu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienThayDoiChucVu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienThayDoiChucVu" OnClientClick="javascript:location.href='GiangVienThayDoiChucVuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienThayDoiChucVuDataSource ID="GiangVienThayDoiChucVuDataSource" runat="server"
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
		</data:GiangVienThayDoiChucVuDataSource>
	    		
</asp:Content>




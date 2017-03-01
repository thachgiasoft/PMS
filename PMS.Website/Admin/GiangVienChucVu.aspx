<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienChucVu.aspx.cs" Inherits="GiangVienChucVu" Title="GiangVienChucVu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Chuc Vu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienChucVuDataSource"
				DataKeyNames="MaQuanLy, MaGiangVien, MaChucVu"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienChucVu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<data:HyperLinkField HeaderText="Ma Chuc Vu" DataNavigateUrlFormatString="ChucVuEdit.aspx?MaChucVu={0}" DataNavigateUrlFields="MaChucVu" DataContainer="MaChucVuSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NgayHieuLuc" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Hieu Luc" SortExpression="[NgayHieuLuc]"  />
				<asp:BoundField DataField="NgayHetHieuLuc" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Het Hieu Luc" SortExpression="[NgayHetHieuLuc]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienChucVu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienChucVu" OnClientClick="javascript:location.href='GiangVienChucVuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienChucVuDataSource ID="GiangVienChucVuDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienChucVuProperty Name="ChucVu"/> 
					<data:GiangVienChucVuProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:GiangVienChucVuDataSource>
	    		
</asp:Content>




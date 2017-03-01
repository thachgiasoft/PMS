<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienPhanHoi.aspx.cs" Inherits="GiangVienPhanHoi" Title="GiangVienPhanHoi List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Phan Hoi List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienPhanHoiDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienPhanHoi.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayPhanHoi" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Phan Hoi" SortExpression="[NgayPhanHoi]"  />
				<asp:BoundField DataField="TraLoiPhanHoi" HeaderText="Tra Loi Phan Hoi" SortExpression="[TraLoiPhanHoi]"  />
				<asp:BoundField DataField="NguoiTraLoi" HeaderText="Nguoi Tra Loi" SortExpression="[NguoiTraLoi]"  />
				<asp:BoundField DataField="NgayTraLoi" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Tra Loi" SortExpression="[NgayTraLoi]"  />
				<asp:BoundField DataField="NoiDungPhanHoi" HeaderText="Noi Dung Phan Hoi" SortExpression="[NoiDungPhanHoi]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]"  />
				<asp:BoundField DataField="MaGiangVienQuanLy" HeaderText="Ma Giang Vien Quan Ly" SortExpression="[MaGiangVienQuanLy]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienPhanHoi Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienPhanHoi" OnClientClick="javascript:location.href='GiangVienPhanHoiEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienPhanHoiDataSource ID="GiangVienPhanHoiDataSource" runat="server"
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
		</data:GiangVienPhanHoiDataSource>
	    		
</asp:Content>




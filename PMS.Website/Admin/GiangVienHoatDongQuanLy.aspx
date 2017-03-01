<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiangVienHoatDongQuanLy.aspx.cs" Inherits="GiangVienHoatDongQuanLy" Title="GiangVienHoatDongQuanLy List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giang Vien Hoat Dong Quan Ly List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiangVienHoatDongQuanLyDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiangVienHoatDongQuanLy.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayThucHien" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Thuc Hien" SortExpression="[NgayThucHien]"  />
				<asp:BoundField DataField="NoiDungCongViec" HeaderText="Noi Dung Cong Viec" SortExpression="[NoiDungCongViec]"  />
				<data:BoundRadioButtonField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]"  />
				<data:BoundRadioButtonField DataField="XacNhan" HeaderText="Xac Nhan" SortExpression="[XacNhan]"  />
				<asp:BoundField DataField="HeSoQuyDoi" HeaderText="He So Quy Doi" SortExpression="[HeSoQuyDoi]"  />
				<asp:BoundField DataField="SoPhut" HeaderText="So Phut" SortExpression="[SoPhut]"  />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<data:HyperLinkField HeaderText="Ma Hoat Dong Quan Ly" DataNavigateUrlFormatString="DanhMucHoatDongQuanLyEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="MaHoatDongQuanLySource" DataTextField="MaHoatDong" />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiangVienHoatDongQuanLy Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiangVienHoatDongQuanLy" OnClientClick="javascript:location.href='GiangVienHoatDongQuanLyEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiangVienHoatDongQuanLyDataSource ID="GiangVienHoatDongQuanLyDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:GiangVienHoatDongQuanLyProperty Name="DanhMucHoatDongQuanLy"/> 
					<data:GiangVienHoatDongQuanLyProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:GiangVienHoatDongQuanLyDataSource>
	    		
</asp:Content>




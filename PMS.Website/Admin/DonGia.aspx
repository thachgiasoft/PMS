<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="DonGia.aspx.cs" Inherits="DonGia" Title="DonGia List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Don Gia List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="DonGiaDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_DonGia.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaHinhThucDaoTao" HeaderText="Ma Hinh Thuc Dao Tao" SortExpression="[MaHinhThucDaoTao]"  />
				<asp:BoundField DataField="BacDaoTao" HeaderText="Bac Dao Tao" SortExpression="[BacDaoTao]"  />
				<asp:BoundField DataField="DonGiaTrongChuan" HeaderText="Don Gia Trong Chuan" SortExpression="[DonGiaTrongChuan]"  />
				<asp:BoundField DataField="DonGiaNgoaiChuan" HeaderText="Don Gia Ngoai Chuan" SortExpression="[DonGiaNgoaiChuan]"  />
				<data:HyperLinkField HeaderText="Ngon Ngu Giang Day" DataNavigateUrlFormatString="NgonNguGiangDayEdit.aspx?MaNgonNgu={0}" DataNavigateUrlFields="MaNgonNgu" DataContainer="NgonNguGiangDaySource" DataTextField="TenNgonNgu" />
				<data:HyperLinkField HeaderText="Ma Nhom Mon" DataNavigateUrlFormatString="NhomMonHocEdit.aspx?MaNhomMon={0}" DataNavigateUrlFields="MaNhomMon" DataContainer="MaNhomMonSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="NhomMonHoc" HeaderText="Nhom Mon Hoc" SortExpression="[NhomMonHoc]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<data:HyperLinkField HeaderText="Ma Hoc Ham" DataNavigateUrlFormatString="HocHamEdit.aspx?MaHocHam={0}" DataNavigateUrlFields="MaHocHam" DataContainer="MaHocHamSource" DataTextField="MaQuanLy" />
				<data:HyperLinkField HeaderText="Ma Hoc Vi" DataNavigateUrlFormatString="HocViEdit.aspx?MaHocVi={0}" DataNavigateUrlFields="MaHocVi" DataContainer="MaHocViSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<data:HyperLinkField HeaderText="Ma Loai Giang Vien" DataNavigateUrlFormatString="LoaiGiangVienEdit.aspx?MaLoaiGiangVien={0}" DataNavigateUrlFields="MaLoaiGiangVien" DataContainer="MaLoaiGiangVienSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="DonGiaClc" HeaderText="Don Gia Clc" SortExpression="[DonGiaClc]"  />
				<asp:BoundField DataField="HeSoQuyDoiChatLuong" HeaderText="He So Quy Doi Chat Luong" SortExpression="[HeSoQuyDoiChatLuong]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No DonGia Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnDonGia" OnClientClick="javascript:location.href='DonGiaEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:DonGiaDataSource ID="DonGiaDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:DonGiaProperty Name="NhomMonHoc"/> 
					<data:DonGiaProperty Name="HocHam"/> 
					<data:DonGiaProperty Name="HocVi"/> 
					<data:DonGiaProperty Name="LoaiGiangVien"/> 
					<data:DonGiaProperty Name="NgonNguGiangDay"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:DonGiaDataSource>
	    		
</asp:Content>




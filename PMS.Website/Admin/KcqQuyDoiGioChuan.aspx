<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqQuyDoiGioChuan.aspx.cs" Inherits="KcqQuyDoiGioChuan" Title="KcqQuyDoiGioChuan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Quy Doi Gio Chuan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqQuyDoiGioChuanDataSource"
				DataKeyNames="MaQuyDoi"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqQuyDoiGioChuan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="ThuTu" HeaderText="Thu Tu" SortExpression="[ThuTu]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="LoaiQuyDoi" HeaderText="Loai Quy Doi" SortExpression="[LoaiQuyDoi]"  />
				<asp:BoundField DataField="TenQuyDoi" HeaderText="Ten Quy Doi" SortExpression="[TenQuyDoi]"  />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<data:HyperLinkField HeaderText="Ma Don Vi" DataNavigateUrlFormatString="DonViTinhEdit.aspx?MaDonVi={0}" DataNavigateUrlFields="MaDonVi" DataContainer="MaDonViSource" DataTextField="MaQuanLy" />
				<data:BoundRadioButtonField DataField="CongDon" HeaderText="Cong Don" SortExpression="[CongDon]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqQuyDoiGioChuan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqQuyDoiGioChuan" OnClientClick="javascript:location.href='KcqQuyDoiGioChuanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqQuyDoiGioChuanDataSource ID="KcqQuyDoiGioChuanDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:KcqQuyDoiGioChuanProperty Name="DonViTinh"/> 
					<%--<data:KcqQuyDoiGioChuanProperty Name="KcqKhoanQuyDoiCollection" />--%>
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:KcqQuyDoiGioChuanDataSource>
	    		
</asp:Content>




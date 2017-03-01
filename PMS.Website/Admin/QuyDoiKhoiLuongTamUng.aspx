<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="QuyDoiKhoiLuongTamUng.aspx.cs" Inherits="QuyDoiKhoiLuongTamUng" Title="QuyDoiKhoiLuongTamUng List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Quy Doi Khoi Luong Tam Ung List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="QuyDoiKhoiLuongTamUngDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_QuyDoiKhoiLuongTamUng.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="HeSoTroCap" HeaderText="He So Tro Cap" SortExpression="[HeSoTroCap]"  />
				<asp:BoundField DataField="HeSoLuong" HeaderText="He So Luong" SortExpression="[HeSoLuong]"  />
				<asp:BoundField DataField="HeSoThinhGiangMonChuyenNganh" HeaderText="He So Thinh Giang Mon Chuyen Nganh" SortExpression="[HeSoThinhGiangMonChuyenNganh]"  />
				<asp:BoundField DataField="LoaiLop" HeaderText="Loai Lop" SortExpression="[LoaiLop]"  />
				<asp:BoundField DataField="HeSoClcCntn" HeaderText="He So Clc Cntn" SortExpression="[HeSoClcCntn]"  />
				<data:BoundRadioButtonField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]"  />
				<asp:BoundField DataField="MucThanhToan" HeaderText="Muc Thanh Toan" SortExpression="[MucThanhToan]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="HeSoMonMoi" HeaderText="He So Mon Moi" SortExpression="[HeSoMonMoi]"  />
				<asp:BoundField DataField="HeSoNienCheTinChi" HeaderText="He So Nien Che Tin Chi" SortExpression="[HeSoNienCheTinChi]"  />
				<asp:BoundField DataField="HeSoNgoaiGio" HeaderText="He So Ngoai Gio" SortExpression="[HeSoNgoaiGio]"  />
				<asp:BoundField DataField="HeSoNgonNgu" HeaderText="He So Ngon Ngu" SortExpression="[HeSoNgonNgu]"  />
				<asp:BoundField DataField="HeSoChucDanhChuyenMon" HeaderText="He So Chuc Danh Chuyen Mon" SortExpression="[HeSoChucDanhChuyenMon]"  />
				<asp:BoundField DataField="HeSoBacDaoTao" HeaderText="He So Bac Dao Tao" SortExpression="[HeSoBacDaoTao]"  />
				<data:HyperLinkField HeaderText="Ma Khoi Luong Tam Ung" DataNavigateUrlFormatString="KhoiLuongTamUngEdit.aspx?MaKhoiLuong={0}" DataNavigateUrlFields="MaKhoiLuong" DataContainer="MaKhoiLuongTamUngSource" DataTextField="MaLichHoc" />
				<asp:BoundField DataField="HeSoCongViec" HeaderText="He So Cong Viec" SortExpression="[HeSoCongViec]"  />
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]"  />
				<asp:BoundField DataField="HeSoQuyDoiThucHanhSangLyThuyet" HeaderText="He So Quy Doi Thuc Hanh Sang Ly Thuyet" SortExpression="[HeSoQuyDoiThucHanhSangLyThuyet]"  />
				<asp:BoundField DataField="SoTietThucTeQuyDoi" HeaderText="So Tiet Thuc Te Quy Doi" SortExpression="[SoTietThucTeQuyDoi]"  />
				<asp:BoundField DataField="HeSoLopDong" HeaderText="He So Lop Dong" SortExpression="[HeSoLopDong]"  />
				<asp:BoundField DataField="HeSoCoSo" HeaderText="He So Co So" SortExpression="[HeSoCoSo]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No QuyDoiKhoiLuongTamUng Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnQuyDoiKhoiLuongTamUng" OnClientClick="javascript:location.href='QuyDoiKhoiLuongTamUngEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:QuyDoiKhoiLuongTamUngDataSource ID="QuyDoiKhoiLuongTamUngDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:QuyDoiKhoiLuongTamUngProperty Name="KhoiLuongTamUng"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:QuyDoiKhoiLuongTamUngDataSource>
	    		
</asp:Content>




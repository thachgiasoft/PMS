<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="HeSoChucDanhTietNghiaVu.aspx.cs" Inherits="HeSoChucDanhTietNghiaVu" Title="HeSoChucDanhTietNghiaVu List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">He So Chuc Danh Tiet Nghia Vu List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="HeSoChucDanhTietNghiaVuDataSource"
				DataKeyNames="MaHeSo"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_HeSoChucDanhTietNghiaVu.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SoTietNghiaVuMonGdtc" HeaderText="So Tiet Nghia Vu Mon Gdtc" SortExpression="[SoTietNghiaVuMonGdtc]"  />
				<asp:BoundField DataField="HeSoLuongTangThem" HeaderText="He So Luong Tang Them" SortExpression="[HeSoLuongTangThem]"  />
				<asp:BoundField DataField="NgayKtApDung" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Kt Ap Dung" SortExpression="[NgayKTApDung]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<data:BoundRadioButtonField DataField="GiangDaySauDaiHoc" HeaderText="Giang Day Sau Dai Hoc" SortExpression="[GiangDaySauDaiHoc]"  />
				<asp:BoundField DataField="NgayBdApDung" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Bd Ap Dung" SortExpression="[NgayBDApDung]"  />
				<data:HyperLinkField HeaderText="Ma Hoc Ham" DataNavigateUrlFormatString="HocHamEdit.aspx?MaHocHam={0}" DataNavigateUrlFields="MaHocHam" DataContainer="MaHocHamSource" DataTextField="MaQuanLy" />
				<asp:BoundField DataField="MaQuanLy" HeaderText="Ma Quan Ly" SortExpression="[MaQuanLy]"  />
				<asp:BoundField DataField="Stt" HeaderText="Stt" SortExpression="[STT]"  />
				<asp:BoundField DataField="SoTietNghiaVu" HeaderText="So Tiet Nghia Vu" SortExpression="[SoTietNghiaVu]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<data:HyperLinkField HeaderText="Ma Hoc Vi" DataNavigateUrlFormatString="HocViEdit.aspx?MaHocVi={0}" DataNavigateUrlFields="MaHocVi" DataContainer="MaHocViSource" DataTextField="MaQuanLy" />
			</Columns>
			<EmptyDataTemplate>
				<b>No HeSoChucDanhTietNghiaVu Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnHeSoChucDanhTietNghiaVu" OnClientClick="javascript:location.href='HeSoChucDanhTietNghiaVuEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:HeSoChucDanhTietNghiaVuDataSource ID="HeSoChucDanhTietNghiaVuDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:HeSoChucDanhTietNghiaVuProperty Name="HocHam"/> 
					<data:HeSoChucDanhTietNghiaVuProperty Name="HocVi"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:HeSoChucDanhTietNghiaVuDataSource>
	    		
</asp:Content>




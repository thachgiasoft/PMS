<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThamDinhLuanVanThacSy.aspx.cs" Inherits="ThamDinhLuanVanThacSy" Title="ThamDinhLuanVanThacSy List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Tham Dinh Luan Van Thac Sy List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThamDinhLuanVanThacSyDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThamDinhLuanVanThacSy.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="SoTien" HeaderText="So Tien" SortExpression="[SoTien]"  />
				<data:BoundRadioButtonField DataField="Chot" HeaderText="Chot" SortExpression="[Chot]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<data:HyperLinkField HeaderText="Ma Giang Vien" DataNavigateUrlFormatString="GiangVienEdit.aspx?MaGiangVien={0}" DataNavigateUrlFields="MaGiangVien" DataContainer="MaGiangVienSource" DataTextField="MaDanToc" />
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]"  />
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThamDinhLuanVanThacSy Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThamDinhLuanVanThacSy" OnClientClick="javascript:location.href='ThamDinhLuanVanThacSyEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThamDinhLuanVanThacSyDataSource ID="ThamDinhLuanVanThacSyDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:ThamDinhLuanVanThacSyProperty Name="GiangVien"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:ThamDinhLuanVanThacSyDataSource>
	    		
</asp:Content>




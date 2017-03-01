<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KetQuaCacKhoanChiKhac.aspx.cs" Inherits="KetQuaCacKhoanChiKhac" Title="KetQuaCacKhoanChiKhac List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Ket Qua Cac Khoan Chi Khac List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KetQuaCacKhoanChiKhacDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KetQuaCacKhoanChiKhac.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="ThanhTien" HeaderText="Thanh Tien" SortExpression="[ThanhTien]"  />
				<asp:BoundField DataField="TienMotTiet" HeaderText="Tien Mot Tiet" SortExpression="[TienMotTiet]"  />
				<asp:BoundField DataField="SoTiet" HeaderText="So Tiet" SortExpression="[SoTiet]"  />
				<asp:BoundField DataField="TongThanhTien" HeaderText="Tong Thanh Tien" SortExpression="[TongThanhTien]"  />
				<asp:BoundField DataField="TienGiangNgoaiGio" HeaderText="Tien Giang Ngoai Gio" SortExpression="[TienGiangNgoaiGio]"  />
				<asp:BoundField DataField="PhiCongTac" HeaderText="Phi Cong Tac" SortExpression="[PhiCongTac]"  />
				<asp:BoundField DataField="MaSo" HeaderText="Ma So" SortExpression="[MaSo]"  />
				<asp:BoundField DataField="Lop" HeaderText="Lop" SortExpression="[Lop]"  />
				<asp:BoundField DataField="MaGiangVienQuanLy" HeaderText="Ma Giang Vien Quan Ly" SortExpression="[MaGiangVienQuanLy]"  />
				<asp:BoundField DataField="HeSo" HeaderText="He So" SortExpression="[HeSo]"  />
				<asp:BoundField DataField="NoiDung" HeaderText="Noi Dung" SortExpression="[NoiDung]"  />
				<asp:BoundField DataField="Ngay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay" SortExpression="[Ngay]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KetQuaCacKhoanChiKhac Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKetQuaCacKhoanChiKhac" OnClientClick="javascript:location.href='KetQuaCacKhoanChiKhacEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KetQuaCacKhoanChiKhacDataSource ID="KetQuaCacKhoanChiKhacDataSource" runat="server"
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
		</data:KetQuaCacKhoanChiKhacDataSource>
	    		
</asp:Content>




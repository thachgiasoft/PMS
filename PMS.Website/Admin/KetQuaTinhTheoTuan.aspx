<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KetQuaTinhTheoTuan.aspx.cs" Inherits="KetQuaTinhTheoTuan" Title="KetQuaTinhTheoTuan List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Ket Qua Tinh Theo Tuan List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KetQuaTinhTheoTuanDataSource"
				DataKeyNames="MaKetQua"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KetQuaTinhTheoTuan.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="TietNghiaVu" HeaderText="Tiet Nghia Vu" SortExpression="[TietNghiaVu]"  />
				<asp:BoundField DataField="TietGioiHan" HeaderText="Tiet Gioi Han" SortExpression="[TietGioiHan]"  />
				<asp:BoundField DataField="NgayTao" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Tao" SortExpression="[NgayTao]"  />
				<asp:BoundField DataField="Tuan" HeaderText="Tuan" SortExpression="[Tuan]"  />
				<asp:BoundField DataField="Nam" HeaderText="Nam" SortExpression="[Nam]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KetQuaTinhTheoTuan Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKetQuaTinhTheoTuan" OnClientClick="javascript:location.href='KetQuaTinhTheoTuanEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KetQuaTinhTheoTuanDataSource ID="KetQuaTinhTheoTuanDataSource" runat="server"
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
		</data:KetQuaTinhTheoTuanDataSource>
	    		
</asp:Content>




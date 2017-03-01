<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThanhTraChamGiangTheoKhoaHoc.aspx.cs" Inherits="ThanhTraChamGiangTheoKhoaHoc" Title="ThanhTraChamGiangTheoKhoaHoc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thanh Tra Cham Giang Theo Khoa Hoc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThanhTraChamGiangTheoKhoaHocDataSource"
				DataKeyNames="NamHoc, HocKy, MaKhoaHoc"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThanhTraChamGiangTheoKhoaHoc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="Chon" HeaderText="Chon" SortExpression="[Chon]"  />
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]" ReadOnly="True" />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]" ReadOnly="True" />
				<asp:BoundField DataField="MaKhoaHoc" HeaderText="Ma Khoa Hoc" SortExpression="[MaKhoaHoc]" ReadOnly="True" />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThanhTraChamGiangTheoKhoaHoc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThanhTraChamGiangTheoKhoaHoc" OnClientClick="javascript:location.href='ThanhTraChamGiangTheoKhoaHocEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThanhTraChamGiangTheoKhoaHocDataSource ID="ThanhTraChamGiangTheoKhoaHocDataSource" runat="server"
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
		</data:ThanhTraChamGiangTheoKhoaHocDataSource>
	    		
</asp:Content>




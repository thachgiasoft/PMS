<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="GiamTruDinhMuc.aspx.cs" Inherits="GiamTruDinhMuc" Title="GiamTruDinhMuc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Giam Tru Dinh Muc List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="GiamTruDinhMucDataSource"
				DataKeyNames="MaQuanLy"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_GiamTruDinhMuc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="DonVi" HeaderText="Don Vi" SortExpression="[DonVi]"  />
				<asp:BoundField DataField="MucGiamNckh" HeaderText="Muc Giam Nckh" SortExpression="[MucGiamNckh]"  />
				<asp:BoundField DataField="NguoiCapNhat" HeaderText="Nguoi Cap Nhat" SortExpression="[NguoiCapNhat]"  />
				<asp:BoundField DataField="PhanTramGiamTru" HeaderText="Phan Tram Giam Tru" SortExpression="[PhanTramGiamTru]"  />
				<asp:BoundField DataField="NoiDungGiamTru" HeaderText="Noi Dung Giam Tru" SortExpression="[NoiDungGiamTru]"  />
				<asp:BoundField DataField="MucGiam" HeaderText="Muc Giam" SortExpression="[MucGiam]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No GiamTruDinhMuc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnGiamTruDinhMuc" OnClientClick="javascript:location.href='GiamTruDinhMucEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:GiamTruDinhMucDataSource ID="GiamTruDinhMucDataSource" runat="server"
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
		</data:GiamTruDinhMucDataSource>
	    		
</asp:Content>




<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoChamThiVhuex.aspx.cs" Inherits="ThuLaoChamThiVhuex" Title="ThuLaoChamThiVhuex List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Cham Thi Vhuex List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoChamThiVhuexDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoChamThiVhuex.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="VanDap" HeaderText="Van Dap" SortExpression="[VanDap]"  />
				<asp:BoundField DataField="TieuLuan" HeaderText="Tieu Luan" SortExpression="[TieuLuan]"  />
				<asp:BoundField DataField="TuLuan" HeaderText="Tu Luan" SortExpression="[TuLuan]"  />
				<asp:BoundField DataField="TongHop" HeaderText="Tong Hop" SortExpression="[TongHop]"  />
				<asp:BoundField DataField="ThucHanh" HeaderText="Thuc Hanh" SortExpression="[ThucHanh]"  />
				<asp:BoundField DataField="UpdateStaff" HeaderText="Update Staff" SortExpression="[UpdateStaff]"  />
				<asp:BoundField DataField="GioChuan" HeaderText="Gio Chuan" SortExpression="[GioChuan]"  />
				<asp:BoundField DataField="DoAn" HeaderText="Do An" SortExpression="[DoAn]"  />
				<asp:BoundField DataField="UpdateDate" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Update Date" SortExpression="[UpdateDate]"  />
				<asp:BoundField DataField="KyThi" HeaderText="Ky Thi" SortExpression="[KyThi]"  />
				<asp:BoundField DataField="LanThi" HeaderText="Lan Thi" SortExpression="[LanThi]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="DotThanhToan" HeaderText="Dot Thanh Toan" SortExpression="[DotThanhToan]"  />
				<asp:BoundField DataField="GiuaKy" HeaderText="Giua Ky" SortExpression="[GiuaKy]"  />
				<asp:BoundField DataField="TracNghiem" HeaderText="Trac Nghiem" SortExpression="[TracNghiem]"  />
				<asp:BoundField DataField="MaGv" HeaderText="Ma Gv" SortExpression="[MaGV]"  />
				<asp:BoundField DataField="DotThi" HeaderText="Dot Thi" SortExpression="[DotThi]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoChamThiVhuex Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoChamThiVhuex" OnClientClick="javascript:location.href='ThuLaoChamThiVhuexEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoChamThiVhuexDataSource ID="ThuLaoChamThiVhuexDataSource" runat="server"
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
		</data:ThuLaoChamThiVhuexDataSource>
	    		
</asp:Content>




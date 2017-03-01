<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="ThuLaoCoiThiVhuex.aspx.cs" Inherits="ThuLaoCoiThiVhuex" Title="ThuLaoCoiThiVhuex List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Thu Lao Coi Thi Vhuex List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="ThuLaoCoiThiVhuexDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_ThuLaoCoiThiVhuex.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="SafeName120Phut" HeaderText="Phut" SortExpression="[120Phut]"  />
				<asp:BoundField DataField="SafeName90Phut" HeaderText="Phut" SortExpression="[90Phut]"  />
				<asp:BoundField DataField="SafeName60Phut" HeaderText="Phut" SortExpression="[60Phut]"  />
				<asp:BoundField DataField="SoCa" HeaderText="So Ca" SortExpression="[SoCa]"  />
				<asp:BoundField DataField="UpdateStaff" HeaderText="Update Staff" SortExpression="[UpdateStaff]"  />
				<asp:BoundField DataField="UpdateDate" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Update Date" SortExpression="[UpdateDate]"  />
				<asp:BoundField DataField="GioChuan" HeaderText="Gio Chuan" SortExpression="[GioChuan]"  />
				<asp:BoundField DataField="KyThi" HeaderText="Ky Thi" SortExpression="[KyThi]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="LanThi" HeaderText="Lan Thi" SortExpression="[LanThi]"  />
				<asp:BoundField DataField="DotThi" HeaderText="Dot Thi" SortExpression="[DotThi]"  />
				<asp:BoundField DataField="MaGv" HeaderText="Ma Gv" SortExpression="[MaGV]"  />
				<asp:BoundField DataField="DotThanhToan" HeaderText="Dot Thanh Toan" SortExpression="[DotThanhToan]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No ThuLaoCoiThiVhuex Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnThuLaoCoiThiVhuex" OnClientClick="javascript:location.href='ThuLaoCoiThiVhuexEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:ThuLaoCoiThiVhuexDataSource ID="ThuLaoCoiThiVhuexDataSource" runat="server"
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
		</data:ThuLaoCoiThiVhuexDataSource>
	    		
</asp:Content>




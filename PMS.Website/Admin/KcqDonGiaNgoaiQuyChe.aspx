<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqDonGiaNgoaiQuyChe.aspx.cs" Inherits="KcqDonGiaNgoaiQuyChe" Title="KcqDonGiaNgoaiQuyChe List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Don Gia Ngoai Quy Che List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqDonGiaNgoaiQuyCheDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqDonGiaNgoaiQuyChe.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="DenNgay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Den Ngay" SortExpression="[DenNgay]"  />
				<asp:BoundField DataField="TuNgay" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Tu Ngay" SortExpression="[TuNgay]"  />
				<asp:BoundField DataField="DonGiaClc" HeaderText="Don Gia Clc" SortExpression="[DonGiaClc]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<asp:BoundField DataField="MaGiangVien" HeaderText="Ma Giang Vien" SortExpression="[MaGiangVien]"  />
				<asp:BoundField DataField="DonGiaDaiTra" HeaderText="Don Gia Dai Tra" SortExpression="[DonGiaDaiTra]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqDonGiaNgoaiQuyChe Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqDonGiaNgoaiQuyChe" OnClientClick="javascript:location.href='KcqDonGiaNgoaiQuyCheEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqDonGiaNgoaiQuyCheDataSource ID="KcqDonGiaNgoaiQuyCheDataSource" runat="server"
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
		</data:KcqDonGiaNgoaiQuyCheDataSource>
	    		
</asp:Content>




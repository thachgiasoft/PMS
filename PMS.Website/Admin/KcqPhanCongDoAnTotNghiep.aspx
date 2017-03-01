<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="KcqPhanCongDoAnTotNghiep.aspx.cs" Inherits="KcqPhanCongDoAnTotNghiep" Title="KcqPhanCongDoAnTotNghiep List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Kcq Phan Cong Do An Tot Nghiep List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="KcqPhanCongDoAnTotNghiepDataSource"
				DataKeyNames="MaLopHocPhan, MaSinhVien"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_KcqPhanCongDoAnTotNghiep.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="GiangVienPhanBien2" HeaderText="Giang Vien Phan Bien2" SortExpression="[GiangVienPhanBien2]"  />
				<asp:BoundField DataField="GiangVienPhanBien1" HeaderText="Giang Vien Phan Bien1" SortExpression="[GiangVienPhanBien1]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="MaSinhVien" HeaderText="Ma Sinh Vien" SortExpression="[MaSinhVien]" ReadOnly="True" />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" ReadOnly="True" />
				<asp:BoundField DataField="GiangVienHuongDan" HeaderText="Giang Vien Huong Dan" SortExpression="[GiangVienHuongDan]"  />
				<asp:BoundField DataField="HoTen" HeaderText="Ho Ten" SortExpression="[HoTen]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No KcqPhanCongDoAnTotNghiep Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnKcqPhanCongDoAnTotNghiep" OnClientClick="javascript:location.href='KcqPhanCongDoAnTotNghiepEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:KcqPhanCongDoAnTotNghiepDataSource ID="KcqPhanCongDoAnTotNghiepDataSource" runat="server"
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
		</data:KcqPhanCongDoAnTotNghiepDataSource>
	    		
</asp:Content>




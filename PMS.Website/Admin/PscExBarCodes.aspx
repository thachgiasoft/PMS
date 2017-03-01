<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="PscExBarCodes.aspx.cs" Inherits="PscExBarCodes" Title="PscExBarCodes List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Psc Ex Bar Codes List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="PscExBarCodesDataSource"
				DataKeyNames="MaLopHocPhan, KyThi, LanThi, BarCode"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_PscExBarCodes.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="NgayGiao" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Giao" SortExpression="[NgayGiao]"  />
				<asp:BoundField DataField="NguoiGiao" HeaderText="Nguoi Giao" SortExpression="[NguoiGiao]"  />
				<asp:BoundField DataField="NgayNhan" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Nhan" SortExpression="[NgayNhan]"  />
				<asp:BoundField DataField="NguoiNhan" HeaderText="Nguoi Nhan" SortExpression="[NguoiNhan]"  />
				<data:BoundRadioButtonField DataField="DaGuiMailNhacGiaoBai" HeaderText="Da Gui Mail Nhac Giao Bai" SortExpression="[DaGuiMailNhacGiaoBai]"  />
				<asp:BoundField DataField="SoBai" HeaderText="So Bai" SortExpression="[SoBai]"  />
				<asp:BoundField DataField="SoTo" HeaderText="So To" SortExpression="[SoTo]"  />
				<data:BoundRadioButtonField DataField="DaGuiMailNhacThuHoiBai" HeaderText="Da Gui Mail Nhac Thu Hoi Bai" SortExpression="[DaGuiMailNhacThuHoiBai]"  />
				<data:BoundRadioButtonField DataField="DaGuiMailNhacNhanBai" HeaderText="Da Gui Mail Nhac Nhan Bai" SortExpression="[DaGuiMailNhacNhanBai]"  />
				<asp:BoundField DataField="UpdateStaff" HeaderText="Update Staff" SortExpression="[UpdateStaff]"  />
				<asp:BoundField DataField="LanThi" HeaderText="Lan Thi" SortExpression="[LanThi]" ReadOnly="True" />
				<asp:BoundField DataField="BarCode" HeaderText="Bar Code" SortExpression="[BarCode]" ReadOnly="True" />
				<asp:BoundField DataField="MaLopHocPhan" HeaderText="Ma Lop Hoc Phan" SortExpression="[MaLopHocPhan]" ReadOnly="True" />
				<asp:BoundField DataField="KyThi" HeaderText="Ky Thi" SortExpression="[KyThi]" ReadOnly="True" />
				<asp:BoundField DataField="MaNhanDang" HeaderText="Ma Nhan Dang" SortExpression="[MaNhanDang]"  />
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]"  />
				<asp:BoundField DataField="UpdateDate" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Update Date" SortExpression="[UpdateDate]"  />
				<data:BoundRadioButtonField DataField="GiaoBai" HeaderText="Giao Bai" SortExpression="[GiaoBai]"  />
				<data:BoundRadioButtonField DataField="NhanBai" HeaderText="Nhan Bai" SortExpression="[NhanBai]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No PscExBarCodes Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnPscExBarCodes" OnClientClick="javascript:location.href='PscExBarCodesEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:PscExBarCodesDataSource ID="PscExBarCodesDataSource" runat="server"
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
		</data:PscExBarCodesDataSource>
	    		
</asp:Content>




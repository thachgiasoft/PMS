<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="SdhChotKhoiLuongGiangDay.aspx.cs" Inherits="SdhChotKhoiLuongGiangDay" Title="SdhChotKhoiLuongGiangDay List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Sdh Chot Khoi Luong Giang Day List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="SdhChotKhoiLuongGiangDayDataSource"
				DataKeyNames="Id"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_SdhChotKhoiLuongGiangDay.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<data:BoundRadioButtonField DataField="KhoiLuongKhac" HeaderText="Khoi Luong Khac" SortExpression="[KhoiLuongKhac]"  />
				<data:BoundRadioButtonField DataField="DoAnTotNghiep" HeaderText="Do An Tot Nghiep" SortExpression="[DoAnTotNghiep]"  />
				<asp:BoundField DataField="MaDot" HeaderText="Ma Dot" SortExpression="[MaDot]"  />
				<asp:BoundField DataField="NgayCapNhat" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]"  />
				<asp:BoundField DataField="HocKy" HeaderText="Hoc Ky" SortExpression="[HocKy]"  />
				<asp:BoundField DataField="NamHoc" HeaderText="Nam Hoc" SortExpression="[NamHoc]"  />
				<data:BoundRadioButtonField DataField="DoAnMonHoc" HeaderText="Do An Mon Hoc" SortExpression="[DoAnMonHoc]"  />
				<data:BoundRadioButtonField DataField="LyThuyetThucHanh" HeaderText="Ly Thuyet Thuc Hanh" SortExpression="[LyThuyetThucHanh]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No SdhChotKhoiLuongGiangDay Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnSdhChotKhoiLuongGiangDay" OnClientClick="javascript:location.href='SdhChotKhoiLuongGiangDayEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:SdhChotKhoiLuongGiangDayDataSource ID="SdhChotKhoiLuongGiangDayDataSource" runat="server"
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
		</data:SdhChotKhoiLuongGiangDayDataSource>
	    		
</asp:Content>




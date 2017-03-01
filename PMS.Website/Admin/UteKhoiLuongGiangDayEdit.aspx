<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="UteKhoiLuongGiangDayEdit.aspx.cs" Inherits="UteKhoiLuongGiangDayEdit" Title="UteKhoiLuongGiangDay Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Ute Khoi Luong Giang Day - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="UteKhoiLuongGiangDayDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/UteKhoiLuongGiangDayFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/UteKhoiLuongGiangDayFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>UteKhoiLuongGiangDay not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:UteKhoiLuongGiangDayDataSource ID="UteKhoiLuongGiangDayDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:UteKhoiLuongGiangDayDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewUteKhoiLuongQuyDoi1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewUteKhoiLuongQuyDoi1_SelectedIndexChanged"			 			 
			DataSourceID="UteKhoiLuongQuyDoiDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_UteKhoiLuongQuyDoi.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Id Khoi Luong Giang Day" DataNavigateUrlFormatString="UteKhoiLuongGiangDayEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="IdKhoiLuongGiangDaySource" DataTextField="MaMonHoc" />
				<asp:BoundField DataField="HeSoLopDongLyThuyet" HeaderText="He So Lop Dong Ly Thuyet" SortExpression="[HeSoLopDongLyThuyet]" />				
				<asp:BoundField DataField="HeSoLopDongThTnTt" HeaderText="He So Lop Dong Th Tn Tt" SortExpression="[HeSoLopDongThTnTt]" />				
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="SoGioThucGiangTrenLop" HeaderText="So Gio Thuc Giang Tren Lop" SortExpression="[SoGioThucGiangTrenLop]" />				
				<asp:BoundField DataField="SoGioChuanTinhThem" HeaderText="So Gio Chuan Tinh Them" SortExpression="[SoGioChuanTinhThem]" />				
				<asp:BoundField DataField="HeSoHocKy" HeaderText="He So Hoc Ky" SortExpression="[HeSoHocKy]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Ute Khoi Luong Quy Doi Found! </b>
				<asp:HyperLink runat="server" ID="hypUteKhoiLuongQuyDoi" NavigateUrl="~/admin/UteKhoiLuongQuyDoiEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:UteKhoiLuongQuyDoiDataSource ID="UteKhoiLuongQuyDoiDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:UteKhoiLuongQuyDoiProperty Name="UteKhoiLuongGiangDay"/> 
					<%--<data:UteKhoiLuongQuyDoiProperty Name="UteThanhToanThuLao" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:UteKhoiLuongQuyDoiFilter  Column="IdKhoiLuongGiangDay" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:UteKhoiLuongQuyDoiDataSource>		
		
		<br />
		

</asp:Content>


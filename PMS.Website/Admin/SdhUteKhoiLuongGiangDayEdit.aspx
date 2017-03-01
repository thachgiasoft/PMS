<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="SdhUteKhoiLuongGiangDayEdit.aspx.cs" Inherits="SdhUteKhoiLuongGiangDayEdit" Title="SdhUteKhoiLuongGiangDay Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Sdh Ute Khoi Luong Giang Day - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="Id" runat="server" DataSourceID="SdhUteKhoiLuongGiangDayDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/SdhUteKhoiLuongGiangDayFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/SdhUteKhoiLuongGiangDayFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>SdhUteKhoiLuongGiangDay not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:SdhUteKhoiLuongGiangDayDataSource ID="SdhUteKhoiLuongGiangDayDataSource" runat="server"
			SelectMethod="GetById"
		>
			<Parameters>
				<asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="String" />

			</Parameters>
		</data:SdhUteKhoiLuongGiangDayDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewSdhUteKhoiLuongQuyDoi1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewSdhUteKhoiLuongQuyDoi1_SelectedIndexChanged"			 			 
			DataSourceID="SdhUteKhoiLuongQuyDoiDataSource1"
			DataKeyNames="Id"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_SdhUteKhoiLuongQuyDoi.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<data:HyperLinkField HeaderText="Id Khoi Luong Giang Day" DataNavigateUrlFormatString="SdhUteKhoiLuongGiangDayEdit.aspx?Id={0}" DataNavigateUrlFields="Id" DataContainer="IdKhoiLuongGiangDaySource" DataTextField="MaMonHoc" />
				<asp:BoundField DataField="HeSoLopDongLyThuyet" HeaderText="He So Lop Dong Ly Thuyet" SortExpression="[HeSoLopDongLyThuyet]" />				
				<asp:BoundField DataField="HeSoLopDongThTnTt" HeaderText="He So Lop Dong Th Tn Tt" SortExpression="[HeSoLopDongThTnTt]" />				
				<asp:BoundField DataField="TietQuyDoi" HeaderText="Tiet Quy Doi" SortExpression="[TietQuyDoi]" />				
				<asp:BoundField DataField="NgayCapNhat" HeaderText="Ngay Cap Nhat" SortExpression="[NgayCapNhat]" />				
				<asp:BoundField DataField="SoGioThucGiangTrenLop" HeaderText="So Gio Thuc Giang Tren Lop" SortExpression="[SoGioThucGiangTrenLop]" />				
				<asp:BoundField DataField="SoGioChuanTinhThem" HeaderText="So Gio Chuan Tinh Them" SortExpression="[SoGioChuanTinhThem]" />				
				<asp:BoundField DataField="HeSoHocKy" HeaderText="He So Hoc Ky" SortExpression="[HeSoHocKy]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Sdh Ute Khoi Luong Quy Doi Found! </b>
				<asp:HyperLink runat="server" ID="hypSdhUteKhoiLuongQuyDoi" NavigateUrl="~/admin/SdhUteKhoiLuongQuyDoiEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:SdhUteKhoiLuongQuyDoiDataSource ID="SdhUteKhoiLuongQuyDoiDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:SdhUteKhoiLuongQuyDoiProperty Name="SdhUteKhoiLuongGiangDay"/> 
					<%--<data:SdhUteKhoiLuongQuyDoiProperty Name="SdhUteThanhToanThuLao" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:SdhUteKhoiLuongQuyDoiFilter  Column="IdKhoiLuongGiangDay" QueryStringField="Id" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:SdhUteKhoiLuongQuyDoiDataSource>		
		
		<br />
		

</asp:Content>


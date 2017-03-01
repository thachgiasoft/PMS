<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="NhomHoatDongNgoaiGiangDayEdit.aspx.cs" Inherits="NhomHoatDongNgoaiGiangDayEdit" Title="NhomHoatDongNgoaiGiangDay Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Nhom Hoat Dong Ngoai Giang Day - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MaNhom" runat="server" DataSourceID="NhomHoatDongNgoaiGiangDayDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomHoatDongNgoaiGiangDayFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/NhomHoatDongNgoaiGiangDayFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>NhomHoatDongNgoaiGiangDay not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:NhomHoatDongNgoaiGiangDayDataSource ID="NhomHoatDongNgoaiGiangDayDataSource" runat="server"
			SelectMethod="GetByMaNhom"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MaNhom" QueryStringField="MaNhom" Type="String" />

			</Parameters>
		</data:NhomHoatDongNgoaiGiangDayDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewHoatDongNgoaiGiangDay1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewHoatDongNgoaiGiangDay1_SelectedIndexChanged"			 			 
			DataSourceID="HoatDongNgoaiGiangDayDataSource1"
			DataKeyNames="MaQuanLy"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_HoatDongNgoaiGiangDay.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="TenHoatDong" HeaderText="Ten Hoat Dong" SortExpression="[TenHoatDong]" />				
				<asp:BoundField DataField="MaDonViTinh" HeaderText="Ma Don Vi Tinh" SortExpression="[MaDonViTinh]" />				
				<asp:BoundField DataField="SoLuong" HeaderText="So Luong" SortExpression="[SoLuong]" />				
				<asp:BoundField DataField="MucQuyDoi" HeaderText="Muc Quy Doi" SortExpression="[MucQuyDoi]" />				
				<asp:BoundField DataField="DonGia" HeaderText="Don Gia" SortExpression="[DonGia]" />				
				<asp:BoundField DataField="GhiChu" HeaderText="Ghi Chu" SortExpression="[GhiChu]" />				
				<data:HyperLinkField HeaderText="Ma Nhom" DataNavigateUrlFormatString="NhomHoatDongNgoaiGiangDayEdit.aspx?MaNhom={0}" DataNavigateUrlFields="MaNhom" DataContainer="MaNhomSource" DataTextField="TenNhom" />
			</Columns>
			<EmptyDataTemplate>
				<b>No Hoat Dong Ngoai Giang Day Found! </b>
				<asp:HyperLink runat="server" ID="hypHoatDongNgoaiGiangDay" NavigateUrl="~/admin/HoatDongNgoaiGiangDayEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:HoatDongNgoaiGiangDayDataSource ID="HoatDongNgoaiGiangDayDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:HoatDongNgoaiGiangDayProperty Name="NhomHoatDongNgoaiGiangDay"/> 
					<%--<data:HoatDongNgoaiGiangDayProperty Name="GiangVienHoatDongNgoaiGiangDayCollection" />--%>
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:HoatDongNgoaiGiangDayFilter  Column="MaNhom" QueryStringField="MaNhom" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:HoatDongNgoaiGiangDayDataSource>		
		
		<br />
		

</asp:Content>


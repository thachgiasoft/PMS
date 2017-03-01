<%@ Control Language="C#" ClassName="ReportTemplateFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataReportId" runat="server" Text="Report Id:" AssociatedControlID="dataReportId" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataReportId" Text='<%# Bind("ReportId") %>' MaxLength="100"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataReportId" runat="server" Display="Dynamic" ControlToValidate="dataReportId" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUserId" runat="server" Text="User Id:" AssociatedControlID="dataUserId" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataUserId" DataSourceID="UserIdTaiKhoanDataSource" DataTextField="TenDangNhap" DataValueField="MaTaiKhoan" SelectedValue='<%# Bind("UserId") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:TaiKhoanDataSource ID="UserIdTaiKhoanDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDuLieu" runat="server" Text="Du Lieu:" AssociatedControlID="dataDuLieu" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataDuLieu" Value='<%# Bind("DuLieu") %>'></asp:HiddenField>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNgayTao" runat="server" Text="Ngay Tao:" AssociatedControlID="dataNgayTao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNgayTao" Text='<%# Bind("NgayTao", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataNgayTao" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



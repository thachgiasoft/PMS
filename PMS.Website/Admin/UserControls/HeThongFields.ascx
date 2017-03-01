<%@ Control Language="C#" ClassName="HeThongFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataUserId" runat="server" Text="User Id:" AssociatedControlID="dataUserId" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataUserId" DataSourceID="UserIdTaiKhoanDataSource" DataTextField="TenDangNhap" DataValueField="MaTaiKhoan" SelectedValue='<%# Bind("UserId") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:TaiKhoanDataSource ID="UserIdTaiKhoanDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataParentId" runat="server" Text="Parent Id:" AssociatedControlID="dataParentId" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataParentId" DataSourceID="ParentIdTaiKhoanDataSource" DataTextField="TenDangNhap" DataValueField="MaTaiKhoan" SelectedValue='<%# Bind("ParentId") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:TaiKhoanDataSource ID="ParentIdTaiKhoanDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



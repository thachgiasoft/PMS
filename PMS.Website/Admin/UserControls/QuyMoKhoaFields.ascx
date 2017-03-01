<%@ Control Language="C#" ClassName="QuyMoKhoaFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataIdQuyMo" runat="server" Text="Id Quy Mo:" AssociatedControlID="dataIdQuyMo" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataIdQuyMo" DataSourceID="IdQuyMoDanhMucQuyMoDataSource" DataTextField="MaQuyMo" DataValueField="Id" SelectedValue='<%# Bind("IdQuyMo") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:DanhMucQuyMoDataSource ID="IdQuyMoDanhMucQuyMoDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaKhoa" runat="server" Text="Ma Khoa:" AssociatedControlID="dataMaKhoa" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaKhoa" Text='<%# Bind("MaKhoa") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaKhoa" runat="server" Display="Dynamic" ControlToValidate="dataMaKhoa" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



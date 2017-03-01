<%@ Control Language="C#" ClassName="LopHocPhanBacDaoTaoFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHeSoBacDaoTao" runat="server" Text="Ma He So Bac Dao Tao:" AssociatedControlID="dataMaHeSoBacDaoTao" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataMaHeSoBacDaoTao" DataSourceID="MaHeSoBacDaoTaoHeSoBacDaoTaoDataSource" DataTextField="Stt" DataValueField="MaHeSo" SelectedValue='<%# Bind("MaHeSoBacDaoTao") %>' AppendNullItem="true" Required="true" NullItemText="< Please Choose ...>" ErrorText="Required" />
					<data:HeSoBacDaoTaoDataSource ID="MaHeSoBacDaoTaoHeSoBacDaoTaoDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLopHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLopHocPhan" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



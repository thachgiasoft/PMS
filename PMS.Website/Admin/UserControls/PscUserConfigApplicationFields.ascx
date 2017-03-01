<%@ Control Language="C#" ClassName="PscUserConfigApplicationFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataStaffId" runat="server" Text="Staff Id:" AssociatedControlID="dataStaffId" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataStaffId" Text='<%# Bind("StaffId") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataStaffId" runat="server" Display="Dynamic" ControlToValidate="dataStaffId" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataConfigName" runat="server" Text="Config Name:" AssociatedControlID="dataConfigName" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataConfigName" Text='<%# Bind("ConfigName") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataConfigName" runat="server" Display="Dynamic" ControlToValidate="dataConfigName" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataConfigValue" runat="server" Text="Config Value:" AssociatedControlID="dataConfigValue" /></td>
        <td>
					<asp:HiddenField runat="server" id="dataConfigValue" Value='<%# Bind("ConfigValue") %>'></asp:HiddenField>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



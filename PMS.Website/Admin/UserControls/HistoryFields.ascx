<%@ Control Language="C#" ClassName="HistoryFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataComputerName" runat="server" Text="Computer Name:" AssociatedControlID="dataComputerName" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataComputerName" Text='<%# Bind("ComputerName") %>' MaxLength="100"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpdatedDate" runat="server" Text="Updated Date:" AssociatedControlID="dataUpdatedDate" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpdatedDate" Text='<%# Bind("UpdatedDate", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataUpdatedDate" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" /><asp:RequiredFieldValidator ID="ReqVal_dataUpdatedDate" runat="server" Display="Dynamic" ControlToValidate="dataUpdatedDate" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUsername" runat="server" Text="Username:" AssociatedControlID="dataUsername" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUsername" Text='<%# Bind("Username") %>' MaxLength="15"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataOldProfessor" runat="server" Text="Old Professor:" AssociatedControlID="dataOldProfessor" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataOldProfessor" Text='<%# Bind("OldProfessor") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataOldProfessor" runat="server" Display="Dynamic" ControlToValidate="dataOldProfessor" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNewProfessor" runat="server" Text="New Professor:" AssociatedControlID="dataNewProfessor" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNewProfessor" Text='<%# Bind("NewProfessor") %>' MaxLength="50"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataNewProfessor" runat="server" Display="Dynamic" ControlToValidate="dataNewProfessor" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



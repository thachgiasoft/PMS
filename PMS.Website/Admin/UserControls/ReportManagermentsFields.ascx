<%@ Control Language="C#" ClassName="ReportManagermentsFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataNote1" runat="server" Text="Note1:" AssociatedControlID="dataNote1" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNote1" Text='<%# Bind("Note1") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNote2" runat="server" Text="Note2:" AssociatedControlID="dataNote2" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNote2" Text='<%# Bind("Note2") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNote3" runat="server" Text="Note3:" AssociatedControlID="dataNote3" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNote3" Text='<%# Bind("Note3") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataReportName" runat="server" Text="Report Name:" AssociatedControlID="dataReportName" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataReportName" Text='<%# Bind("ReportName") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataStoreprocedure" runat="server" Text="Storeprocedure:" AssociatedControlID="dataStoreprocedure" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataStoreprocedure" Text='<%# Bind("Storeprocedure") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataFileName" runat="server" Text="File Name:" AssociatedControlID="dataFileName" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataFileName" Text='<%# Bind("FileName") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



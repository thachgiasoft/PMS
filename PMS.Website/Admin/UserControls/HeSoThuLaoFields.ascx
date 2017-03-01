<%@ Control Language="C#" ClassName="HeSoThuLaoFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHeSoThuLao" runat="server" Text="Ten He So Thu Lao:" AssociatedControlID="dataTenHeSoThuLao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHeSoThuLao" Text='<%# Bind("TenHeSoThuLao") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoThuLao" runat="server" Text="He So Thu Lao:" AssociatedControlID="dataHeSoThuLao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoThuLao" Text='<%# Bind("HeSoThuLao") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoThuLao" runat="server" Display="Dynamic" ControlToValidate="dataHeSoThuLao" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaThuLao" runat="server" Text="Ma Thu Lao:" AssociatedControlID="dataMaThuLao" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaThuLao" Text='<%# Bind("MaThuLao") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaThuLao" runat="server" Display="Dynamic" ControlToValidate="dataMaThuLao" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



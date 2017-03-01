<%@ Control Language="C#" ClassName="CongThucFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataCol07" runat="server" Text="Col07:" AssociatedControlID="dataCol07" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCol07" Text='<%# Bind("Col07") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCol07" runat="server" Display="Dynamic" ControlToValidate="dataCol07" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCol06" runat="server" Text="Col06:" AssociatedControlID="dataCol06" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCol06" Text='<%# Bind("Col06") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCol06" runat="server" Display="Dynamic" ControlToValidate="dataCol06" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCol05" runat="server" Text="Col05:" AssociatedControlID="dataCol05" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCol05" Text='<%# Bind("Col05") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCol05" runat="server" Display="Dynamic" ControlToValidate="dataCol05" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpdateStaff" runat="server" Text="Update Staff:" AssociatedControlID="dataUpdateStaff" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpdateStaff" Text='<%# Bind("UpdateStaff") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpdateDate" runat="server" Text="Update Date:" AssociatedControlID="dataUpdateDate" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpdateDate" Text='<%# Bind("UpdateDate") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCol08" runat="server" Text="Col08:" AssociatedControlID="dataCol08" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCol08" Text='<%# Bind("Col08") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCol08" runat="server" Display="Dynamic" ControlToValidate="dataCol08" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCol01" runat="server" Text="Col01:" AssociatedControlID="dataCol01" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCol01" Text='<%# Bind("Col01") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCol01" runat="server" Display="Dynamic" ControlToValidate="dataCol01" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataName" runat="server" Text="Name:" AssociatedControlID="dataName" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataName" Text='<%# Bind("Name") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataYearStudy" runat="server" Text="Year Study:" AssociatedControlID="dataYearStudy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataYearStudy" Text='<%# Bind("YearStudy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCol04" runat="server" Text="Col04:" AssociatedControlID="dataCol04" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCol04" Text='<%# Bind("Col04") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCol04" runat="server" Display="Dynamic" ControlToValidate="dataCol04" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCol03" runat="server" Text="Col03:" AssociatedControlID="dataCol03" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCol03" Text='<%# Bind("Col03") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCol03" runat="server" Display="Dynamic" ControlToValidate="dataCol03" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCol02" runat="server" Text="Col02:" AssociatedControlID="dataCol02" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCol02" Text='<%# Bind("Col02") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCol02" runat="server" Display="Dynamic" ControlToValidate="dataCol02" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



<%@ Control Language="C#" ClassName="SiSoLopHocPhanFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataScheduleStudyUnitId" runat="server" Text="Schedule Study Unit Id:" AssociatedControlID="dataScheduleStudyUnitId" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataScheduleStudyUnitId" Text='<%# Bind("ScheduleStudyUnitId") %>' MaxLength="30"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataScheduleStudyUnitId" runat="server" Display="Dynamic" ControlToValidate="dataScheduleStudyUnitId" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoLop" runat="server" Text="Si So Lop:" AssociatedControlID="dataSiSoLop" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoLop" Text='<%# Bind("SiSoLop") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoLop" runat="server" Display="Dynamic" ControlToValidate="dataSiSoLop" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



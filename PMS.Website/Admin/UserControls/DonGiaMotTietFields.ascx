<%@ Control Language="C#" ClassName="DonGiaMotTietFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaMotTiet" runat="server" Text="Don Gia Mot Tiet:" AssociatedControlID="dataDonGiaMotTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaMotTiet" Text='<%# Bind("DonGiaMotTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaMotTiet" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaMotTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHocVi" runat="server" Text="Ten Hoc Vi:" AssociatedControlID="dataTenHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHocVi" Text='<%# Bind("TenHocVi") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenHocHam" runat="server" Text="Ten Hoc Ham:" AssociatedControlID="dataTenHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenHocHam" Text='<%# Bind("TenHocHam") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocHam" runat="server" Text="Ma Hoc Ham:" AssociatedControlID="dataMaHocHam" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocHam" Text='<%# Bind("MaHocHam") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaHocHam" runat="server" Display="Dynamic" ControlToValidate="dataMaHocHam" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHocVi" runat="server" Text="Ma Hoc Vi:" AssociatedControlID="dataMaHocVi" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHocVi" Text='<%# Bind("MaHocVi") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaHocVi" runat="server" Display="Dynamic" ControlToValidate="dataMaHocVi" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



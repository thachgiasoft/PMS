<%@ Control Language="C#" ClassName="NhomMonHocFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSiSoNhomThucHanh" runat="server" Text="Si So Nhom Thuc Hanh:" AssociatedControlID="dataSiSoNhomThucHanh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSiSoNhomThucHanh" Text='<%# Bind("SiSoNhomThucHanh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSiSoNhomThucHanh" runat="server" Display="Dynamic" ControlToValidate="dataSiSoNhomThucHanh" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoQuyDoiThSangLt" runat="server" Text="He So Quy Doi Th Sang Lt:" AssociatedControlID="dataHeSoQuyDoiThSangLt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoQuyDoiThSangLt" Text='<%# Bind("HeSoQuyDoiThSangLt") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoQuyDoiThSangLt" runat="server" Display="Dynamic" ControlToValidate="dataHeSoQuyDoiThSangLt" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMucThanhToan" runat="server" Text="Muc Thanh Toan:" AssociatedControlID="dataMucThanhToan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMucThanhToan" Text='<%# Bind("MucThanhToan") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMucThanhToan" runat="server" Display="Dynamic" ControlToValidate="dataMucThanhToan" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaQuanLy" runat="server" Display="Dynamic" ControlToValidate="dataMaQuanLy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenNhomMon" runat="server" Text="Ten Nhom Mon:" AssociatedControlID="dataTenNhomMon" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenNhomMon" Text='<%# Bind("TenNhomMon") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



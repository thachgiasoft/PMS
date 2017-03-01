<%@ Control Language="C#" ClassName="KcqPhuCapHanhChinhFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoThangTruPhuCapHanhChinh" runat="server" Text="So Thang Tru Phu Cap Hanh Chinh:" AssociatedControlID="dataSoThangTruPhuCapHanhChinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoThangTruPhuCapHanhChinh" Text='<%# Bind("SoThangTruPhuCapHanhChinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoThangTruPhuCapHanhChinh" runat="server" Display="Dynamic" ControlToValidate="dataSoThangTruPhuCapHanhChinh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGiaPhuCapHanhChinh" runat="server" Text="Don Gia Phu Cap Hanh Chinh:" AssociatedControlID="dataDonGiaPhuCapHanhChinh" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGiaPhuCapHanhChinh" Text='<%# Bind("DonGiaPhuCapHanhChinh") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGiaPhuCapHanhChinh" runat="server" Display="Dynamic" ControlToValidate="dataDonGiaPhuCapHanhChinh" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



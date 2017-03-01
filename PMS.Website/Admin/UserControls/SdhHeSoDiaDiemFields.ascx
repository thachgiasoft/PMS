<%@ Control Language="C#" ClassName="SdhHeSoDiaDiemFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataDonGia" runat="server" Text="Don Gia:" AssociatedControlID="dataDonGia" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDonGia" Text='<%# Bind("DonGia") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDonGia" runat="server" Display="Dynamic" ControlToValidate="dataDonGia" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTienXeDiaDiem" runat="server" Text="Tien Xe Dia Diem:" AssociatedControlID="dataTienXeDiaDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTienXeDiaDiem" Text='<%# Bind("TienXeDiaDiem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTienXeDiaDiem" runat="server" Display="Dynamic" ControlToValidate="dataTienXeDiaDiem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeSoDiaDiem" runat="server" Text="He So Dia Diem:" AssociatedControlID="dataHeSoDiaDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeSoDiaDiem" Text='<%# Bind("HeSoDiaDiem") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeSoDiaDiem" runat="server" Display="Dynamic" ControlToValidate="dataHeSoDiaDiem" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataStt" runat="server" Text="Stt:" AssociatedControlID="dataStt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataStt" Text='<%# Bind("Stt") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataStt" runat="server" Display="Dynamic" ControlToValidate="dataStt" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaQuanLy" runat="server" Text="Ma Quan Ly:" AssociatedControlID="dataMaQuanLy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaQuanLy" Text='<%# Bind("MaQuanLy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTenDiaDiem" runat="server" Text="Ten Dia Diem:" AssociatedControlID="dataTenDiaDiem" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTenDiaDiem" Text='<%# Bind("TenDiaDiem") %>' MaxLength="200"></asp:TextBox>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



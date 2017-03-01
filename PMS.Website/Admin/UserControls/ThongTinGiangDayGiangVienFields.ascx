<%@ Control Language="C#" ClassName="ThongTinGiangDayGiangVienFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataHocKy" runat="server" Display="Dynamic" ControlToValidate="dataHocKy" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataNamHoc" runat="server" Display="Dynamic" ControlToValidate="dataNamHoc" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChiPhiDiLai" runat="server" Text="Chi Phi Di Lai:" AssociatedControlID="dataChiPhiDiLai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChiPhiDiLai" Text='<%# Bind("ChiPhiDiLai") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataChiPhiDiLai" runat="server" Display="Dynamic" ControlToValidate="dataChiPhiDiLai" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataChiPhiLuuTru" runat="server" Text="Chi Phi Luu Tru:" AssociatedControlID="dataChiPhiLuuTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataChiPhiLuuTru" Text='<%# Bind("ChiPhiLuuTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataChiPhiLuuTru" runat="server" Display="Dynamic" ControlToValidate="dataChiPhiLuuTru" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="30"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaLopHocPhan" runat="server" Display="Dynamic" ControlToValidate="dataMaLopHocPhan" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>' MaxLength="20"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoNgayLuuTru" runat="server" Text="So Ngay Luu Tru:" AssociatedControlID="dataSoNgayLuuTru" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoNgayLuuTru" Text='<%# Bind("SoNgayLuuTru") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoNgayLuuTru" runat="server" Display="Dynamic" ControlToValidate="dataSoNgayLuuTru" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoLanDiLai" runat="server" Text="So Lan Di Lai:" AssociatedControlID="dataSoLanDiLai" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLanDiLai" Text='<%# Bind("SoLanDiLai") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLanDiLai" runat="server" Display="Dynamic" ControlToValidate="dataSoLanDiLai" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>



<%@ Control Language="C#" ClassName="HoatDongNgoaiGiangDayClcFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTiet" runat="server" Text="So Tiet:" AssociatedControlID="dataSoTiet" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTiet" Text='<%# Bind("SoTiet") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTiet" runat="server" Display="Dynamic" ControlToValidate="dataSoTiet" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoLuong" runat="server" Text="So Luong:" AssociatedControlID="dataSoLuong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoLuong" Text='<%# Bind("SoLuong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoLuong" runat="server" Display="Dynamic" ControlToValidate="dataSoLuong" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGhiChu" runat="server" Text="Ghi Chu:" AssociatedControlID="dataGhiChu" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGhiChu" Text='<%# Bind("GhiChu") %>'  TextMode="MultiLine"  Width="250px" Rows="5"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataSoTien" runat="server" Text="So Tien:" AssociatedControlID="dataSoTien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataSoTien" Text='<%# Bind("SoTien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataSoTien" runat="server" Display="Dynamic" ControlToValidate="dataSoTien" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaHoatDong" runat="server" Text="Ma Hoat Dong:" AssociatedControlID="dataMaHoatDong" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaHoatDong" Text='<%# Bind("MaHoatDong") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaHoatDong" runat="server" Display="Dynamic" ControlToValidate="dataMaHoatDong" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHocKy" runat="server" Text="Hoc Ky:" AssociatedControlID="dataHocKy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHocKy" Text='<%# Bind("HocKy") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNamHoc" runat="server" Text="Nam Hoc:" AssociatedControlID="dataNamHoc" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNamHoc" Text='<%# Bind("NamHoc") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaLopHocPhan" runat="server" Text="Ma Lop Hoc Phan:" AssociatedControlID="dataMaLopHocPhan" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaLopHocPhan" Text='<%# Bind("MaLopHocPhan") %>' MaxLength="50"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaGiangVien" runat="server" Text="Ma Giang Vien:" AssociatedControlID="dataMaGiangVien" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaGiangVien" Text='<%# Bind("MaGiangVien") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMaGiangVien" runat="server" Display="Dynamic" ControlToValidate="dataMaGiangVien" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


